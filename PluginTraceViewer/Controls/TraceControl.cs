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
        private char[] spacechars = new[] { ' ', '\t', '\n', '\r', ':', '=' };
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
            linkRecord.Text = "";
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
                await Task.Run(() => MatchGuids(links, log, currectentity, showlinks));
                if (currectentity != tracerecord || log != textMessage.Text)
                {   // This will cancel if UI is now on another trace line since this is async
                    return;
                }
                if (showlinks)
                {
                    lblLoading.Visible = false;
                    btnShowAllRecordLinks.Enabled = links.Any();
                    btnShowAllRecordLinks.Text = $"Show {links.Where(l => l.TypeIdentifier != "Target" && l.Record != null).Select(l => l.Record).Distinct().Count()} records";
                    textMessage.Text = Links.InsertRecordsInLog(log, links);
                    links.ForEach(SetRecordLink);
                    lblTrigger.Visible = !string.IsNullOrEmpty(linkRecord.Text);
                }
                HighlightRecords(links, showlinks);
            }
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
                var guidname = "";
                if (lookuprecords)
                {
                    if (logbeforeguid.ToLowerInvariant().EndsWith("initiating user"))
                    {
                        guidname = "Initiating User";
                    }
                    else if (logbeforeguid.LastIndexOfAny(spacechars) is int pos && pos >= 0)
                    {
                        guidname = logbeforeguid.Substring(pos + 1);
                    }
                }
                if (Link.GetRecordLink(lookuprecords, ptv.recordlist, triggerentity, guidname, m.Value) is Link link)
                {
                    link.OriginalPosition = m.Index + m.Length;
                    link.CurrentlyPosition = link.OriginalPosition;
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
                    textMessage.Select(link.CurrentlyPosition + 1, link.AddedLength - 1);
                    textMessage.SelectionBackColor = System.Drawing.Color.LightGreen;
                    // Gray on the table identifier
                    var beforeid = textMessage.Text.Substring(0, link.CurrentlyPosition).Trim(spacechars).LastIndexOf(link.LogIdentifier);
                    if (beforeid >= 0)
                    {
                        textMessage.Select(beforeid, link.LogIdentifier.Length);
                        textMessage.SelectionBackColor = System.Drawing.Color.LightGray;
                    }
                }
                // Yellow on the guid
                textMessage.Select(link.CurrentlyPosition - 36, 36);
                textMessage.SelectionBackColor = System.Drawing.Color.Yellow;
            }
            textMessage.DeselectAll();
        }

        private void SetRecordLink(Link link)
        {
            //LinkLabel linklabel = null;
            switch (link.TypeIdentifier)
            {
                //case "UserId":
                //    linklabel = linkUser;
                //    break;

                //case "InitUserId":
                //    linklabel = linkIniUser;
                //    break;

                case "Target":
                    var msgtable = $"{tracerecord["messagename"]} {link.Record.Metadata.ToDisplayName()} ";
                    linkRecord.Text = $"{msgtable}{link.Record.Name}";
                    linkRecord.Tag = link.Record.Url;
                    linkRecord.LinkArea = new LinkArea(msgtable.Length, linkRecord.Text.Length - msgtable.Length);
                    break;
            }
            //if (linklabel != null)
            //{
            //    linklabel.Text = $"{link.Record.Metadata.ToDisplayName()}: {link.Record.Name}";
            //    linklabel.Tag = link.Record.Url;
            //    linklabel.LinkArea = new LinkArea(0, linklabel.Text.Length);
            //}
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
            allrecords.SetRecords(links.Where(l => l.TypeIdentifier != "Target" && l.Record != null).Select(l => l.Record).Distinct(), ptv.ConnectionDetail);
            allrecords.ShowDialog();
        }
    }
}