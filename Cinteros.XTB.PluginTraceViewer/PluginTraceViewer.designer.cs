namespace Cinteros.XTB.PluginTraceViewer
{
    partial class PluginTraceViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PluginTraceViewer));
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.tsbCloseThisTab = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbAbout = new System.Windows.Forms.ToolStripButton();
            this.groupFilter = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numRecords = new System.Windows.Forms.NumericUpDown();
            this.rbModeAsync = new System.Windows.Forms.RadioButton();
            this.rbModeSync = new System.Windows.Forms.RadioButton();
            this.rbModeAll = new System.Windows.Forms.RadioButton();
            this.chkExceptions = new System.Windows.Forms.CheckBox();
            this.comboMessage = new System.Windows.Forms.ComboBox();
            this.chkMessage = new System.Windows.Forms.CheckBox();
            this.comboPlugin = new System.Windows.Forms.ComboBox();
            this.chkPlugin = new System.Windows.Forms.CheckBox();
            this.checkDateTo = new System.Windows.Forms.CheckBox();
            this.checkDateFrom = new System.Windows.Forms.CheckBox();
            this.buttonRetrieveLogs = new System.Windows.Forms.Button();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.panelData = new System.Windows.Forms.Panel();
            this.crmGridView = new Cinteros.Xrm.CRMWinForm.CRMGridView();
            this.performanceexecutionstarttime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.performanceexecutionduration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operationtype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.messagename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.primaryentity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exceptiondetails = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.messagebody = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelDataTop = new System.Windows.Forms.Panel();
            this.groupDetails = new System.Windows.Forms.GroupBox();
            this.panelException = new System.Windows.Forms.Panel();
            this.textException = new System.Windows.Forms.TextBox();
            this.labelException = new System.Windows.Forms.Label();
            this.splitterMessageHeight = new System.Windows.Forms.Splitter();
            this.textMessage = new System.Windows.Forms.TextBox();
            this.labelMessage = new System.Windows.Forms.Label();
            this.panelDetailsTop = new System.Windows.Forms.Panel();
            this.buttonOpenRecord = new System.Windows.Forms.Button();
            this.splitterDetailsWidth = new System.Windows.Forms.Splitter();
            this.toolStripMain.SuspendLayout();
            this.groupFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRecords)).BeginInit();
            this.panelData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crmGridView)).BeginInit();
            this.groupDetails.SuspendLayout();
            this.panelException.SuspendLayout();
            this.panelDetailsTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMain
            // 
            this.toolStripMain.AutoSize = false;
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbCloseThisTab,
            this.toolStripSeparator4,
            this.tsbAbout});
            this.toolStripMain.Location = new System.Drawing.Point(0, 0);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(1255, 25);
            this.toolStripMain.TabIndex = 24;
            this.toolStripMain.Text = "toolStrip1";
            // 
            // tsbCloseThisTab
            // 
            this.tsbCloseThisTab.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCloseThisTab.Image = ((System.Drawing.Image)(resources.GetObject("tsbCloseThisTab.Image")));
            this.tsbCloseThisTab.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCloseThisTab.Name = "tsbCloseThisTab";
            this.tsbCloseThisTab.Size = new System.Drawing.Size(23, 22);
            this.tsbCloseThisTab.Text = "Close this tab";
            this.tsbCloseThisTab.Click += new System.EventHandler(this.tsbCloseThisTab_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbAbout
            // 
            this.tsbAbout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbAbout.Image = ((System.Drawing.Image)(resources.GetObject("tsbAbout.Image")));
            this.tsbAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAbout.Name = "tsbAbout";
            this.tsbAbout.Size = new System.Drawing.Size(60, 22);
            this.tsbAbout.Text = "About";
            this.tsbAbout.Click += new System.EventHandler(this.tsbAbout_Click);
            // 
            // groupFilter
            // 
            this.groupFilter.Controls.Add(this.label1);
            this.groupFilter.Controls.Add(this.numRecords);
            this.groupFilter.Controls.Add(this.rbModeAsync);
            this.groupFilter.Controls.Add(this.rbModeSync);
            this.groupFilter.Controls.Add(this.rbModeAll);
            this.groupFilter.Controls.Add(this.chkExceptions);
            this.groupFilter.Controls.Add(this.comboMessage);
            this.groupFilter.Controls.Add(this.chkMessage);
            this.groupFilter.Controls.Add(this.comboPlugin);
            this.groupFilter.Controls.Add(this.chkPlugin);
            this.groupFilter.Controls.Add(this.checkDateTo);
            this.groupFilter.Controls.Add(this.checkDateFrom);
            this.groupFilter.Controls.Add(this.buttonRetrieveLogs);
            this.groupFilter.Controls.Add(this.dateTo);
            this.groupFilter.Controls.Add(this.dateFrom);
            this.groupFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupFilter.Location = new System.Drawing.Point(0, 25);
            this.groupFilter.Name = "groupFilter";
            this.groupFilter.Size = new System.Drawing.Size(825, 127);
            this.groupFilter.TabIndex = 26;
            this.groupFilter.TabStop = false;
            this.groupFilter.Text = "Filter";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(384, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Max logs";
            // 
            // numRecords
            // 
            this.numRecords.Increment = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numRecords.Location = new System.Drawing.Point(452, 88);
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
            this.numRecords.Size = new System.Drawing.Size(90, 20);
            this.numRecords.TabIndex = 15;
            this.numRecords.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numRecords.ValueChanged += new System.EventHandler(this.numRecords_ValueChanged);
            // 
            // rbModeAsync
            // 
            this.rbModeAsync.AutoSize = true;
            this.rbModeAsync.Location = new System.Drawing.Point(542, 42);
            this.rbModeAsync.Name = "rbModeAsync";
            this.rbModeAsync.Size = new System.Drawing.Size(76, 17);
            this.rbModeAsync.TabIndex = 14;
            this.rbModeAsync.TabStop = true;
            this.rbModeAsync.Text = "Async only";
            this.rbModeAsync.UseVisualStyleBackColor = true;
            // 
            // rbModeSync
            // 
            this.rbModeSync.AutoSize = true;
            this.rbModeSync.Location = new System.Drawing.Point(464, 42);
            this.rbModeSync.Name = "rbModeSync";
            this.rbModeSync.Size = new System.Drawing.Size(71, 17);
            this.rbModeSync.TabIndex = 13;
            this.rbModeSync.TabStop = true;
            this.rbModeSync.Text = "Sync only";
            this.rbModeSync.UseVisualStyleBackColor = true;
            // 
            // rbModeAll
            // 
            this.rbModeAll.AutoSize = true;
            this.rbModeAll.Checked = true;
            this.rbModeAll.Location = new System.Drawing.Point(387, 42);
            this.rbModeAll.Name = "rbModeAll";
            this.rbModeAll.Size = new System.Drawing.Size(70, 17);
            this.rbModeAll.TabIndex = 12;
            this.rbModeAll.TabStop = true;
            this.rbModeAll.Text = "All modes";
            this.rbModeAll.UseVisualStyleBackColor = true;
            // 
            // chkExceptions
            // 
            this.chkExceptions.AutoSize = true;
            this.chkExceptions.Location = new System.Drawing.Point(387, 18);
            this.chkExceptions.Name = "chkExceptions";
            this.chkExceptions.Size = new System.Drawing.Size(100, 17);
            this.chkExceptions.TabIndex = 11;
            this.chkExceptions.Text = "Exceptions only";
            this.chkExceptions.UseVisualStyleBackColor = true;
            // 
            // comboMessage
            // 
            this.comboMessage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMessage.Enabled = false;
            this.comboMessage.FormattingEnabled = true;
            this.comboMessage.Location = new System.Drawing.Point(88, 87);
            this.comboMessage.Name = "comboMessage";
            this.comboMessage.Size = new System.Drawing.Size(287, 21);
            this.comboMessage.TabIndex = 10;
            // 
            // chkMessage
            // 
            this.chkMessage.AutoSize = true;
            this.chkMessage.Location = new System.Drawing.Point(7, 89);
            this.chkMessage.Name = "chkMessage";
            this.chkMessage.Size = new System.Drawing.Size(69, 17);
            this.chkMessage.TabIndex = 9;
            this.chkMessage.Text = "Message";
            this.chkMessage.UseVisualStyleBackColor = true;
            this.chkMessage.CheckedChanged += new System.EventHandler(this.chkMessage_CheckedChanged);
            // 
            // comboPlugin
            // 
            this.comboPlugin.Enabled = false;
            this.comboPlugin.FormattingEnabled = true;
            this.comboPlugin.Location = new System.Drawing.Point(88, 63);
            this.comboPlugin.Name = "comboPlugin";
            this.comboPlugin.Size = new System.Drawing.Size(287, 21);
            this.comboPlugin.TabIndex = 8;
            // 
            // chkPlugin
            // 
            this.chkPlugin.AutoSize = true;
            this.chkPlugin.Location = new System.Drawing.Point(7, 65);
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
            this.checkDateTo.Location = new System.Drawing.Point(7, 42);
            this.checkDateTo.Name = "checkDateTo";
            this.checkDateTo.Size = new System.Drawing.Size(65, 17);
            this.checkDateTo.TabIndex = 6;
            this.checkDateTo.Text = "Date To";
            this.checkDateTo.UseVisualStyleBackColor = true;
            this.checkDateTo.CheckedChanged += new System.EventHandler(this.checkDateTo_CheckedChanged);
            // 
            // checkDateFrom
            // 
            this.checkDateFrom.AutoSize = true;
            this.checkDateFrom.Location = new System.Drawing.Point(7, 18);
            this.checkDateFrom.Name = "checkDateFrom";
            this.checkDateFrom.Size = new System.Drawing.Size(75, 17);
            this.checkDateFrom.TabIndex = 5;
            this.checkDateFrom.Text = "Date From";
            this.checkDateFrom.UseVisualStyleBackColor = true;
            this.checkDateFrom.CheckedChanged += new System.EventHandler(this.checkDateFrom_CheckedChanged);
            // 
            // buttonRetrieveLogs
            // 
            this.buttonRetrieveLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRetrieveLogs.Location = new System.Drawing.Point(701, 19);
            this.buttonRetrieveLogs.Name = "buttonRetrieveLogs";
            this.buttonRetrieveLogs.Size = new System.Drawing.Size(118, 27);
            this.buttonRetrieveLogs.TabIndex = 4;
            this.buttonRetrieveLogs.Text = "Retrieve";
            this.buttonRetrieveLogs.UseVisualStyleBackColor = true;
            this.buttonRetrieveLogs.Click += new System.EventHandler(this.buttonRetrieveLogs_Click);
            // 
            // dateTo
            // 
            this.dateTo.Enabled = false;
            this.dateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTo.Location = new System.Drawing.Point(88, 39);
            this.dateTo.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dateTo.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(100, 20);
            this.dateTo.TabIndex = 3;
            // 
            // dateFrom
            // 
            this.dateFrom.Enabled = false;
            this.dateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFrom.Location = new System.Drawing.Point(88, 15);
            this.dateFrom.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dateFrom.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(100, 20);
            this.dateFrom.TabIndex = 2;
            // 
            // panelData
            // 
            this.panelData.Controls.Add(this.crmGridView);
            this.panelData.Controls.Add(this.panelDataTop);
            this.panelData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelData.Location = new System.Drawing.Point(0, 152);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(825, 402);
            this.panelData.TabIndex = 27;
            // 
            // crmGridView
            // 
            this.crmGridView.AllowUserToAddRows = false;
            this.crmGridView.AllowUserToDeleteRows = false;
            this.crmGridView.AllowUserToOrderColumns = true;
            this.crmGridView.AllowUserToResizeRows = false;
            this.crmGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.crmGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.crmGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.performanceexecutionstarttime,
            this.performanceexecutionduration,
            this.operationtype,
            this.typename,
            this.depth,
            this.mode,
            this.messagename,
            this.primaryentity,
            this.exceptiondetails,
            this.messagebody});
            this.crmGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crmGridView.EnableHeadersVisualStyles = false;
            this.crmGridView.Location = new System.Drawing.Point(0, 32);
            this.crmGridView.Name = "crmGridView";
            this.crmGridView.ReadOnly = true;
            this.crmGridView.RowHeadersWidth = 20;
            this.crmGridView.ShowFriendlyNames = true;
            this.crmGridView.ShowIdColumn = false;
            this.crmGridView.ShowIndexColumn = false;
            this.crmGridView.Size = new System.Drawing.Size(825, 370);
            this.crmGridView.TabIndex = 25;
            this.crmGridView.RecordEnter += new Cinteros.Xrm.CRMWinForm.CRMRecordEventHandler(this.crmGridView_RecordEnter);
            // 
            // performanceexecutionstarttime
            // 
            this.performanceexecutionstarttime.HeaderText = "Start Time";
            this.performanceexecutionstarttime.Name = "performanceexecutionstarttime";
            this.performanceexecutionstarttime.ReadOnly = true;
            this.performanceexecutionstarttime.Width = 80;
            // 
            // performanceexecutionduration
            // 
            this.performanceexecutionduration.HeaderText = "Duration";
            this.performanceexecutionduration.Name = "performanceexecutionduration";
            this.performanceexecutionduration.ReadOnly = true;
            this.performanceexecutionduration.Width = 72;
            // 
            // operationtype
            // 
            this.operationtype.HeaderText = "Operation";
            this.operationtype.Name = "operationtype";
            this.operationtype.ReadOnly = true;
            this.operationtype.Width = 78;
            // 
            // typename
            // 
            this.typename.HeaderText = "Plugin";
            this.typename.Name = "typename";
            this.typename.ReadOnly = true;
            this.typename.Width = 61;
            // 
            // depth
            // 
            this.depth.HeaderText = "Depth";
            this.depth.Name = "depth";
            this.depth.ReadOnly = true;
            this.depth.Width = 61;
            // 
            // mode
            // 
            this.mode.HeaderText = "Mode";
            this.mode.Name = "mode";
            this.mode.ReadOnly = true;
            this.mode.Width = 59;
            // 
            // messagename
            // 
            this.messagename.HeaderText = "Message";
            this.messagename.Name = "messagename";
            this.messagename.ReadOnly = true;
            this.messagename.Width = 75;
            // 
            // primaryentity
            // 
            this.primaryentity.HeaderText = "Entity";
            this.primaryentity.Name = "primaryentity";
            this.primaryentity.ReadOnly = true;
            this.primaryentity.Width = 58;
            // 
            // exceptiondetails
            // 
            this.exceptiondetails.HeaderText = "Exception";
            this.exceptiondetails.Name = "exceptiondetails";
            this.exceptiondetails.ReadOnly = true;
            this.exceptiondetails.Visible = false;
            this.exceptiondetails.Width = 79;
            // 
            // messagebody
            // 
            this.messagebody.HeaderText = "Message";
            this.messagebody.Name = "messagebody";
            this.messagebody.ReadOnly = true;
            this.messagebody.Visible = false;
            this.messagebody.Width = 75;
            // 
            // panelDataTop
            // 
            this.panelDataTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDataTop.Location = new System.Drawing.Point(0, 0);
            this.panelDataTop.Name = "panelDataTop";
            this.panelDataTop.Size = new System.Drawing.Size(825, 32);
            this.panelDataTop.TabIndex = 26;
            // 
            // groupDetails
            // 
            this.groupDetails.Controls.Add(this.panelException);
            this.groupDetails.Controls.Add(this.splitterMessageHeight);
            this.groupDetails.Controls.Add(this.textMessage);
            this.groupDetails.Controls.Add(this.labelMessage);
            this.groupDetails.Controls.Add(this.panelDetailsTop);
            this.groupDetails.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupDetails.Location = new System.Drawing.Point(828, 25);
            this.groupDetails.Name = "groupDetails";
            this.groupDetails.Size = new System.Drawing.Size(427, 529);
            this.groupDetails.TabIndex = 28;
            this.groupDetails.TabStop = false;
            this.groupDetails.Text = "Details";
            // 
            // panelException
            // 
            this.panelException.Controls.Add(this.textException);
            this.panelException.Controls.Add(this.labelException);
            this.panelException.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelException.Location = new System.Drawing.Point(3, 212);
            this.panelException.Name = "panelException";
            this.panelException.Size = new System.Drawing.Size(421, 314);
            this.panelException.TabIndex = 6;
            // 
            // textException
            // 
            this.textException.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textException.Location = new System.Drawing.Point(0, 13);
            this.textException.Multiline = true;
            this.textException.Name = "textException";
            this.textException.ReadOnly = true;
            this.textException.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textException.Size = new System.Drawing.Size(421, 301);
            this.textException.TabIndex = 5;
            // 
            // labelException
            // 
            this.labelException.AutoSize = true;
            this.labelException.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelException.Location = new System.Drawing.Point(0, 0);
            this.labelException.Name = "labelException";
            this.labelException.Size = new System.Drawing.Size(54, 13);
            this.labelException.TabIndex = 4;
            this.labelException.Text = "Exception";
            // 
            // splitterMessageHeight
            // 
            this.splitterMessageHeight.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitterMessageHeight.Location = new System.Drawing.Point(3, 209);
            this.splitterMessageHeight.Name = "splitterMessageHeight";
            this.splitterMessageHeight.Size = new System.Drawing.Size(421, 3);
            this.splitterMessageHeight.TabIndex = 5;
            this.splitterMessageHeight.TabStop = false;
            // 
            // textMessage
            // 
            this.textMessage.AcceptsReturn = true;
            this.textMessage.Dock = System.Windows.Forms.DockStyle.Top;
            this.textMessage.Location = new System.Drawing.Point(3, 59);
            this.textMessage.Multiline = true;
            this.textMessage.Name = "textMessage";
            this.textMessage.ReadOnly = true;
            this.textMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textMessage.Size = new System.Drawing.Size(421, 150);
            this.textMessage.TabIndex = 2;
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelMessage.Location = new System.Drawing.Point(3, 46);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(50, 13);
            this.labelMessage.TabIndex = 1;
            this.labelMessage.Text = "Message";
            // 
            // panelDetailsTop
            // 
            this.panelDetailsTop.Controls.Add(this.buttonOpenRecord);
            this.panelDetailsTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDetailsTop.Location = new System.Drawing.Point(3, 16);
            this.panelDetailsTop.Name = "panelDetailsTop";
            this.panelDetailsTop.Size = new System.Drawing.Size(421, 30);
            this.panelDetailsTop.TabIndex = 0;
            // 
            // buttonOpenRecord
            // 
            this.buttonOpenRecord.Location = new System.Drawing.Point(3, 3);
            this.buttonOpenRecord.Name = "buttonOpenRecord";
            this.buttonOpenRecord.Size = new System.Drawing.Size(87, 23);
            this.buttonOpenRecord.TabIndex = 0;
            this.buttonOpenRecord.Text = "Open in CRM";
            this.buttonOpenRecord.UseVisualStyleBackColor = true;
            this.buttonOpenRecord.Click += new System.EventHandler(this.buttonOpenRecord_Click);
            // 
            // splitterDetailsWidth
            // 
            this.splitterDetailsWidth.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitterDetailsWidth.Location = new System.Drawing.Point(825, 25);
            this.splitterDetailsWidth.Name = "splitterDetailsWidth";
            this.splitterDetailsWidth.Size = new System.Drawing.Size(3, 529);
            this.splitterDetailsWidth.TabIndex = 29;
            this.splitterDetailsWidth.TabStop = false;
            // 
            // PluginTraceViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelData);
            this.Controls.Add(this.groupFilter);
            this.Controls.Add(this.splitterDetailsWidth);
            this.Controls.Add(this.groupDetails);
            this.Controls.Add(this.toolStripMain);
            this.Name = "PluginTraceViewer";
            this.Size = new System.Drawing.Size(1255, 554);
            this.ConnectionUpdated += new XrmToolBox.Extensibility.PluginControlBase.ConnectionUpdatedHandler(this.PluginTraceViewer_ConnectionUpdated);
            this.Load += new System.EventHandler(this.PluginTraceViewer_Load);
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.groupFilter.ResumeLayout(false);
            this.groupFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRecords)).EndInit();
            this.panelData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.crmGridView)).EndInit();
            this.groupDetails.ResumeLayout(false);
            this.groupDetails.PerformLayout();
            this.panelException.ResumeLayout(false);
            this.panelException.PerformLayout();
            this.panelDetailsTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripButton tsbCloseThisTab;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsbAbout;
        private Xrm.CRMWinForm.CRMGridView crmGridView;
        private System.Windows.Forms.GroupBox groupFilter;
        private System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.Panel panelDataTop;
        private System.Windows.Forms.GroupBox groupDetails;
        private System.Windows.Forms.Splitter splitterDetailsWidth;
        private System.Windows.Forms.Button buttonRetrieveLogs;
        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.CheckBox checkDateTo;
        private System.Windows.Forms.CheckBox checkDateFrom;
        private System.Windows.Forms.Splitter splitterMessageHeight;
        private System.Windows.Forms.TextBox textMessage;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Panel panelDetailsTop;
        private System.Windows.Forms.Panel panelException;
        private System.Windows.Forms.TextBox textException;
        private System.Windows.Forms.Label labelException;
        private System.Windows.Forms.DataGridViewTextBoxColumn performanceexecutionstarttime;
        private System.Windows.Forms.DataGridViewTextBoxColumn performanceexecutionduration;
        private System.Windows.Forms.DataGridViewTextBoxColumn operationtype;
        private System.Windows.Forms.DataGridViewTextBoxColumn typename;
        private System.Windows.Forms.DataGridViewTextBoxColumn depth;
        private System.Windows.Forms.DataGridViewTextBoxColumn mode;
        private System.Windows.Forms.DataGridViewTextBoxColumn messagename;
        private System.Windows.Forms.DataGridViewTextBoxColumn primaryentity;
        private System.Windows.Forms.DataGridViewTextBoxColumn exceptiondetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn messagebody;
        private System.Windows.Forms.Button buttonOpenRecord;
        private System.Windows.Forms.ComboBox comboPlugin;
        private System.Windows.Forms.CheckBox chkPlugin;
        private System.Windows.Forms.ComboBox comboMessage;
        private System.Windows.Forms.CheckBox chkMessage;
        private System.Windows.Forms.RadioButton rbModeAsync;
        private System.Windows.Forms.RadioButton rbModeSync;
        private System.Windows.Forms.RadioButton rbModeAll;
        private System.Windows.Forms.CheckBox chkExceptions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numRecords;
    }
}