using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

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

        internal void AddPluginFilter(List<string> newplugins)
        {
            var plugins = comboPlugin.Text.Trim().Split(',').Where(s => !string.IsNullOrWhiteSpace(s)).Select(s => s.Trim()).ToList();
            plugins = plugins.Concat(newplugins.Where(s => !plugins.Contains(s))).ToList();
            comboPlugin.Text = string.Join(", ", plugins);
            chkPlugin.Checked = true;
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
    }
}
