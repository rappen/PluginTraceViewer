using Cinteros.XTB.PluginTraceViewer.Const;
using Microsoft.Xrm.Sdk;
using Rappen.XRM.Helpers.Extensions;
using Rappen.XTB.Helpers;
using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinteros.XTB.PluginTraceViewer.Controls
{
    public partial class TraceControl : WeifenLuo.WinFormsUI.Docking.DockContent
    {
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

        internal void SetLogText(string log, Entity tracer, string freefilter, string quickfilter)
        {
            textMessage.Clear();
            if (tracerecord == tracer)
            {
                return;
            }
            tracerecord = tracer;
            triggerentity = tracer[PluginTraceLog.PrimaryEntity].ToString();

            originallog = log;
            originallog = originallog.Replace("\r\n", "\n");

            _ = ShowMessageTextAsync(ptv.tsmiHighlightGuids.Checked, ptv.tsmiIdentifyRecords.Checked, triggerentity, freefilter, quickfilter);
        }

        internal async Task ShowMessageTextAsync(bool highlightguids, bool showlinks, string triggerentity, string freefilter, string quickfilter)
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
            if (string.IsNullOrWhiteSpace(triggerentity))
            {
                triggerentity = this.triggerentity;
            }
            if (highlightguids || showlinks)
            {
                lblLoading.Visible = showlinks;
                var currectentity = tracerecord;
                links = new Links(originallog, ptv.recordlist, triggerentity);
                ptv.StopRefreshTimer();
                await Task.Run(() => links.MatchGuids(showlinks));
                ptv.StartRefreshTimer(false);
                if (currectentity != tracerecord || originallog != textMessage.Text)
                {   // This will cancel if UI is now on another trace line since this is async
                    return;
                }
                if (showlinks)
                {
                    lblLoading.Visible = false;
                    btnShowAllRecordLinks.Enabled = links.LinkRecords.Any();
                    btnShowAllRecordLinks.Text =
                        links.LinkRecords.Count == 1 ? $"1 record" :
                        links.LinkRecords.Any() ? $"{links.LinkRecords.Count()} records" :
                        "No records";
                    textMessage.Text = links.InsertRecordsInLog();
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
                links.HighlightRecords(textMessage);
            }
            if (!string.IsNullOrWhiteSpace(freefilter))
            {
                textMessage.HighlightFilter(freefilter, Color.White, Color.Red);
            }
            if (!string.IsNullOrWhiteSpace(quickfilter))
            {
                textMessage.HighlightFilter(quickfilter, Color.Red, Color.White);
            }
            textMessage.Select(0, 0);
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

        private void btnLedgendClose_Click(object sender, EventArgs e)
        {
            panLegend.Visible = false;
        }
    }
}