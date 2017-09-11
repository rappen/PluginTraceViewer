using Cinteros.Xrm.CRMWinForm;
using Cinteros.XTB.PluginTraceViewer.Controls;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinteros.XTB.PluginTraceViewer
{
    public partial class PluginStatistics : Form
    {
        IOrganizationService _service;

        internal List<string> SelectedPlugins;

        public PluginStatistics(IOrganizationService service)
        {
            InitializeComponent();
            _service = service;
        }

        private void PluginStatistics_Load(object sender, EventArgs e)
        {
            PopulateStats();
        }

        private void PopulateStats()
        {
            var qex = new QueryExpression("plugintypestatistic");
            qex.ColumnSet.AddColumns(
                "createdon",
                "modifiedon",
                "executecount",
                "averageexecutetimeinmilliseconds",
                "failurecount",
                "failurepercent",
                "crashcount",
                "crashpercent",
                "crashcontributionpercent",
                "terminatememorycontributionpercent",
                "terminatehandlescontributionpercent",
                "terminatecpucontributionpercent",
                "terminateothercontributionpercent");
            var leplugin = qex.AddLink("plugintype", "plugintypeid", "plugintypeid", JoinOperator.LeftOuter);
            leplugin.EntityAlias = "plugin";
            leplugin.Columns.AddColumns("name");
            var stats = _service.RetrieveMultiple(qex);
            foreach (var stat in stats.Entities)
            {
                var secperday = StatsControl.GetStatTimePerDay(stat);
                stat["secondsperday"] = secperday;
            }
            gridPluginStats.DataSource = stats;
            gridPluginStats.AutoResizeColumns();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            SelectedPlugins = gridPluginStats.SelectedCellRecords.Entities.Select(s => GetPluginName(s)).Where(s=>!string.IsNullOrWhiteSpace(s)).ToList();
            DialogResult = DialogResult.OK;
        }

        private string GetPluginName(Entity stat)
        {
            if (stat.Contains("plugin.name"))
            {
                if (stat["plugin.name"] is AliasedValue)
                {
                    return ((AliasedValue)stat["plugin.name"]).Value.ToString();
                }
                return stat["plugin.name"].ToString();
            }
            return string.Empty;
        }
    }
}
