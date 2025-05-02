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
            this.components = new System.ComponentModel.Container();
            Rappen.XTB.Helpers.Controls.CheckCombo.CheckBoxProperties checkBoxProperties1 = new Rappen.XTB.Helpers.Controls.CheckCombo.CheckBoxProperties();
            Rappen.XTB.Helpers.Controls.CheckCombo.CheckBoxProperties checkBoxProperties2 = new Rappen.XTB.Helpers.Controls.CheckCombo.CheckBoxProperties();
            Rappen.XTB.Helpers.Controls.CheckCombo.CheckBoxProperties checkBoxProperties3 = new Rappen.XTB.Helpers.Controls.CheckCombo.CheckBoxProperties();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.chkFreeExceptions = new System.Windows.Forms.CheckBox();
            this.textFreeTextFilter = new System.Windows.Forms.TextBox();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.chkFreeMessage = new System.Windows.Forms.CheckBox();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.llToDate = new System.Windows.Forms.LinkLabel();
            this.llFromDate = new System.Windows.Forms.LinkLabel();
            this.textCorrelationId = new System.Windows.Forms.TextBox();
            this.chkCorrelation = new System.Windows.Forms.CheckBox();
            this.textRequestId = new System.Windows.Forms.TextBox();
            this.chkRequestId = new System.Windows.Forms.CheckBox();
            this.labelTimeZone = new System.Windows.Forms.Label();
            this.comboEntity = new Rappen.XTB.Helpers.Controls.CheckCombo.CheckBoxComboBox();
            this.chkEntity = new System.Windows.Forms.CheckBox();
            this.comboMessage = new Rappen.XTB.Helpers.Controls.CheckCombo.CheckBoxComboBox();
            this.chkMessage = new System.Windows.Forms.CheckBox();
            this.comboPlugin = new Rappen.XTB.Helpers.Controls.CheckCombo.CheckBoxComboBox();
            this.chkPlugin = new System.Windows.Forms.CheckBox();
            this.checkDateTo = new System.Windows.Forms.CheckBox();
            this.checkDateFrom = new System.Windows.Forms.CheckBox();
            this.panelOptions = new System.Windows.Forms.Panel();
            this.numDurationMin = new System.Windows.Forms.NumericUpDown();
            this.numRecords = new System.Windows.Forms.NumericUpDown();
            this.chkRecords = new System.Windows.Forms.CheckBox();
            this.numDurationMax = new System.Windows.Forms.NumericUpDown();
            this.chkDurationMax = new System.Windows.Forms.CheckBox();
            this.chkDurationMin = new System.Windows.Forms.CheckBox();
            this.linkLabel6 = new System.Windows.Forms.LinkLabel();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.chkStage30 = new System.Windows.Forms.CheckBox();
            this.chkOperWF = new System.Windows.Forms.CheckBox();
            this.chkOperPlugins = new System.Windows.Forms.CheckBox();
            this.chkModeAsync = new System.Windows.Forms.CheckBox();
            this.chkModeSync = new System.Windows.Forms.CheckBox();
            this.chkStage40 = new System.Windows.Forms.CheckBox();
            this.chkStage20 = new System.Windows.Forms.CheckBox();
            this.chkStage10 = new System.Windows.Forms.CheckBox();
            this.chkExceptions = new System.Windows.Forms.CheckBox();
            this.dateMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dateMenuNow = new System.Windows.Forms.ToolStripMenuItem();
            this.dateMenuToday = new System.Windows.Forms.ToolStripMenuItem();
            this.dateMenuFirst = new System.Windows.Forms.ToolStripMenuItem();
            this.dateMenuLast = new System.Windows.Forms.ToolStripMenuItem();
            this.panelFilter.SuspendLayout();
            this.panelOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDurationMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRecords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDurationMax)).BeginInit();
            this.dateMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFilter
            // 
            this.panelFilter.Controls.Add(this.chkFreeExceptions);
            this.panelFilter.Controls.Add(this.textFreeTextFilter);
            this.panelFilter.Controls.Add(this.dateTo);
            this.panelFilter.Controls.Add(this.chkFreeMessage);
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
            this.panelFilter.Size = new System.Drawing.Size(652, 174);
            this.panelFilter.TabIndex = 1;
            // 
            // chkFreeExceptions
            // 
            this.chkFreeExceptions.AutoSize = true;
            this.chkFreeExceptions.Location = new System.Drawing.Point(49, 150);
            this.chkFreeExceptions.Name = "chkFreeExceptions";
            this.chkFreeExceptions.Size = new System.Drawing.Size(47, 17);
            this.chkFreeExceptions.TabIndex = 18;
            this.chkFreeExceptions.Text = "Exc.";
            this.chkFreeExceptions.UseVisualStyleBackColor = true;
            this.chkFreeExceptions.CheckedChanged += new System.EventHandler(this.chkFreeMsgExc_CheckedChanged);
            // 
            // textFreeTextFilter
            // 
            this.textFreeTextFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textFreeTextFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textFreeTextFilter.Enabled = false;
            this.textFreeTextFilter.Location = new System.Drawing.Point(97, 148);
            this.textFreeTextFilter.Name = "textFreeTextFilter";
            this.textFreeTextFilter.Size = new System.Drawing.Size(548, 20);
            this.textFreeTextFilter.TabIndex = 19;
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
            // chkFreeMessage
            // 
            this.chkFreeMessage.AutoSize = true;
            this.chkFreeMessage.Location = new System.Drawing.Point(3, 150);
            this.chkFreeMessage.Name = "chkFreeMessage";
            this.chkFreeMessage.Size = new System.Drawing.Size(46, 17);
            this.chkFreeMessage.TabIndex = 17;
            this.chkFreeMessage.Text = "Msg";
            this.chkFreeMessage.UseVisualStyleBackColor = true;
            this.chkFreeMessage.CheckedChanged += new System.EventHandler(this.chkFreeMsgExc_CheckedChanged);
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
            this.textCorrelationId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textCorrelationId.Enabled = false;
            this.textCorrelationId.Location = new System.Drawing.Point(97, 100);
            this.textCorrelationId.Name = "textCorrelationId";
            this.textCorrelationId.Size = new System.Drawing.Size(548, 20);
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
            this.textRequestId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textRequestId.Enabled = false;
            this.textRequestId.Location = new System.Drawing.Point(97, 124);
            this.textRequestId.Name = "textRequestId";
            this.textRequestId.Size = new System.Drawing.Size(548, 20);
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
            checkBoxProperties1.AutoSize = true;
            checkBoxProperties1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.comboEntity.CheckBoxProperties = checkBoxProperties1;
            this.comboEntity.DisplayMemberSingleItem = "";
            this.comboEntity.Enabled = false;
            this.comboEntity.FormattingEnabled = true;
            this.comboEntity.Location = new System.Drawing.Point(97, 76);
            this.comboEntity.Name = "comboEntity";
            this.comboEntity.Size = new System.Drawing.Size(548, 21);
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
            checkBoxProperties2.AutoSize = true;
            checkBoxProperties2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.comboMessage.CheckBoxProperties = checkBoxProperties2;
            this.comboMessage.DisplayMemberSingleItem = "";
            this.comboMessage.Enabled = false;
            this.comboMessage.FormattingEnabled = true;
            this.comboMessage.Location = new System.Drawing.Point(97, 52);
            this.comboMessage.Name = "comboMessage";
            this.comboMessage.Size = new System.Drawing.Size(548, 21);
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
            checkBoxProperties3.AutoSize = true;
            checkBoxProperties3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.comboPlugin.CheckBoxProperties = checkBoxProperties3;
            this.comboPlugin.DisplayMemberSingleItem = "";
            this.comboPlugin.Enabled = false;
            this.comboPlugin.FormattingEnabled = true;
            this.comboPlugin.Location = new System.Drawing.Point(97, 28);
            this.comboPlugin.Name = "comboPlugin";
            this.comboPlugin.Size = new System.Drawing.Size(548, 21);
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
            this.panelOptions.Controls.Add(this.numDurationMin);
            this.panelOptions.Controls.Add(this.numRecords);
            this.panelOptions.Controls.Add(this.chkRecords);
            this.panelOptions.Controls.Add(this.numDurationMax);
            this.panelOptions.Controls.Add(this.chkDurationMax);
            this.panelOptions.Controls.Add(this.chkDurationMin);
            this.panelOptions.Controls.Add(this.linkLabel6);
            this.panelOptions.Controls.Add(this.linkLabel5);
            this.panelOptions.Controls.Add(this.linkLabel4);
            this.panelOptions.Controls.Add(this.linkLabel3);
            this.panelOptions.Controls.Add(this.linkLabel2);
            this.panelOptions.Controls.Add(this.linkLabel1);
            this.panelOptions.Controls.Add(this.chkStage30);
            this.panelOptions.Controls.Add(this.chkOperWF);
            this.panelOptions.Controls.Add(this.chkOperPlugins);
            this.panelOptions.Controls.Add(this.chkModeAsync);
            this.panelOptions.Controls.Add(this.chkModeSync);
            this.panelOptions.Controls.Add(this.chkStage40);
            this.panelOptions.Controls.Add(this.chkStage20);
            this.panelOptions.Controls.Add(this.chkStage10);
            this.panelOptions.Controls.Add(this.chkExceptions);
            this.panelOptions.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelOptions.Location = new System.Drawing.Point(652, 0);
            this.panelOptions.Name = "panelOptions";
            this.panelOptions.Size = new System.Drawing.Size(330, 174);
            this.panelOptions.TabIndex = 2;
            // 
            // numDurationMin
            // 
            this.numDurationMin.Enabled = false;
            this.numDurationMin.Increment = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numDurationMin.Location = new System.Drawing.Point(122, 124);
            this.numDurationMin.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numDurationMin.Name = "numDurationMin";
            this.numDurationMin.Size = new System.Drawing.Size(69, 20);
            this.numDurationMin.TabIndex = 55;
            // 
            // numRecords
            // 
            this.numRecords.Increment = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numRecords.Location = new System.Drawing.Point(122, 148);
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
            this.numRecords.Size = new System.Drawing.Size(69, 20);
            this.numRecords.TabIndex = 65;
            this.numRecords.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // chkRecords
            // 
            this.chkRecords.AutoSize = true;
            this.chkRecords.Location = new System.Drawing.Point(81, 150);
            this.chkRecords.Name = "chkRecords";
            this.chkRecords.Size = new System.Drawing.Size(46, 17);
            this.chkRecords.TabIndex = 63;
            this.chkRecords.Text = "Max";
            this.chkRecords.UseVisualStyleBackColor = true;
            // 
            // numDurationMax
            // 
            this.numDurationMax.Enabled = false;
            this.numDurationMax.Increment = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numDurationMax.Location = new System.Drawing.Point(239, 124);
            this.numDurationMax.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numDurationMax.Name = "numDurationMax";
            this.numDurationMax.Size = new System.Drawing.Size(69, 20);
            this.numDurationMax.TabIndex = 59;
            // 
            // chkDurationMax
            // 
            this.chkDurationMax.AutoSize = true;
            this.chkDurationMax.Location = new System.Drawing.Point(198, 126);
            this.chkDurationMax.Name = "chkDurationMax";
            this.chkDurationMax.Size = new System.Drawing.Size(46, 17);
            this.chkDurationMax.TabIndex = 57;
            this.chkDurationMax.Text = "Max";
            this.chkDurationMax.UseVisualStyleBackColor = true;
            this.chkDurationMax.CheckedChanged += new System.EventHandler(this.chkDuration_CheckedChanged);
            // 
            // chkDurationMin
            // 
            this.chkDurationMin.AutoSize = true;
            this.chkDurationMin.Location = new System.Drawing.Point(81, 126);
            this.chkDurationMin.Name = "chkDurationMin";
            this.chkDurationMin.Size = new System.Drawing.Size(43, 17);
            this.chkDurationMin.TabIndex = 53;
            this.chkDurationMin.Text = "Min";
            this.chkDurationMin.UseVisualStyleBackColor = true;
            this.chkDurationMin.CheckedChanged += new System.EventHandler(this.chkDuration_CheckedChanged);
            // 
            // linkLabel6
            // 
            this.linkLabel6.AutoSize = true;
            this.linkLabel6.LinkArea = new System.Windows.Forms.LinkArea(0, 0);
            this.linkLabel6.Location = new System.Drawing.Point(6, 151);
            this.linkLabel6.Name = "linkLabel6";
            this.linkLabel6.Size = new System.Drawing.Size(60, 13);
            this.linkLabel6.TabIndex = 61;
            this.linkLabel6.Text = "Log counts";
            // 
            // linkLabel5
            // 
            this.linkLabel5.AutoSize = true;
            this.linkLabel5.LinkArea = new System.Windows.Forms.LinkArea(0, 0);
            this.linkLabel5.Location = new System.Drawing.Point(6, 126);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new System.Drawing.Size(69, 13);
            this.linkLabel5.TabIndex = 51;
            this.linkLabel5.Text = "Duration (ms)";
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Location = new System.Drawing.Point(6, 79);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(35, 13);
            this.linkLabel4.TabIndex = 40;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Tag = "https://learn.microsoft.com/en-us/power-apps/developer/data-platform/event-framew" +
    "ork#event-execution-pipeline";
            this.linkLabel4.Text = "Stage";
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(6, 55);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(34, 13);
            this.linkLabel3.TabIndex = 30;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Tag = "https://learn.microsoft.com/en-us/power-apps/developer/data-platform/event-framew" +
    "ork#asynchronous-plug-in-steps";
            this.linkLabel3.Text = "Mode";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(6, 31);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(53, 13);
            this.linkLabel2.TabIndex = 20;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Tag = "https://learn.microsoft.com/en-us/power-apps/developer/data-platform/reference/en" +
    "tities/plugintracelog#BKMK_OperationType";
            this.linkLabel2.Text = "Operation";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(6, 7);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(34, 13);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Tag = "https://learn.microsoft.com/en-us/power-apps/developer/data-platform/reference/en" +
    "tities/plugintracelog#BKMK_ExceptionDetails";
            this.linkLabel1.Text = "Errors";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
            // 
            // chkStage30
            // 
            this.chkStage30.AutoSize = true;
            this.chkStage30.Checked = true;
            this.chkStage30.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkStage30.Location = new System.Drawing.Point(198, 78);
            this.chkStage30.Name = "chkStage30";
            this.chkStage30.Size = new System.Drawing.Size(63, 17);
            this.chkStage30.TabIndex = 43;
            this.chkStage30.Text = "MainOp";
            this.chkStage30.UseVisualStyleBackColor = true;
            // 
            // chkOperWF
            // 
            this.chkOperWF.AutoSize = true;
            this.chkOperWF.Checked = true;
            this.chkOperWF.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkOperWF.Location = new System.Drawing.Point(198, 30);
            this.chkOperWF.Name = "chkOperWF";
            this.chkOperWF.Size = new System.Drawing.Size(88, 17);
            this.chkOperWF.TabIndex = 22;
            this.chkOperWF.Text = "WF Activities";
            this.chkOperWF.UseVisualStyleBackColor = true;
            // 
            // chkOperPlugins
            // 
            this.chkOperPlugins.AutoSize = true;
            this.chkOperPlugins.Checked = true;
            this.chkOperPlugins.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkOperPlugins.Location = new System.Drawing.Point(81, 30);
            this.chkOperPlugins.Name = "chkOperPlugins";
            this.chkOperPlugins.Size = new System.Drawing.Size(60, 17);
            this.chkOperPlugins.TabIndex = 21;
            this.chkOperPlugins.Text = "Plugins";
            this.chkOperPlugins.UseVisualStyleBackColor = true;
            // 
            // chkModeAsync
            // 
            this.chkModeAsync.AutoSize = true;
            this.chkModeAsync.Checked = true;
            this.chkModeAsync.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkModeAsync.Location = new System.Drawing.Point(198, 54);
            this.chkModeAsync.Name = "chkModeAsync";
            this.chkModeAsync.Size = new System.Drawing.Size(93, 17);
            this.chkModeAsync.TabIndex = 32;
            this.chkModeAsync.Text = "Asynchronous";
            this.chkModeAsync.UseVisualStyleBackColor = true;
            // 
            // chkModeSync
            // 
            this.chkModeSync.AutoSize = true;
            this.chkModeSync.Checked = true;
            this.chkModeSync.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkModeSync.Location = new System.Drawing.Point(81, 54);
            this.chkModeSync.Name = "chkModeSync";
            this.chkModeSync.Size = new System.Drawing.Size(88, 17);
            this.chkModeSync.TabIndex = 31;
            this.chkModeSync.Text = "Synchronous";
            this.chkModeSync.UseVisualStyleBackColor = true;
            // 
            // chkStage40
            // 
            this.chkStage40.AutoSize = true;
            this.chkStage40.Checked = true;
            this.chkStage40.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkStage40.Location = new System.Drawing.Point(263, 78);
            this.chkStage40.Name = "chkStage40";
            this.chkStage40.Size = new System.Drawing.Size(61, 17);
            this.chkStage40.TabIndex = 44;
            this.chkStage40.Text = "PostOp";
            this.chkStage40.UseVisualStyleBackColor = true;
            // 
            // chkStage20
            // 
            this.chkStage20.AutoSize = true;
            this.chkStage20.Checked = true;
            this.chkStage20.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkStage20.Location = new System.Drawing.Point(140, 78);
            this.chkStage20.Name = "chkStage20";
            this.chkStage20.Size = new System.Drawing.Size(56, 17);
            this.chkStage20.TabIndex = 42;
            this.chkStage20.Text = "PreOp";
            this.chkStage20.UseVisualStyleBackColor = true;
            // 
            // chkStage10
            // 
            this.chkStage10.AutoSize = true;
            this.chkStage10.Checked = true;
            this.chkStage10.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkStage10.Location = new System.Drawing.Point(81, 78);
            this.chkStage10.Name = "chkStage10";
            this.chkStage10.Size = new System.Drawing.Size(57, 17);
            this.chkStage10.TabIndex = 41;
            this.chkStage10.Text = "PreVal";
            this.chkStage10.UseVisualStyleBackColor = true;
            // 
            // chkExceptions
            // 
            this.chkExceptions.AutoSize = true;
            this.chkExceptions.Location = new System.Drawing.Point(81, 6);
            this.chkExceptions.Name = "chkExceptions";
            this.chkExceptions.Size = new System.Drawing.Size(100, 17);
            this.chkExceptions.TabIndex = 11;
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
            this.ClientSize = new System.Drawing.Size(982, 174);
            this.Controls.Add(this.panelFilter);
            this.Controls.Add(this.panelOptions);
            this.DockAreas = ((WeifenLuo.WinFormsUI.Docking.DockAreas)((WeifenLuo.WinFormsUI.Docking.DockAreas.DockTop | WeifenLuo.WinFormsUI.Docking.DockAreas.DockBottom)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HideOnClose = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(16, 213);
            this.Name = "FilterControl";
            this.TabText = "Filter";
            this.Text = "Filter";
            this.DockStateChanged += new System.EventHandler(this.FilterControl_DockStateChanged);
            this.panelFilter.ResumeLayout(false);
            this.panelFilter.PerformLayout();
            this.panelOptions.ResumeLayout(false);
            this.panelOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDurationMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRecords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDurationMax)).EndInit();
            this.dateMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.TextBox textCorrelationId;
        private System.Windows.Forms.CheckBox chkCorrelation;
        private System.Windows.Forms.Label labelTimeZone;
        private Rappen.XTB.Helpers.Controls.CheckCombo.CheckBoxComboBox comboEntity;
        private System.Windows.Forms.CheckBox chkEntity;
        private Rappen.XTB.Helpers.Controls.CheckCombo.CheckBoxComboBox comboMessage;
        private System.Windows.Forms.CheckBox chkMessage;
        private Rappen.XTB.Helpers.Controls.CheckCombo.CheckBoxComboBox comboPlugin;
        private System.Windows.Forms.CheckBox chkPlugin;
        private System.Windows.Forms.CheckBox checkDateTo;
        private System.Windows.Forms.CheckBox checkDateFrom;
        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.Panel panelOptions;
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
        private System.Windows.Forms.LinkLabel llFromDate;
        private System.Windows.Forms.ContextMenuStrip dateMenu;
        private System.Windows.Forms.ToolStripMenuItem dateMenuNow;
        private System.Windows.Forms.LinkLabel llToDate;
        private System.Windows.Forms.ToolStripMenuItem dateMenuToday;
        private System.Windows.Forms.ToolStripMenuItem dateMenuFirst;
        private System.Windows.Forms.ToolStripMenuItem dateMenuLast;
        private System.Windows.Forms.TextBox textRequestId;
        private System.Windows.Forms.CheckBox chkRequestId;
        private System.Windows.Forms.CheckBox chkStage30;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.CheckBox chkFreeMessage;
        private System.Windows.Forms.CheckBox chkFreeExceptions;
        private System.Windows.Forms.CheckBox chkDurationMin;
        private System.Windows.Forms.LinkLabel linkLabel6;
        private System.Windows.Forms.LinkLabel linkLabel5;
        private System.Windows.Forms.CheckBox chkRecords;
        private System.Windows.Forms.CheckBox chkDurationMax;
        internal System.Windows.Forms.TextBox textFreeTextFilter;
    }
}
