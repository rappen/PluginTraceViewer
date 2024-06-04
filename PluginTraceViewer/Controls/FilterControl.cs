using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using XrmToolBox.Extensibility;

namespace Cinteros.XTB.PluginTraceViewer.Controls
{
    public partial class FilterControl : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        private PluginTraceViewer ptv;
        internal Size originalSize;

        public FilterControl(PluginTraceViewer ptv)
        {
            this.ptv = ptv;
            InitializeComponent();
            originalSize = Size;
        }

        private void FilterControl_DockStateChanged(object sender, EventArgs e)
        {
            if (DockState == WeifenLuo.WinFormsUI.Docking.DockState.Float)
            {
                FloatPane.FloatWindow.Size = originalSize;
            }
        }

        private void checkDateFrom_CheckedChanged(object sender, EventArgs e)
        {
            dateFrom.Enabled = checkDateFrom.Checked;
        }

        private void checkDateTo_CheckedChanged(object sender, EventArgs e)
        {
            dateTo.Enabled = checkDateTo.Checked;
        }

        private void chkPlugin_CheckedChanged(object sender, EventArgs e)
        {
            comboPlugin.Enabled = chkPlugin.Checked;
        }

        private void chkMessage_CheckedChanged(object sender, EventArgs e)
        {
            comboMessage.Enabled = chkMessage.Checked;
        }

        private void chkEntity_CheckedChanged(object sender, EventArgs e)
        {
            comboEntity.Enabled = chkEntity.Checked;
        }

        private void chkCorrelation_CheckedChanged(object sender, EventArgs e)
        {
            textCorrelationId.Enabled = chkCorrelation.Checked;
        }

        private void chkRequestId_CheckedChanged(object sender, EventArgs e)
        {
            textRequestId.Enabled = chkRequestId.Checked;
        }

        private void chkDurationMin_CheckedChanged(object sender, EventArgs e)
        {
            numDurationMin.Enabled = chkDuration.Checked;
            numDurationMax.Enabled = chkDuration.Checked;
        }

        private void chkRecords_CheckedChanged(object sender, EventArgs e)
        {
            numRecords.Enabled = chkRecords.Checked;
        }

        internal void AddEntityFilter(List<string> newentities)
        {
            var entities = comboEntity.Text.Trim().Split(',').Where(s => !string.IsNullOrWhiteSpace(s)).Select(s => s.Trim()).ToList();
            entities = entities.Concat(newentities.Where(s => !entities.Contains(s))).ToList();
            comboEntity.Text = string.Join(", ", entities);
            chkEntity.Checked = true;
        }

        internal void SetMessageFilter(string message)
        {
            comboMessage.SelectedItem = message;
            chkMessage.Checked = true;
        }

        internal void AddPluginFilter(List<string> newplugins, bool clearexisting)
        {
            if (clearexisting)
            {
                comboPlugin.Text = string.Empty;
            }
            var plugins = comboPlugin.Text.Trim().Split(',').Where(s => !string.IsNullOrWhiteSpace(s)).Select(s => s.Trim()).ToList();
            plugins = plugins.Concat(newplugins.Select(ParsePluginType).Where(s => !plugins.Contains(s))).ToList();
            comboPlugin.Text = string.Join(", ", plugins);
            chkPlugin.Checked = true;
        }

        private string ParsePluginType(string plugin)
        {
            if (!string.IsNullOrWhiteSpace(plugin) &&
                (!ptv.tsmiFullyQualifiedPluginNames.Checked ||
                 (plugin.Contains(",") && plugin.Contains("Version="))))
            {   // Looks like new fully qualified format of the plugintype, break before first comma and add wildcard
                return plugin.Split(',')[0] + "*";
            }
            return plugin;
        }

        internal void AddCorrelationFilter(Guid newCorrId)
        {
            if (!newCorrId.Equals(Guid.Empty))
            {
                var corrIds = GetCurrentCorrelationIdFilter(true);
                if (!corrIds.Contains(newCorrId))
                {
                    corrIds.Add(newCorrId);
                }
                chkCorrelation.Checked = true;
                textCorrelationId.Text = string.Join(", ", corrIds);
                ptv.LogUse("FilterByCorrelationId");
            }
        }

        private List<Guid> GetCurrentCorrelationIdFilter(bool silent)
        {
            var results = new List<Guid>();
            foreach (var idstr in textCorrelationId.Text.Split(',').Select(i => i.Trim()))
            {
                var id = Guid.Empty;
                if (Guid.TryParse(idstr, out id) && !results.Contains(id))
                {
                    results.Add(id);
                }
                else if (!silent)
                {
                    MessageBox.Show($"\"{idstr}\" is not a valid correlation guid.", "Correlation Id", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            return results;
        }

        internal void AddRequestIdFilter(Guid newReqId)
        {
            if (!newReqId.Equals(Guid.Empty))
            {
                var reqIds = GetCurrentRequestIdFilter(true);
                if (!reqIds.Contains(newReqId))
                {
                    reqIds.Add(newReqId);
                }
                chkRequestId.Checked = true;
                textRequestId.Text = string.Join(", ", reqIds);
                ptv.LogUse("AddRequestIdFilter");
            }
        }

        private List<Guid> GetCurrentRequestIdFilter(bool silent)
        {
            var results = new List<Guid>();
            foreach (var idstr in textRequestId.Text.Split(',').Select(i => i.Trim()))
            {
                var id = Guid.Empty;
                if (Guid.TryParse(idstr, out id) && !results.Contains(id))
                {
                    results.Add(id);
                }
                else if (!silent)
                {
                    MessageBox.Show($"\"{idstr}\" is not a valid guid.", "Request Id", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            return results;
        }

        internal void ApplyFilter(PTVFilter filter)
        {
            checkDateFrom.Checked = !filter.DateFrom.Equals(DateTime.MinValue);
            if (checkDateFrom.Checked)
            {
                dateFrom.Value = filter.DateFrom;
            }
            checkDateTo.Checked = !filter.DateTo.Equals(DateTime.MinValue);
            if (checkDateTo.Checked)
            {
                dateTo.Value = filter.DateTo;
            }
            chkPlugin.Checked = filter.FilterPlugin;
            comboPlugin.Text = filter.Plugin;
            chkMessage.Checked = filter.FilterMessage;
            comboMessage.Text = filter.Message;
            chkEntity.Checked = filter.FilterEntity;
            comboEntity.Text = filter.Entity;
            chkCorrelation.Checked = filter.FilterCorr;
            textCorrelationId.Text = filter.CorrelationId;
            chkRequestId.Checked = filter.FilterReq;
            textRequestId.Text = filter.RequestId;
            chkExceptions.Checked = filter.Exceptions;
            chkOperPlugins.Checked = filter.OperationPlugin;
            chkOperWF.Checked = filter.OperationWF;
            chkModeSync.Checked = filter.ModeSync;
            chkModeAsync.Checked = filter.ModeAsync;
            chkDuration.Checked = filter.MinDuration > -1 && filter.MaxDuration > -1;
            if (chkDuration.Checked)
            {
                numDurationMin.Value = filter.MinDuration;
                numDurationMax.Value = filter.MaxDuration;
            }
            chkRecords.Checked = filter.Records > -1;
            if (chkRecords.Checked)
            {
                numRecords.Value = filter.Records;
            }
            ptv.tsmiSuppressLogSettingWarning.Checked = filter.SuppressSettingWarning;
        }

        internal PTVFilter GetFilter()
        {
            var ass = Assembly.GetExecutingAssembly().GetName();
            var version = ass.Version.ToString();
            var filter = new PTVFilter
            {
                DateFrom = checkDateFrom.Checked ? dateFrom.Value : DateTime.MinValue,
                DateTo = checkDateTo.Checked ? dateTo.Value : DateTime.MinValue,
                FilterPlugin = chkPlugin.Checked,
                Plugin = comboPlugin.Text,
                FilterMessage = chkMessage.Checked,
                Message = comboMessage.Text,
                FilterEntity = chkEntity.Checked,
                Entity = comboEntity.Text,
                FilterCorr = chkCorrelation.Checked,
                CorrelationId = textCorrelationId.Text,
                FilterReq = chkRequestId.Checked,
                RequestId = textRequestId.Text,
                Exceptions = chkExceptions.Checked,
                OperationPlugin = chkOperPlugins.Checked,
                OperationWF = chkOperWF.Checked,
                ModeSync = chkModeSync.Checked,
                ModeAsync = chkModeAsync.Checked,
                StagePreVal = chkStage10.Checked,
                StagePreOp = chkStage20.Checked,
                StagePostOp = chkStage40.Checked,
                MinDuration = chkDuration.Checked ? (int)numDurationMin.Value : -1,
                MaxDuration = chkDuration.Checked ? (int)numDurationMax.Value : -1,
                Records = chkRecords.Checked ? (int)numRecords.Value : -1,
                SuppressSettingWarning = ptv.tsmiSuppressLogSettingWarning.Checked
            };
            return filter;
        }

        internal void GetQueryFilter(QueryExpression QEplugintracelog, bool refreshOnly)
        {
            if (refreshOnly &&
                ptv.gridControl.crmGridView.GetDataSource<EntityCollection>() is EntityCollection entities &&
                entities.Entities.FirstOrDefault(e => e.Contains(Const.PluginTraceLog.PerformanceExecutionStarttime)) is Entity lasttimedlog &&
                lasttimedlog[Const.PluginTraceLog.PerformanceExecutionStarttime] is DateTime last)
            {
                QEplugintracelog.Criteria.AddCondition(Const.PluginTraceLog.PerformanceExecutionStarttime, ConditionOperator.GreaterThan, last);
            }
            if (chkRecords.Checked)
            {
                QEplugintracelog.TopCount = (int)numRecords.Value;
            }
            if (checkDateFrom.Checked)
            {
                QEplugintracelog.Criteria.AddCondition("createdon", ConditionOperator.GreaterEqual, GetDateTimeAsUtcOrLocal(dateFrom.Value));
            }
            if (checkDateTo.Checked)
            {
                QEplugintracelog.Criteria.AddCondition("createdon", ConditionOperator.LessEqual, GetDateTimeAsUtcOrLocal(dateTo.Value));
            }
            if (chkPlugin.Checked && !string.IsNullOrWhiteSpace(comboPlugin.Text))
            {
                var pluginFilterInclude = QEplugintracelog.Criteria.AddFilter(LogicalOperator.Or);
                var pluginFilterExclude = QEplugintracelog.Criteria.AddFilter(LogicalOperator.And);
                foreach (var plugin in comboPlugin.Text.Split(','))
                {
                    if (string.IsNullOrWhiteSpace(plugin))
                    {
                        continue;
                    }
                    if (plugin.Trim().StartsWith("!"))
                    {
                        pluginFilterExclude.AddCondition("typename", plugin.Contains("*") ? ConditionOperator.NotLike : ConditionOperator.NotEqual, plugin.Replace("*", "%").Trim().Substring(1));
                    }
                    else
                    {
                        pluginFilterInclude.AddCondition("typename", plugin.Contains("*") ? ConditionOperator.Like : ConditionOperator.BeginsWith, plugin.Replace("*", "%").Trim());
                    }
                }
            }
            if (chkMessage.Checked && !string.IsNullOrWhiteSpace(comboMessage.Text))
            {
                var messageFilterInclude = QEplugintracelog.Criteria.AddFilter(LogicalOperator.Or);
                var messageFilterExclude = QEplugintracelog.Criteria.AddFilter(LogicalOperator.And);
                foreach (var message in comboMessage.Text.Split(','))
                {
                    if (string.IsNullOrWhiteSpace(message))
                    {
                        continue;
                    }
                    if (message.Trim().StartsWith("!"))
                    {
                        messageFilterExclude.AddCondition("messagename", message.Contains("*") ? ConditionOperator.NotLike : ConditionOperator.NotEqual, message.Replace("*", "%").Trim().Substring(1));
                    }
                    else
                    {
                        messageFilterInclude.AddCondition("messagename", message.Contains("*") ? ConditionOperator.Like : ConditionOperator.Equal, message.Replace("*", "%").Trim());
                    }
                }
            }
            if (chkEntity.Checked && !string.IsNullOrWhiteSpace(comboEntity.Text))
            {
                var entityFilterInclude = QEplugintracelog.Criteria.AddFilter(LogicalOperator.Or);
                var entityFilterExclude = QEplugintracelog.Criteria.AddFilter(LogicalOperator.And);
                foreach (var entity in comboEntity.Text.Split(','))
                {
                    if (string.IsNullOrWhiteSpace(entity))
                    {
                        continue;
                    }
                    if (entity.Trim().StartsWith("!"))
                    {
                        entityFilterExclude.AddCondition("primaryentity", entity.Contains("*") ? ConditionOperator.NotLike : ConditionOperator.NotEqual, entity.Replace("*", "%").Trim().Substring(1));
                    }
                    else
                    {
                        entityFilterInclude.AddCondition("primaryentity", entity.Contains("*") ? ConditionOperator.Like : ConditionOperator.Equal, entity.Replace("*", "%").Trim());
                    }
                }
            }
            if (chkCorrelation.Checked)
            {
                var ids = GetCurrentCorrelationIdFilter(false);
                QEplugintracelog.Criteria.AddCondition("correlationid", ConditionOperator.In, ids.Select(i => i.ToString()).ToArray());
            }
            if (chkRequestId.Checked)
            {
                var ids = GetCurrentRequestIdFilter(false);
                QEplugintracelog.Criteria.AddCondition(Const.PluginTraceLog.RequestId, ConditionOperator.In, ids.Select(i => i.ToString()).ToArray());
            }
            if (chkExceptions.Checked)
            {
                QEplugintracelog.Criteria.AddCondition("exceptiondetails", ConditionOperator.NotNull);
                QEplugintracelog.Criteria.AddCondition("exceptiondetails", ConditionOperator.NotEqual, "");
            }
            if (chkOperPlugins.Checked && !chkOperWF.Checked)
            {
                QEplugintracelog.Criteria.AddCondition("operationtype", ConditionOperator.Equal, 1);
            }
            if (!chkOperPlugins.Checked && chkOperWF.Checked)
            {
                QEplugintracelog.Criteria.AddCondition("operationtype", ConditionOperator.Equal, 2);
            }
            if (chkModeSync.Checked && !chkModeAsync.Checked)
            {
                QEplugintracelog.Criteria.AddCondition("mode", ConditionOperator.Equal, 0);
            }
            else if (!chkModeSync.Checked && chkModeAsync.Checked)
            {
                QEplugintracelog.Criteria.AddCondition("mode", ConditionOperator.Equal, 1);
            }
            if (!chkStage10.Checked || !chkStage20.Checked || !chkStage40.Checked)
            {
                var condStage = new ConditionExpression("step", "stage", ConditionOperator.In);
                if (chkStage10.Checked)
                {
                    condStage.Values.Add(10);
                }
                if (chkStage20.Checked)
                {
                    condStage.Values.Add(20);
                }
                if (chkStage40.Checked)
                {
                    condStage.Values.Add(40);
                }
                if (condStage.Values.Count > 0)
                {
                    QEplugintracelog.Criteria.AddCondition(condStage);
                }
            }
            if (chkDuration.Checked)
            {
                QEplugintracelog.Criteria.AddCondition("performanceexecutionduration", ConditionOperator.GreaterEqual, (int)numDurationMin.Value);
                QEplugintracelog.Criteria.AddCondition("performanceexecutionduration", ConditionOperator.LessEqual, (int)numDurationMax.Value);
            }
        }

        private DateTime GetDateTimeAsUtcOrLocal(DateTime source)
        {
            if (!ptv.tsmiLocalTimes.Checked)
            {
                return new DateTime(source.Ticks, DateTimeKind.Utc);
            }
            else
            {
                return source;
            }
        }

        internal void LoadConstraints()
        {
            ptv.LogInfo("Loading constraints");
            // These constraints really doesn't add much from a usability perspective, they take time,
            // and as #39 and #54 shows it can be quite annoying.
            //GetDateConstraint("min", (datemin) =>
            //{
            //    if (!datemin.Equals(DateTime.MinValue))
            //    {
            //        dateFrom.MinDate = datemin;
            //        dateFrom.Value = datemin;
            //        dateTo.MinDate = datemin;
            //    }
            //    GetDateConstraint("max", (datemax) =>
            //    {
            //        if (!datemax.Equals(DateTime.MinValue))
            //        {
            //            dateFrom.MaxDate = datemax;
            //            dateTo.MaxDate = datemax;
            //            dateTo.Value = datemax;
            //        }
            GetPlugins((pluginlist) =>
            {
                comboPlugin.Items.Clear();
                comboPlugin.Items.AddRange(pluginlist.ToArray());
            });
            GetMessages((messagelist) =>
            {
                comboMessage.Items.Clear();
                comboMessage.Items.AddRange(messagelist.ToArray());
            });
            GetEntities((entitylist) =>
            {
                comboEntity.Items.Clear();
                comboEntity.Items.AddRange(entitylist.ToArray());
            });
            //    });
            //});
        }

        private void GetPlugins(Action<List<string>> callback)
        {
            ptv.LogInfo("GetPlugins");
            var QEplugintracelog = new QueryExpression("plugintracelog");
            QEplugintracelog.Distinct = true;
            QEplugintracelog.ColumnSet.AddColumns("typename");
            var asyncinfo = new WorkAsyncInfo()
            {
                Message = "Loading plugin types",
                Work = (a, args) =>
                {
                    args.Result = ptv.Service.RetrieveMultiple(QEplugintracelog);
                },
                PostWorkCallBack = (args) =>
                {
                    if (args.Error != null)
                    {
                        ptv.LogError("GetPlugins: {0}", args.Error.Message);
                        callback(new List<string>());
                    }
                    else if (args.Result is EntityCollection)
                    {
                        var entities = ((EntityCollection)args.Result).Entities;
                        var plugins = entities.Where(e => e.Attributes.Contains("typename")).Select(e => e.Attributes["typename"].ToString().Split(',')[0].Trim()).ToList();
                        ptv.LogInfo("GetPlugins = {0}", plugins.Count);
                        callback(plugins);
                    }
                }
            };
            ptv.WorkAsync(asyncinfo);
        }

        private void GetMessages(Action<List<string>> callback)
        {
            ptv.LogInfo("GetMessages");
            var QEplugintracelog = new QueryExpression("plugintracelog");
            QEplugintracelog.Distinct = true;
            QEplugintracelog.ColumnSet.AddColumns("messagename");
            var asyncinfo = new WorkAsyncInfo()
            {
                Message = "Loading messages",
                Work = (a, args) =>
                {
                    args.Result = ptv.Service.RetrieveMultiple(QEplugintracelog);
                },
                PostWorkCallBack = (args) =>
                {
                    if (args.Error != null)
                    {
                        ptv.LogError("GetMessages {0}", args.Error.Message);
                        callback(new List<string>());
                    }
                    else if (args.Result is EntityCollection)
                    {
                        var entities = ((EntityCollection)args.Result).Entities;
                        var messages = entities.Where(e => e.Attributes.Contains("messagename")).Select(e => e.Attributes["messagename"].ToString()).ToList();
                        ptv.LogInfo("GetMessages = {0}", messages.Count);
                        callback(messages);
                    }
                }
            };
            ptv.WorkAsync(asyncinfo);
        }

        private void GetEntities(Action<List<string>> callback)
        {
            ptv.LogInfo("GetEntities");
            var QEplugintracelog = new QueryExpression("plugintracelog");
            QEplugintracelog.Distinct = true;
            QEplugintracelog.ColumnSet.AddColumns("primaryentity");
            var asyncinfo = new WorkAsyncInfo()
            {
                Message = "Loading entities",
                Work = (a, args) =>
                {
                    args.Result = ptv.Service.RetrieveMultiple(QEplugintracelog);
                },
                PostWorkCallBack = (args) =>
                {
                    if (args.Error != null)
                    {
                        ptv.LogError("GetEntities {0}", args.Error.Message);
                        callback(new List<string>());
                    }
                    else if (args.Result is EntityCollection)
                    {
                        var entities = ((EntityCollection)args.Result).Entities;
                        var entitylist = entities.Where(e => e.Attributes.Contains("primaryentity")).Select(e => e.Attributes["primaryentity"].ToString()).ToList();
                        ptv.LogInfo("GetEntities = {0}", entitylist.Count);
                        callback(entitylist);
                    }
                }
            };
            ptv.WorkAsync(asyncinfo);
        }

        private void GetDateConstraint(string aggregate, Action<DateTime> callback)
        {
            ptv.LogInfo("GetDateConstraint {0}", aggregate);
            var date = DateTime.Today;
            var fetch = $"<fetch aggregate='true'><entity name='plugintracelog'><attribute name='createdon' alias='created' aggregate='{aggregate}'/></entity></fetch>";
            var asyncinfo = new WorkAsyncInfo()
            {
                Message = $"Loading {aggregate} date limits",
                Work = (a, args) =>
                {
                    args.Result = ptv.Service.RetrieveMultiple(new FetchExpression(fetch));
                },
                PostWorkCallBack = (args) =>
                {
                    if (args.Error != null)
                    {
                        ptv.LogError("GetDateConstraint({0}): {1}", aggregate, args.Error);
                        callback(DateTime.MinValue);
                    }
                    else if (args.Result is EntityCollection && ((EntityCollection)args.Result).Entities.Count > 0)
                    {
                        var result = ((EntityCollection)args.Result).Entities[0];
                        if (result.Contains("created") && result["created"] is AliasedValue)
                        {
                            var created = (AliasedValue)result["created"];
                            if (created.Value is DateTime)
                            {
                                date = (DateTime)created.Value;
                                ptv.LogInfo("GetDateConstraint {0} = {1}", aggregate, date);
                                callback(date);
                            }
                        }
                    }
                }
            };
            ptv.WorkAsync(asyncinfo);
        }

        internal void ShowTZInfo(bool showlocal)
        {
            if (!showlocal)
            {
                labelTimeZone.Text = "Times in UTC";
            }
            else
            {
                var tz = TimeZone.CurrentTimeZone;
                var tzname = tz.IsDaylightSavingTime(DateTime.Now) ? tz.DaylightName : tz.StandardName;
                var off = tz.GetUtcOffset(DateTime.Now);
                var offtxt = (off.TotalMinutes > 0 ? "+" : "") + off.ToString();

                labelTimeZone.Text = $"{tzname} UTC{offtxt} Filter times always UTC!";
            }
        }

        private void llDate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (sender is Control control)
            {
                dateMenu.Tag = control.Tag;
                dateMenu.Show(control, control.Width / 2, control.Height);
            }
        }

        private void dateMenuItem_Click(object sender, EventArgs e)
        {
            if (sender is ToolStripItem item)
            {
                switch (item.Tag)
                {
                    case "now":
                        SetDateValue(DateTime.Now);
                        break;

                    case "today":
                        SetDateValue(DateTime.Today);
                        break;

                    case "first":
                        GetDateConstraint("min", SetDateValue);
                        break;

                    case "last":
                        GetDateConstraint("max", SetDateValue);
                        break;
                }
            }
        }

        private void SetDateValue(DateTime date)
        {
            DateTimePicker dateControl;
            switch (dateMenu.Tag)
            {
                case "from":
                    dateControl = dateFrom;
                    checkDateFrom.Checked = true;
                    break;

                case "to":
                    dateControl = dateTo;
                    checkDateTo.Checked = true;
                    break;

                default:
                    return;
            }
            if (dateControl.MinDate > date)
            {
                dateControl.MinDate = date;
            }
            if (dateControl.MaxDate < date)
            {
                dateControl.MaxDate = date;
            }
            dateControl.Value = date;
        }
    }
}