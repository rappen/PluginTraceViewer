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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PluginTraceViewer));
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.tsbCloseThisTab = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbAbout = new System.Windows.Forms.ToolStripButton();
            this.buttonOpen = new System.Windows.Forms.ToolStripDropDownButton();
            this.buttonOpenFilter = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.buttonOpenLogRecord = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonOpenFXB = new System.Windows.Forms.ToolStripMenuItem();
            this.dropdownSave = new System.Windows.Forms.ToolStripDropDownButton();
            this.buttonSaveFilter = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonSaveLogs = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonSaveQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.buttonRetrieveLogs = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.hejToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.buttonShowHideFilter = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.buttonRefreshFilter = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.comboLogSetting = new System.Windows.Forms.ToolStripComboBox();
            this.groupFilter = new System.Windows.Forms.GroupBox();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
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
            this.chkExceptionSummary = new System.Windows.Forms.CheckBox();
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
            this.exceptionsummary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.messagebody = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuGridView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiDeleteSelected = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeleteAll = new System.Windows.Forms.ToolStripMenuItem();
            this.panelDataTop = new System.Windows.Forms.Panel();
            this.labelInfo = new System.Windows.Forms.Label();
            this.labelMessage = new System.Windows.Forms.Label();
            this.chkWordWrap = new System.Windows.Forms.CheckBox();
            this.splitContainerRight = new System.Windows.Forms.SplitContainer();
            this.textMessage = new System.Windows.Forms.TextBox();
            this.panelMessageLabel = new System.Windows.Forms.Panel();
            this.textException = new System.Windows.Forms.TextBox();
            this.panelExceptionLabel = new System.Windows.Forms.Panel();
            this.labelException = new System.Windows.Forms.Label();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.toolStripMain.SuspendLayout();
            this.groupFilter.SuspendLayout();
            this.panelFilter.SuspendLayout();
            this.panelOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDurationMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDurationMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRecords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crmGridView)).BeginInit();
            this.contextMenuGridView.SuspendLayout();
            this.panelDataTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRight)).BeginInit();
            this.splitContainerRight.Panel1.SuspendLayout();
            this.splitContainerRight.Panel2.SuspendLayout();
            this.splitContainerRight.SuspendLayout();
            this.panelMessageLabel.SuspendLayout();
            this.panelExceptionLabel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMain
            // 
            this.toolStripMain.AutoSize = false;
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbCloseThisTab,
            this.toolStripSeparator4,
            this.tsbAbout,
            this.buttonOpen,
            this.dropdownSave,
            this.toolStripSeparator3,
            this.buttonRetrieveLogs,
            this.toolStripDropDownButton1,
            this.toolStripSeparator1,
            this.buttonShowHideFilter,
            this.toolStripSeparator2,
            this.buttonRefreshFilter,
            this.toolStripSeparator6,
            this.toolStripLabel1,
            this.comboLogSetting});
            this.toolStripMain.Location = new System.Drawing.Point(0, 0);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(1114, 25);
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
            // buttonOpen
            // 
            this.buttonOpen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonOpenFilter,
            this.toolStripSeparator5,
            this.buttonOpenLogRecord,
            this.buttonOpenFXB});
            this.buttonOpen.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpen.Image")));
            this.buttonOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(65, 22);
            this.buttonOpen.Text = "Open";
            // 
            // buttonOpenFilter
            // 
            this.buttonOpenFilter.Name = "buttonOpenFilter";
            this.buttonOpenFilter.Size = new System.Drawing.Size(224, 22);
            this.buttonOpenFilter.Text = "Filter...";
            this.buttonOpenFilter.Click += new System.EventHandler(this.buttonOpenFilter_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(221, 6);
            // 
            // buttonOpenLogRecord
            // 
            this.buttonOpenLogRecord.Enabled = false;
            this.buttonOpenLogRecord.Name = "buttonOpenLogRecord";
            this.buttonOpenLogRecord.Size = new System.Drawing.Size(224, 22);
            this.buttonOpenLogRecord.Text = "Selected log record in CRM";
            this.buttonOpenLogRecord.Click += new System.EventHandler(this.buttonOpenLogRecord_Click);
            // 
            // buttonOpenFXB
            // 
            this.buttonOpenFXB.Name = "buttonOpenFXB";
            this.buttonOpenFXB.Size = new System.Drawing.Size(224, 22);
            this.buttonOpenFXB.Text = "Query in FetchXML Builder...";
            this.buttonOpenFXB.Click += new System.EventHandler(this.buttonOpenFXB_Click);
            // 
            // dropdownSave
            // 
            this.dropdownSave.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonSaveFilter,
            this.buttonSaveLogs,
            this.buttonSaveQuery});
            this.dropdownSave.Image = ((System.Drawing.Image)(resources.GetObject("dropdownSave.Image")));
            this.dropdownSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.dropdownSave.Name = "dropdownSave";
            this.dropdownSave.Size = new System.Drawing.Size(60, 22);
            this.dropdownSave.Text = "Save";
            // 
            // buttonSaveFilter
            // 
            this.buttonSaveFilter.Name = "buttonSaveFilter";
            this.buttonSaveFilter.Size = new System.Drawing.Size(115, 22);
            this.buttonSaveFilter.Text = "Filter...";
            this.buttonSaveFilter.Click += new System.EventHandler(this.buttonSaveFilter_Click);
            // 
            // buttonSaveLogs
            // 
            this.buttonSaveLogs.Name = "buttonSaveLogs";
            this.buttonSaveLogs.Size = new System.Drawing.Size(115, 22);
            this.buttonSaveLogs.Text = "Logs...";
            this.buttonSaveLogs.Click += new System.EventHandler(this.buttonSaveLogs_Click);
            // 
            // buttonSaveQuery
            // 
            this.buttonSaveQuery.Name = "buttonSaveQuery";
            this.buttonSaveQuery.Size = new System.Drawing.Size(115, 22);
            this.buttonSaveQuery.Text = "Query...";
            this.buttonSaveQuery.Click += new System.EventHandler(this.buttonSaveQuery_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // buttonRetrieveLogs
            // 
            this.buttonRetrieveLogs.Enabled = false;
            this.buttonRetrieveLogs.Image = ((System.Drawing.Image)(resources.GetObject("buttonRetrieveLogs.Image")));
            this.buttonRetrieveLogs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonRetrieveLogs.Name = "buttonRetrieveLogs";
            this.buttonRetrieveLogs.Size = new System.Drawing.Size(120, 22);
            this.buttonRetrieveLogs.Text = "Retrieve Logs (F5)";
            this.buttonRetrieveLogs.Click += new System.EventHandler(this.buttonRetrieveLogs_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hejToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Visible = false;
            // 
            // hejToolStripMenuItem
            // 
            this.hejToolStripMenuItem.Name = "hejToolStripMenuItem";
            this.hejToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.hejToolStripMenuItem.Size = new System.Drawing.Size(303, 22);
            this.hejToolStripMenuItem.Text = "HiddenRetrieveButton used for shortcut";
            this.hejToolStripMenuItem.Click += new System.EventHandler(this.buttonRetrieveLogs_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // buttonShowHideFilter
            // 
            this.buttonShowHideFilter.CheckOnClick = true;
            this.buttonShowHideFilter.Image = ((System.Drawing.Image)(resources.GetObject("buttonShowHideFilter.Image")));
            this.buttonShowHideFilter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonShowHideFilter.Name = "buttonShowHideFilter";
            this.buttonShowHideFilter.Size = new System.Drawing.Size(81, 22);
            this.buttonShowHideFilter.Text = "Hide Filter";
            this.buttonShowHideFilter.ToolTipText = "Click this button to toggle the Filter panel";
            this.buttonShowHideFilter.Click += new System.EventHandler(this.buttonShowHideFilter_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // buttonRefreshFilter
            // 
            this.buttonRefreshFilter.Enabled = false;
            this.buttonRefreshFilter.Image = ((System.Drawing.Image)(resources.GetObject("buttonRefreshFilter.Image")));
            this.buttonRefreshFilter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonRefreshFilter.Name = "buttonRefreshFilter";
            this.buttonRefreshFilter.Size = new System.Drawing.Size(140, 22);
            this.buttonRefreshFilter.Text = "Refresh Filter Options";
            this.buttonRefreshFilter.Click += new System.EventHandler(this.buttonRefreshFilter_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(98, 22);
            this.toolStripLabel1.Text = "Trace Log Setting";
            // 
            // comboLogSetting
            // 
            this.comboLogSetting.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLogSetting.Items.AddRange(new object[] {
            "Off",
            "Exception",
            "All"});
            this.comboLogSetting.Name = "comboLogSetting";
            this.comboLogSetting.Size = new System.Drawing.Size(121, 25);
            this.comboLogSetting.SelectedIndexChanged += new System.EventHandler(this.comboLogSetting_SelectedIndexChanged);
            // 
            // groupFilter
            // 
            this.groupFilter.Controls.Add(this.panelFilter);
            this.groupFilter.Controls.Add(this.panelOptions);
            this.groupFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupFilter.Location = new System.Drawing.Point(0, 0);
            this.groupFilter.Name = "groupFilter";
            this.groupFilter.Size = new System.Drawing.Size(617, 142);
            this.groupFilter.TabIndex = 26;
            this.groupFilter.TabStop = false;
            this.groupFilter.Text = "Filter";
            // 
            // panelFilter
            // 
            this.panelFilter.Controls.Add(this.label1);
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
            this.panelFilter.Location = new System.Drawing.Point(3, 16);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Size = new System.Drawing.Size(348, 123);
            this.panelFilter.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Note: Times in UTC";
            // 
            // comboEntity
            // 
            this.comboEntity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboEntity.Enabled = false;
            this.comboEntity.FormattingEnabled = true;
            this.comboEntity.Location = new System.Drawing.Point(84, 96);
            this.comboEntity.Name = "comboEntity";
            this.comboEntity.Size = new System.Drawing.Size(257, 21);
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
            this.comboMessage.Location = new System.Drawing.Point(84, 72);
            this.comboMessage.Name = "comboMessage";
            this.comboMessage.Size = new System.Drawing.Size(257, 21);
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
            this.comboPlugin.Location = new System.Drawing.Point(84, 48);
            this.comboPlugin.Name = "comboPlugin";
            this.comboPlugin.Size = new System.Drawing.Size(257, 21);
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
            this.dateTo.Location = new System.Drawing.Point(84, 24);
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
            this.dateFrom.Location = new System.Drawing.Point(84, 0);
            this.dateFrom.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dateFrom.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(130, 20);
            this.dateFrom.TabIndex = 2;
            // 
            // panelOptions
            // 
            this.panelOptions.Controls.Add(this.chkExceptionSummary);
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
            this.panelOptions.Location = new System.Drawing.Point(351, 16);
            this.panelOptions.Name = "panelOptions";
            this.panelOptions.Size = new System.Drawing.Size(263, 123);
            this.panelOptions.TabIndex = 2;
            // 
            // chkExceptionSummary
            // 
            this.chkExceptionSummary.AutoSize = true;
            this.chkExceptionSummary.Checked = true;
            this.chkExceptionSummary.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkExceptionSummary.Location = new System.Drawing.Point(158, 3);
            this.chkExceptionSummary.Name = "chkExceptionSummary";
            this.chkExceptionSummary.Size = new System.Drawing.Size(97, 17);
            this.chkExceptionSummary.TabIndex = 11;
            this.chkExceptionSummary.Text = "Show summary";
            this.chkExceptionSummary.UseVisualStyleBackColor = true;
            // 
            // chkRecords
            // 
            this.chkRecords.AutoSize = true;
            this.chkRecords.Checked = true;
            this.chkRecords.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRecords.Location = new System.Drawing.Point(3, 98);
            this.chkRecords.Name = "chkRecords";
            this.chkRecords.Size = new System.Drawing.Size(91, 17);
            this.chkRecords.TabIndex = 9;
            this.chkRecords.Text = "Record count";
            this.chkRecords.UseVisualStyleBackColor = true;
            this.chkRecords.CheckedChanged += new System.EventHandler(this.chkRecords_CheckedChanged);
            // 
            // chkDurationMax
            // 
            this.chkDurationMax.AutoSize = true;
            this.chkDurationMax.Location = new System.Drawing.Point(3, 74);
            this.chkDurationMax.Name = "chkDurationMax";
            this.chkDurationMax.Size = new System.Drawing.Size(89, 17);
            this.chkDurationMax.TabIndex = 7;
            this.chkDurationMax.Text = "Duration Max";
            this.chkDurationMax.UseVisualStyleBackColor = true;
            this.chkDurationMax.CheckedChanged += new System.EventHandler(this.chkDurationMax_CheckedChanged);
            // 
            // chkDurationMin
            // 
            this.chkDurationMin.AutoSize = true;
            this.chkDurationMin.Location = new System.Drawing.Point(3, 50);
            this.chkDurationMin.Name = "chkDurationMin";
            this.chkDurationMin.Size = new System.Drawing.Size(86, 17);
            this.chkDurationMin.TabIndex = 5;
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
            this.numDurationMax.Location = new System.Drawing.Point(158, 73);
            this.numDurationMax.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numDurationMax.Name = "numDurationMax";
            this.numDurationMax.Size = new System.Drawing.Size(76, 20);
            this.numDurationMax.TabIndex = 8;
            // 
            // numDurationMin
            // 
            this.numDurationMin.Enabled = false;
            this.numDurationMin.Increment = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numDurationMin.Location = new System.Drawing.Point(158, 49);
            this.numDurationMin.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numDurationMin.Name = "numDurationMin";
            this.numDurationMin.Size = new System.Drawing.Size(76, 20);
            this.numDurationMin.TabIndex = 6;
            // 
            // numRecords
            // 
            this.numRecords.Increment = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numRecords.Location = new System.Drawing.Point(158, 97);
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
            this.numRecords.TabIndex = 10;
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
            this.rbModeAsync.Location = new System.Drawing.Point(158, 25);
            this.rbModeAsync.Name = "rbModeAsync";
            this.rbModeAsync.Size = new System.Drawing.Size(76, 17);
            this.rbModeAsync.TabIndex = 4;
            this.rbModeAsync.TabStop = true;
            this.rbModeAsync.Text = "Async only";
            this.rbModeAsync.UseVisualStyleBackColor = true;
            // 
            // rbModeSync
            // 
            this.rbModeSync.AutoSize = true;
            this.rbModeSync.Location = new System.Drawing.Point(80, 25);
            this.rbModeSync.Name = "rbModeSync";
            this.rbModeSync.Size = new System.Drawing.Size(71, 17);
            this.rbModeSync.TabIndex = 3;
            this.rbModeSync.TabStop = true;
            this.rbModeSync.Text = "Sync only";
            this.rbModeSync.UseVisualStyleBackColor = true;
            // 
            // rbModeAll
            // 
            this.rbModeAll.AutoSize = true;
            this.rbModeAll.Checked = true;
            this.rbModeAll.Location = new System.Drawing.Point(3, 25);
            this.rbModeAll.Name = "rbModeAll";
            this.rbModeAll.Size = new System.Drawing.Size(70, 17);
            this.rbModeAll.TabIndex = 2;
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
            // crmGridView
            // 
            this.crmGridView.AllowUserToAddRows = false;
            this.crmGridView.AllowUserToDeleteRows = false;
            this.crmGridView.AllowUserToOrderColumns = true;
            this.crmGridView.AllowUserToResizeRows = false;
            this.crmGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
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
            this.exceptionsummary,
            this.messagebody});
            this.crmGridView.ContextMenuStrip = this.contextMenuGridView;
            this.crmGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crmGridView.EnableHeadersVisualStyles = false;
            this.crmGridView.Location = new System.Drawing.Point(0, 167);
            this.crmGridView.Name = "crmGridView";
            this.crmGridView.ReadOnly = true;
            this.crmGridView.RowHeadersWidth = 20;
            this.crmGridView.ShowFriendlyNames = true;
            this.crmGridView.ShowIdColumn = false;
            this.crmGridView.ShowIndexColumn = false;
            this.crmGridView.Size = new System.Drawing.Size(617, 288);
            this.crmGridView.TabIndex = 25;
            this.crmGridView.RecordDoubleClick += new Cinteros.Xrm.CRMWinForm.CRMRecordEventHandler(this.crmGridView_RecordDoubleClick);
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
            // exceptionsummary
            // 
            this.exceptionsummary.HeaderText = "Exception Summary";
            this.exceptionsummary.Name = "exceptionsummary";
            this.exceptionsummary.ReadOnly = true;
            this.exceptionsummary.Visible = false;
            // 
            // messagebody
            // 
            this.messagebody.HeaderText = "Trace Log";
            this.messagebody.Name = "messagebody";
            this.messagebody.ReadOnly = true;
            this.messagebody.Visible = false;
            this.messagebody.Width = 75;
            // 
            // contextMenuGridView
            // 
            this.contextMenuGridView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDeleteSelected,
            this.tsmiDeleteAll});
            this.contextMenuGridView.Name = "contextStripMain";
            this.contextMenuGridView.Size = new System.Drawing.Size(155, 48);
            this.contextMenuGridView.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuGridView_Opening);
            // 
            // tsmiDeleteSelected
            // 
            this.tsmiDeleteSelected.Name = "tsmiDeleteSelected";
            this.tsmiDeleteSelected.Size = new System.Drawing.Size(154, 22);
            this.tsmiDeleteSelected.Text = "Delete Selected";
            this.tsmiDeleteSelected.Click += new System.EventHandler(this.tsmiDeleteSelected_Click);
            // 
            // tsmiDeleteAll
            // 
            this.tsmiDeleteAll.Name = "tsmiDeleteAll";
            this.tsmiDeleteAll.Size = new System.Drawing.Size(154, 22);
            this.tsmiDeleteAll.Text = "Delete All...";
            this.tsmiDeleteAll.Click += new System.EventHandler(this.tsmiDeleteAll_Click);
            // 
            // panelDataTop
            // 
            this.panelDataTop.Controls.Add(this.labelInfo);
            this.panelDataTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDataTop.Location = new System.Drawing.Point(0, 142);
            this.panelDataTop.Name = "panelDataTop";
            this.panelDataTop.Size = new System.Drawing.Size(617, 25);
            this.panelDataTop.TabIndex = 26;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(4, 4);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(182, 13);
            this.labelInfo.TabIndex = 0;
            this.labelInfo.Text = "Select filter criteria and Retrieve logs!";
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(4, 4);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(52, 13);
            this.labelMessage.TabIndex = 8;
            this.labelMessage.Text = "Trace log";
            // 
            // chkWordWrap
            // 
            this.chkWordWrap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkWordWrap.AutoSize = true;
            this.chkWordWrap.Location = new System.Drawing.Point(414, 3);
            this.chkWordWrap.Name = "chkWordWrap";
            this.chkWordWrap.Size = new System.Drawing.Size(72, 17);
            this.chkWordWrap.TabIndex = 7;
            this.chkWordWrap.Text = "Wrap text";
            this.chkWordWrap.UseVisualStyleBackColor = true;
            this.chkWordWrap.CheckedChanged += new System.EventHandler(this.checkWordWrap_CheckedChanged);
            // 
            // splitContainerRight
            // 
            this.splitContainerRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerRight.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainerRight.Location = new System.Drawing.Point(0, 0);
            this.splitContainerRight.Name = "splitContainerRight";
            this.splitContainerRight.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerRight.Panel1
            // 
            this.splitContainerRight.Panel1.Controls.Add(this.textMessage);
            this.splitContainerRight.Panel1.Controls.Add(this.panelMessageLabel);
            this.splitContainerRight.Panel1MinSize = 23;
            // 
            // splitContainerRight.Panel2
            // 
            this.splitContainerRight.Panel2.Controls.Add(this.textException);
            this.splitContainerRight.Panel2.Controls.Add(this.panelExceptionLabel);
            this.splitContainerRight.Panel2MinSize = 23;
            this.splitContainerRight.Size = new System.Drawing.Size(489, 455);
            this.splitContainerRight.SplitterDistance = 230;
            this.splitContainerRight.SplitterWidth = 8;
            this.splitContainerRight.TabIndex = 12;
            // 
            // textMessage
            // 
            this.textMessage.AcceptsReturn = true;
            this.textMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textMessage.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMessage.Location = new System.Drawing.Point(0, 25);
            this.textMessage.MinimumSize = new System.Drawing.Size(4, 100);
            this.textMessage.Multiline = true;
            this.textMessage.Name = "textMessage";
            this.textMessage.ReadOnly = true;
            this.textMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textMessage.Size = new System.Drawing.Size(489, 205);
            this.textMessage.TabIndex = 10;
            this.textMessage.WordWrap = false;
            // 
            // panelMessageLabel
            // 
            this.panelMessageLabel.Controls.Add(this.chkWordWrap);
            this.panelMessageLabel.Controls.Add(this.labelMessage);
            this.panelMessageLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMessageLabel.Location = new System.Drawing.Point(0, 0);
            this.panelMessageLabel.Name = "panelMessageLabel";
            this.panelMessageLabel.Size = new System.Drawing.Size(489, 25);
            this.panelMessageLabel.TabIndex = 11;
            // 
            // textException
            // 
            this.textException.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textException.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textException.Location = new System.Drawing.Point(0, 25);
            this.textException.Multiline = true;
            this.textException.Name = "textException";
            this.textException.ReadOnly = true;
            this.textException.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textException.Size = new System.Drawing.Size(489, 192);
            this.textException.TabIndex = 6;
            this.textException.WordWrap = false;
            // 
            // panelExceptionLabel
            // 
            this.panelExceptionLabel.Controls.Add(this.labelException);
            this.panelExceptionLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelExceptionLabel.Location = new System.Drawing.Point(0, 0);
            this.panelExceptionLabel.Name = "panelExceptionLabel";
            this.panelExceptionLabel.Size = new System.Drawing.Size(489, 25);
            this.panelExceptionLabel.TabIndex = 8;
            // 
            // labelException
            // 
            this.labelException.AutoSize = true;
            this.labelException.Location = new System.Drawing.Point(4, 4);
            this.labelException.Name = "labelException";
            this.labelException.Size = new System.Drawing.Size(54, 13);
            this.labelException.TabIndex = 7;
            this.labelException.Text = "Exception";
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 25);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.crmGridView);
            this.splitContainerMain.Panel1.Controls.Add(this.panelDataTop);
            this.splitContainerMain.Panel1.Controls.Add(this.groupFilter);
            this.splitContainerMain.Panel1MinSize = 100;
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.splitContainerRight);
            this.splitContainerMain.Panel2MinSize = 100;
            this.splitContainerMain.Size = new System.Drawing.Size(1114, 455);
            this.splitContainerMain.SplitterDistance = 617;
            this.splitContainerMain.SplitterWidth = 8;
            this.splitContainerMain.TabIndex = 31;
            // 
            // PluginTraceViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerMain);
            this.Controls.Add(this.toolStripMain);
            this.Name = "PluginTraceViewer";
            this.Size = new System.Drawing.Size(1114, 480);
            this.ConnectionUpdated += new XrmToolBox.Extensibility.PluginControlBase.ConnectionUpdatedHandler(this.PluginTraceViewer_ConnectionUpdated);
            this.Load += new System.EventHandler(this.PluginTraceViewer_Load);
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.groupFilter.ResumeLayout(false);
            this.panelFilter.ResumeLayout(false);
            this.panelFilter.PerformLayout();
            this.panelOptions.ResumeLayout(false);
            this.panelOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDurationMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDurationMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRecords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crmGridView)).EndInit();
            this.contextMenuGridView.ResumeLayout(false);
            this.panelDataTop.ResumeLayout(false);
            this.panelDataTop.PerformLayout();
            this.splitContainerRight.Panel1.ResumeLayout(false);
            this.splitContainerRight.Panel1.PerformLayout();
            this.splitContainerRight.Panel2.ResumeLayout(false);
            this.splitContainerRight.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRight)).EndInit();
            this.splitContainerRight.ResumeLayout(false);
            this.panelMessageLabel.ResumeLayout(false);
            this.panelMessageLabel.PerformLayout();
            this.panelExceptionLabel.ResumeLayout(false);
            this.panelExceptionLabel.PerformLayout();
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripButton tsbCloseThisTab;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsbAbout;
        private Xrm.CRMWinForm.CRMGridView crmGridView;
        private System.Windows.Forms.GroupBox groupFilter;
        private System.Windows.Forms.Panel panelDataTop;
        private System.Windows.Forms.Panel panelOptions;
        private System.Windows.Forms.NumericUpDown numRecords;
        private System.Windows.Forms.RadioButton rbModeAsync;
        private System.Windows.Forms.RadioButton rbModeSync;
        private System.Windows.Forms.RadioButton rbModeAll;
        private System.Windows.Forms.CheckBox chkExceptions;
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.ComboBox comboMessage;
        private System.Windows.Forms.CheckBox chkMessage;
        private System.Windows.Forms.ComboBox comboPlugin;
        private System.Windows.Forms.CheckBox chkPlugin;
        private System.Windows.Forms.CheckBox checkDateTo;
        private System.Windows.Forms.CheckBox checkDateFrom;
        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.ComboBox comboEntity;
        private System.Windows.Forms.CheckBox chkEntity;
        private System.Windows.Forms.NumericUpDown numDurationMax;
        private System.Windows.Forms.NumericUpDown numDurationMin;
        private System.Windows.Forms.CheckBox chkRecords;
        private System.Windows.Forms.CheckBox chkDurationMax;
        private System.Windows.Forms.CheckBox chkDurationMin;
        private System.Windows.Forms.ToolStripButton buttonRetrieveLogs;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem hejToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton buttonShowHideFilter;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton buttonRefreshFilter;
        private System.Windows.Forms.ToolStripDropDownButton dropdownSave;
        private System.Windows.Forms.ToolStripMenuItem buttonSaveFilter;
        private System.Windows.Forms.ToolStripMenuItem buttonSaveLogs;
        private System.Windows.Forms.ToolStripDropDownButton buttonOpen;
        private System.Windows.Forms.ToolStripMenuItem buttonOpenFilter;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem buttonOpenLogRecord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuGridView;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeleteSelected;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeleteAll;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.CheckBox chkWordWrap;
        private System.Windows.Forms.SplitContainer splitContainerRight;
        private System.Windows.Forms.TextBox textMessage;
        private System.Windows.Forms.Panel panelExceptionLabel;
        private System.Windows.Forms.Label labelException;
        private System.Windows.Forms.TextBox textException;
        private System.Windows.Forms.Panel panelMessageLabel;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.ToolStripMenuItem buttonOpenFXB;
        private System.Windows.Forms.ToolStripMenuItem buttonSaveQuery;
        private System.Windows.Forms.CheckBox chkExceptionSummary;
        private System.Windows.Forms.DataGridViewTextBoxColumn performanceexecutionstarttime;
        private System.Windows.Forms.DataGridViewTextBoxColumn performanceexecutionduration;
        private System.Windows.Forms.DataGridViewTextBoxColumn operationtype;
        private System.Windows.Forms.DataGridViewTextBoxColumn typename;
        private System.Windows.Forms.DataGridViewTextBoxColumn depth;
        private System.Windows.Forms.DataGridViewTextBoxColumn mode;
        private System.Windows.Forms.DataGridViewTextBoxColumn messagename;
        private System.Windows.Forms.DataGridViewTextBoxColumn primaryentity;
        private System.Windows.Forms.DataGridViewTextBoxColumn exceptiondetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn exceptionsummary;
        private System.Windows.Forms.DataGridViewTextBoxColumn messagebody;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox comboLogSetting;
    }
}
