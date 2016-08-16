using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XrmToolBox.Extensibility;
using XrmToolBox.Extensibility.Interfaces;

namespace Cinteros.XTB.PluginTraceViewer
{
    public partial class PluginTraceViewer : PluginControlBase, IGitHubPlugin, IMessageBusHost, IHelpPlugin, IPayPalPlugin
    {
        private int lastRecordCount = 100;

        public PluginTraceViewer()
        {
            InitializeComponent();
        }

        public string HelpUrl { get { return "https://github.com/Innofactor/XrmToolBox.PluginTraceViewer"; } }

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

        public void OnIncomingMessage(MessageBusEventArgs message)
        {
            MessageBox.Show("Incoming from " + message.SourcePlugin);
        }

        private void tsbAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Plugin Trace Viewer for XrmToolBox\n" +
                "Version: " + Assembly.GetExecutingAssembly().GetName().Version + "\n\n" +
                "Developed by Jonas Rapp at Innofactor AB.",
                "About Plugin Trace Viewer", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void PluginTraceViewer_ConnectionUpdated(object sender, ConnectionUpdatedEventArgs e)
        {
            if (crmGridView.DataSource != null)
            {
                crmGridView.DataSource = null;
            }
            crmGridView.OrganizationService = e.Service;
            LoadConstraints();
        }

        private void LoadConstraints()
        {
            GetDateConstraint("min", (datemin) =>
            {
                dateFrom.MinDate = datemin;
                dateTo.MinDate = datemin;
                GetDateConstraint("max", (datemax) =>
                {
                    dateFrom.MaxDate = datemax;
                    dateTo.MaxDate = datemax;
                    GetPlugins((pluginlist) =>
                    {
                        comboPlugin.Items.Clear();
                        comboPlugin.Items.AddRange(pluginlist.ToArray());
                        GetMessages((messagelist) =>
                        {
                            comboMessage.Items.Clear();
                            comboMessage.Items.AddRange(messagelist.ToArray());
                        });
                    });
                });
            });
        }

        private void GetPlugins(Action<List<string>> callback)
        {
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
                        MessageBox.Show($"Failed to load plugin types:\n{args.Error.Message}", "Load", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (args.Result is EntityCollection)
                    {
                        var entities = ((EntityCollection)args.Result).Entities;
                        var plugins = entities.Where(e => e.Attributes.Contains("typename")).Select(e => e.Attributes["typename"].ToString()).ToList();
                        callback(plugins);
                    }
                }
            };
            WorkAsync(asyncinfo);
        }

        private void GetMessages(Action<List<string>> callback)
        {
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
                        MessageBox.Show($"Failed to load messages:\n{args.Error.Message}", "Load", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (args.Result is EntityCollection)
                    {
                        var entities = ((EntityCollection)args.Result).Entities;
                        var messages = entities.Where(e => e.Attributes.Contains("messagename")).Select(e => e.Attributes["messagename"].ToString()).ToList();
                        callback(messages);
                    }
                }
            };
            WorkAsync(asyncinfo);
        }

        private void GetDateConstraint(string aggregate, Action<DateTime> callback)
        {
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
                        MessageBox.Show($"Failed to load date constraints:\n{args.Error.Message}", "Load", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                                callback(date);
                            }
                        }
                    }
                }
            };
            WorkAsync(asyncinfo);
        }

        private void RefreshTraces()
        {
            if (Service != null)
            {
                var QEplugintracelog = new QueryExpression("plugintracelog");
                QEplugintracelog.ColumnSet.AddColumns(
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
                QEplugintracelog.TopCount = (int)numRecords.Value;
                if (dateFrom.Checked)
                {
                    QEplugintracelog.Criteria.AddCondition("createdon", ConditionOperator.OnOrAfter, dateFrom.Value.Date);
                }
                if (dateTo.Checked)
                {
                    QEplugintracelog.Criteria.AddCondition("createdon", ConditionOperator.OnOrBefore, dateTo.Value.Date);
                }
                if (chkPlugin.Checked && !string.IsNullOrWhiteSpace(comboPlugin.Text))
                {
                    QEplugintracelog.Criteria.AddCondition("typename", comboPlugin.Text.Contains("*") ? ConditionOperator.Like : ConditionOperator.Equal, comboPlugin.Text.Replace("*", "%"));
                }
                if (chkMessage.Checked && !string.IsNullOrWhiteSpace(comboMessage.Text))
                {
                    QEplugintracelog.Criteria.AddCondition("messagename", ConditionOperator.Equal, comboMessage.Text);
                }
                if (chkExceptions.Checked)
                {
                    QEplugintracelog.Criteria.AddCondition("exceptiondetails", ConditionOperator.NotNull);
                    QEplugintracelog.Criteria.AddCondition("exceptiondetails", ConditionOperator.NotEqual, "");
                }
                if (rbModeSync.Checked)
                {
                    QEplugintracelog.Criteria.AddCondition("mode", ConditionOperator.Equal, 0);
                }
                else if (rbModeAsync.Checked)
                {
                    QEplugintracelog.Criteria.AddCondition("mode", ConditionOperator.Equal, 1);
                }
                QEplugintracelog.AddOrder("performanceexecutionstarttime", OrderType.Descending);
                var asyncinfo = new WorkAsyncInfo()
                {
                    Message = "Loading trace log records",
                    Work = (a, args) =>
                    {
                        args.Result = Service.RetrieveMultiple(QEplugintracelog);
                    },
                    PostWorkCallBack = (args) =>
                    {
                        if (args.Error != null)
                        {
                            MessageBox.Show($"Failed to load trace logs:\n{args.Error.Message}", "Load", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (args.Result is EntityCollection)
                        {
                            PopulateGrid(args.Result as EntityCollection);
                        }
                    }
                };
                WorkAsync(asyncinfo);
            }
        }

        private void PopulateGrid(EntityCollection results)
        {
            var asyncinfo = new WorkAsyncInfo()
            {
                Message = "Populating result view",
                Work = (a, args) =>
                {
                    MethodInvoker mi = delegate
                    {
                        crmGridView.DataSource = results;
                        var dt = crmGridView.GetDataSource<DataTable>();
                        if (dt != null)
                        {
                            dt.Columns.Add("Exception", typeof(bool), "exceptiondetails <> ''");
                        }
                        labelInfo.Text = $"Loaded {results.Entities.Count} trace records";
                        crmGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                    };
                    if (InvokeRequired)
                    {
                        Invoke(mi);
                    }
                    else
                    {
                        mi();
                    }
                },
                PostWorkCallBack = (args) =>
                {
                    if (args.Error != null)
                    {
                        MessageBox.Show($"Failed to populate result view:\n{args.Error.Message}", "Load", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            };
            WorkAsync(asyncinfo);
        }

        private void buttonRetrieveLogs_Click(object sender, EventArgs e)
        {
            RefreshTraces();
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
            textMessage.Text = FixLineBreaks(e.Entity != null && e.Entity.Contains("messageblock") ? e.Entity["messageblock"].ToString() : "");
            textException.Text = FixLineBreaks(e.Entity != null && e.Entity.Contains("exceptiondetails") ? e.Entity["exceptiondetails"].ToString() : "");
        }

        private string FixLineBreaks(string text)
        {
            text = text.Replace("\r\n", "\n");
            text = text.Replace("\n", Environment.NewLine);
            return text;
        }

        private void PluginTraceViewer_Load(object sender, EventArgs e)
        {
            groupDetails.Width = Width / 2;
            textMessage.Height = (groupDetails.Height - panelDetailsTop.Height - labelMessage.Height - labelException.Height) / 2;
        }

        private void buttonOpenRecord_Click(object sender, EventArgs e)
        {
            var firstselected = crmGridView.SelectedCellRecords.Entities.FirstOrDefault();
            if (firstselected != null)
            {
                var url = GetEntityReferenceUrl(firstselected.ToEntityReference());
                if (!string.IsNullOrEmpty(url))
                {
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
            if (compareValue < 10) numRecords.Increment = 1;
            else if (compareValue < 20) numRecords.Increment = 5;
            else if (compareValue < 50) numRecords.Increment = 10;
            else if (compareValue < 200) numRecords.Increment = 25;
            else if (compareValue < 1000) numRecords.Increment = 100;
            else numRecords.Increment = 1000;
            lastRecordCount = (int)numRecords.Value;
        }

        private void checkWordWrap_CheckedChanged(object sender, EventArgs e)
        {
            textMessage.WordWrap = checkWordWrap.Checked;
            textException.WordWrap = checkWordWrap.Checked;
        }
    }
}
