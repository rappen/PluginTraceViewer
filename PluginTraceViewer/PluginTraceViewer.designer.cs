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
            this.buttonOpen = new System.Windows.Forms.ToolStripDropDownButton();
            this.buttonOpenFilter = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonOpenFXB = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.buttonOpenLogRecord = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonOpenLogTrace = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonOpenLogException = new System.Windows.Forms.ToolStripMenuItem();
            this.dropdownSave = new System.Windows.Forms.ToolStripDropDownButton();
            this.buttonSaveFilter = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonSaveLogs = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonSaveQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.dropdownView = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmiViewFilter = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiViewStatistics = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiViewLog = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiViewException = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiResetWindows = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiViewQuickFilter = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiWordWrap = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLocalTimes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFullyQualifiedPluginNames = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHidePluginFromStep = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHideEntityFromStep = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHighlight = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiRefreshFilter = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiPluginStats = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSuppressLogSettingWarning = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.buttonRetrieveLogs = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.comboRefreshMode = new System.Windows.Forms.ToolStripComboBox();
            this.buttonRefreshLogs = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.comboLogSetting = new System.Windows.Forms.ToolStripComboBox();
            this.tslAbout = new System.Windows.Forms.ToolStripLabel();
            this.vS2005Theme1 = new WeifenLuo.WinFormsUI.Docking.VS2005Theme();
            this.dockContainer = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.timerRefresh = new System.Windows.Forms.Timer(this.components);
            this.tsbBymeacoffee = new System.Windows.Forms.ToolStripButton();
            this.toolStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMain
            // 
            this.toolStripMain.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonOpen,
            this.dropdownSave,
            this.dropdownView,
            this.toolStripSeparator3,
            this.buttonRetrieveLogs,
            this.toolStripSeparator1,
            this.toolStripLabel2,
            this.comboRefreshMode,
            this.buttonRefreshLogs,
            this.toolStripSeparator2,
            this.toolStripLabel1,
            this.comboLogSetting,
            this.tslAbout,
            this.tsbBymeacoffee});
            this.toolStripMain.Location = new System.Drawing.Point(0, 0);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(1114, 39);
            this.toolStripMain.TabIndex = 24;
            this.toolStripMain.Text = "toolStrip1";
            // 
            // buttonOpen
            // 
            this.buttonOpen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonOpenFilter,
            this.buttonOpenFXB,
            this.toolStripSeparator5,
            this.buttonOpenLogRecord,
            this.buttonOpenLogTrace,
            this.buttonOpenLogException});
            this.buttonOpen.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpen.Image")));
            this.buttonOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(81, 36);
            this.buttonOpen.Text = "Open";
            // 
            // buttonOpenFilter
            // 
            this.buttonOpenFilter.Name = "buttonOpenFilter";
            this.buttonOpenFilter.Size = new System.Drawing.Size(239, 22);
            this.buttonOpenFilter.Text = "Filter...";
            this.buttonOpenFilter.Click += new System.EventHandler(this.buttonOpenFilter_Click);
            // 
            // buttonOpenFXB
            // 
            this.buttonOpenFXB.Name = "buttonOpenFXB";
            this.buttonOpenFXB.Size = new System.Drawing.Size(239, 22);
            this.buttonOpenFXB.Text = "Query in FetchXML Builder...";
            this.buttonOpenFXB.Click += new System.EventHandler(this.buttonOpenFXB_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(236, 6);
            // 
            // buttonOpenLogRecord
            // 
            this.buttonOpenLogRecord.Enabled = false;
            this.buttonOpenLogRecord.Name = "buttonOpenLogRecord";
            this.buttonOpenLogRecord.Size = new System.Drawing.Size(239, 22);
            this.buttonOpenLogRecord.Text = "Selected log record in CRM...";
            this.buttonOpenLogRecord.Click += new System.EventHandler(this.buttonOpenLogRecord_Click);
            // 
            // buttonOpenLogTrace
            // 
            this.buttonOpenLogTrace.Enabled = false;
            this.buttonOpenLogTrace.Name = "buttonOpenLogTrace";
            this.buttonOpenLogTrace.Size = new System.Drawing.Size(239, 22);
            this.buttonOpenLogTrace.Text = "Selected log record Trace...";
            this.buttonOpenLogTrace.Click += new System.EventHandler(this.buttonOpenLogTrace_Click);
            // 
            // buttonOpenLogException
            // 
            this.buttonOpenLogException.Enabled = false;
            this.buttonOpenLogException.Name = "buttonOpenLogException";
            this.buttonOpenLogException.Size = new System.Drawing.Size(239, 22);
            this.buttonOpenLogException.Text = "Selected log record Exception...";
            this.buttonOpenLogException.Click += new System.EventHandler(this.buttonOpenLogException_Click);
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
            this.dropdownSave.Size = new System.Drawing.Size(76, 36);
            this.dropdownSave.Text = "Save";
            // 
            // buttonSaveFilter
            // 
            this.buttonSaveFilter.Name = "buttonSaveFilter";
            this.buttonSaveFilter.Size = new System.Drawing.Size(180, 22);
            this.buttonSaveFilter.Text = "Filter...";
            this.buttonSaveFilter.Click += new System.EventHandler(this.buttonSaveFilter_Click);
            // 
            // buttonSaveLogs
            // 
            this.buttonSaveLogs.Name = "buttonSaveLogs";
            this.buttonSaveLogs.Size = new System.Drawing.Size(180, 22);
            this.buttonSaveLogs.Text = "Logs...";
            this.buttonSaveLogs.Click += new System.EventHandler(this.buttonSaveLogs_Click);
            // 
            // buttonSaveQuery
            // 
            this.buttonSaveQuery.Name = "buttonSaveQuery";
            this.buttonSaveQuery.Size = new System.Drawing.Size(180, 22);
            this.buttonSaveQuery.Text = "Query...";
            this.buttonSaveQuery.Click += new System.EventHandler(this.buttonSaveQuery_Click);
            // 
            // dropdownView
            // 
            this.dropdownView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiViewFilter,
            this.tsmiViewStatistics,
            this.tsmiViewLog,
            this.tsmiViewException,
            this.toolStripMenuItem4,
            this.tsmiResetWindows,
            this.toolStripMenuItem2,
            this.tsmiViewQuickFilter,
            this.tsmiWordWrap,
            this.tsmiLocalTimes,
            this.tsmiFullyQualifiedPluginNames,
            this.tsmiHidePluginFromStep,
            this.tsmiHideEntityFromStep,
            this.tsmiHighlight,
            this.toolStripMenuItem3,
            this.tsmiRefreshFilter,
            this.toolStripMenuItem1,
            this.tsmiPluginStats,
            this.toolStripMenuItem5,
            this.tsmiSuppressLogSettingWarning});
            this.dropdownView.Image = ((System.Drawing.Image)(resources.GetObject("dropdownView.Image")));
            this.dropdownView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.dropdownView.Name = "dropdownView";
            this.dropdownView.Size = new System.Drawing.Size(88, 36);
            this.dropdownView.Text = "Layout";
            // 
            // tsmiViewFilter
            // 
            this.tsmiViewFilter.Image = ((System.Drawing.Image)(resources.GetObject("tsmiViewFilter.Image")));
            this.tsmiViewFilter.Name = "tsmiViewFilter";
            this.tsmiViewFilter.Size = new System.Drawing.Size(250, 38);
            this.tsmiViewFilter.Text = "Filter";
            this.tsmiViewFilter.Click += new System.EventHandler(this.tsmiViewFilter_Click);
            // 
            // tsmiViewStatistics
            // 
            this.tsmiViewStatistics.Image = ((System.Drawing.Image)(resources.GetObject("tsmiViewStatistics.Image")));
            this.tsmiViewStatistics.Name = "tsmiViewStatistics";
            this.tsmiViewStatistics.Size = new System.Drawing.Size(250, 38);
            this.tsmiViewStatistics.Text = "Statistics";
            this.tsmiViewStatistics.Click += new System.EventHandler(this.tsmiViewStatistics_Click);
            // 
            // tsmiViewLog
            // 
            this.tsmiViewLog.Image = ((System.Drawing.Image)(resources.GetObject("tsmiViewLog.Image")));
            this.tsmiViewLog.Name = "tsmiViewLog";
            this.tsmiViewLog.Size = new System.Drawing.Size(250, 38);
            this.tsmiViewLog.Text = "Trace";
            this.tsmiViewLog.Click += new System.EventHandler(this.tsmiViewLog_Click);
            // 
            // tsmiViewException
            // 
            this.tsmiViewException.Image = ((System.Drawing.Image)(resources.GetObject("tsmiViewException.Image")));
            this.tsmiViewException.Name = "tsmiViewException";
            this.tsmiViewException.Size = new System.Drawing.Size(250, 38);
            this.tsmiViewException.Text = "Exception";
            this.tsmiViewException.Click += new System.EventHandler(this.tsmiViewException_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(247, 6);
            // 
            // tsmiResetWindows
            // 
            this.tsmiResetWindows.Name = "tsmiResetWindows";
            this.tsmiResetWindows.Size = new System.Drawing.Size(250, 38);
            this.tsmiResetWindows.Text = "Reset window layout";
            this.tsmiResetWindows.Click += new System.EventHandler(this.tsmiResetWindows_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(247, 6);
            // 
            // tsmiViewQuickFilter
            // 
            this.tsmiViewQuickFilter.CheckOnClick = true;
            this.tsmiViewQuickFilter.Image = ((System.Drawing.Image)(resources.GetObject("tsmiViewQuickFilter.Image")));
            this.tsmiViewQuickFilter.Name = "tsmiViewQuickFilter";
            this.tsmiViewQuickFilter.Size = new System.Drawing.Size(250, 38);
            this.tsmiViewQuickFilter.Text = "Quick Filter";
            this.tsmiViewQuickFilter.Click += new System.EventHandler(this.tsmiViewQuickFilter_Click);
            // 
            // tsmiWordWrap
            // 
            this.tsmiWordWrap.CheckOnClick = true;
            this.tsmiWordWrap.Image = ((System.Drawing.Image)(resources.GetObject("tsmiWordWrap.Image")));
            this.tsmiWordWrap.Name = "tsmiWordWrap";
            this.tsmiWordWrap.Size = new System.Drawing.Size(250, 38);
            this.tsmiWordWrap.Text = "Wrap text in log window";
            this.tsmiWordWrap.CheckedChanged += new System.EventHandler(this.tsmiWordWrap_CheckedChanged);
            // 
            // tsmiLocalTimes
            // 
            this.tsmiLocalTimes.CheckOnClick = true;
            this.tsmiLocalTimes.Image = ((System.Drawing.Image)(resources.GetObject("tsmiLocalTimes.Image")));
            this.tsmiLocalTimes.Name = "tsmiLocalTimes";
            this.tsmiLocalTimes.Size = new System.Drawing.Size(250, 38);
            this.tsmiLocalTimes.Text = "Local Times";
            this.tsmiLocalTimes.Click += new System.EventHandler(this.tsmiLocalTimes_Click);
            // 
            // tsmiFullyQualifiedPluginNames
            // 
            this.tsmiFullyQualifiedPluginNames.CheckOnClick = true;
            this.tsmiFullyQualifiedPluginNames.Image = ((System.Drawing.Image)(resources.GetObject("tsmiFullyQualifiedPluginNames.Image")));
            this.tsmiFullyQualifiedPluginNames.Name = "tsmiFullyQualifiedPluginNames";
            this.tsmiFullyQualifiedPluginNames.Size = new System.Drawing.Size(250, 38);
            this.tsmiFullyQualifiedPluginNames.Text = "Fully Qualified Plugin names";
            this.tsmiFullyQualifiedPluginNames.Click += new System.EventHandler(this.tsmiFullyQualifiedPluginNames_Click);
            // 
            // tsmiHidePluginFromStep
            // 
            this.tsmiHidePluginFromStep.CheckOnClick = true;
            this.tsmiHidePluginFromStep.Name = "tsmiHidePluginFromStep";
            this.tsmiHidePluginFromStep.Size = new System.Drawing.Size(250, 38);
            this.tsmiHidePluginFromStep.Text = "Hide Plugin names from Steps";
            this.tsmiHidePluginFromStep.Click += new System.EventHandler(this.tsmiHidePluginFromStep_Click);
            // 
            // tsmiHideEntityFromStep
            // 
            this.tsmiHideEntityFromStep.CheckOnClick = true;
            this.tsmiHideEntityFromStep.Name = "tsmiHideEntityFromStep";
            this.tsmiHideEntityFromStep.Size = new System.Drawing.Size(250, 38);
            this.tsmiHideEntityFromStep.Text = "Hide Entity names from Steps";
            this.tsmiHideEntityFromStep.Click += new System.EventHandler(this.tsmiHideEntityFromStep_Click);
            // 
            // tsmiHighlight
            // 
            this.tsmiHighlight.Checked = true;
            this.tsmiHighlight.CheckOnClick = true;
            this.tsmiHighlight.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiHighlight.Name = "tsmiHighlight";
            this.tsmiHighlight.Size = new System.Drawing.Size(250, 38);
            this.tsmiHighlight.Text = "Highlight identical cells";
            this.tsmiHighlight.Click += new System.EventHandler(this.tsmiHighlight_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(247, 6);
            // 
            // tsmiRefreshFilter
            // 
            this.tsmiRefreshFilter.Enabled = false;
            this.tsmiRefreshFilter.Image = ((System.Drawing.Image)(resources.GetObject("tsmiRefreshFilter.Image")));
            this.tsmiRefreshFilter.Name = "tsmiRefreshFilter";
            this.tsmiRefreshFilter.Size = new System.Drawing.Size(250, 38);
            this.tsmiRefreshFilter.Text = "Refresh Filter Options";
            this.tsmiRefreshFilter.Click += new System.EventHandler(this.tsmiRefreshFilter_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(247, 6);
            // 
            // tsmiPluginStats
            // 
            this.tsmiPluginStats.Name = "tsmiPluginStats";
            this.tsmiPluginStats.Size = new System.Drawing.Size(250, 38);
            this.tsmiPluginStats.Text = "Show all Plugin Statistics...";
            this.tsmiPluginStats.Click += new System.EventHandler(this.tsmiPluginStats_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(247, 6);
            // 
            // tsmiSuppressLogSettingWarning
            // 
            this.tsmiSuppressLogSettingWarning.CheckOnClick = true;
            this.tsmiSuppressLogSettingWarning.Name = "tsmiSuppressLogSettingWarning";
            this.tsmiSuppressLogSettingWarning.Size = new System.Drawing.Size(250, 38);
            this.tsmiSuppressLogSettingWarning.Text = "Supress log setting warning";
            this.tsmiSuppressLogSettingWarning.Click += new System.EventHandler(this.tsmiSuppressLogSettingWarning_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // buttonRetrieveLogs
            // 
            this.buttonRetrieveLogs.Enabled = false;
            this.buttonRetrieveLogs.Image = ((System.Drawing.Image)(resources.GetObject("buttonRetrieveLogs.Image")));
            this.buttonRetrieveLogs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonRetrieveLogs.Name = "buttonRetrieveLogs";
            this.buttonRetrieveLogs.Size = new System.Drawing.Size(136, 36);
            this.buttonRetrieveLogs.Text = "Retrieve Logs (F5)";
            this.buttonRetrieveLogs.ToolTipText = "Retrieve Logs <F5>";
            this.buttonRetrieveLogs.Click += new System.EventHandler(this.buttonRetrieveLogs_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(80, 36);
            this.toolStripLabel2.Text = "Refresh Mode";
            // 
            // comboRefreshMode
            // 
            this.comboRefreshMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRefreshMode.Items.AddRange(new object[] {
            "Off",
            "Notify",
            "Auto"});
            this.comboRefreshMode.Name = "comboRefreshMode";
            this.comboRefreshMode.Size = new System.Drawing.Size(121, 39);
            this.comboRefreshMode.SelectedIndexChanged += new System.EventHandler(this.comboRefreshMode_SelectedIndexChanged);
            // 
            // buttonRefreshLogs
            // 
            this.buttonRefreshLogs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buttonRefreshLogs.Image = ((System.Drawing.Image)(resources.GetObject("buttonRefreshLogs.Image")));
            this.buttonRefreshLogs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonRefreshLogs.Name = "buttonRefreshLogs";
            this.buttonRefreshLogs.Size = new System.Drawing.Size(67, 36);
            this.buttonRefreshLogs.Text = "0 new logs";
            this.buttonRefreshLogs.Visible = false;
            this.buttonRefreshLogs.Click += new System.EventHandler(this.buttonRefreshLogs_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(97, 36);
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
            this.comboLogSetting.Size = new System.Drawing.Size(121, 39);
            this.comboLogSetting.SelectedIndexChanged += new System.EventHandler(this.comboLogSetting_SelectedIndexChanged);
            // 
            // tslAbout
            // 
            this.tslAbout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tslAbout.Image = ((System.Drawing.Image)(resources.GetObject("tslAbout.Image")));
            this.tslAbout.IsLink = true;
            this.tslAbout.Name = "tslAbout";
            this.tslAbout.Size = new System.Drawing.Size(114, 36);
            this.tslAbout.Text = "by Jonas Rapp";
            this.tslAbout.Click += new System.EventHandler(this.tslAbout_Click);
            // 
            // dockContainer
            // 
            this.dockContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dockContainer.DefaultFloatWindowSize = new System.Drawing.Size(600, 400);
            this.dockContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockContainer.DocumentStyle = WeifenLuo.WinFormsUI.Docking.DocumentStyle.DockingWindow;
            this.dockContainer.Location = new System.Drawing.Point(0, 39);
            this.dockContainer.Name = "dockContainer";
            this.dockContainer.Size = new System.Drawing.Size(1114, 689);
            this.dockContainer.TabIndex = 32;
            // 
            // timerRefresh
            // 
            this.timerRefresh.Interval = 1000;
            this.timerRefresh.Tick += new System.EventHandler(this.timerRefresh_Tick);
            // 
            // tsbBymeacoffee
            // 
            this.tsbBymeacoffee.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbBymeacoffee.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbBymeacoffee.Image = ((System.Drawing.Image)(resources.GetObject("tsbBymeacoffee.Image")));
            this.tsbBymeacoffee.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBymeacoffee.Name = "tsbBymeacoffee";
            this.tsbBymeacoffee.Size = new System.Drawing.Size(36, 36);
            this.tsbBymeacoffee.Text = "toolStripButton1";
            this.tsbBymeacoffee.ToolTipText = "By Me a Coffee!";
            this.tsbBymeacoffee.Click += new System.EventHandler(this.tsbBymeacoffee_Click);
            // 
            // PluginTraceViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dockContainer);
            this.Controls.Add(this.toolStripMain);
            this.Name = "PluginTraceViewer";
            this.PluginIcon = ((System.Drawing.Icon)(resources.GetObject("$this.PluginIcon")));
            this.Size = new System.Drawing.Size(1114, 728);
            this.TabIcon = ((System.Drawing.Image)(resources.GetObject("$this.TabIcon")));
            this.ConnectionUpdated += new XrmToolBox.Extensibility.PluginControlBase.ConnectionUpdatedHandler(this.PluginTraceViewer_ConnectionUpdated);
            this.Load += new System.EventHandler(this.PluginTraceViewer_Load);
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripButton buttonRetrieveLogs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton dropdownSave;
        private System.Windows.Forms.ToolStripMenuItem buttonSaveFilter;
        private System.Windows.Forms.ToolStripMenuItem buttonSaveLogs;
        private System.Windows.Forms.ToolStripDropDownButton buttonOpen;
        private System.Windows.Forms.ToolStripMenuItem buttonOpenFilter;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem buttonOpenLogRecord;
        private System.Windows.Forms.ToolStripMenuItem buttonOpenFXB;
        private System.Windows.Forms.ToolStripMenuItem buttonSaveQuery;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox comboLogSetting;
        private System.Windows.Forms.ToolStripDropDownButton dropdownView;
        private System.Windows.Forms.ToolStripMenuItem tsmiViewFilter;
        private System.Windows.Forms.ToolStripMenuItem tsmiViewStatistics;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem tsmiWordWrap;
        private System.Windows.Forms.ToolStripMenuItem tsmiRefreshFilter;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmiPluginStats;
        private WeifenLuo.WinFormsUI.Docking.VS2005Theme vS2005Theme1;
        private WeifenLuo.WinFormsUI.Docking.DockPanel dockContainer;
        private System.Windows.Forms.ToolStripMenuItem tsmiViewLog;
        private System.Windows.Forms.ToolStripMenuItem tsmiViewException;
        internal System.Windows.Forms.ToolStripMenuItem tsmiHighlight;
        internal System.Windows.Forms.ToolStripMenuItem tsmiLocalTimes;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem tsmiResetWindows;
        private System.Windows.Forms.Timer timerRefresh;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox comboRefreshMode;
        private System.Windows.Forms.ToolStripButton buttonRefreshLogs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel tslAbout;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        internal System.Windows.Forms.ToolStripMenuItem tsmiSuppressLogSettingWarning;
        private System.Windows.Forms.ToolStripMenuItem tsmiViewQuickFilter;
        private System.Windows.Forms.ToolStripMenuItem buttonOpenLogTrace;
        private System.Windows.Forms.ToolStripMenuItem buttonOpenLogException;
        internal System.Windows.Forms.ToolStripMenuItem tsmiFullyQualifiedPluginNames;
        internal System.Windows.Forms.ToolStripMenuItem tsmiHidePluginFromStep;
        internal System.Windows.Forms.ToolStripMenuItem tsmiHideEntityFromStep;
        private System.Windows.Forms.ToolStripButton tsbBymeacoffee;
    }
}
