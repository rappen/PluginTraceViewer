using McTools.Xrm.Connection;
using Rappen.XRM.Helpers.Extensions;
using Rappen.XTB.Helpers;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Cinteros.XTB.PluginTraceViewer.Controls
{
    public partial class RecordLinks : Form
    {
        private const int PANELHEIGHT = 20;
        private ConnectionDetail connectionDetail;
        private LinkLabel currentlink;

        public RecordLinks()
        {
            InitializeComponent();
        }

        public void SetRecords(IEnumerable<Record> records, Record target, ConnectionDetail cd)
        {
            connectionDetail = cd;
            sptLinks.Panel1.Controls.Clear();
            var recs =
                records
                .Where(r => r != null)
                .Distinct()
                .OrderBy(r => r.Name)
                .OrderBy(r => r.Metadata?.LogicalName)
                .OrderBy(r => r.Metadata?.ToDisplayName());
            foreach (var record in recs.Reverse().Where(r => r != target))
            {
                AddLinkPanel(
                    record.Metadata?.ToDisplayName() ?? record.Name,
                    record.Metadata != null ? $"Table: {record.Metadata.LogicalName}" : record.Name,
                    record.Name,
                    record.Url,
                    $"Open this {record.Metadata?.ToDisplayName()?.ToLowerInvariant()} record.\n{record.Url}");
            }
            if (target != null)
            {
                AddLinkPanel(
                    target.Metadata?.ToDisplayName() ?? target.Name,
                    target.Metadata != null ? $"Triggered plugin by table: {target.Metadata.LogicalName}" : target.Name,
                    target.Name,
                    target.Url,
                    $"Open the triggered {target.Metadata?.ToDisplayName()?.ToLowerInvariant()} record.\n{target.Url}",
                    true);
            }
            AddLinkPanel("Table", "", "Record name", "", "Click on record name to open in the browser", true);
            ClientSize = new Size(500, sptLinks.Panel1.Controls.Count * PANELHEIGHT + 40);
            btnClose.Focus();
        }

        private void AddLinkPanel(string lbltext, string lbltip, string lnktext, string lnktag, string lnktip, bool bold = false)
        {
            var panLbl = new Panel
            {
                Dock = DockStyle.Top,
                Height = PANELHEIGHT,
                Font = bold ? new Font(Font, FontStyle.Bold) : Font,
            };
            var lbl = new Label
            {
                Parent = panLbl,
                Left = 6,
                Top = 2,
                AutoSize = true,
                Text = lbltext,
            };
            toolTip1.SetToolTip(lbl, lbltip);
            sptLinks.Panel1.Controls.Add(panLbl);
            var panUrl = new Panel
            {
                Dock = DockStyle.Top,
                Height = PANELHEIGHT,
                Font = bold ? new Font(Font, FontStyle.Bold) : Font,
            };
            if (!string.IsNullOrWhiteSpace(lnktag))
            {
                var link = new LinkLabel
                {
                    Parent = panUrl,
                    Left = 6,
                    Top = 2,
                    AutoSize = true,
                    Text = lnktext,
                    Tag = lnktag,
                    LinkArea = new LinkArea(0, lnktext.Length),
                    ContextMenuStrip = ctxMenu
                };
                link.LinkClicked += link_LinkClicked;
                toolTip1.SetToolTip(link, lnktip);
            }
            else
            {
                var lbl2 = new Label
                {
                    Parent = panUrl,
                    Left = 6,
                    Top = 2,
                    AutoSize = true,
                    Text = lnktext,
                };
                toolTip1.SetToolTip(lbl2, lnktip);
            }
            sptLinks.Panel2.Controls.Add(panUrl);
        }

        private void link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                UrlUtils.OpenUrl(sender, connectionDetail);
            }
            else if (sender is LinkLabel link)
            {
                currentlink = link;
            }
        }

        private void copyURLToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (currentlink == null)
            {
                return;
            }
            var url = currentlink.Tag.ToString();
            if (!string.IsNullOrWhiteSpace(url))
            {
                Clipboard.SetText(url);
                lblCopied.Visible = true;
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, System.EventArgs e)
        {
            timer1.Stop();
            lblCopied.Visible = false;
        }
    }
}