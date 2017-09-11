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
            this.buttonOpen = new System.Windows.Forms.ToolStripDropDownButton();
            this.buttonOpenFilter = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.buttonOpenLogRecord = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonOpenFXB = new System.Windows.Forms.ToolStripMenuItem();
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
            this.tsmiWordWrap = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLocalTimes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHighlight = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiRefreshFilter = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiPluginStats = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.buttonRetrieveLogs = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.comboLogSetting = new System.Windows.Forms.ToolStripComboBox();
            this.vS2005Theme1 = new WeifenLuo.WinFormsUI.Docking.VS2005Theme();
            this.dockContainer = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.toolStripMain.SuspendLayout();
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
            this.dropdownView,
            this.toolStripSeparator3,
            this.buttonRetrieveLogs,
            this.toolStripSeparator1,
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
            this.tsmiWordWrap,
            this.tsmiLocalTimes,
            this.tsmiHighlight,
            this.toolStripMenuItem3,
            this.tsmiRefreshFilter,
            this.toolStripMenuItem1,
            this.tsmiPluginStats});
            this.dropdownView.Image = ((System.Drawing.Image)(resources.GetObject("dropdownView.Image")));
            this.dropdownView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.dropdownView.Name = "dropdownView";
            this.dropdownView.Size = new System.Drawing.Size(61, 22);
            this.dropdownView.Text = "View";
            // 
            // tsmiViewFilter
            // 
            this.tsmiViewFilter.Image = ((System.Drawing.Image)(resources.GetObject("tsmiViewFilter.Image")));
            this.tsmiViewFilter.Name = "tsmiViewFilter";
            this.tsmiViewFilter.Size = new System.Drawing.Size(202, 22);
            this.tsmiViewFilter.Text = "Filter box";
            this.tsmiViewFilter.Click += new System.EventHandler(this.tsmiViewFilter_Click);
            // 
            // tsmiViewStatistics
            // 
            this.tsmiViewStatistics.Image = ((System.Drawing.Image)(resources.GetObject("tsmiViewStatistics.Image")));
            this.tsmiViewStatistics.Name = "tsmiViewStatistics";
            this.tsmiViewStatistics.Size = new System.Drawing.Size(202, 22);
            this.tsmiViewStatistics.Text = "Statistics box";
            this.tsmiViewStatistics.Click += new System.EventHandler(this.tsmiViewStatistics_Click);
            // 
            // tsmiViewLog
            // 
            this.tsmiViewLog.Image = ((System.Drawing.Image)(resources.GetObject("tsmiViewLog.Image")));
            this.tsmiViewLog.Name = "tsmiViewLog";
            this.tsmiViewLog.Size = new System.Drawing.Size(202, 22);
            this.tsmiViewLog.Text = "Trace message";
            this.tsmiViewLog.Click += new System.EventHandler(this.tsmiViewLog_Click);
            // 
            // tsmiViewException
            // 
            this.tsmiViewException.Image = ((System.Drawing.Image)(resources.GetObject("tsmiViewException.Image")));
            this.tsmiViewException.Name = "tsmiViewException";
            this.tsmiViewException.Size = new System.Drawing.Size(202, 22);
            this.tsmiViewException.Text = "Exception detail";
            this.tsmiViewException.Click += new System.EventHandler(this.tsmiViewException_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(199, 6);
            // 
            // tsmiResetWindows
            // 
            this.tsmiResetWindows.Name = "tsmiResetWindows";
            this.tsmiResetWindows.Size = new System.Drawing.Size(202, 22);
            this.tsmiResetWindows.Text = "Reset window layout";
            this.tsmiResetWindows.Click += new System.EventHandler(this.tsmiResetWindows_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(199, 6);
            // 
            // tsmiWordWrap
            // 
            this.tsmiWordWrap.CheckOnClick = true;
            this.tsmiWordWrap.Image = ((System.Drawing.Image)(resources.GetObject("tsmiWordWrap.Image")));
            this.tsmiWordWrap.Name = "tsmiWordWrap";
            this.tsmiWordWrap.Size = new System.Drawing.Size(202, 22);
            this.tsmiWordWrap.Text = "Wrap text in log window";
            this.tsmiWordWrap.CheckedChanged += new System.EventHandler(this.tsmiWordWrap_CheckedChanged);
            // 
            // tsmiLocalTimes
            // 
            this.tsmiLocalTimes.CheckOnClick = true;
            this.tsmiLocalTimes.Image = ((System.Drawing.Image)(resources.GetObject("tsmiLocalTimes.Image")));
            this.tsmiLocalTimes.Name = "tsmiLocalTimes";
            this.tsmiLocalTimes.Size = new System.Drawing.Size(202, 22);
            this.tsmiLocalTimes.Text = "Local Times";
            this.tsmiLocalTimes.Click += new System.EventHandler(this.tsmiLocalTimes_Click);
            // 
            // tsmiHighlight
            // 
            this.tsmiHighlight.Checked = true;
            this.tsmiHighlight.CheckOnClick = true;
            this.tsmiHighlight.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiHighlight.Name = "tsmiHighlight";
            this.tsmiHighlight.Size = new System.Drawing.Size(202, 22);
            this.tsmiHighlight.Text = "Highlight identical cells";
            this.tsmiHighlight.Click += new System.EventHandler(this.tsmiHighlight_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(199, 6);
            // 
            // tsmiRefreshFilter
            // 
            this.tsmiRefreshFilter.Enabled = false;
            this.tsmiRefreshFilter.Image = ((System.Drawing.Image)(resources.GetObject("tsmiRefreshFilter.Image")));
            this.tsmiRefreshFilter.Name = "tsmiRefreshFilter";
            this.tsmiRefreshFilter.Size = new System.Drawing.Size(202, 22);
            this.tsmiRefreshFilter.Text = "Refresh Filter Options";
            this.tsmiRefreshFilter.Click += new System.EventHandler(this.tsmiRefreshFilter_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(199, 6);
            // 
            // tsmiPluginStats
            // 
            this.tsmiPluginStats.Name = "tsmiPluginStats";
            this.tsmiPluginStats.Size = new System.Drawing.Size(202, 22);
            this.tsmiPluginStats.Text = "Plugin Statistics...";
            this.tsmiPluginStats.Click += new System.EventHandler(this.tsmiPluginStats_Click);
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
            this.buttonRetrieveLogs.ToolTipText = "Retrieve Logs <F5>";
            this.buttonRetrieveLogs.Click += new System.EventHandler(this.buttonRetrieveLogs_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
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
            // dockContainer
            // 
            this.dockContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dockContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockContainer.DocumentStyle = WeifenLuo.WinFormsUI.Docking.DocumentStyle.DockingWindow;
            this.dockContainer.Location = new System.Drawing.Point(0, 25);
            this.dockContainer.Name = "dockContainer";
            this.dockContainer.Size = new System.Drawing.Size(1114, 703);
            this.dockContainer.TabIndex = 32;
            // 
            // PluginTraceViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dockContainer);
            this.Controls.Add(this.toolStripMain);
            this.Name = "PluginTraceViewer";
            this.Size = new System.Drawing.Size(1114, 728);
            this.ConnectionUpdated += new XrmToolBox.Extensibility.PluginControlBase.ConnectionUpdatedHandler(this.PluginTraceViewer_ConnectionUpdated);
            this.Load += new System.EventHandler(this.PluginTraceViewer_Load);
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripButton tsbCloseThisTab;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsbAbout;
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
    }
}
