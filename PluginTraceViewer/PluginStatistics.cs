using Cinteros.Xrm.CRMWinForm;
using Cinteros.XTB.PluginTraceViewer.Const;
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
        const string PluginTypeAlias = "plugin";
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
            var qex = new QueryExpression(PluginTypeStatistic.EntityName);
            qex.ColumnSet.AddColumns(
                PluginTypeStatistic.CreatedOn,
                PluginTypeStatistic.ModifiedOn,
                PluginTypeStatistic.ExecuteCount,
                PluginTypeStatistic.Averageexecutetimeinmilliseconds,
                PluginTypeStatistic.FailureCount,
                PluginTypeStatistic.FailurePercent,
                PluginTypeStatistic.CrashCount,
                PluginTypeStatistic.CrashPercent,
                PluginTypeStatistic.CrashcontributionPercent,
                PluginTypeStatistic.TerminatememorycontributionPercent,
                PluginTypeStatistic.TerminatehandlescontributionPercent,
                PluginTypeStatistic.TerminatecpucontributionPercent,
                PluginTypeStatistic.TerminateothercontributionPercent);
            var leplugin = qex.AddLink(PluginType.EntityName, PluginType.PrimaryKey, PluginTypeStatistic.PluginTypeId, JoinOperator.LeftOuter);
            leplugin.EntityAlias = PluginTypeAlias;
            leplugin.Columns.AddColumns(PluginType.PrimaryName);
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
            var pluginnameattr = $"{PluginTypeAlias}.{PluginType.PrimaryName}";
            if (stat.Contains(pluginnameattr))
            {
                if (stat[pluginnameattr] is AliasedValue)
                {
                    return ((AliasedValue)stat[pluginnameattr]).Value.ToString();
                }
                return stat[pluginnameattr].ToString();
            }
            return string.Empty;
        }
    }
}
