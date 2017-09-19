using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace Cinteros.XTB.PluginTraceViewer.Controls
{
    public partial class StatsControl : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        private PluginTraceViewer ptv;
        private Size floatSize;
        private Dictionary<string, Entity> statistics;

        public StatsControl(PluginTraceViewer ptv)
        {
            this.ptv = ptv;
            InitializeComponent();
            floatSize = Size;
        }

        private void StatsControl_DockStateChanged(object sender, EventArgs e)
        {
            if (DockState == WeifenLuo.WinFormsUI.Docking.DockState.Float)
            {
                FloatPane.FloatWindow.Size = floatSize;
            }
        }

        internal void Clear()
        {
            if (statistics != null)
            {
                statistics.Clear();
            }
        }

        internal void ShowStatistics(Entity entity)
        {
            if (!Visible)
            {
                return;
            }
            TabText = "Plugin Statistics";
            txtStatCreated.Text = "?";
            txtStatModified.Text = "?";
            txtStatExecCnt.Text = "?";
            txtStatAvgExecTime.Text = "?";
            txtStatSecPerDay.Text = "?";
            if (entity != null && entity.Contains("typename"))
            {
                var plugin = (string)entity["typename"];
                TabText = $"Plugin Statistics: {plugin}";
                var stats = GetStatistics(plugin);
                if (stats != null)
                {
                    var first = stats.Contains("createdon") ? (DateTime)stats["createdon"] : DateTime.MinValue;
                    var last = stats.Contains("modifiedon") ? (DateTime)stats["modifiedon"] : DateTime.MinValue;
                    var execs = stats.Contains("executecount") ? (int)stats["executecount"] : -1;
                    var avgtime = stats.Contains("averageexecutetimeinmilliseconds") ? (int)stats["averageexecutetimeinmilliseconds"] : -1;
                    var failcnt = stats.Contains("failurecount") ? (int)stats["failurecount"] : -1;
                    var failpct = stats.Contains("failurepercent") ? (int)stats["failurepercent"] : -1;
                    var crashcnt = stats.Contains("crashcount") ? (int)stats["crashcount"] : -1;
                    var crashpct = stats.Contains("crashpercent") ? (int)stats["crashpercent"] : -1;
                    var crashcontrpct = stats.Contains("crashcontributionpercent") ? (int)stats["crashcontributionpercent"] : -1;
                    var termcpu = stats.Contains("terminatecpucontributionpercent") ? (int)stats["terminatecpucontributionpercent"] : -1;
                    var termmem = stats.Contains("terminatememorycontributionpercent") ? (int)stats["terminatememorycontributionpercent"] : -1;
                    var termhnd = stats.Contains("terminatehandlescontributionpercent") ? (int)stats["terminatehandlescontributionpercent"] : -1;
                    var termoth = stats.Contains("terminateothercontributionpercent") ? (int)stats["terminateothercontributionpercent"] : -1;

                    txtStatCreated.Text = !first.Equals(DateTime.MinValue) ? first.ToString("yyyy-MM-dd HH:mm:ss") : "?";
                    txtStatModified.Text = !last.Equals(DateTime.MinValue) ? last.ToString("yyyy-MM-dd HH:mm:ss") : "?";
                    txtStatExecCnt.Text = execs >= 0 ? execs.ToString() : "?";
                    txtStatAvgExecTime.Text = avgtime >= 0 ? avgtime.ToString() : "?";
                    txtStatFailCnt.Text = failcnt >= 0 ? failcnt.ToString() : "?";
                    txtStatFailPct.Text = failpct >= 0 ? failpct.ToString() + " %" : "?";
                    txtStatCrashCnt.Text = crashcnt >= 0 ? crashcnt.ToString() : "?";
                    txtStatCrashPct.Text = crashpct >= 0 ? crashpct.ToString() + " %" : "?";
                    txtStatCrashContrPct.Text = crashcontrpct >= 0 ? crashcontrpct.ToString() + " %" : "?";
                    txtStatTermCPU.Text = termcpu >= 0 ? termcpu.ToString() + " %" : "?";
                    txtStatTermMemory.Text = termmem >= 0 ? termmem.ToString() + " %" : "?";
                    txtStatTermHandles.Text = termhnd >= 0 ? termhnd.ToString() + " %" : "?";
                    txtStatTermOther.Text = termoth >= 0 ? termoth.ToString() + " %" : "?";
                    var secsperday = GetStatTimePerDay(stats);
                    txtStatSecPerDay.Text = secsperday >= 0 ? secsperday.ToString("N2") : "";
                }
            }
        }

        private Entity GetStatistics(string typename)
        {
            if (statistics == null)
            {
                statistics = new Dictionary<string, Entity>();
            }
            if (!statistics.ContainsKey(typename))
            {
                var qex = new QueryExpression("plugintypestatistic");
                qex.ColumnSet.AddColumns("failurepercent", "terminatememorycontributionpercent", "averageexecutetimeinmilliseconds",
                    "crashpercent", "crashcount", "terminatehandlescontributionpercent", "executecount", "failurecount",
                    "terminatecpucontributionpercent", "modifiedon", "createdon", "terminateothercontributionpercent", "crashcontributionpercent");
                var leType = qex.AddLink("plugintype", "plugintypeid", "plugintypeid");
                leType.LinkCriteria.AddCondition("typename", ConditionOperator.Equal, typename);
                var res = ptv.Service.RetrieveMultiple(qex);
                if (res.Entities.Count == 1)
                {
                    statistics.Add(typename, res[0]);
                }
            }
            if (statistics.ContainsKey(typename))
            {
                return statistics[typename];
            }
            return null;
        }

        internal static double GetStatTimePerDay(Entity pluginstatistic)
        {
            var first = pluginstatistic.Contains("createdon") ? (DateTime)pluginstatistic["createdon"] : DateTime.MinValue;
            var last = pluginstatistic.Contains("modifiedon") ? (DateTime)pluginstatistic["modifiedon"] : DateTime.MinValue;
            var execs = pluginstatistic.Contains("executecount") ? (int)pluginstatistic["executecount"] : -1;
            var avgtime = pluginstatistic.Contains("averageexecutetimeinmilliseconds") ? (int)pluginstatistic["averageexecutetimeinmilliseconds"] : -1;
            var secperday = 0D;
            if (!first.Equals(DateTime.MinValue) && !last.Equals(DateTime.MinValue) && !first.Equals(last) && execs >= 0 && avgtime >= 0)
            {
                var span = last - first;
                if (span.TotalDays > 0)
                {
                    var tottime = execs * avgtime;
                    secperday = tottime / span.TotalDays / 1000;
                }
            }
            return secperday;
        }
    }
}
