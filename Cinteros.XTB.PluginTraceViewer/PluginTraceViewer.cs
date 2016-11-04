using Cinteros.Xrm.CRMWinForm;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using XrmToolBox.Extensibility;
using XrmToolBox.Extensibility.Interfaces;
using XrmToolBox.Extensibility.Args;
using System.Threading.Tasks;
using Microsoft.Xrm.Sdk.Messages;

namespace Cinteros.XTB.PluginTraceViewer
{
    public partial class PluginTraceViewer : PluginControlBase, IGitHubPlugin, IMessageBusHost, IHelpPlugin, IPayPalPlugin, IStatusBarMessenger
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
        public event EventHandler<StatusBarMessageEventArgs> SendMessageToStatusBar;

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
            var orgver = new Version(e.ConnectionDetail.OrganizationVersion);
            var orgok = orgver >= new Version(7, 1);
            crmGridView.OrganizationService = orgok ? e.Service : null;
            buttonRetrieveLogs.Enabled = orgok;
            buttonRefreshFilter.Enabled = orgok;
            if (orgok)
            {
                LoadConstraints();
            }
            else
            {
                MessageBox.Show("Plug-in Trace Log was introduced in\nMicrosoft Dynamics CRM 2015 Update 1 (7.1.0.0)\n\nPlease connect to a newer organization to use this cool tool.", "Organization too old", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
                            GetEntities((entitylist) =>
                            {
                                comboEntity.Items.Clear();
                                comboEntity.Items.AddRange(entitylist.ToArray());
                            });
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

        private void GetEntities(Action<List<string>> callback)
        {
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
                        MessageBox.Show($"Failed to load entities:\n{args.Error.Message}", "Load", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (args.Result is EntityCollection)
                    {
                        var entities = ((EntityCollection)args.Result).Entities;
                        var entitylist = entities.Where(e => e.Attributes.Contains("primaryentity")).Select(e => e.Attributes["primaryentity"].ToString()).ToList();
                        callback(entitylist);
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
                if (chkRecords.Checked)
                {
                    QEplugintracelog.TopCount = (int)numRecords.Value;
                }
                if (checkDateFrom.Checked)
                {
                    QEplugintracelog.Criteria.AddCondition("createdon", ConditionOperator.OnOrAfter, dateFrom.Value.Date);
                }
                if (checkDateTo.Checked)
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
                if (chkEntity.Checked && !string.IsNullOrWhiteSpace(comboEntity.Text))
                {
                    QEplugintracelog.Criteria.AddCondition("primaryentity", comboEntity.Text.Contains("*") ? ConditionOperator.Like : ConditionOperator.Equal, comboEntity.Text.Replace("*", "%"));
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
                if (chkDurationMin.Checked)
                {
                    QEplugintracelog.Criteria.AddCondition("performanceexecutionduration", ConditionOperator.GreaterEqual, (int)numDurationMin.Value);
                }
                if (chkDurationMax.Checked)
                {
                    QEplugintracelog.Criteria.AddCondition("performanceexecutionduration", ConditionOperator.LessEqual, (int)numDurationMax.Value);
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

        private void checkWordWrap_CheckedChanged(object sender, EventArgs e)
        {
            textMessage.WordWrap = chkWordWrap.Checked;
            textException.WordWrap = chkWordWrap.Checked;
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

        private void buttonShowHideFilter_Click(object sender, EventArgs e)
        {
            buttonShowHideFilter.Text = buttonShowHideFilter.Checked ? "Hide Filter" : "Show Filter";
            groupFilter.Visible = buttonShowHideFilter.Checked;
        }

        private void buttonRefreshFilter_Click(object sender, EventArgs e)
        {
            LoadConstraints();
        }

        private void btnSaveLogs_Click(object sender, EventArgs e)
        {
            SaveLogs();
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

        private void deleteSelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var menu = (ContextMenuStrip)((ToolStripDropDownItem)sender).GetCurrentParent();
            var grid = (CRMGridView)menu?.SourceControl;
            var entities = grid?.SelectedCellRecords?.Entities;

            if (entities?.Count == 1)
            {
                // Execute one 'Delete' request
                var entity = entities.FirstOrDefault();

                var task = new Task(() =>
                {
                    try
                    {
                        NotifyUser($"Deleting log record id {entity.Id}");
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

                task.Start();
            }
            else
            {
                // Use 'Execute Multiple' request
                if (entities?.Count < 1000)
                {
                    // Only one batch will be needed
                    var request = new ExecuteMultipleRequest
                    {
                        Requests = new OrganizationRequestCollection(),
                        Settings = new ExecuteMultipleSettings()
                    };

                    foreach(var entity in entities)
                    {
                        request.Requests.Add(new DeleteRequest
                        {
                            Target = entity.ToEntityReference()
                        });
                    }

                    request.Settings.ContinueOnError = true;
                    request.Settings.ReturnResponses = false;

                    NotifyUser($"Deleting {request.Requests.Count} log records");

                    Service.Execute(request);

                    NotifyUser();
                }
                else
                {
                    // Several batches need to be run
                }
            }
        }

        private void contextStripMain_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var menu = (ContextMenuStrip)sender;
            var grid = (CRMGridView)menu?.SourceControl;
            var entities = grid?.SelectedCellRecords?.Entities;

            if (entities?.Count > 0)
            {
                // If there are records selected — enable 'Delete Selected' action
                deleteSelectedToolStripMenuItem.Enabled = true;
            }
            else
            {
                // If there are no records selected — disable 'Delete Selected' action
                deleteSelectedToolStripMenuItem.Enabled = false;
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
    }
}
