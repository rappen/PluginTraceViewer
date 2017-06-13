namespace Cinteros.XTB.PluginTraceViewer
{
    partial class PluginStatistics
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridPluginStats = new Cinteros.Xrm.CRMWinForm.CRMGridView();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.plugin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifiedon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.executecount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.averageexecutetimeinmilliseconds = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secondsperday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.failurecount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.failurepercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crashcount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crashpercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crashcontributionpercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.terminatecpucontributionpercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.terminatememorycontributionpercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.terminatehandlescontributionpercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.terminateothercontributionpercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridPluginStats)).BeginInit();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridPluginStats
            // 
            this.gridPluginStats.AllowUserToAddRows = false;
            this.gridPluginStats.AllowUserToDeleteRows = false;
            this.gridPluginStats.AllowUserToOrderColumns = true;
            this.gridPluginStats.AllowUserToResizeRows = false;
            this.gridPluginStats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPluginStats.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.plugin,
            this.createdon,
            this.modifiedon,
            this.executecount,
            this.averageexecutetimeinmilliseconds,
            this.secondsperday,
            this.failurecount,
            this.failurepercent,
            this.crashcount,
            this.crashpercent,
            this.crashcontributionpercent,
            this.terminatecpucontributionpercent,
            this.terminatememorycontributionpercent,
            this.terminatehandlescontributionpercent,
            this.terminateothercontributionpercent});
            this.gridPluginStats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPluginStats.EnableHeadersVisualStyles = false;
            this.gridPluginStats.Location = new System.Drawing.Point(0, 0);
            this.gridPluginStats.Name = "gridPluginStats";
            this.gridPluginStats.ReadOnly = true;
            this.gridPluginStats.RowHeadersWidth = 20;
            this.gridPluginStats.Size = new System.Drawing.Size(1136, 369);
            this.gridPluginStats.TabIndex = 0;
            // 
            // panelTop
            // 
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1136, 0);
            this.panelTop.TabIndex = 1;
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.btnFilter);
            this.panelBottom.Controls.Add(this.btnCancel);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 369);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1136, 38);
            this.panelBottom.TabIndex = 2;
            // 
            // plugin
            // 
            this.plugin.DataPropertyName = "plugin.name";
            this.plugin.HeaderText = "Plugin";
            this.plugin.Name = "plugin";
            this.plugin.ReadOnly = true;
            this.plugin.Width = 61;
            // 
            // createdon
            // 
            this.createdon.HeaderText = "First run";
            this.createdon.Name = "createdon";
            this.createdon.ReadOnly = true;
            this.createdon.Width = 69;
            // 
            // modifiedon
            // 
            this.modifiedon.HeaderText = "Last run";
            this.modifiedon.Name = "modifiedon";
            this.modifiedon.ReadOnly = true;
            this.modifiedon.Width = 70;
            // 
            // executecount
            // 
            this.executecount.HeaderText = "Executions";
            this.executecount.Name = "executecount";
            this.executecount.ReadOnly = true;
            this.executecount.Width = 84;
            // 
            // averageexecutetimeinmilliseconds
            // 
            this.averageexecutetimeinmilliseconds.HeaderText = "Avg Time";
            this.averageexecutetimeinmilliseconds.Name = "averageexecutetimeinmilliseconds";
            this.averageexecutetimeinmilliseconds.ReadOnly = true;
            this.averageexecutetimeinmilliseconds.Width = 77;
            // 
            // secondsperday
            // 
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.secondsperday.DefaultCellStyle = dataGridViewCellStyle3;
            this.secondsperday.HeaderText = "Sec/Day";
            this.secondsperday.Name = "secondsperday";
            this.secondsperday.ReadOnly = true;
            // 
            // failurecount
            // 
            this.failurecount.HeaderText = "Failures";
            this.failurecount.Name = "failurecount";
            this.failurecount.ReadOnly = true;
            this.failurecount.Width = 68;
            // 
            // failurepercent
            // 
            this.failurepercent.HeaderText = "Fail %";
            this.failurepercent.Name = "failurepercent";
            this.failurepercent.ReadOnly = true;
            this.failurepercent.Width = 59;
            // 
            // crashcount
            // 
            this.crashcount.HeaderText = "Crashes";
            this.crashcount.Name = "crashcount";
            this.crashcount.ReadOnly = true;
            this.crashcount.Width = 70;
            // 
            // crashpercent
            // 
            this.crashpercent.HeaderText = "Crash %";
            this.crashpercent.Name = "crashpercent";
            this.crashpercent.ReadOnly = true;
            this.crashpercent.Width = 70;
            // 
            // crashcontributionpercent
            // 
            this.crashcontributionpercent.HeaderText = "Crash Contrib %";
            this.crashcontributionpercent.Name = "crashcontributionpercent";
            this.crashcontributionpercent.ReadOnly = true;
            this.crashcontributionpercent.Width = 87;
            // 
            // terminatecpucontributionpercent
            // 
            this.terminatecpucontributionpercent.HeaderText = "Trm CPU %";
            this.terminatecpucontributionpercent.Name = "terminatecpucontributionpercent";
            this.terminatecpucontributionpercent.ReadOnly = true;
            this.terminatecpucontributionpercent.Width = 72;
            // 
            // terminatememorycontributionpercent
            // 
            this.terminatememorycontributionpercent.HeaderText = "Trm Mem %";
            this.terminatememorycontributionpercent.Name = "terminatememorycontributionpercent";
            this.terminatememorycontributionpercent.ReadOnly = true;
            this.terminatememorycontributionpercent.Width = 73;
            // 
            // terminatehandlescontributionpercent
            // 
            this.terminatehandlescontributionpercent.HeaderText = "Trm Hndl %";
            this.terminatehandlescontributionpercent.Name = "terminatehandlescontributionpercent";
            this.terminatehandlescontributionpercent.ReadOnly = true;
            this.terminatehandlescontributionpercent.Width = 72;
            // 
            // terminateothercontributionpercent
            // 
            this.terminateothercontributionpercent.HeaderText = "Trm Other %";
            this.terminateothercontributionpercent.Name = "terminateothercontributionpercent";
            this.terminateothercontributionpercent.ReadOnly = true;
            this.terminateothercontributionpercent.Width = 76;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(1049, 7);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Close";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnFilter
            // 
            this.btnFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFilter.Location = new System.Drawing.Point(859, 7);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(184, 23);
            this.btnFilter.TabIndex = 1;
            this.btnFilter.Text = "Filter logs by selected plugins";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // PluginStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(1136, 407);
            this.Controls.Add(this.gridPluginStats);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.Name = "PluginStatistics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PluginStatistics";
            this.Load += new System.EventHandler(this.PluginStatistics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridPluginStats)).EndInit();
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Xrm.CRMWinForm.CRMGridView gridPluginStats;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.DataGridViewTextBoxColumn plugin;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdon;
        private System.Windows.Forms.DataGridViewTextBoxColumn modifiedon;
        private System.Windows.Forms.DataGridViewTextBoxColumn executecount;
        private System.Windows.Forms.DataGridViewTextBoxColumn averageexecutetimeinmilliseconds;
        private System.Windows.Forms.DataGridViewTextBoxColumn secondsperday;
        private System.Windows.Forms.DataGridViewTextBoxColumn failurecount;
        private System.Windows.Forms.DataGridViewTextBoxColumn failurepercent;
        private System.Windows.Forms.DataGridViewTextBoxColumn crashcount;
        private System.Windows.Forms.DataGridViewTextBoxColumn crashpercent;
        private System.Windows.Forms.DataGridViewTextBoxColumn crashcontributionpercent;
        private System.Windows.Forms.DataGridViewTextBoxColumn terminatecpucontributionpercent;
        private System.Windows.Forms.DataGridViewTextBoxColumn terminatememorycontributionpercent;
        private System.Windows.Forms.DataGridViewTextBoxColumn terminatehandlescontributionpercent;
        private System.Windows.Forms.DataGridViewTextBoxColumn terminateothercontributionpercent;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnCancel;
    }
}