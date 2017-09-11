using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Xrm.Sdk;
using McTools.Xrm.Connection;
using System.Diagnostics;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Query;
using XrmToolBox.Extensibility;

namespace Cinteros.XTB.PluginTraceViewer.Controls
{
    public partial class GridControl : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        private PluginTraceViewer ptv;
        private bool refreshingGrid = false;
        private Color highlightColor;
        private const int MAX_BATCH = 2;
        private const int PAGE_SIZE = 1000;

        public GridControl(PluginTraceViewer ptv)
        {
            this.ptv = ptv;
            InitializeComponent();
        }

        private void crmGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var tooltipcolumn = e.ColumnIndex == crmGridView.Columns["correlation"].Index ? "correlationid" : crmGridView.Columns[e.ColumnIndex].Name;
            var cell = crmGridView[e.ColumnIndex, e.RowIndex];
            cell.ToolTipText = crmGridView.Rows[e.RowIndex].Cells[tooltipcolumn].Value.ToString();
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

        private void crmGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C && tsmiCorrelationSelectThis.Enabled)
            {
                tsmiCorrelationSelectThis_Click(null, null);
            }
        }

        private void crmGridView_RecordDoubleClick(object sender, Xrm.CRMWinForm.CRMRecordEventArgs e)
        {
            ptv.OpenLogRecord(crmGridView.SelectedCellRecords.Entities.FirstOrDefault());
        }

        private void crmGridView_RecordEnter(object sender, Xrm.CRMWinForm.CRMRecordEventArgs e)
        {
            ptv.GridRecordEnter(e.Entity);
        }

        private void crmGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (!ptv.tsmiHighlight.Checked || !crmGridView.Focused || refreshingGrid)
            {
                return;
            }
            foreach (DataGridViewRow row in crmGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Style = cell.OwningColumn.DefaultCellStyle;
                }
            }
            var selectedCells = new DataGridViewCell[crmGridView.SelectedCells.Count];
            crmGridView.SelectedCells.CopyTo(selectedCells, 0);
            if (selectedCells.Select(c => c.RowIndex).Distinct().Count() != 1)
            {
                ptv.SendStatusMessage("Cannot highlight when multiple rows are selected.");
                return;
            }
            selectedCells = selectedCells.OrderBy(c => c.ColumnIndex).ToArray();
            var selectedRow = selectedCells[0].OwningRow;
            var identical = 1;
            var duration = (int)selectedRow.Cells["performanceexecutionduration"].Value;
            foreach (DataGridViewRow row in crmGridView.Rows)
            {
                if (row.Index == selectedRow.Index)
                {
                    continue;
                }
                var isIdentical = true;
                foreach (var cell in selectedCells)
                {
                    cell.Style = cell.OwningColumn.DefaultCellStyle.Clone();
                    cell.Style.BackColor = highlightColor;
                    var value = cell.Value.ToString();
                    if (string.IsNullOrWhiteSpace(value) || !value.Equals(row.Cells[cell.ColumnIndex].Value.ToString()))
                    {
                        isIdentical = false;
                    }
                }
                if (isIdentical)
                {
                    foreach (var cell in selectedCells)
                    {
                        row.Cells[cell.ColumnIndex].Style = cell.Style;
                    }
                    identical++;
                    duration += (int)row.Cells["performanceexecutionduration"].Value;
                }
            }
            ptv.SendStatusMessage($"Highlighted {identical} rows with total duration {duration} ms, matching: {string.Join(" and ", selectedCells.Select(c => "(" + c.OwningColumn.HeaderCell.Value.ToString() + "=" + c.Value.ToString() + ")"))}");
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
            var selentities = selected?.Select(s => (string)s["primaryentity"]).Distinct().ToList();
            ptv.filter.AddEntityFilter(selentities);
        }

        private void tsmiFilterByMessage_Click(object sender, EventArgs e)
        {
            var selected = crmGridView.SelectedCellRecords?.Entities;
            var selmessages = selected?.Select(s => (string)s["messagename"]).Distinct().ToList();
            if (selmessages.Count == 1)
            {
                ptv.filter.SetMessageFilter(selmessages[0]);
            }
            else
            {
                MessageBox.Show("Can only filter by one message.");
            }
        }

        private void tsmiFilterByPlugin_Click(object sender, EventArgs e)
        {
            var selected = crmGridView.SelectedCellRecords?.Entities;
            var selplugins = selected?.Select(s => (string)s["typename"]).Distinct().ToList();
            ptv.filter.AddPluginFilter(selplugins);
        }

        private void tsmiFilterByCorrelation_Click(object sender, EventArgs e)
        {
            ptv.filter.AddCorrelationFilter(GetSelectedCorrelationId());
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
                ptv.LogUse("SelectByCorrelationId");
            }
            ptv.SendStatusMessage($"Selected {count} log records");
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
            foreach (ToolStripMenuItem menu in contextMenuGridView.Items)
            {
                if (!menu.CheckOnClick || menu.Tag == null || !crmGridView.Columns.Contains(menu.Tag.ToString()))
                {
                    continue;
                }
                crmGridView.Columns[menu.Tag.ToString()].Visible = menu.Checked;
            }
        }

        private void PopulateGrid(EntityCollection results)
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
                        crmGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
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
    }
}
