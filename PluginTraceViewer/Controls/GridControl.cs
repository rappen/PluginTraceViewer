using Cinteros.XTB.PluginTraceViewer.Const;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using XrmToolBox.Extensibility;

namespace Cinteros.XTB.PluginTraceViewer.Controls
{
    public partial class GridControl : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        private PluginTraceViewer ptv;
        private bool refreshingGrid = false;
        private bool manualColumnChange = false;
        private bool updatingMenus = false;
        internal Color highlightColor;
        private const int MAX_BATCH = 2;
        private const int PAGE_SIZE = 1000;
        private List<string> columns;

        public GridControl(PluginTraceViewer ptv)
        {
            this.ptv = ptv;
            InitializeComponent();
        }

        internal void SetOrgService(IOrganizationService service)
        {
            if (crmGridView.DataSource != null)
            {
                crmGridView.DataSource = null;
            }
            if (service != null)
            {
                crmGridView.OrganizationService = service;
            }
        }

        public override void Refresh()
        {
            refreshingGrid = true;
            crmGridView.Refresh();
            ptv.SendStatusMessage("");
            refreshingGrid = false;
            HighlightAndAggregate(GetSelectedCellsArray());
        }

        public EntityCollection Entities
        {
            get
            {
                return (EntityCollection)crmGridView.GetDataSource<EntityCollection>();
            }
        }

        public List<string> Columns
        {
            get
            {
                GetColumnsFromGrid();
                return columns;
            }
            set
            {
                if (value != null && value.Count > 0)
                {
                    columns = value;
                }
                else
                {
                    columns = Columns;
                }
            }
        }

        private void GetColumnsFromGrid()
        {
            var colArray = new DataGridViewColumn[crmGridView.ColumnCount];
            crmGridView.Columns.CopyTo(colArray, 0);
            columns = colArray.OrderBy(c => c.DisplayIndex).Select(c => $"{c.Name}:{(c.Visible ? c.Width : -1)}").ToList();
        }

        internal void UpdateColumnsLayout()
        {
            //RefreshingGrid = true;
            var anycolwidthspecified = false;
            var index = 0;
            foreach (var colinfo in columns.Select(c => c.Split(':')))
            {
                var colname = colinfo[0];
                var colwidth = colinfo.Length > 1 ? int.Parse(colinfo[1]) : 0;
                if (crmGridView.Columns.Contains(colname))
                {
                    var column = crmGridView.Columns[colname];
                    if (column.DisplayIndex != index)
                    {
                        column.DisplayIndex = index;
                    }
                    column.Visible = colwidth > -1;
                    if (colwidth > 0)
                    {
                        column.Width = colwidth;
                        anycolwidthspecified = true;
                    }
                    index++;
                }
            }
            if (!anycolwidthspecified)
            {
                crmGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            //RefreshingGrid = false;
        }

        internal void UpdateMenuChecks()
        {
            if (columns == null)
            {
                return;
            }
            updatingMenus = true;
            var visibleColumns = columns
                .Where(c => !c.Contains(':') || c.Split(':')[1] != "-1")
                .Select(c => c.Split(':')[0])
                .ToList();
            foreach (ToolStripMenuItem menu in contextMenuGridView.Items)
            {
                if (menu.Tag != null && crmGridView.Columns.Contains(menu.Tag.ToString()))
                {   // Menu item with corresponding column
                    menu.Checked = visibleColumns.Contains(menu.Tag.ToString());
                }
            }
            updatingMenus = false;
        }

        private void crmGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var tooltipcolumn = e.ColumnIndex == crmGridView.Columns["correlation"].Index ? "correlationid" : crmGridView.Columns[e.ColumnIndex].Name;
            var cell = crmGridView[e.ColumnIndex, e.RowIndex];
            cell.ToolTipText = crmGridView.Rows[e.RowIndex].Cells[tooltipcolumn].Value.ToString();
        }

        private void crmGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            var header = e.RowIndex == -1;
            if (header && e.Button == MouseButtons.Left)
            {
                manualColumnChange = true;
            }
            else if (e.Button == MouseButtons.Right)
            {
                foreach (ToolStripMenuItem menu in contextMenuGridView.Items)
                {
                    menu.Visible = header == (menu.Tag != null && crmGridView.Columns.Contains(menu.Tag.ToString()));
                }
            }
        }

        private void crmGridView_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            manualColumnChange = false;
        }

        private void crmGridView_ColumnChanged(object sender, DataGridViewColumnEventArgs e)
        {
            if (manualColumnChange)
            {
                GetColumnsFromGrid();
            }
        }

        private void crmGridView_RecordDoubleClick(object sender, xrmtb.XrmToolBox.Controls.CRMRecordEventArgs e)
        {
            ptv.OpenLogRecord(crmGridView.SelectedCellRecords.Entities.FirstOrDefault());
        }

        private void crmGridView_RecordEnter(object sender, xrmtb.XrmToolBox.Controls.CRMRecordEventArgs e)
        {
            ptv.GridRecordEnter(e.Entity);
        }

        private void crmGridView_SelectionChanged(object sender, EventArgs e)
        {
            HighlightAndAggregate(GetSelectedCellsArray());
        }

        private DataGridViewCell[] GetSelectedCellsArray()
        {
            var selectedCells = new DataGridViewCell[crmGridView.SelectedCells.Count];
            crmGridView.SelectedCells.CopyTo(selectedCells, 0);
            return selectedCells;
        }

        private void contextMenuGridView_Opening(object sender, CancelEventArgs e)
        {
            var entities = crmGridView.SelectedCellRecords?.Entities;

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

        private void tsmiFilterByEntity_Click(object sender, EventArgs e)
        {
            var selected = crmGridView.SelectedCellRecords?.Entities;
            var selentities = selected?.Select(s => (string)s[PluginTraceLog.PrimaryEntity]).Distinct().ToList();
            ptv.filterControl.AddEntityFilter(selentities);
        }

        private void tsmiFilterByMessage_Click(object sender, EventArgs e)
        {
            var selected = crmGridView.SelectedCellRecords?.Entities;
            var selmessages = selected?.Select(s => (string)s[PluginTraceLog.MessageName]).Distinct().ToList();
            if (selmessages.Count == 1)
            {
                ptv.filterControl.SetMessageFilter(selmessages[0]);
            }
            else
            {
                MessageBox.Show("Can only filter by one message.");
            }
        }

        private void tsmiFilterByPlugin_Click(object sender, EventArgs e)
        {
            var selected = crmGridView.SelectedCellRecords?.Entities;
            var selplugins = selected?.Select(s => (string)s[PluginTraceLog.PrimaryName]).Distinct().ToList();
            ptv.filterControl.AddPluginFilter(selplugins, false);
        }

        private void tsmiFilterByCorrelation_Click(object sender, EventArgs e)
        {
            ptv.filterControl.AddCorrelationFilter(GetSelectedCorrelationId());
        }

        private void tsmiCorrelationSelectThis_Click(object sender, EventArgs e)
        {
            SelectCurrentCorrelation();
        }

        internal void SelectCurrentCorrelation()
        {
            var count = 0;
            var corrId = GetSelectedCorrelationId();
            if (!corrId.Equals(Guid.Empty))
            {
                foreach (DataGridViewRow row in crmGridView.Rows)
                {
                    var idstr = row.Cells[PluginTraceLog.CorrelationId]?.Value?.ToString();
                    if (Guid.TryParse(idstr, out Guid id) && id.Equals(corrId))
                    {
                        row.Selected = true;
                        count++;
                    }
                    else
                    {
                        row.Selected = false;
                    }
                }
                ptv.LogUse("SelectByCorrelationId");
            }
        }

        private void tsmiDeleteSelected_Click(object sender, EventArgs e)
        {
            var entities = crmGridView.SelectedCellRecords?.Entities;

            if (entities != null && entities.Count > 0)
            {
                Delete(Bundle(entities)).Start();

                // Deleting log records from the list
                var source = crmGridView.GetDataSource<EntityCollection>();

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
            if (DialogResult.Yes != MessageBox.Show("This action will permanently delete all log records in the database.\n\nContinue?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                return;
            }
            var query = new QueryExpression(PluginTraceLog.EntityName);
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
                result = ptv.Service.RetrieveMultiple(query);
                batches.AddRange(Bundle(result.Entities));
            } while (result.MoreRecords == true);

            // Deleting log records
            Delete(batches).Start();

            var source = crmGridView.GetDataSource<EntityCollection>();

            // TODO: Prompt user - reload logs? Otherwise just clear the list
            if (source != null)
            {
                source.Entities.Clear();

                // Refresh unfortunately crashes with InvalidAsynchronousStateException "Target thread does not exist anymore
                // grid.Refresh();
                PopulateGrid(source);
            }
        }

        private void tsmiShowColumn_CheckedChanged(object sender, EventArgs e)
        {
            if (updatingMenus)
            {
                return;
            }
            foreach (ToolStripMenuItem menu in contextMenuGridView.Items)
            {
                if (!menu.CheckOnClick || menu.Tag == null || !crmGridView.Columns.Contains(menu.Tag.ToString()))
                {
                    continue;
                }
                crmGridView.Columns[menu.Tag.ToString()].Visible = menu.Checked;
            }
            GetColumnsFromGrid();
        }

        internal void PopulateGrid(EntityCollection results)
        {
            ptv.LogInfo("PopulateGrid with {0} logs", results.Entities.Count);
            var asyncinfo = new WorkAsyncInfo()
            {
                Message = "Populating result view",
                Work = (a, args) =>
                {
                    ptv.UpdateUI(() =>
                    {
                        refreshingGrid = true;
                        crmGridView.DataSource = results;
                        refreshingGrid = false;
                        ptv.SendStatusMessage($"Loaded {results.Entities.Count} trace records");
                        UpdateColumnsLayout();
                    });
                },
                PostWorkCallBack = (args) =>
                {
                    if (args.Error != null)
                    {
                        ptv.AlertError($"Failed to populate result view:\n{args.Error.Message}", "Load");
                    }
                }
            };
            ptv.WorkAsync(asyncinfo);
        }

        internal void HighlightAndAggregate(DataGridViewCell[] selectedCells)
        {
            if (!crmGridView.Focused || refreshingGrid || selectedCells == null || selectedCells.Length == 0)
            {
                return;
            }
            ResetAllCellStyles();
            if (!ptv.tsmiHighlight.Checked ||
                selectedCells.Select(c => c.RowIndex).Distinct().Count() != 1 ||
                selectedCells.Where(c => !string.IsNullOrWhiteSpace(c.Value.ToString())).Count() == 0)
            {
                toolStripMatch.Visible = false;
                UpdateStatusBar(selectedCells.Select(c => c.OwningRow).Distinct());
            }
            else
            {
                selectedCells = selectedCells.Where(c => !string.IsNullOrWhiteSpace(c.Value.ToString())).OrderBy(c => c.ColumnIndex).ToArray();
                if (selectedCells.Length > 0)
                {
                    foreach (var cell in selectedCells)
                    {
                        cell.Style = cell.OwningColumn.DefaultCellStyle.Clone();
                        cell.Style.BackColor = highlightColor;
                    }
                    var highlightedRows = new List<DataGridViewRow>();
                    var selectedRow = selectedCells[0].OwningRow;
                    foreach (DataGridViewRow row in crmGridView.Rows)
                    {
                        var isIdentical = true;
                        foreach (var cell in selectedCells)
                        {
                            var selectedvalue = cell.Value.ToString();
                            var rowvalue = row.Cells[cell.ColumnIndex].Value.ToString();
                            if (!selectedvalue.Equals(rowvalue))
                            {
                                isIdentical = false;
                                break;
                            }
                        }
                        if (isIdentical)
                        {
                            foreach (var cell in selectedCells)
                            {
                                row.Cells[cell.ColumnIndex].Style = cell.Style;
                            }
                            highlightedRows.Add(row);
                        }
                    }
                    toolStripMatch.Visible = true;
                    toolStripMatch.Text = $"Match: {string.Join(" and ", selectedCells.Select(c => GetMatchString(c)))}";
                    UpdateStatusBar(highlightedRows);
                }
            }
        }

        private static string GetMatchString(DataGridViewCell c)
        {
            var header = c.OwningColumn.HeaderCell.Value.ToString();
            var value = c.Value.ToString();
            value = value.Replace("\r\n", " ");
            if (value.Length > 100)
            {
                value = value.Substring(0, 100) + "...";
            }
            return $"({header}={value})";
        }

        private void ResetAllCellStyles()
        {
            foreach (DataGridViewRow row in crmGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Style = cell.OwningColumn.DefaultCellStyle;
                }
            }
        }

        private void UpdateStatusBar(IEnumerable<DataGridViewRow> rows)
        {
            rows = rows.Distinct();
            toolStripRecords.Text = $"Records: {rows.Count()}";
            toolStripDuration.Text = $"Duration: {rows.Select(r => (r.Cells[PluginTraceLog.PerformanceExecutionDuration].Value as int?)).Sum()} ms";
            toolStripPlugins.Text = $"Plugins: {rows.Select(r => r.Cells[PluginTraceLog.PrimaryName].Value).Distinct().Count()}";
            toolStripEntities.Text = $"Entities: {rows.Select(r => r.Cells[PluginTraceLog.PrimaryEntity].Value).Distinct().Count()}";
            toolStripCorrelations.Text = $"Correlations: {rows.Select(r => r.Cells[PluginTraceLog.CorrelationId].Value).Distinct().Count()}";
        }

        private Guid GetSelectedCorrelationId()
        {
            var result = Guid.Empty;
            var entities = crmGridView.SelectedCellRecords?.Entities;
            var ids = entities?.Select(e => (Guid)e[PluginTraceLog.CorrelationId]).Distinct();
            if (ids?.Count() == 1)
            {
                return ids.FirstOrDefault();
            }
            return Guid.Empty;
        }

        private Task Delete(Entity entity)
        {
            return new Task(() =>
            {
                try
                {
                    ptv.SendStatusMessage($"Deleting log record id {entity.Id}...");
                    ptv.Service.Delete(entity.LogicalName, entity.Id);
                }
                catch (Exception)
                {
                    // Hiding exception if something will go wrong
                }
                finally
                {
                    ptv.SendStatusMessage("");
                }
            });
        }

        private Task Delete(ExecuteMultipleRequest batch)
        {
            return new Task(() =>
            {
                try
                {
                    ptv.SendStatusMessage($"Deleting {batch.Requests.Count} log records...");
                    ptv.Service.Execute(batch);
                }
                catch (Exception ex)
                {
                    // Hiding exception if something will go wrong
                    ptv.LogError("Fatal error at Delete(batch):\n{0}", ex.Message);
                }
                finally
                {
                    ptv.SendStatusMessage("");
                }
            });
        }

        private Task Delete(List<ExecuteMultipleRequest> batches)
        {
            var total = batches.Select(x => x.Requests.Count).Sum();

            ptv.SendStatusMessage($"{total} records going to be deleted in {batches} batches...");

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

                    ptv.SendStatusMessage($"Statrting {number} new batches...");

                    tasks.Where(x => x.Status == TaskStatus.Created).Take(number).ToList().ForEach(x => x.Start());

                    await Task.WhenAny(tasks);

                    foreach (var task in tasks.Where(x => x.Status == TaskStatus.RanToCompletion).ToList())
                    {
                        tasks.Remove(task);
                    }
                }

                ptv.SendStatusMessage($"{total} log records was removed.");
                await Task.Delay(10000);
                ptv.SendStatusMessage("");
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

        private void txtQuickFilter_TextChanged(object sender, EventArgs e)
        {
            crmGridView.FilterText = txtQuickFilter.Text;
        }
    }
}
