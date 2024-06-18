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
        private char[] spacechars = new[] { ' ', '\t', '\n', '\r', ':', ',', '=', '"', '\'', '(', ')' };
        private string[] wordsbetweenstableandguid = new[] { "new Guid", ", Id", "with id" };
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
            btnShowAllRecordLinks.Text = $"Show records";
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
                links = new Links();
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
                    btnShowAllRecordLinks.Text = links.LinkRecords.Any() ? $"Show {links.LinkRecords.Count()} records" : "No extra records";
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
                var logbeforeguid = log.Substring(0, m.Index);
                logbeforeguid = logbeforeguid.TrimEnd(spacechars);
                foreach (var word in wordsbetweenstableandguid)
                {
                    if (logbeforeguid.EndsWith(word))
                    {
                        logbeforeguid = logbeforeguid.Substring(0, logbeforeguid.Length - word.Length).TrimEnd(spacechars);
                    }
                }
                var guidname = "";
                if (lookuprecords)
                {
                    if (logbeforeguid.ToLowerInvariant().EndsWith("initiating user"))
                    {   // MS traces...
                        guidname = "Initiating User";
                    }
                    else if (logbeforeguid.LastIndexOfAny(spacechars) is int pos && pos >= 0)
                    {
                        guidname = logbeforeguid.Substring(pos + 1).Split('.').Last().Trim();
                    }
                    if (logbeforeguid.Substring(0, logbeforeguid.Length - guidname.Length).TrimEnd(spacechars).ToLowerInvariant().Equals("in execute"))
                    {   // Low-code Plugin indication
                        guidname = "Target";
                    }
                }
                if (Link.GetRecordLink(lookuprecords, ptv.recordlist, triggerentity, guidname, m.Value) is Link link)
                {
                    link.GuidLength = m.Length;
                    link.GuidPosition = m.Index;
                    link.LinkPosition = link.GuidPosition + link.GuidLength;
                    links.Add(link);
                }
            }
        }

        private void HighlightRecords(List<Link> links, bool showlinks)
        {
            foreach (var link in links)
            {
                if (link.IsAdded)
                {
                    // Green on the name of the record
                    textMessage.Select(link.LinkPosition + 1, link.LinkName.Length - 1);
                    textMessage.SelectionBackColor = System.Drawing.Color.LightGreen;
                    // Gray on the table identifier
                    var beforeid = textMessage.Text.Substring(0, link.LinkPosition).Trim(spacechars).LastIndexOf(link.LogIdentifier);
                    if (beforeid >= 0)
                    {
                        textMessage.Select(beforeid, link.LogIdentifier.Length);
                        textMessage.SelectionBackColor = System.Drawing.Color.LightGray;
                    }
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
        }

        private void TraceControl_KeyDown(object sender, KeyEventArgs e)
        {
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

        private void panLinks_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnShowAllRecordLinks_Click(object sender, EventArgs e)
        {
            var allrecords = new RecordLinks();
            allrecords.SetRecords(links.LinkRecords, links.Target?.Record, ptv.ConnectionDetail);
            allrecords.ShowDialog();
        }
    }
}