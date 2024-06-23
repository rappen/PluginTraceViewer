using Cinteros.XTB.PluginTraceViewer.Const;
using Microsoft.Xrm.Sdk;
using Rappen.XRM.Helpers.Extensions;
using Rappen.XTB.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinteros.XTB.PluginTraceViewer.Controls
{
    public partial class TraceControl : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        private const string guidregex = @"([a-z0-9]{8}[-][a-z0-9]{4}[-][a-z0-9]{4}[-][a-z0-9]{4}[-][a-z0-9]{12})";
        private static char[] spacechars = new[] { ' ', '\t', '\n', '\r', ':', '.', ',', '=', '"', '\'', '(', ')' };
        private string[] wordsbetweenstableandguid = new[] { "new Guid", ", Id", "with id", "of entity" };
        private string findtext = "";
        private Entity tracerecord;
        private string triggerentity;
        private PluginTraceViewer ptv;
        private string originallog;
        private Links links;

        public TraceControl(PluginTraceViewer ptv)
        {
            this.ptv = ptv;
            InitializeComponent();
            lblLoading.Dock = DockStyle.Fill;
            lblLoading.Visible = true;
            panLinks.Visible = false;
        }

        internal void SetLogText(string log, Entity tracer)
        {
            textMessage.Clear();
            if (tracerecord == tracer)
            {
                return;
            }
            tracerecord = tracer;
            triggerentity = tracer[PluginTraceLog.PrimaryEntity].ToString();
            originallog = log.Replace("\r\n", "\n");
            _ = ShowMessageTextAsync(ptv.tsmiHighlightGuids.Checked, ptv.tsmiIdentifyRecords.Checked);
        }

        internal async Task ShowMessageTextAsync(bool highlightguids, bool showlinks)
        {
            panLinks.Visible = showlinks;
            picIcon.Left = ClientSize.Width - picIcon.Width - (showlinks ? 0 : 16);
            linkRecord.Text = "";
            btnShowAllRecordLinks.Enabled = false;
            btnShowAllRecordLinks.Text = $"- records";
            textMessage.Text = originallog;
            if (string.IsNullOrWhiteSpace(originallog))
            {
                return;
            }
            if (highlightguids || showlinks)
            {
                lblLoading.Visible = showlinks;
                btnShowAllRecordLinks.Enabled = false;
                var currectentity = tracerecord;
                var log = textMessage.Text;
                links = new Links(triggerentity);
                ptv.StopRefreshTimer();
                await Task.Run(() => MatchGuids(links, log, currectentity, showlinks));
                ptv.StartRefreshTimer(false);
                if (currectentity != tracerecord || log != textMessage.Text)
                {   // This will cancel if UI is now on another trace line since this is async
                    return;
                }
                if (showlinks)
                {
                    lblLoading.Visible = false;
                    btnShowAllRecordLinks.Enabled = links.LinkRecords.Any();
                    btnShowAllRecordLinks.Text =
                        links.Count == 1 ? $"1 record" :
                        links.LinkRecords.Any() ? $"{links.LinkRecords.Count()} records" :
                        "No records";
                    textMessage.Text = Links.InsertRecordsInLog(log, links);
                    if (links.Target?.Record is Record target)
                    {
                        var msgtable = $"{tracerecord["messagename"]} {target.Metadata.ToDisplayName()} ";
                        linkRecord.Text = $"{msgtable}{target.Name ?? target.Id.ToString()}";
                        linkRecord.Tag = target.Url;
                        linkRecord.LinkArea = new LinkArea(msgtable.Length, linkRecord.Text.Length - msgtable.Length);
                        toolTip1.SetToolTip(linkRecord, $"Click to open this record.\n{target.Url}");
                        lblTrigger.Visible = !string.IsNullOrEmpty(linkRecord.Text);
                    }
                    else
                    {
                        lblTrigger.Visible = false;
                    }
                }
                HighlightRecords(links, showlinks);
            }
            textMessage.Select(0, 0);
        }

        private void MatchGuids(Links links, string log, Entity currectentity, bool lookuprecords)
        {
            foreach (Match m in Regex.Matches(log, guidregex))
            {
                if (currectentity != tracerecord)
                {   // This will cancel if UI is now on another trace line since this is async
                    return;
                }
                if (!Link.TryParse(m, out var link))
                {
                    continue;
                }
                links.Add(link);
                var beforeguidorg = log.Substring(0, m.Index);
                var afterguidorg = log.Substring(m.Index + m.Length);
                if (lookuprecords && !link.Id.Equals(Guid.Empty))
                {
                    //     var pos = Math.Max(m.Index - 200, 0);
                    var beforeguid = beforeguidorg.TrimEnd(spacechars);
                    if (!string.IsNullOrWhiteSpace(beforeguid))
                    {
                        foreach (var word in wordsbetweenstableandguid)
                        {
                            if (beforeguid.EndsWith(word))
                            {
                                beforeguid = beforeguid.Substring(0, beforeguid.Length - word.Length).TrimEnd(spacechars);
                            }
                        }
                        if (beforeguid.ToLowerInvariant().EndsWith("id"))
                        {
                            if (beforeguid.Length > 2 && !char.IsLetterOrDigit(beforeguid[beforeguid.Length - 3]))
                            {
                                beforeguid = beforeguid.Substring(0, beforeguid.Length - 2).TrimEnd(spacechars);
                            }
                        }
                        if (FindGuidTable(beforeguid, false) is string guidname1)
                        {
                            link.EntityRelativePosition = beforeguidorg.LastIndexOf(guidname1) - m.Index;
                            link.IdentifyRecord(ptv.recordlist, guidname1, triggerentity);
                        }
                    }
                    if (link.Record == null)
                    {
                        //            pos = Math.Min(m.Index + m.Length, log.Length);
                        var afterguid = afterguidorg.TrimStart(spacechars);
                        if (!string.IsNullOrWhiteSpace(afterguid))
                        {
                            foreach (var word in wordsbetweenstableandguid)
                            {
                                if (afterguid.StartsWith(word))
                                {
                                    afterguid = afterguid.Substring(word.Length).Trim(spacechars);
                                }
                            }
                            if (afterguid.Split(spacechars).First().ToLowerInvariant().EndsWith("id"))
                            {
                                if (afterguid.Length > 2 && !char.IsLetterOrDigit(afterguid[afterguid.Length - 3]))
                                {
                                    afterguid = afterguid.Substring(0, afterguid.Length - 2).Trim(spacechars);
                                }
                            }
                            if (FindGuidTable(afterguid, true) is string guidname2)
                            {
                                link.EntityRelativePosition = m.Index + afterguidorg.IndexOf(guidname2);
                                link.IdentifyRecord(ptv.recordlist, guidname2, triggerentity);
                            }
                        }
                    }
                }
            }
        }

        private static string FindGuidTable(string closestlog, bool afterguid)
        {
            var tablename = "";
            if (!afterguid)
            {
                if (closestlog.ToLowerInvariant().EndsWith("initiating user"))
                {   // MS traces...
                    tablename = "Initiating User";
                }
                else if (closestlog.ToLowerInvariant().EndsWith("corrolation id"))
                {   // MS traces...
                    tablename = "Corrolation Id";
                }
                else if (closestlog.ToLowerInvariant().EndsWith("principal with id"))
                {
                    tablename = "Principal";
                }
                else if (closestlog.LastIndexOfAny(spacechars) is int pos && pos >= 0)
                {
                    tablename = closestlog.Substring(pos + 1).Split('.').Last().Trim();
                }
            }
            else
            {
                if (closestlog.ToLowerInvariant().StartsWith("initiating user"))
                {   // MS traces...
                    tablename = "Initiating User";
                }
                else if (closestlog.ToLowerInvariant().StartsWith("corrolation id"))
                {   // MS traces...
                    tablename = "Corrolation Id";
                }
                else if (closestlog.ToLowerInvariant().StartsWith("principal with id"))
                {
                    tablename = "Principal";
                }
                else if (closestlog.IndexOfAny(spacechars) is int pos && pos >= 0)
                {
                    tablename = closestlog.Split(spacechars)[0].Trim(spacechars);
                }
            }
            if (closestlog.Substring(0, closestlog.Length - tablename.Length).TrimEnd(spacechars).ToLowerInvariant().Equals("in execute"))
            {   // Low-code Plugin indication
                tablename = "Target";
            }
            return !string.IsNullOrEmpty(tablename) ? tablename : null;
        }

        private void HighlightRecords(List<Link> links, bool showlinks)
        {
            foreach (var link in links)
            {
                if (link.IsInserted)
                {
                    // Green on the name of the record
                    textMessage.Select(link.GuidPosition + link.GuidLength + 1, link.LinkName.Length - 1);
                    textMessage.SelectionBackColor = System.Drawing.Color.LightGreen;
                    // Gray on the table identifier
                    textMessage.Select(link.GuidPosition + link.EntityRelativePosition, link.LogIdentifier.Length);
                    textMessage.SelectionBackColor = System.Drawing.Color.LightGray;
                }
                // Yellow on the guid
                textMessage.Select(link.GuidPosition, link.GuidLength);
                textMessage.SelectionBackColor = System.Drawing.Color.Yellow;
            }
            textMessage.DeselectAll();
        }

        internal void Clear()
        {
            textMessage.Clear();
            panLinks.Visible = false;
            links = null;
        }

        private void TraceControl_KeyDown(object sender, KeyEventArgs e)
        {
            if (panLegend.Visible && e.KeyCode == Keys.Escape)
            {
                panLegend.Visible = false;
                return;
            }
            var textBox = textMessage;
            findtext = FindTextHandler.HandleFindKeyPress(e, textBox, findtext);
        }

        private void link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UrlUtils.OpenUrl(sender, ptv.ConnectionDetail);
        }

        private void textMessage_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            UrlUtils.OpenUrl(e.LinkText, ptv.ConnectionDetail);
        }

        private void btnShowAllRecordLinks_Click(object sender, EventArgs e)
        {
            var allrecords = new RecordLinks();
            allrecords.SetRecords(links.LinkRecords, links.Target?.Record, ptv.ConnectionDetail);
            allrecords.ShowDialog();
        }

        private void picLegend_Click(object sender, EventArgs e)
        {
            panLegend.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panLegend.Visible = false;
        }
    }
}