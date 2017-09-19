namespace Cinteros.XTB.PluginTraceViewer.Controls
{
    partial class FilterControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelFilter = new System.Windows.Forms.Panel();
            this.textCorrelationId = new System.Windows.Forms.TextBox();
            this.chkCorrelation = new System.Windows.Forms.CheckBox();
            this.labelTimeZone = new System.Windows.Forms.Label();
            this.comboEntity = new System.Windows.Forms.ComboBox();
            this.chkEntity = new System.Windows.Forms.CheckBox();
            this.comboMessage = new System.Windows.Forms.ComboBox();
            this.chkMessage = new System.Windows.Forms.CheckBox();
            this.comboPlugin = new System.Windows.Forms.ComboBox();
            this.chkPlugin = new System.Windows.Forms.CheckBox();
            this.checkDateTo = new System.Windows.Forms.CheckBox();
            this.checkDateFrom = new System.Windows.Forms.CheckBox();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.panelOptions = new System.Windows.Forms.Panel();
            this.panelOperationFilter = new System.Windows.Forms.Panel();
            this.rbOperWF = new System.Windows.Forms.RadioButton();
            this.rbOperPlugin = new System.Windows.Forms.RadioButton();
            this.rbOperAll = new System.Windows.Forms.RadioButton();
            this.chkRecords = new System.Windows.Forms.CheckBox();
            this.chkDurationMax = new System.Windows.Forms.CheckBox();
            this.chkDurationMin = new System.Windows.Forms.CheckBox();
            this.numDurationMax = new System.Windows.Forms.NumericUpDown();
            this.numDurationMin = new System.Windows.Forms.NumericUpDown();
            this.numRecords = new System.Windows.Forms.NumericUpDown();
            this.rbModeAsync = new System.Windows.Forms.RadioButton();
            this.rbModeSync = new System.Windows.Forms.RadioButton();
            this.rbModeAll = new System.Windows.Forms.RadioButton();
            this.chkExceptions = new System.Windows.Forms.CheckBox();
            this.panelFilter.SuspendLayout();
            this.panelOptions.SuspendLayout();
            this.panelOperationFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDurationMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDurationMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFilter
            // 
            this.panelFilter.Controls.Add(this.textCorrelationId);
            this.panelFilter.Controls.Add(this.chkCorrelation);
            this.panelFilter.Controls.Add(this.labelTimeZone);
            this.panelFilter.Controls.Add(this.comboEntity);
            this.panelFilter.Controls.Add(this.chkEntity);
            this.panelFilter.Controls.Add(this.comboMessage);
            this.panelFilter.Controls.Add(this.chkMessage);
            this.panelFilter.Controls.Add(this.comboPlugin);
            this.panelFilter.Controls.Add(this.chkPlugin);
            this.panelFilter.Controls.Add(this.checkDateTo);
            this.panelFilter.Controls.Add(this.checkDateFrom);
            this.panelFilter.Controls.Add(this.dateTo);
            this.panelFilter.Controls.Add(this.dateFrom);
            this.panelFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFilter.Location = new System.Drawing.Point(0, 0);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Size = new System.Drawing.Size(398, 151);
            this.panelFilter.TabIndex = 1;
            // 
            // textCorrelationId
            // 
            this.textCorrelationId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textCorrelationId.Enabled = false;
            this.textCorrelationId.Location = new System.Drawing.Point(97, 120);
            this.textCorrelationId.Name = "textCorrelationId";
            this.textCorrelationId.Size = new System.Drawing.Size(294, 20);
            this.textCorrelationId.TabIndex = 13;
            // 
            // chkCorrelation
            // 
            this.chkCorrelation.AutoSize = true;
            this.chkCorrelation.Location = new System.Drawing.Point(3, 122);
            this.chkCorrelation.Name = "chkCorrelation";
            this.chkCorrelation.Size = new System.Drawing.Size(88, 17);
            this.chkCorrelation.TabIndex = 12;
            this.chkCorrelation.Text = "Correlation Id";
            this.chkCorrelation.UseVisualStyleBackColor = true;
            this.chkCorrelation.CheckedChanged += new System.EventHandler(this.chkCorrelation_CheckedChanged);
            // 
            // labelTimeZone
            // 
            this.labelTimeZone.AutoSize = true;
            this.labelTimeZone.Location = new System.Drawing.Point(270, 4);
            this.labelTimeZone.Name = "labelTimeZone";
            this.labelTimeZone.Size = new System.Drawing.Size(71, 13);
            this.labelTimeZone.TabIndex = 11;
            this.labelTimeZone.Text = "Times in UTC";
            // 
            // comboEntity
            // 
            this.comboEntity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboEntity.Enabled = false;
            this.comboEntity.FormattingEnabled = true;
            this.comboEntity.Location = new System.Drawing.Point(97, 96);
            this.comboEntity.Name = "comboEntity";
            this.comboEntity.Size = new System.Drawing.Size(294, 21);
            this.comboEntity.Sorted = true;
            this.comboEntity.TabIndex = 10;
            // 
            // chkEntity
            // 
            this.chkEntity.AutoSize = true;
            this.chkEntity.Location = new System.Drawing.Point(3, 98);
            this.chkEntity.Name = "chkEntity";
            this.chkEntity.Size = new System.Drawing.Size(52, 17);
            this.chkEntity.TabIndex = 9;
            this.chkEntity.Text = "Entity";
            this.chkEntity.UseVisualStyleBackColor = true;
            this.chkEntity.CheckedChanged += new System.EventHandler(this.chkEntity_CheckedChanged);
            // 
            // comboMessage
            // 
            this.comboMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboMessage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMessage.Enabled = false;
            this.comboMessage.FormattingEnabled = true;
            this.comboMessage.Location = new System.Drawing.Point(97, 72);
            this.comboMessage.Name = "comboMessage";
            this.comboMessage.Size = new System.Drawing.Size(294, 21);
            this.comboMessage.TabIndex = 8;
            // 
            // chkMessage
            // 
            this.chkMessage.AutoSize = true;
            this.chkMessage.Location = new System.Drawing.Point(3, 74);
            this.chkMessage.Name = "chkMessage";
            this.chkMessage.Size = new System.Drawing.Size(69, 17);
            this.chkMessage.TabIndex = 7;
            this.chkMessage.Text = "Message";
            this.chkMessage.UseVisualStyleBackColor = true;
            this.chkMessage.CheckedChanged += new System.EventHandler(this.chkMessage_CheckedChanged);
            // 
            // comboPlugin
            // 
            this.comboPlugin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboPlugin.Enabled = false;
            this.comboPlugin.FormattingEnabled = true;
            this.comboPlugin.Location = new System.Drawing.Point(97, 48);
            this.comboPlugin.Name = "comboPlugin";
            this.comboPlugin.Size = new System.Drawing.Size(294, 21);
            this.comboPlugin.TabIndex = 6;
            // 
            // chkPlugin
            // 
            this.chkPlugin.AutoSize = true;
            this.chkPlugin.Location = new System.Drawing.Point(3, 50);
            this.chkPlugin.Name = "chkPlugin";
            this.chkPlugin.Size = new System.Drawing.Size(55, 17);
            this.chkPlugin.TabIndex = 5;
            this.chkPlugin.Text = "Plugin";
            this.chkPlugin.UseVisualStyleBackColor = true;
            this.chkPlugin.CheckedChanged += new System.EventHandler(this.chkPlugin_CheckedChanged);
            // 
            // checkDateTo
            // 
            this.checkDateTo.AutoSize = true;
            this.checkDateTo.Location = new System.Drawing.Point(3, 27);
            this.checkDateTo.Name = "checkDateTo";
            this.checkDateTo.Size = new System.Drawing.Size(65, 17);
            this.checkDateTo.TabIndex = 3;
            this.checkDateTo.Text = "Date To";
            this.checkDateTo.UseVisualStyleBackColor = true;
            this.checkDateTo.CheckedChanged += new System.EventHandler(this.checkDateTo_CheckedChanged);
            // 
            // checkDateFrom
            // 
            this.checkDateFrom.AutoSize = true;
            this.checkDateFrom.Location = new System.Drawing.Point(3, 3);
            this.checkDateFrom.Name = "checkDateFrom";
            this.checkDateFrom.Size = new System.Drawing.Size(75, 17);
            this.checkDateFrom.TabIndex = 1;
            this.checkDateFrom.Text = "Date From";
            this.checkDateFrom.UseVisualStyleBackColor = true;
            this.checkDateFrom.CheckedChanged += new System.EventHandler(this.checkDateFrom_CheckedChanged);
            // 
            // dateTo
            // 
            this.dateTo.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dateTo.Enabled = false;
            this.dateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTo.Location = new System.Drawing.Point(97, 24);
            this.dateTo.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dateTo.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(130, 20);
            this.dateTo.TabIndex = 4;
            // 
            // dateFrom
            // 
            this.dateFrom.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dateFrom.Enabled = false;
            this.dateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFrom.Location = new System.Drawing.Point(97, 0);
            this.dateFrom.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dateFrom.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(130, 20);
            this.dateFrom.TabIndex = 2;
            // 
            // panelOptions
            // 
            this.panelOptions.Controls.Add(this.panelOperationFilter);
            this.panelOptions.Controls.Add(this.chkRecords);
            this.panelOptions.Controls.Add(this.chkDurationMax);
            this.panelOptions.Controls.Add(this.chkDurationMin);
            this.panelOptions.Controls.Add(this.numDurationMax);
            this.panelOptions.Controls.Add(this.numDurationMin);
            this.panelOptions.Controls.Add(this.numRecords);
            this.panelOptions.Controls.Add(this.rbModeAsync);
            this.panelOptions.Controls.Add(this.rbModeSync);
            this.panelOptions.Controls.Add(this.rbModeAll);
            this.panelOptions.Controls.Add(this.chkExceptions);
            this.panelOptions.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelOptions.Location = new System.Drawing.Point(398, 0);
            this.panelOptions.Name = "panelOptions";
            this.panelOptions.Size = new System.Drawing.Size(257, 151);
            this.panelOptions.TabIndex = 2;
            // 
            // panelOperationFilter
            // 
            this.panelOperationFilter.Controls.Add(this.rbOperWF);
            this.panelOperationFilter.Controls.Add(this.rbOperPlugin);
            this.panelOperationFilter.Controls.Add(this.rbOperAll);
            this.panelOperationFilter.Location = new System.Drawing.Point(0, 24);
            this.panelOperationFilter.Name = "panelOperationFilter";
            this.panelOperationFilter.Size = new System.Drawing.Size(257, 22);
            this.panelOperationFilter.TabIndex = 2;
            // 
            // rbOperWF
            // 
            this.rbOperWF.AutoSize = true;
            this.rbOperWF.Location = new System.Drawing.Point(158, 2);
            this.rbOperWF.Name = "rbOperWF";
            this.rbOperWF.Size = new System.Drawing.Size(87, 17);
            this.rbOperWF.TabIndex = 7;
            this.rbOperWF.TabStop = true;
            this.rbOperWF.Text = "WF Activities";
            this.rbOperWF.UseVisualStyleBackColor = true;
            // 
            // rbOperPlugin
            // 
            this.rbOperPlugin.AutoSize = true;
            this.rbOperPlugin.Location = new System.Drawing.Point(80, 2);
            this.rbOperPlugin.Name = "rbOperPlugin";
            this.rbOperPlugin.Size = new System.Drawing.Size(59, 17);
            this.rbOperPlugin.TabIndex = 6;
            this.rbOperPlugin.TabStop = true;
            this.rbOperPlugin.Text = "Plugins";
            this.rbOperPlugin.UseVisualStyleBackColor = true;
            // 
            // rbOperAll
            // 
            this.rbOperAll.AutoSize = true;
            this.rbOperAll.Checked = true;
            this.rbOperAll.Location = new System.Drawing.Point(3, 2);
            this.rbOperAll.Name = "rbOperAll";
            this.rbOperAll.Size = new System.Drawing.Size(63, 17);
            this.rbOperAll.TabIndex = 5;
            this.rbOperAll.TabStop = true;
            this.rbOperAll.Text = "All oper.";
            this.rbOperAll.UseVisualStyleBackColor = true;
            // 
            // chkRecords
            // 
            this.chkRecords.AutoSize = true;
            this.chkRecords.Checked = true;
            this.chkRecords.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRecords.Location = new System.Drawing.Point(3, 122);
            this.chkRecords.Name = "chkRecords";
            this.chkRecords.Size = new System.Drawing.Size(91, 17);
            this.chkRecords.TabIndex = 12;
            this.chkRecords.Text = "Record count";
            this.chkRecords.UseVisualStyleBackColor = true;
            this.chkRecords.CheckedChanged += new System.EventHandler(this.chkRecords_CheckedChanged);
            // 
            // chkDurationMax
            // 
            this.chkDurationMax.AutoSize = true;
            this.chkDurationMax.Location = new System.Drawing.Point(3, 98);
            this.chkDurationMax.Name = "chkDurationMax";
            this.chkDurationMax.Size = new System.Drawing.Size(89, 17);
            this.chkDurationMax.TabIndex = 10;
            this.chkDurationMax.Text = "Duration Max";
            this.chkDurationMax.UseVisualStyleBackColor = true;
            this.chkDurationMax.CheckedChanged += new System.EventHandler(this.chkDurationMax_CheckedChanged);
            // 
            // chkDurationMin
            // 
            this.chkDurationMin.AutoSize = true;
            this.chkDurationMin.Location = new System.Drawing.Point(3, 74);
            this.chkDurationMin.Name = "chkDurationMin";
            this.chkDurationMin.Size = new System.Drawing.Size(86, 17);
            this.chkDurationMin.TabIndex = 8;
            this.chkDurationMin.Text = "Duration Min";
            this.chkDurationMin.UseVisualStyleBackColor = true;
            this.chkDurationMin.CheckedChanged += new System.EventHandler(this.chkDurationMin_CheckedChanged);
            // 
            // numDurationMax
            // 
            this.numDurationMax.Enabled = false;
            this.numDurationMax.Increment = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numDurationMax.Location = new System.Drawing.Point(158, 97);
            this.numDurationMax.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numDurationMax.Name = "numDurationMax";
            this.numDurationMax.Size = new System.Drawing.Size(76, 20);
            this.numDurationMax.TabIndex = 11;
            // 
            // numDurationMin
            // 
            this.numDurationMin.Enabled = false;
            this.numDurationMin.Increment = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numDurationMin.Location = new System.Drawing.Point(158, 73);
            this.numDurationMin.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numDurationMin.Name = "numDurationMin";
            this.numDurationMin.Size = new System.Drawing.Size(76, 20);
            this.numDurationMin.TabIndex = 9;
            // 
            // numRecords
            // 
            this.numRecords.Increment = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numRecords.Location = new System.Drawing.Point(158, 121);
            this.numRecords.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numRecords.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRecords.Name = "numRecords";
            this.numRecords.Size = new System.Drawing.Size(76, 20);
            this.numRecords.TabIndex = 13;
            this.numRecords.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // rbModeAsync
            // 
            this.rbModeAsync.AutoSize = true;
            this.rbModeAsync.Location = new System.Drawing.Point(158, 49);
            this.rbModeAsync.Name = "rbModeAsync";
            this.rbModeAsync.Size = new System.Drawing.Size(76, 17);
            this.rbModeAsync.TabIndex = 7;
            this.rbModeAsync.TabStop = true;
            this.rbModeAsync.Text = "Async only";
            this.rbModeAsync.UseVisualStyleBackColor = true;
            // 
            // rbModeSync
            // 
            this.rbModeSync.AutoSize = true;
            this.rbModeSync.Location = new System.Drawing.Point(80, 49);
            this.rbModeSync.Name = "rbModeSync";
            this.rbModeSync.Size = new System.Drawing.Size(71, 17);
            this.rbModeSync.TabIndex = 6;
            this.rbModeSync.TabStop = true;
            this.rbModeSync.Text = "Sync only";
            this.rbModeSync.UseVisualStyleBackColor = true;
            // 
            // rbModeAll
            // 
            this.rbModeAll.AutoSize = true;
            this.rbModeAll.Checked = true;
            this.rbModeAll.Location = new System.Drawing.Point(3, 49);
            this.rbModeAll.Name = "rbModeAll";
            this.rbModeAll.Size = new System.Drawing.Size(70, 17);
            this.rbModeAll.TabIndex = 5;
            this.rbModeAll.TabStop = true;
            this.rbModeAll.Text = "All modes";
            this.rbModeAll.UseVisualStyleBackColor = true;
            // 
            // chkExceptions
            // 
            this.chkExceptions.AutoSize = true;
            this.chkExceptions.Location = new System.Drawing.Point(3, 3);
            this.chkExceptions.Name = "chkExceptions";
            this.chkExceptions.Size = new System.Drawing.Size(100, 17);
            this.chkExceptions.TabIndex = 1;
            this.chkExceptions.Text = "Exceptions only";
            this.chkExceptions.UseVisualStyleBackColor = true;
            // 
            // FilterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 151);
            this.Controls.Add(this.panelFilter);
            this.Controls.Add(this.panelOptions);
            this.DockAreas = ((WeifenLuo.WinFormsUI.Docking.DockAreas)((((WeifenLuo.WinFormsUI.Docking.DockAreas.DockLeft | WeifenLuo.WinFormsUI.Docking.DockAreas.DockRight) 
            | WeifenLuo.WinFormsUI.Docking.DockAreas.DockTop) 
            | WeifenLuo.WinFormsUI.Docking.DockAreas.DockBottom)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HideOnClose = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FilterControl";
            this.TabText = "Filter";
            this.Text = "Filter";
            this.DockStateChanged += new System.EventHandler(this.FilterControl_DockStateChanged);
            this.panelFilter.ResumeLayout(false);
            this.panelFilter.PerformLayout();
            this.panelOptions.ResumeLayout(false);
            this.panelOptions.PerformLayout();
            this.panelOperationFilter.ResumeLayout(false);
            this.panelOperationFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDurationMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDurationMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRecords)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.TextBox textCorrelationId;
        private System.Windows.Forms.CheckBox chkCorrelation;
        private System.Windows.Forms.Label labelTimeZone;
        private System.Windows.Forms.ComboBox comboEntity;
        private System.Windows.Forms.CheckBox chkEntity;
        private System.Windows.Forms.ComboBox comboMessage;
        private System.Windows.Forms.CheckBox chkMessage;
        private System.Windows.Forms.ComboBox comboPlugin;
        private System.Windows.Forms.CheckBox chkPlugin;
        private System.Windows.Forms.CheckBox checkDateTo;
        private System.Windows.Forms.CheckBox checkDateFrom;
        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.Panel panelOptions;
        private System.Windows.Forms.Panel panelOperationFilter;
        private System.Windows.Forms.RadioButton rbOperWF;
        private System.Windows.Forms.RadioButton rbOperPlugin;
        private System.Windows.Forms.RadioButton rbOperAll;
        private System.Windows.Forms.CheckBox chkRecords;
        private System.Windows.Forms.CheckBox chkDurationMax;
        private System.Windows.Forms.CheckBox chkDurationMin;
        private System.Windows.Forms.NumericUpDown numDurationMax;
        private System.Windows.Forms.NumericUpDown numDurationMin;
        private System.Windows.Forms.NumericUpDown numRecords;
        private System.Windows.Forms.RadioButton rbModeAsync;
        private System.Windows.Forms.RadioButton rbModeSync;
        private System.Windows.Forms.RadioButton rbModeAll;
        private System.Windows.Forms.CheckBox chkExceptions;
    }
}
