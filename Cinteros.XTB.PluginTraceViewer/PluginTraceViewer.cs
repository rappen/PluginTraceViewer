using Cinteros.Xrm.CRMWinForm;
using McTools.Xrm.Connection;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.Xml;
using XrmToolBox.Extensibility;
using XrmToolBox.Extensibility.Interfaces;
using XrmToolBox.Extensibility.Args;
using System.Threading.Tasks;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Crm.Sdk.Messages;

namespace Cinteros.XTB.PluginTraceViewer
{
    public partial class PluginTraceViewer : PluginControlBase, IGitHubPlugin, IMessageBusHost, IHelpPlugin, IPayPalPlugin, IStatusBarMessenger
    {
        private int lastRecordCount = 100;

        private const int PAGE_SIZE = 1000;
        private const int MAX_BATCH = 2;
        private bool? logUsage = null;
        private Dictionary<string, Entity> statistics;

        public PluginTraceViewer()
        {
            InitializeComponent();
        }

        public string HelpUrl { get { return "http://ptv.xrmtoolbox.com"; } }

        public string RepositoryName { get { return "XrmToolBox.PluginTraceViewer"; } }

        public string UserName { get { return "Innofactor"; } }

        public string DonationDescription
        {
            get { return "Plug-in Trace Viewer Fan Club"; }
        }

        public string EmailAccount
        {
            get { return "jonas@rappen.net"; }
        }

        public event EventHandler<MessageBusEventArgs> OnOutgoingMessage;
        public event EventHandler<StatusBarMessageEventArgs> SendMessageToStatusBar;

        public void OnIncomingMessage(MessageBusEventArgs message)
        {
            if (message.SourcePlugin == "FetchXML Builder" && message.TargetArgument is string)
            {
                FetchUpdated(message.TargetArgument);
            }
        }

        private void tsbAbout_Click(object sender, EventArgs e)
        {
            LogUse("OpenAbout");
            var about = new About(this);
            about.StartPosition = FormStartPosition.CenterParent;
            about.lblVersion.Text = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            about.chkStatAllow.Checked = logUsage != false;
            about.ShowDialog();
            if (logUsage != about.chkStatAllow.Checked)
            {
                logUsage = about.chkStatAllow.Checked;
                if (logUsage == true)
                {
                    LogUse("Accept", true);
                }
                else if (logUsage == false)
                {
                    LogUse("Deny", true);
                }
            }
        }

        private void AlertError(string msg, string capt)
        {
            LogError(msg);
            MessageBox.Show(msg, capt, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void PluginTraceViewer_Load(object sender, EventArgs e)
        {
            LoadSettings();
            LogUse("Load");
        }

        private void PluginTraceViewer_ConnectionUpdated(object sender, ConnectionUpdatedEventArgs e)
        {
            LoadFilter();
            if (crmGridView.DataSource != null)
            {
                crmGridView.DataSource = null;
            }
            var orgver = new Version(e.ConnectionDetail.OrganizationVersion);
            LogInfo("Connected CRM version: {0}", orgver);
            var orgok = orgver >= new Version(7, 1);
            crmGridView.OrganizationService = orgok ? e.Service : null;
            buttonRetrieveLogs.Enabled = orgok;
            tsmiRefreshFilter.Enabled = orgok;
            if (orgok)
            {
                LoadLogSetting();
                LoadConstraints();
            }
            else
            {
                LogError("CRM version too old for PTV");
                MessageBox.Show("Plug-in Trace Log was introduced in\nMicrosoft Dynamics CRM 2015 Update 1 (7.1.0.0)\n\nPlease connect to a newer organization to use this cool tool.", "Organization too old", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public override void ClosingPlugin(PluginCloseInfo info)
        {
            SaveSettings();
            LogUse("Close");
        }

        private void LoadFilter()
        {
            PTVFilter settings;
            if (SettingsManager.Instance.TryLoad(typeof(PluginTraceViewer), out settings, ConnectionDetail?.ConnectionName))
            {
                ApplyFilter(settings);
            }
        }

        private void LoadSettings()
        {
            Settings settings;
            if (!SettingsManager.Instance.TryLoad(typeof(PluginTraceViewer), out settings, "Settings"))
            {
                settings = new Settings();
            }
            ApplySettings(settings);
        }

        private void LoadLogSetting()
        {
            comboLogSetting.Enabled = false;
            GetLogSetting((id, setting) =>
            {
                comboLogSetting.Tag = id;
                comboLogSetting.SelectedIndex = setting;
                comboLogSetting.Enabled = true;
            });
        }

        private void UpdateLogSetting(int setting)
        {
            LogUse("UpdateSetting-" + setting);
            var orgsetting = new Entity("organization");
            orgsetting.Id = (Guid)comboLogSetting.Tag;
            orgsetting["plugintracelogsetting"] = new OptionSetValue(setting);
            SendMessageToStatusBar(this, new StatusBarMessageEventArgs($"Updating setting for org {orgsetting.Id} to {setting}"));
            LogInfo("Updating setting for org {0} to {1}", orgsetting.Id, setting);
            Service.Update(orgsetting);
            crmGridView.Focus();
            MessageBox.Show("Updated trace setting!");
        }

        private void LoadConstraints()
        {
            LogInfo("Loading constraints");
            GetDateConstraint("min", (datemin) =>
            {
                dateFrom.MinDate = datemin;
                dateFrom.Value = datemin;
                dateTo.MinDate = datemin;
            });
            GetDateConstraint("max", (datemax) =>
            {
                dateFrom.MaxDate = datemax;
                dateTo.MaxDate = datemax;
                dateTo.Value = datemax;
            });
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
        }

        private void GetLogSetting(Action<Guid, int> callback)
        {
            LogInfo("GetLogSetting");
            var QEorganization = new QueryExpression("organization");
            QEorganization.ColumnSet.AddColumns("name", "plugintracelogsetting");
            var asyncinfo = new WorkAsyncInfo()
            {
                Message = "Loading organization settings",
                Work = (a, args) =>
                {
                    args.Result = Service.RetrieveMultiple(QEorganization);
                },
                PostWorkCallBack = (args) =>
                {
                    if (args.Error != null)
                    {
                        AlertError($"Failed to load plugin types:\n{args.Error.Message}", "Load");
                    }
                    else if (args.Result is EntityCollection)
                    {
                        var entity = ((EntityCollection)args.Result).Entities.FirstOrDefault();
                        if (entity != null)
                        {
                            var id = entity.Id;
                            var name = entity.Contains("name") ? entity["name"] : "?";
                            var setting = entity.Contains("plugintracelogsetting") ? ((OptionSetValue)entity["plugintracelogsetting"]).Value : 0;
                            LogInfo("Found org: {0} with setting {1}", name, setting);
                            callback(id, setting);
                        }
                        else
                        {
                            LogError("No organization data found!");
                        }
                    }
                }
            };
            WorkAsync(asyncinfo);
        }

        private void GetPlugins(Action<List<string>> callback)
        {
            LogInfo("GetPlugins");
            var QEplugintracelog = new QueryExpression("plugintracelog");
            QEplugintracelog.Distinct = true;
            QEplugintracelog.ColumnSet.AddColumns("typename");
            var asyncinfo = new WorkAsyncInfo()
            {
                Message = "Loading plugin types",
                Work = (a, args) =>
                {
                    args.Result = Service.RetrieveMultiple(QEplugintracelog);
                },
                PostWorkCallBack = (args) =>
                {
                    if (args.Error != null)
                    {
                        AlertError($"Failed to load plugin types:\n{args.Error.Message}", "Load");
                    }
                    else if (args.Result is EntityCollection)
                    {
                        var entities = ((EntityCollection)args.Result).Entities;
                        var plugins = entities.Where(e => e.Attributes.Contains("typename")).Select(e => e.Attributes["typename"].ToString()).ToList();
                        LogInfo("GetPlugins = {0}", plugins.Count);
                        callback(plugins);
                    }
                }
            };
            WorkAsync(asyncinfo);
        }

        private void GetMessages(Action<List<string>> callback)
        {
            LogInfo("GetMessages");
            var QEplugintracelog = new QueryExpression("plugintracelog");
            QEplugintracelog.Distinct = true;
            QEplugintracelog.ColumnSet.AddColumns("messagename");
            var asyncinfo = new WorkAsyncInfo()
            {
                Message = "Loading messages",
                Work = (a, args) =>
                {
                    args.Result = Service.RetrieveMultiple(QEplugintracelog);
                },
                PostWorkCallBack = (args) =>
                {
                    if (args.Error != null)
                    {
                        AlertError($"Failed to load messages:\n{args.Error.Message}", "Load");
                    }
                    else if (args.Result is EntityCollection)
                    {
                        var entities = ((EntityCollection)args.Result).Entities;
                        var messages = entities.Where(e => e.Attributes.Contains("messagename")).Select(e => e.Attributes["messagename"].ToString()).ToList();
                        LogInfo("GetMessages = {0}", messages.Count);
                        callback(messages);
                    }
                }
            };
            WorkAsync(asyncinfo);
        }

        private void GetEntities(Action<List<string>> callback)
        {
            LogInfo("GetEntities");
            var QEplugintracelog = new QueryExpression("plugintracelog");
            QEplugintracelog.Distinct = true;
            QEplugintracelog.ColumnSet.AddColumns("primaryentity");
            var asyncinfo = new WorkAsyncInfo()
            {
                Message = "Loading entities",
                Work = (a, args) =>
                {
                    args.Result = Service.RetrieveMultiple(QEplugintracelog);
                },
                PostWorkCallBack = (args) =>
                {
                    if (args.Error != null)
                    {
                        AlertError($"Failed to load entities:\n{args.Error.Message}", "Load");
                    }
                    else if (args.Result is EntityCollection)
                    {
                        var entities = ((EntityCollection)args.Result).Entities;
                        var entitylist = entities.Where(e => e.Attributes.Contains("primaryentity")).Select(e => e.Attributes["primaryentity"].ToString()).ToList();
                        LogInfo("GetEntities = {0}", entitylist.Count);
                        callback(entitylist);
                    }
                }
            };
            WorkAsync(asyncinfo);
        }

        private void GetDateConstraint(string aggregate, Action<DateTime> callback)
        {
            LogInfo("GetDateConstraint {0}", aggregate);
            var date = DateTime.Today;
            var fetch = $"<fetch aggregate='true'><entity name='plugintracelog'><attribute name='createdon' alias='created' aggregate='{aggregate}'/></entity></fetch>";
            var asyncinfo = new WorkAsyncInfo()
            {
                Message = $"Loading {aggregate} date limits",
                Work = (a, args) =>
                {
                    args.Result = Service.RetrieveMultiple(new FetchExpression(fetch));
                },
                PostWorkCallBack = (args) =>
                {
                    if (args.Error != null)
                    {
                        AlertError($"Failed to load date constraints:\n{args.Error.Message}", "Load");
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
                                LogInfo("GetDateConstraint {0} = {1}", aggregate, date);
                                callback(date);
                            }
                        }
                    }
                }
            };
            WorkAsync(asyncinfo);
        }

        private void FetchUpdated(string fetchxml)
        {
            var req = Service.Execute(new FetchXmlToQueryExpressionRequest { FetchXml = fetchxml }) as FetchXmlToQueryExpressionResponse;
            RefreshTraces(req.Query);
        }

        private void RefreshTraces(QueryExpression query)
        {
            if (query == null)
            {
                return;
            }
            if (Service == null)
            {
                return;
            }
            if (statistics != null)
            {
                statistics.Clear();
            }
            LogUse("RetrieveLogs");
            var asyncinfo = new WorkAsyncInfo()
            {
                Message = "Loading trace log records",
                Work = (a, args) =>
                {
                    LogInfo("Loading logs");
                    args.Result = Service.RetrieveMultiple(query);
                },
                PostWorkCallBack = (args) =>
                {
                    if (args.Error != null)
                    {
                        AlertError($"Failed to load trace logs:\n{args.Error.Message}", "Load");
                    }
                    else if (args.Result is EntityCollection)
                    {
                        FriendlyfyCorrelationIds(args.Result as EntityCollection);
                        ExtractExceptionSummaries(args.Result as EntityCollection);
                        PopulateGrid(args.Result as EntityCollection);
                    }
                }
            };
            WorkAsync(asyncinfo);
        }

        private void FriendlyfyCorrelationIds(EntityCollection entities)
        {
            var allCorrelationIds = new List<Guid>();
            var correlationIds = new List<Guid>();
            foreach (var entity in entities.Entities)
            {   // First determine which correlation ids that occur more than once, we don't want to show corr for single occurences
                if (entity.Contains("correlationid"))
                {
                    var corrId = (Guid)entity["correlationid"];
                    if (allCorrelationIds.Contains(corrId))
                    {   // id occurs more than once
                        if (!correlationIds.Contains(corrId))
                        {
                            correlationIds.Add(corrId);
                        }
                    }
                    else
                    {
                        allCorrelationIds.Add(corrId);
                    }
                }
            }
            foreach (var entity in entities.Entities)
            {
                if (entity.Contains("correlationid"))
                {
                    var corrId = (Guid)entity["correlationid"];
                    if (correlationIds.Contains(corrId))
                    {
                        var index = correlationIds.IndexOf(corrId);
                        var friendlyCorr = string.Empty;
                        do
                        {
                            var curr = (index > 25 ? index / 26 - 1 : index) + 65;
                            friendlyCorr += (char)curr;
                            index = index > 25 ? index % 26 : -1;
                        }
                        while (index >= 0);
                        entity.Attributes.Add("correlation", friendlyCorr);
                    }
                }
            }
        }

        private void ExtractExceptionSummaries(EntityCollection entities)
        {
            const string fault = "(Fault Detail is equal to Microsoft.Xrm.Sdk.OrganizationServiceFault).: ";
            const string unhandled = "Unhandled Exception: ";
            var cnt = 0;
            foreach (var entity in entities.Entities)
            {
                if (entity.Contains("exceptiondetails") && !string.IsNullOrWhiteSpace(entity["exceptiondetails"].ToString()))
                {
                    var summary = entity["exceptiondetails"].ToString();
                    if (summary.Contains("<Message>") && summary.Contains("</Message>"))
                    {
                        summary = summary.Substring(summary.IndexOf("<Message>") + 9);
                        summary = summary.Substring(0, summary.IndexOf("</Message>"));
                        while (summary.Contains(fault))
                        {
                            summary = summary.Substring(summary.IndexOf(fault) + fault.Length);
                        }
                    }
                    else if (summary.StartsWith(unhandled))
                    {
                        summary = summary.Substring(summary.IndexOf(unhandled) + unhandled.Length);
                        if (summary.Contains(":"))
                        {
                            summary = summary.Split(':')[0];
                        }
                    }
                    if (!string.IsNullOrWhiteSpace(summary))
                    {
                        entity.Attributes.Add("exceptionsummary", summary);
                        cnt++;
                    }
                }
            }
            LogInfo("Extracted exception summary from {0} logs", cnt);
        }

        private QueryExpression GetQuery()
        {
            var QEplugintracelog = new QueryExpression("plugintracelog");
            QEplugintracelog.ColumnSet.AddColumns(
                            "correlationid",
                            "performanceexecutionstarttime",
                            "operationtype",
                            "messagename",
                            "plugintracelogid",
                            "primaryentity",
                            "exceptiondetails",
                            "messageblock",
                            "performanceexecutionduration",
                            "createdon",
                            "typename",
                            "depth",
                            "mode");
            var LEstep = QEplugintracelog.AddLink("sdkmessageprocessingstep", "pluginstepid", "sdkmessageprocessingstepid", JoinOperator.LeftOuter);
            LEstep.EntityAlias = "step";
            LEstep.Columns.AddColumns("rank", "stage");
            if (chkRecords.Checked)
            {
                QEplugintracelog.TopCount = (int)numRecords.Value;
            }
            GetQueryFilter(QEplugintracelog);
            QEplugintracelog.AddOrder("performanceexecutionstarttime", OrderType.Descending);
            QEplugintracelog.AddOrder("correlationid", OrderType.Ascending);    // This just to group threads together when starting the same second
            QEplugintracelog.AddOrder("depth", OrderType.Descending);           // This to try to compensate for executionstarttime only accurate to the second
            return QEplugintracelog;
        }

        private void GetQueryFilter(QueryExpression QEplugintracelog)
        {
            if (checkDateFrom.Checked)
            {
                QEplugintracelog.Criteria.AddCondition("createdon", ConditionOperator.GreaterEqual, GetDateTimeAsUTC(dateFrom.Value));
            }
            if (checkDateTo.Checked)
            {
                QEplugintracelog.Criteria.AddCondition("createdon", ConditionOperator.LessEqual, GetDateTimeAsUTC(dateTo.Value));
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
                        pluginFilterInclude.AddCondition("typename", plugin.Contains("*") ? ConditionOperator.Like : ConditionOperator.Equal, plugin.Replace("*", "%").Trim());
                    }
                }
            }
            if (chkMessage.Checked && !string.IsNullOrWhiteSpace(comboMessage.Text))
            {
                QEplugintracelog.Criteria.AddCondition("messagename", ConditionOperator.Equal, comboMessage.Text);
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
            if (chkExceptions.Checked)
            {
                QEplugintracelog.Criteria.AddCondition("exceptiondetails", ConditionOperator.NotNull);
                QEplugintracelog.Criteria.AddCondition("exceptiondetails", ConditionOperator.NotEqual, "");
            }
            if (rbOperPlugin.Checked)
            {
                QEplugintracelog.Criteria.AddCondition("operationtype", ConditionOperator.Equal, 1);
            }
            else if (rbOperWF.Checked)
            {
                QEplugintracelog.Criteria.AddCondition("operationtype", ConditionOperator.Equal, 2);
            }
            if (rbModeSync.Checked)
            {
                QEplugintracelog.Criteria.AddCondition("mode", ConditionOperator.Equal, 0);
            }
            else if (rbModeAsync.Checked)
            {
                QEplugintracelog.Criteria.AddCondition("mode", ConditionOperator.Equal, 1);
            }
            if (chkDurationMin.Checked)
            {
                QEplugintracelog.Criteria.AddCondition("performanceexecutionduration", ConditionOperator.GreaterEqual, (int)numDurationMin.Value);
            }
            if (chkDurationMax.Checked)
            {
                QEplugintracelog.Criteria.AddCondition("performanceexecutionduration", ConditionOperator.LessEqual, (int)numDurationMax.Value);
            }
        }

        private DateTime GetDateTimeAsUTC(DateTime source)
        {
            return new DateTime(source.Ticks, DateTimeKind.Utc);
        }

        private void PopulateGrid(EntityCollection results)
        {
            LogInfo("PopulateGrid with {0} logs", results.Entities.Count);
            var asyncinfo = new WorkAsyncInfo()
            {
                Message = "Populating result view",
                Work = (a, args) =>
                {
                    UpdateUI(() =>
                    {
                        crmGridView.DataSource = results;
                        SendMessageToStatusBar(this, new StatusBarMessageEventArgs($"Loaded {results.Entities.Count} trace records"));
                        crmGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                    });
                },
                PostWorkCallBack = (args) =>
                {
                    if (args.Error != null)
                    {
                        AlertError($"Failed to populate result view:\n{args.Error.Message}", "Load");
                    }
                }
            };
            WorkAsync(asyncinfo);
        }

        private void buttonRetrieveLogs_Click(object sender, EventArgs e)
        {
            RefreshTraces(GetQuery());
        }

        private void checkDateFrom_CheckedChanged(object sender, EventArgs e)
        {
            dateFrom.Enabled = checkDateFrom.Checked;
        }

        private void checkDateTo_CheckedChanged(object sender, EventArgs e)
        {
            dateTo.Enabled = checkDateTo.Checked;
        }

        private void crmGridView_RecordEnter(object sender, Xrm.CRMWinForm.CRMRecordEventArgs e)
        {
            buttonOpenLogRecord.Enabled = e.Entity != null;
            textMessage.Text = FixLineBreaks(e.Entity != null && e.Entity.Contains("messageblock") ? e.Entity["messageblock"].ToString() : "");
            textException.Text = FixLineBreaks(e.Entity != null && e.Entity.Contains("exceptiondetails") ? e.Entity["exceptiondetails"].ToString() : "");
            groupException.Text = "Exception" + (e.Entity.Contains("exceptionsummary") ? ": " + e.Entity["exceptionsummary"].ToString().Replace("\r\n", " ") : "");
            ShowStatistics(e.Entity);
        }

        private void ShowStatistics(Entity entity)
        {
            if (!tsmiViewStatistics.Checked)
            {
                return;
            }
            groupStatistics.Text = "Plugin Statistics";
            txtStatCreated.Text = "?";
            txtStatModified.Text = "?";
            txtStatExecCnt.Text = "?";
            txtStatAvgExecTime.Text = "?";
            txtStatSecPerDay.Text = "?";
            if (entity != null && entity.Contains("typename"))
            {
                var plugin = (string)entity["typename"];
                groupStatistics.Text = $"Plugin Statistics: {plugin}";
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
                    if (!first.Equals(DateTime.MinValue) && !last.Equals(DateTime.MinValue) && !first.Equals(last) && execs >= 0 && avgtime >= 0)
                    {
                        var span = last - first;
                        if (span.TotalDays > 0)
                        {
                            var tottime = execs * avgtime;
                            var timeperday = tottime / span.TotalDays / 1000;
                            txtStatSecPerDay.Text = timeperday.ToString("N2");
                        }
                    }
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
                var res = Service.RetrieveMultiple(qex);
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

        private string FixLineBreaks(string text)
        {
            text = text.Replace("\r\n", "\n");
            text = text.Replace("\n", Environment.NewLine);
            return text;
        }

        private void OpenLogRecord()
        {
            var firstselected = crmGridView.SelectedCellRecords.Entities.FirstOrDefault();
            if (firstselected != null)
            {
                var url = GetEntityReferenceUrl(firstselected.ToEntityReference());
                if (!string.IsNullOrEmpty(url))
                {
                    LogUse("Open log record");
                    LogInfo("Opening record: {0}", url);
                    Process.Start(url);
                }
            }
        }

        private string GetEntityReferenceUrl(EntityReference entref)
        {
            if (!string.IsNullOrEmpty(entref.LogicalName) && !entref.Id.Equals(Guid.Empty))
            {
                var url = ConnectionDetail.WebApplicationUrl;
                if (string.IsNullOrEmpty(url))
                {
                    url = string.Concat(ConnectionDetail.ServerName, "/", ConnectionDetail.Organization);
                    if (!url.ToLower().StartsWith("http"))
                    {
                        url = string.Concat("http://", url);
                    }
                }
                url = string.Concat(url,
                    "/main.aspx?etn=",
                    entref.LogicalName,
                    "&pagetype=entityrecord&id=",
                    entref.Id.ToString());
                return url;
            }
            return string.Empty;
        }

        private void chkPlugin_CheckedChanged(object sender, EventArgs e)
        {
            comboPlugin.Enabled = chkPlugin.Checked;
        }

        private void tsbCloseThisTab_Click(object sender, EventArgs e)
        {
            CloseTool();
        }

        private void chkMessage_CheckedChanged(object sender, EventArgs e)
        {
            comboMessage.Enabled = chkMessage.Checked;
        }

        private void numRecords_ValueChanged(object sender, EventArgs e)
        {
            var compareValue = numRecords.Value - lastRecordCount.CompareTo((int)numRecords.Value);
            var increment = 1;
            if (compareValue < 10) increment = 1;
            else if (compareValue < 20) increment = 5;
            else if (compareValue < 50) increment = 10;
            else if (compareValue < 200) increment = 25;
            else if (compareValue < 1000) increment = 100;
            else increment = 1000;
            if (numRecords.Value % increment != 0)
            {
                numRecords.Value = Math.Round(numRecords.Value / increment) * increment;
            }
            numRecords.Increment = increment;
            lastRecordCount = (int)numRecords.Value;
        }

        private void tsmiWordWrap_CheckedChanged(object sender, EventArgs e)
        {
            textMessage.WordWrap = tsmiWordWrap.Checked;
            textException.WordWrap = tsmiWordWrap.Checked;
        }

        private void chkEntity_CheckedChanged(object sender, EventArgs e)
        {
            comboEntity.Enabled = chkEntity.Checked;
        }

        private void chkDurationMin_CheckedChanged(object sender, EventArgs e)
        {
            numDurationMin.Enabled = chkDurationMin.Checked;
        }

        private void chkDurationMax_CheckedChanged(object sender, EventArgs e)
        {
            numDurationMax.Enabled = chkDurationMax.Checked;
        }

        private void chkRecords_CheckedChanged(object sender, EventArgs e)
        {
            numRecords.Enabled = chkRecords.Checked;
        }

        private void tsmiViewFilter_CheckedChanged(object sender, EventArgs e)
        {
            groupFilter.Visible = tsmiViewFilter.Checked;
        }

        private void tsmiRefreshFilter_Click(object sender, EventArgs e)
        {
            LoadLogSetting();
            LoadConstraints();
            LogUse("LoadConstraints");
        }

        private void SaveLogs()
        {
            var sfd = new SaveFileDialog
            {
                Title = "Select a location to save the logs",
                Filter = "XML file (*.xml)|*.xml"
            };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                var newfile = sfd.FileName;
                if (!string.IsNullOrEmpty(newfile))
                {
                    var serialized = EntityCollectionSerializer.Serialize((EntityCollection)crmGridView.GetDataSource<EntityCollection>(), SerializationStyle.Explicit);
                    serialized.Save(newfile);
                    MessageBox.Show(this, "Logs saved!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void UpdateUI(Action action)
        {
            MethodInvoker mi = delegate
            {
                action();
            };
            if (InvokeRequired)
            {
                Invoke(mi);
            }
            else
            {
                mi();
            }
        }

        private void buttonSaveLogs_Click(object sender, EventArgs e)
        {
            SaveLogs();
        }

        private void buttonSaveFilter_Click(object sender, EventArgs e)
        {
            SaveFilter();
        }

        private void SaveFilter()
        {
            PTVFilter filter = GetFilter();
            var sfd = new SaveFileDialog
            {
                Title = "Select a location to save the filter",
                Filter = "XML file (*.xml)|*.xml"
            };
            if (sfd.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(sfd.FileName))
            {
                XmlSerializerHelper.SerializeToFile(filter, sfd.FileName);
                MessageBox.Show(this, "Filter saved!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private PTVFilter GetFilter()
        {
            var ass = Assembly.GetExecutingAssembly().GetName();
            var version = ass.Version.ToString();
            return new PTVFilter
            {
                DateFrom = checkDateFrom.Checked ? dateFrom.Value : DateTime.MinValue,
                DateTo = checkDateTo.Checked ? dateTo.Value : DateTime.MinValue,
                Plugin = chkPlugin.Checked ? comboPlugin.Text : string.Empty,
                Message = chkMessage.Checked ? comboMessage.Text : string.Empty,
                Entity = chkEntity.Checked ? comboEntity.Text : string.Empty,
                CorrelationId = chkCorrelation.Checked ? textCorrelationId.Text : string.Empty,
                Exceptions = chkExceptions.Checked,
                Operation = rbOperPlugin.Checked ? 1 : rbOperWF.Checked ? 2 : 0,
                Mode = rbModeSync.Checked ? 1 : rbModeAsync.Checked ? 2 : 0,
                MinDuration = chkDurationMin.Checked ? (int)numDurationMin.Value : -1,
                MaxDuration = chkDurationMax.Checked ? (int)numDurationMax.Value : -1,
                Records = chkRecords.Checked ? (int)numRecords.Value : -1
            };
        }

        private Settings GetSettings()
        {
            var ass = Assembly.GetExecutingAssembly().GetName();
            var version = ass.Version.ToString();
            return new Settings
            {
                FilterHidden = !groupFilter.Visible,
                WordWrap = tsmiWordWrap.Checked,
                Statistics = tsmiViewStatistics.Checked,
                UseLog = logUsage,
                Version = version
            };
        }

        private void buttonOpenFilter_Click(object sender, EventArgs e)
        {
            OpenFilter();
        }

        private void OpenFilter()
        {
            var ofd = new OpenFileDialog
            {
                Title = "Select filter file",
                Filter = "XML file (*.xml)|*.xml"
            };
            if (ofd.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(ofd.FileName))
            {
                var document = new XmlDocument();
                try
                {
                    document.Load(ofd.FileName);
                    var filter = (PTVFilter)XmlSerializerHelper.Deserialize(document.OuterXml, typeof(PTVFilter));
                    ApplyFilter(filter);
                    MessageBox.Show(this, "Filter loaded!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    LogError("Fatal error at OpenFilter:\n{0}", ex.Message);
                }
            }
        }

        private void ApplyFilter(PTVFilter filter)
        {
            tsmiViewFilter.Checked = groupFilter.Visible;
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
            chkPlugin.Checked = !string.IsNullOrEmpty(filter.Plugin);
            comboPlugin.Text = filter.Plugin;
            chkMessage.Checked = !string.IsNullOrEmpty(filter.Message);
            comboMessage.SelectedIndex = comboMessage.Items.IndexOf(filter.Message);
            chkEntity.Checked = !string.IsNullOrEmpty(filter.Entity);
            comboEntity.Text = filter.Entity;
            chkCorrelation.Checked = !string.IsNullOrEmpty(filter.CorrelationId);
            textCorrelationId.Text = filter.CorrelationId;
            chkExceptions.Checked = filter.Exceptions;
            switch (filter.Operation)
            {
                case 1:
                    rbOperPlugin.Checked = true;
                    break;
                case 2:
                    rbOperWF.Checked = true;
                    break;
                default:
                    rbOperAll.Checked = true;
                    break;
            }
            switch (filter.Mode)
            {
                case 1:
                    rbModeSync.Checked = true;
                    break;
                case 2:
                    rbModeAsync.Checked = true;
                    break;
                default:
                    rbModeAll.Checked = true;
                    break;
            }
            chkDurationMin.Checked = filter.MinDuration > -1;
            if (chkDurationMin.Checked)
            {
                numDurationMin.Value = filter.MinDuration;
            }
            chkDurationMax.Checked = filter.MaxDuration > -1;
            if (chkDurationMax.Checked)
            {
                numDurationMax.Value = filter.MaxDuration;
            }
            chkRecords.Checked = filter.Records > -1;
            if (chkRecords.Checked)
            {
                numRecords.Value = filter.Records;
            }
        }

        private void ApplySettings(Settings settings)
        {
            groupFilter.Visible = !settings.FilterHidden;
            tsmiViewFilter.Checked = groupFilter.Visible;
            tsmiWordWrap.Checked = settings.WordWrap;
            tsmiViewStatistics.Checked = settings.Statistics;
            logUsage = settings.UseLog;
            var ass = Assembly.GetExecutingAssembly().GetName();
            var version = ass.Version.ToString();
            if (!version.Equals(settings.Version))
            {
                // Reset some settings when new version is deployed
                logUsage = null;
            }
            if (logUsage == null)
            {
                logUsage = LogUsage.PromptToLog();
            }
        }

        private void buttonOpenLogRecord_Click(object sender, EventArgs e)
        {
            OpenLogRecord();
        }

        private void crmGridView_RecordDoubleClick(object sender, CRMRecordEventArgs e)
        {
            OpenLogRecord();
        }

        private void tsmiDeleteSelected_Click(object sender, EventArgs e)
        {
            var menu = (ContextMenuStrip)((ToolStripDropDownItem)sender).GetCurrentParent();
            var grid = (CRMGridView)menu?.SourceControl;
            var entities = grid?.SelectedCellRecords?.Entities;

            if (entities != null && entities.Count > 0)
            {
                Delete(Bundle(entities)).Start();

                // Deleting log records from the list
                var source = (EntityCollection)grid.DataSource;

                foreach (var entity in entities)
                {
                    source.Entities.Remove(entity);
                }

                // Refresh unfortunately crashes with InvalidAsynchronousStateException "Target thread does not exist anymore
                // grid.Refresh();
                PopulateGrid(source);
            }
        }

        private void tsmiDeleteAll_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes != MessageBox.Show("This action will permanently delete all returned log records.\n\nContinue?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                return;
            }
            var query = new QueryExpression("plugintracelog");
            var batches = new List<ExecuteMultipleRequest>();
            EntityCollection result = null;

            do
            {
                query.PageInfo = new PagingInfo();

                if (result != null)
                {
                    query.PageInfo.PagingCookie = result.PagingCookie;
                }

                // Getting all log records in the loop
                result = Service.RetrieveMultiple(query);
                batches.AddRange(Bundle(result.Entities));
            } while (result.MoreRecords == true);

            // Deleting log records
            Delete(batches).Start();

            var menu = (ContextMenuStrip)((ToolStripDropDownItem)sender).GetCurrentParent();
            var grid = (CRMGridView)menu?.SourceControl;
            var source = (EntityCollection)grid.DataSource;

            // TODO: Prompt user - reload logs? Otherwise just clear the list
            if (source != null)
            {
                source.Entities.Clear();

                // Refresh unfortunately crashes with InvalidAsynchronousStateException "Target thread does not exist anymore
                // grid.Refresh();
                PopulateGrid(source);
            }
        }

        private void contextMenuGridView_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var menu = (ContextMenuStrip)sender;
            var grid = (CRMGridView)menu?.SourceControl;
            var entities = grid?.SelectedCellRecords?.Entities;

            var corrId = GetSelectedCorrelationId();
            if (!corrId.Equals(Guid.Empty))
            {
                tsmiCorrelationId.Text = "Id: " + corrId.ToString();
                tsmiCorrelation.Enabled = true;
            }
            else
            {
                tsmiCorrelation.Enabled = false;
            }
            if (entities?.Count > 0)
            {
                // If there are records selected — enable 'Delete Selected' action
                tsmiDeleteSelected.Enabled = true;
            }
            else
            {
                // If there are no records selected — disable 'Delete Selected' action
                tsmiDeleteSelected.Enabled = false;
            }
        }

        private void NotifyUser()
        {
            NotifyUser(string.Empty);
        }

        private void NotifyUser(string text)
        {
            Invoke(new Action(() =>
            {
                SendMessageToStatusBar(this, new StatusBarMessageEventArgs(text));
            }));
        }

        private Task Delete(Entity entity)
        {
            return new Task(() =>
            {
                try
                {
                    NotifyUser($"Deleting log record id {entity.Id}...");
                    Service.Delete(entity.LogicalName, entity.Id);
                }
                catch (Exception)
                {
                    // Hiding exception if something will go wrong
                }
                finally
                {
                    NotifyUser();
                }
            });
        }

        private Task Delete(ExecuteMultipleRequest batch)
        {
            return new Task(() =>
            {
                try
                {
                    NotifyUser($"Deleting {batch.Requests.Count} log records...");
                    Service.Execute(batch);
                }
                catch (Exception ex)
                {
                    // Hiding exception if something will go wrong
                    LogError("Fatal error at Delete(batch):\n{0}", ex.Message);
                }
                finally
                {
                    NotifyUser();
                }
            });
        }

        private Task Delete(List<ExecuteMultipleRequest> batches)
        {
            var total = batches.Select(x => x.Requests.Count).Sum();

            NotifyUser($"{total} records going to be deleted in {batches} batches...");

            var tasks = new List<Task>();
            foreach (var batch in batches)
            {
                tasks.Add(Delete(batch));
            }

            return new Task(async () =>
            {
                while (tasks.Count > 0)
                {
                    var number = MAX_BATCH - tasks.Count(x => x.Status == TaskStatus.Running);

                    NotifyUser($"Statrting {number} new batches...");

                    tasks.Where(x => x.Status == TaskStatus.Created).Take(number).ToList().ForEach(x => x.Start());

                    await Task.WhenAny(tasks);

                    foreach (var task in tasks.Where(x => x.Status == TaskStatus.RanToCompletion).ToList())
                    {
                        tasks.Remove(task);
                    }
                }

                NotifyUser($"{total} log records was removed.");
                await Task.Delay(10000);
                NotifyUser();
            });
        }

        private static List<ExecuteMultipleRequest> Bundle(IEnumerable<Entity> entities)
        {
            var result = new List<ExecuteMultipleRequest>();

            for (var i = 0; i < Math.Ceiling((decimal)entities.Count() / PAGE_SIZE); i++)
            {
                var batch = new ExecuteMultipleRequest
                {
                    Requests = new OrganizationRequestCollection(),
                    Settings = new ExecuteMultipleSettings()
                };

                foreach (var entity in entities.Skip(i * PAGE_SIZE).Take(PAGE_SIZE))
                {
                    batch.Requests.Add(new DeleteRequest
                    {
                        Target = entity.ToEntityReference()
                    });
                }

                batch.Settings.ContinueOnError = true;
                batch.Settings.ReturnResponses = false;

                result.Add(batch);
            }

            return result;
        }

        private void SaveSettings()
        {
            var settings = GetSettings();
            SettingsManager.Instance.Save(typeof(PluginTraceViewer), settings, "Settings");
            var filter = GetFilter();
            SettingsManager.Instance.Save(typeof(PluginTraceViewer), filter, ConnectionDetail?.ConnectionName);
        }

        private void buttonOpenFXB_Click(object sender, EventArgs e)
        {
            var fetchxml = GetQueryFetchXML();
            if (string.IsNullOrEmpty(fetchxml))
            {
                return;
            }
            var messageBusEventArgs = new MessageBusEventArgs("FetchXML Builder")
            {
                TargetArgument = fetchxml
            };
            OnOutgoingMessage(this, messageBusEventArgs);
        }

        private string GetQueryFetchXML()
        {
            QueryExpression query = GetQuery();
            if (query == null)
            {
                return string.Empty;
            }
            var resp = Service.Execute(new QueryExpressionToFetchXmlRequest() { Query = query }) as QueryExpressionToFetchXmlResponse;
            return resp.FetchXml;
        }

        private void buttonSaveQuery_Click(object sender, EventArgs e)
        {
            SaveQuery();
        }

        private void SaveQuery()
        {
            var sfd = new SaveFileDialog
            {
                Title = "Select a location to save the trace log query",
                Filter = "XML file (*.xml)|*.xml"
            };
            if (sfd.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(sfd.FileName))
            {
                var fetchxml = GetQueryFetchXML();
                if (string.IsNullOrEmpty(fetchxml))
                {
                    return;
                }
                var fetchdoc = new XmlDocument();
                fetchdoc.LoadXml(fetchxml);
                fetchdoc.Save(sfd.FileName);
                MessageBox.Show(this, "Query saved!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        internal void LogUse(string action, bool forceLog = false)
        {
            if (logUsage == true || forceLog)
            {
                LogUsage.DoLog(action);
            }
        }

        private void comboLogSetting_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!comboLogSetting.Enabled)
            {
                return;
            }
            if (DialogResult.OK == MessageBox.Show($"Update the organization wide setting for plug-in trace log to\n\n  \"{comboLogSetting.Text}\" ?", "Confirm",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation))
            {
                UpdateLogSetting(comboLogSetting.SelectedIndex);
            }
            else
            {
                LoadLogSetting();
            }
        }

        private void tsmiCorrelationSelectThis_Click(object sender, EventArgs e)
        {
            var count = 0;
            var corrId = GetSelectedCorrelationId();
            if (!corrId.Equals(Guid.Empty))
            {
                foreach (DataGridViewRow row in crmGridView.Rows)
                {
                    var idstr = row.Cells["correlationid"]?.Value?.ToString();
                    Guid id;
                    if (Guid.TryParse(idstr, out id) && id.Equals(corrId))
                    {
                        row.Selected = true;
                        count++;
                    }
                    else
                    {
                        row.Selected = false;
                    }
                }
                LogUse("SelectByCorrelationId");
            }
            SendMessageToStatusBar(this, new StatusBarMessageEventArgs($"Selected {count} log records"));
        }

        private void chkCorrelation_CheckedChanged(object sender, EventArgs e)
        {
            textCorrelationId.Enabled = chkCorrelation.Checked;
        }

        private void tsmiCorrelationFilterByThis_Click(object sender, EventArgs e)
        {
            var newCorrId = GetSelectedCorrelationId();
            if (!newCorrId.Equals(Guid.Empty))
            {
                var corrIds = GetCurrentCorrelationIdFilter(true);
                if (!corrIds.Contains(newCorrId))
                {
                    corrIds.Add(newCorrId);
                }
                chkCorrelation.Checked = true;
                textCorrelationId.Text = string.Join(", ", corrIds);
                LogUse("FilterByCorrelationId");
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

        private Guid GetSelectedCorrelationId()
        {
            var result = Guid.Empty;
            var entities = crmGridView.SelectedCellRecords?.Entities;
            var ids = entities?.Select(e => (Guid)e["correlationid"]).Distinct();
            if (ids?.Count() == 1)
            {
                return ids.FirstOrDefault();
            }
            return Guid.Empty;
        }

        private void crmGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var tooltipcolumn = e.ColumnIndex == crmGridView.Columns["correlation"].Index ? "correlationid" : crmGridView.Columns[e.ColumnIndex].Name;
            var cell = crmGridView[e.ColumnIndex, e.RowIndex];
            cell.ToolTipText = crmGridView.Rows[e.RowIndex].Cells[tooltipcolumn].Value.ToString();
        }

        private void tsmiViewStatistics_CheckedChanged(object sender, EventArgs e)
        {
            panelStatistics.Visible = tsmiViewStatistics.Checked;
        }

        private void crmGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right)
            {
                return;
            }
            var header = e.RowIndex == -1;
            foreach (ToolStripMenuItem menu in contextMenuGridView.Items)
            {
                menu.Visible = header == (menu.Tag != null && crmGridView.Columns.Contains(menu.Tag.ToString()));
            }
        }

        private void tsmiShowColumn_CheckedChanged(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem menu in contextMenuGridView.Items)
            {
                if (!menu.CheckOnClick || menu.Tag == null || !crmGridView.Columns.Contains(menu.Tag.ToString()))
                {
                    continue;
                }
                crmGridView.Columns[menu.Tag.ToString()].Visible = menu.Checked;
            }
        }
    }
}
