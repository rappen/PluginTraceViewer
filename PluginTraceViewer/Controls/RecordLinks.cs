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

        public RecordLinks()
        {
            InitializeComponent();
        }

        public void SetRecords(IEnumerable<Record> records, ConnectionDetail cd)
        {
            connectionDetail = cd;
            sptLinks.Panel1.Controls.Clear();
            var recs =
                records
                //.Where(r => r.Metadata?.LogicalName == "account").OrderBy(r => r.Name)
                //.Union(records.Where(r => r.Metadata?.LogicalName == "contact").OrderBy(r => r.Name))
                //.Union(records.Where(r => r.Metadata?.LogicalName == "systemuser").OrderBy(r => r.Name))
                //.Union(records.Where(r => r.Metadata?.LogicalName == "team").OrderBy(r => r.Name))
                //.Union(records.OrderBy(r => r.Metadata?.LogicalName))
                .Where(r => r != null)
                .Distinct()
                .OrderBy(r => r.Name)
                .OrderBy(r => r.Metadata?.LogicalName)
                .OrderBy(r => r.Metadata?.ToDisplayName());
            foreach (var record in recs.Reverse())
            {
                AddLinkPanel(
                    record.Metadata?.ToDisplayName() ?? record.Name,
                    record.Metadata != null ? $"Table: {record.Metadata.LogicalName}" : record.Name,
                    record.Name,
                    record.Url,
                    $"Open this {record.Metadata?.ToDisplayName()?.ToLowerInvariant()} record.\n{record.Url}");
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
            UrlUtils.OpenUrl(sender, connectionDetail);
        }
    }
}