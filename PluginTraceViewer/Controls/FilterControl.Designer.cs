﻿namespace Cinteros.XTB.PluginTraceViewer.Controls
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
            this.components = new System.ComponentModel.Container();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.llToDate = new System.Windows.Forms.LinkLabel();
            this.llFromDate = new System.Windows.Forms.LinkLabel();
            this.textCorrelationId = new System.Windows.Forms.TextBox();
            this.chkCorrelation = new System.Windows.Forms.CheckBox();
            this.textRequestId = new System.Windows.Forms.TextBox();
            this.chkRequestId = new System.Windows.Forms.CheckBox();
            this.labelTimeZone = new System.Windows.Forms.Label();
            this.comboEntity = new System.Windows.Forms.ComboBox();
            this.chkEntity = new System.Windows.Forms.CheckBox();
            this.comboMessage = new System.Windows.Forms.ComboBox();
            this.chkMessage = new System.Windows.Forms.CheckBox();
            this.comboPlugin = new System.Windows.Forms.ComboBox();
            this.chkPlugin = new System.Windows.Forms.CheckBox();
            this.checkDateTo = new System.Windows.Forms.CheckBox();
            this.checkDateFrom = new System.Windows.Forms.CheckBox();
            this.panelOptions = new System.Windows.Forms.Panel();
            this.chkOperWF = new System.Windows.Forms.CheckBox();
            this.chkOperPlugins = new System.Windows.Forms.CheckBox();
            this.chkModeAsync = new System.Windows.Forms.CheckBox();
            this.chkModeSync = new System.Windows.Forms.CheckBox();
            this.chkStage40 = new System.Windows.Forms.CheckBox();
            this.chkStage20 = new System.Windows.Forms.CheckBox();
            this.chkStage10 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkRecords = new System.Windows.Forms.CheckBox();
            this.chkDuration = new System.Windows.Forms.CheckBox();
            this.numDurationMax = new System.Windows.Forms.NumericUpDown();
            this.numDurationMin = new System.Windows.Forms.NumericUpDown();
            this.numRecords = new System.Windows.Forms.NumericUpDown();
            this.chkExceptions = new System.Windows.Forms.CheckBox();
            this.dateMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dateMenuNow = new System.Windows.Forms.ToolStripMenuItem();
            this.dateMenuToday = new System.Windows.Forms.ToolStripMenuItem();
            this.dateMenuFirst = new System.Windows.Forms.ToolStripMenuItem();
            this.dateMenuLast = new System.Windows.Forms.ToolStripMenuItem();
            this.panelFilter.SuspendLayout();
            this.panelOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDurationMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDurationMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRecords)).BeginInit();
            this.dateMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFilter
            // 
            this.panelFilter.Controls.Add(this.dateTo);
            this.panelFilter.Controls.Add(this.dateFrom);
            this.panelFilter.Controls.Add(this.llToDate);
            this.panelFilter.Controls.Add(this.llFromDate);
            this.panelFilter.Controls.Add(this.textCorrelationId);
            this.panelFilter.Controls.Add(this.chkCorrelation);
            this.panelFilter.Controls.Add(this.textRequestId);
            this.panelFilter.Controls.Add(this.chkRequestId);
            this.panelFilter.Controls.Add(this.labelTimeZone);
            this.panelFilter.Controls.Add(this.comboEntity);
            this.panelFilter.Controls.Add(this.chkEntity);
            this.panelFilter.Controls.Add(this.comboMessage);
            this.panelFilter.Controls.Add(this.chkMessage);
            this.panelFilter.Controls.Add(this.comboPlugin);
            this.panelFilter.Controls.Add(this.chkPlugin);
            this.panelFilter.Controls.Add(this.checkDateTo);
            this.panelFilter.Controls.Add(this.checkDateFrom);
            this.panelFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFilter.Location = new System.Drawing.Point(0, 0);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Size = new System.Drawing.Size(773, 147);
            this.panelFilter.TabIndex = 1;
            // 
            // dateTo
            // 
            this.dateTo.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dateTo.Enabled = false;
            this.dateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTo.Location = new System.Drawing.Point(298, 4);
            this.dateTo.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dateTo.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(130, 20);
            this.dateTo.TabIndex = 6;
            // 
            // dateFrom
            // 
            this.dateFrom.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dateFrom.Enabled = false;
            this.dateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFrom.Location = new System.Drawing.Point(97, 4);
            this.dateFrom.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dateFrom.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(130, 20);
            this.dateFrom.TabIndex = 3;
            // 
            // llToDate
            // 
            this.llToDate.AutoSize = true;
            this.llToDate.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.llToDate.Location = new System.Drawing.Point(277, 7);
            this.llToDate.Name = "llToDate";
            this.llToDate.Size = new System.Drawing.Size(19, 13);
            this.llToDate.TabIndex = 5;
            this.llToDate.TabStop = true;
            this.llToDate.Tag = "to";
            this.llToDate.Text = ">>";
            this.llToDate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llDate_LinkClicked);
            // 
            // llFromDate
            // 
            this.llFromDate.AutoSize = true;
            this.llFromDate.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.llFromDate.Location = new System.Drawing.Point(76, 7);
            this.llFromDate.Name = "llFromDate";
            this.llFromDate.Size = new System.Drawing.Size(19, 13);
            this.llFromDate.TabIndex = 2;
            this.llFromDate.TabStop = true;
            this.llFromDate.Tag = "from";
            this.llFromDate.Text = ">>";
            this.llFromDate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llDate_LinkClicked);
            // 
            // textCorrelationId
            // 
            this.textCorrelationId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textCorrelationId.Enabled = false;
            this.textCorrelationId.Location = new System.Drawing.Point(97, 100);
            this.textCorrelationId.Name = "textCorrelationId";
            this.textCorrelationId.Size = new System.Drawing.Size(669, 20);
            this.textCorrelationId.TabIndex = 14;
            // 
            // chkCorrelation
            // 
            this.chkCorrelation.AutoSize = true;
            this.chkCorrelation.Location = new System.Drawing.Point(3, 102);
            this.chkCorrelation.Name = "chkCorrelation";
            this.chkCorrelation.Size = new System.Drawing.Size(88, 17);
            this.chkCorrelation.TabIndex = 13;
            this.chkCorrelation.Text = "Correlation Id";
            this.chkCorrelation.UseVisualStyleBackColor = true;
            this.chkCorrelation.CheckedChanged += new System.EventHandler(this.chkCorrelation_CheckedChanged);
            // 
            // textRequestId
            // 
            this.textRequestId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textRequestId.Enabled = false;
            this.textRequestId.Location = new System.Drawing.Point(97, 124);
            this.textRequestId.Name = "textRequestId";
            this.textRequestId.Size = new System.Drawing.Size(669, 20);
            this.textRequestId.TabIndex = 16;
            // 
            // chkRequestId
            // 
            this.chkRequestId.AutoSize = true;
            this.chkRequestId.Location = new System.Drawing.Point(3, 126);
            this.chkRequestId.Name = "chkRequestId";
            this.chkRequestId.Size = new System.Drawing.Size(78, 17);
            this.chkRequestId.TabIndex = 15;
            this.chkRequestId.Text = "Request Id";
            this.chkRequestId.UseVisualStyleBackColor = true;
            this.chkRequestId.CheckedChanged += new System.EventHandler(this.chkRequestId_CheckedChanged);
            // 
            // labelTimeZone
            // 
            this.labelTimeZone.AutoSize = true;
            this.labelTimeZone.Location = new System.Drawing.Point(434, 7);
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
            this.comboEntity.Location = new System.Drawing.Point(97, 76);
            this.comboEntity.Name = "comboEntity";
            this.comboEntity.Size = new System.Drawing.Size(669, 21);
            this.comboEntity.Sorted = true;
            this.comboEntity.TabIndex = 12;
            // 
            // chkEntity
            // 
            this.chkEntity.AutoSize = true;
            this.chkEntity.Location = new System.Drawing.Point(3, 78);
            this.chkEntity.Name = "chkEntity";
            this.chkEntity.Size = new System.Drawing.Size(52, 17);
            this.chkEntity.TabIndex = 11;
            this.chkEntity.Text = "Entity";
            this.chkEntity.UseVisualStyleBackColor = true;
            this.chkEntity.CheckedChanged += new System.EventHandler(this.chkEntity_CheckedChanged);
            // 
            // comboMessage
            // 
            this.comboMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboMessage.Enabled = false;
            this.comboMessage.FormattingEnabled = true;
            this.comboMessage.Location = new System.Drawing.Point(97, 52);
            this.comboMessage.Name = "comboMessage";
            this.comboMessage.Size = new System.Drawing.Size(669, 21);
            this.comboMessage.TabIndex = 10;
            // 
            // chkMessage
            // 
            this.chkMessage.AutoSize = true;
            this.chkMessage.Location = new System.Drawing.Point(3, 54);
            this.chkMessage.Name = "chkMessage";
            this.chkMessage.Size = new System.Drawing.Size(69, 17);
            this.chkMessage.TabIndex = 9;
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
            this.comboPlugin.Location = new System.Drawing.Point(97, 28);
            this.comboPlugin.Name = "comboPlugin";
            this.comboPlugin.Size = new System.Drawing.Size(669, 21);
            this.comboPlugin.TabIndex = 8;
            // 
            // chkPlugin
            // 
            this.chkPlugin.AutoSize = true;
            this.chkPlugin.Location = new System.Drawing.Point(3, 30);
            this.chkPlugin.Name = "chkPlugin";
            this.chkPlugin.Size = new System.Drawing.Size(55, 17);
            this.chkPlugin.TabIndex = 7;
            this.chkPlugin.Text = "Plugin";
            this.chkPlugin.UseVisualStyleBackColor = true;
            this.chkPlugin.CheckedChanged += new System.EventHandler(this.chkPlugin_CheckedChanged);
            // 
            // checkDateTo
            // 
            this.checkDateTo.AutoSize = true;
            this.checkDateTo.Location = new System.Drawing.Point(242, 6);
            this.checkDateTo.Name = "checkDateTo";
            this.checkDateTo.Size = new System.Drawing.Size(39, 17);
            this.checkDateTo.TabIndex = 4;
            this.checkDateTo.Text = "To";
            this.checkDateTo.UseVisualStyleBackColor = true;
            this.checkDateTo.CheckedChanged += new System.EventHandler(this.checkDateTo_CheckedChanged);
            // 
            // checkDateFrom
            // 
            this.checkDateFrom.AutoSize = true;
            this.checkDateFrom.Location = new System.Drawing.Point(3, 6);
            this.checkDateFrom.Name = "checkDateFrom";
            this.checkDateFrom.Size = new System.Drawing.Size(75, 17);
            this.checkDateFrom.TabIndex = 1;
            this.checkDateFrom.Text = "Date From";
            this.checkDateFrom.UseVisualStyleBackColor = true;
            this.checkDateFrom.CheckedChanged += new System.EventHandler(this.checkDateFrom_CheckedChanged);
            // 
            // panelOptions
            // 
            this.panelOptions.Controls.Add(this.chkOperWF);
            this.panelOptions.Controls.Add(this.chkOperPlugins);
            this.panelOptions.Controls.Add(this.chkModeAsync);
            this.panelOptions.Controls.Add(this.chkModeSync);
            this.panelOptions.Controls.Add(this.chkStage40);
            this.panelOptions.Controls.Add(this.chkStage20);
            this.panelOptions.Controls.Add(this.chkStage10);
            this.panelOptions.Controls.Add(this.label1);
            this.panelOptions.Controls.Add(this.chkRecords);
            this.panelOptions.Controls.Add(this.chkDuration);
            this.panelOptions.Controls.Add(this.numDurationMax);
            this.panelOptions.Controls.Add(this.numDurationMin);
            this.panelOptions.Controls.Add(this.numRecords);
            this.panelOptions.Controls.Add(this.chkExceptions);
            this.panelOptions.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelOptions.Location = new System.Drawing.Point(773, 0);
            this.panelOptions.Name = "panelOptions";
            this.panelOptions.Size = new System.Drawing.Size(255, 147);
            this.panelOptions.TabIndex = 2;
            // 
            // chkOperWF
            // 
            this.chkOperWF.AutoSize = true;
            this.chkOperWF.Checked = true;
            this.chkOperWF.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkOperWF.Location = new System.Drawing.Point(93, 30);
            this.chkOperWF.Name = "chkOperWF";
            this.chkOperWF.Size = new System.Drawing.Size(88, 17);
            this.chkOperWF.TabIndex = 3;
            this.chkOperWF.Text = "WF Activities";
            this.chkOperWF.UseVisualStyleBackColor = true;
            // 
            // chkOperPlugins
            // 
            this.chkOperPlugins.AutoSize = true;
            this.chkOperPlugins.Checked = true;
            this.chkOperPlugins.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkOperPlugins.Location = new System.Drawing.Point(3, 30);
            this.chkOperPlugins.Name = "chkOperPlugins";
            this.chkOperPlugins.Size = new System.Drawing.Size(60, 17);
            this.chkOperPlugins.TabIndex = 2;
            this.chkOperPlugins.Text = "Plugins";
            this.chkOperPlugins.UseVisualStyleBackColor = true;
            // 
            // chkModeAsync
            // 
            this.chkModeAsync.AutoSize = true;
            this.chkModeAsync.Checked = true;
            this.chkModeAsync.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkModeAsync.Location = new System.Drawing.Point(93, 53);
            this.chkModeAsync.Name = "chkModeAsync";
            this.chkModeAsync.Size = new System.Drawing.Size(55, 17);
            this.chkModeAsync.TabIndex = 5;
            this.chkModeAsync.Text = "Async";
            this.chkModeAsync.UseVisualStyleBackColor = true;
            // 
            // chkModeSync
            // 
            this.chkModeSync.AutoSize = true;
            this.chkModeSync.Checked = true;
            this.chkModeSync.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkModeSync.Location = new System.Drawing.Point(3, 53);
            this.chkModeSync.Name = "chkModeSync";
            this.chkModeSync.Size = new System.Drawing.Size(50, 17);
            this.chkModeSync.TabIndex = 4;
            this.chkModeSync.Text = "Sync";
            this.chkModeSync.UseVisualStyleBackColor = true;
            // 
            // chkStage40
            // 
            this.chkStage40.AutoSize = true;
            this.chkStage40.Checked = true;
            this.chkStage40.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkStage40.Location = new System.Drawing.Point(183, 77);
            this.chkStage40.Name = "chkStage40";
            this.chkStage40.Size = new System.Drawing.Size(61, 17);
            this.chkStage40.TabIndex = 8;
            this.chkStage40.Text = "PostOp";
            this.chkStage40.UseVisualStyleBackColor = true;
            // 
            // chkStage20
            // 
            this.chkStage20.AutoSize = true;
            this.chkStage20.Checked = true;
            this.chkStage20.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkStage20.Location = new System.Drawing.Point(93, 77);
            this.chkStage20.Name = "chkStage20";
            this.chkStage20.Size = new System.Drawing.Size(56, 17);
            this.chkStage20.TabIndex = 7;
            this.chkStage20.Text = "PreOp";
            this.chkStage20.UseVisualStyleBackColor = true;
            // 
            // chkStage10
            // 
            this.chkStage10.AutoSize = true;
            this.chkStage10.Checked = true;
            this.chkStage10.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkStage10.Location = new System.Drawing.Point(3, 77);
            this.chkStage10.Name = "chkStage10";
            this.chkStage10.Size = new System.Drawing.Size(57, 17);
            this.chkStage10.TabIndex = 6;
            this.chkStage10.Text = "PreVal";
            this.chkStage10.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "-";
            // 
            // chkRecords
            // 
            this.chkRecords.AutoSize = true;
            this.chkRecords.Checked = true;
            this.chkRecords.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRecords.Location = new System.Drawing.Point(3, 125);
            this.chkRecords.Name = "chkRecords";
            this.chkRecords.Size = new System.Drawing.Size(66, 17);
            this.chkRecords.TabIndex = 12;
            this.chkRecords.Text = "Records";
            this.chkRecords.UseVisualStyleBackColor = true;
            this.chkRecords.CheckedChanged += new System.EventHandler(this.chkRecords_CheckedChanged);
            // 
            // chkDuration
            // 
            this.chkDuration.AutoSize = true;
            this.chkDuration.Location = new System.Drawing.Point(3, 101);
            this.chkDuration.Name = "chkDuration";
            this.chkDuration.Size = new System.Drawing.Size(66, 17);
            this.chkDuration.TabIndex = 9;
            this.chkDuration.Text = "Duration";
            this.chkDuration.UseVisualStyleBackColor = true;
            this.chkDuration.CheckedChanged += new System.EventHandler(this.chkDurationMin_CheckedChanged);
            // 
            // numDurationMax
            // 
            this.numDurationMax.Enabled = false;
            this.numDurationMax.Increment = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numDurationMax.Location = new System.Drawing.Point(183, 100);
            this.numDurationMax.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numDurationMax.Name = "numDurationMax";
            this.numDurationMax.Size = new System.Drawing.Size(61, 20);
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
            this.numDurationMin.Location = new System.Drawing.Point(93, 100);
            this.numDurationMin.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numDurationMin.Name = "numDurationMin";
            this.numDurationMin.Size = new System.Drawing.Size(61, 20);
            this.numDurationMin.TabIndex = 10;
            // 
            // numRecords
            // 
            this.numRecords.Increment = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numRecords.Location = new System.Drawing.Point(93, 124);
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
            this.numRecords.Size = new System.Drawing.Size(61, 20);
            this.numRecords.TabIndex = 13;
            this.numRecords.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // chkExceptions
            // 
            this.chkExceptions.AutoSize = true;
            this.chkExceptions.Location = new System.Drawing.Point(3, 6);
            this.chkExceptions.Name = "chkExceptions";
            this.chkExceptions.Size = new System.Drawing.Size(100, 17);
            this.chkExceptions.TabIndex = 1;
            this.chkExceptions.Text = "Exceptions only";
            this.chkExceptions.UseVisualStyleBackColor = true;
            // 
            // dateMenu
            // 
            this.dateMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateMenuNow,
            this.dateMenuToday,
            this.dateMenuFirst,
            this.dateMenuLast});
            this.dateMenu.Name = "dateMenu";
            this.dateMenu.Size = new System.Drawing.Size(154, 92);
            // 
            // dateMenuNow
            // 
            this.dateMenuNow.Name = "dateMenuNow";
            this.dateMenuNow.Size = new System.Drawing.Size(153, 22);
            this.dateMenuNow.Tag = "now";
            this.dateMenuNow.Text = "Now";
            this.dateMenuNow.Click += new System.EventHandler(this.dateMenuItem_Click);
            // 
            // dateMenuToday
            // 
            this.dateMenuToday.Name = "dateMenuToday";
            this.dateMenuToday.Size = new System.Drawing.Size(153, 22);
            this.dateMenuToday.Tag = "today";
            this.dateMenuToday.Text = "Today";
            this.dateMenuToday.Click += new System.EventHandler(this.dateMenuItem_Click);
            // 
            // dateMenuFirst
            // 
            this.dateMenuFirst.Name = "dateMenuFirst";
            this.dateMenuFirst.Size = new System.Drawing.Size(153, 22);
            this.dateMenuFirst.Tag = "first";
            this.dateMenuFirst.Text = "First log record";
            this.dateMenuFirst.Click += new System.EventHandler(this.dateMenuItem_Click);
            // 
            // dateMenuLast
            // 
            this.dateMenuLast.Name = "dateMenuLast";
            this.dateMenuLast.Size = new System.Drawing.Size(153, 22);
            this.dateMenuLast.Tag = "last";
            this.dateMenuLast.Text = "Last log record";
            this.dateMenuLast.Click += new System.EventHandler(this.dateMenuItem_Click);
            // 
            // FilterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1028, 147);
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
            ((System.ComponentModel.ISupportInitialize)(this.numDurationMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDurationMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRecords)).EndInit();
            this.dateMenu.ResumeLayout(false);
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
        private System.Windows.Forms.CheckBox chkRecords;
        private System.Windows.Forms.CheckBox chkDuration;
        private System.Windows.Forms.NumericUpDown numDurationMax;
        private System.Windows.Forms.NumericUpDown numDurationMin;
        private System.Windows.Forms.NumericUpDown numRecords;
        private System.Windows.Forms.CheckBox chkExceptions;
        private System.Windows.Forms.CheckBox chkOperWF;
        private System.Windows.Forms.CheckBox chkOperPlugins;
        private System.Windows.Forms.CheckBox chkModeAsync;
        private System.Windows.Forms.CheckBox chkModeSync;
        private System.Windows.Forms.CheckBox chkStage40;
        private System.Windows.Forms.CheckBox chkStage20;
        private System.Windows.Forms.CheckBox chkStage10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel llFromDate;
        private System.Windows.Forms.ContextMenuStrip dateMenu;
        private System.Windows.Forms.ToolStripMenuItem dateMenuNow;
        private System.Windows.Forms.LinkLabel llToDate;
        private System.Windows.Forms.ToolStripMenuItem dateMenuToday;
        private System.Windows.Forms.ToolStripMenuItem dateMenuFirst;
        private System.Windows.Forms.ToolStripMenuItem dateMenuLast;
        private System.Windows.Forms.TextBox textRequestId;
        private System.Windows.Forms.CheckBox chkRequestId;
    }
}
