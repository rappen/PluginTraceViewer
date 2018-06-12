namespace Cinteros.XTB.PluginTraceViewer.Controls
{
    partial class GridControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.crmGridView = new Cinteros.Xrm.CRMWinForm.CRMGridView();
            this.correlation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.performanceexecutionstarttime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.performanceexecutionduration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operationtype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stepname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.messagename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.primaryentity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tracesize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correlationid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exceptionsummary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.messagebody = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exceptiondetails = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuGridView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiFilterBy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFilterByEntity = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFilterByMessage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFilterByPlugin = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFilterByCorrelation = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCorrelation = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCorrelationId = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCorrelationSelectThis = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeleteSelected = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeleteAll = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShowColCorrelation = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShowColStartTime = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShowColDuration = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShowColOperation = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShowColPlugin = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShowColStep = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShowColDepth = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShowColMode = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShowColStage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShowColRank = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShowColMessage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShowColEntity = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShowColTraceSize = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShowColCorrelationId = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShowColRequestId = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShowColException = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripRecords = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripDuration = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripPlugins = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripEntities = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripCorrelations = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripMatch = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.crmGridView)).BeginInit();
            this.contextMenuGridView.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // crmGridView
            // 
            this.crmGridView.AllowUserToAddRows = false;
            this.crmGridView.AllowUserToDeleteRows = false;
            this.crmGridView.AllowUserToOrderColumns = true;
            this.crmGridView.AllowUserToResizeRows = false;
            this.crmGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.crmGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.correlation,
            this.performanceexecutionstarttime,
            this.performanceexecutionduration,
            this.operationtype,
            this.typename,
            this.stepname,
            this.depth,
            this.mode,
            this.stage,
            this.rank,
            this.messagename,
            this.primaryentity,
            this.tracesize,
            this.correlationid,
            this.requestid,
            this.exceptionsummary,
            this.messagebody,
            this.exceptiondetails});
            this.crmGridView.ContextMenuStrip = this.contextMenuGridView;
            this.crmGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crmGridView.EnableHeadersVisualStyles = false;
            this.crmGridView.Location = new System.Drawing.Point(0, 0);
            this.crmGridView.Name = "crmGridView";
            this.crmGridView.ReadOnly = true;
            this.crmGridView.RowHeadersWidth = 20;
            this.crmGridView.ShowFriendlyNames = true;
            this.crmGridView.ShowIdColumn = false;
            this.crmGridView.ShowIndexColumn = false;
            this.crmGridView.Size = new System.Drawing.Size(1065, 274);
            this.crmGridView.TabIndex = 26;
            this.crmGridView.RecordDoubleClick += new Cinteros.Xrm.CRMWinForm.CRMRecordEventHandler(this.crmGridView_RecordDoubleClick);
            this.crmGridView.RecordEnter += new Cinteros.Xrm.CRMWinForm.CRMRecordEventHandler(this.crmGridView_RecordEnter);
            this.crmGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.crmGridView_CellFormatting);
            this.crmGridView.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.crmGridView_CellMouseDown);
            this.crmGridView.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.crmGridView_CellMouseUp);
            this.crmGridView.ColumnDisplayIndexChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.crmGridView_ColumnChanged);
            this.crmGridView.ColumnWidthChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.crmGridView_ColumnChanged);
            this.crmGridView.SelectionChanged += new System.EventHandler(this.crmGridView_SelectionChanged);
            // 
            // correlation
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.correlation.DefaultCellStyle = dataGridViewCellStyle3;
            this.correlation.HeaderText = "Corr";
            this.correlation.Name = "correlation";
            this.correlation.ReadOnly = true;
            this.correlation.Width = 35;
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
            this.performanceexecutionduration.Width = 50;
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
            // stepname
            // 
            this.stepname.DataPropertyName = "step.name";
            this.stepname.HeaderText = "Step";
            this.stepname.Name = "stepname";
            this.stepname.ReadOnly = true;
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
            // stage
            // 
            this.stage.DataPropertyName = "step.stage";
            this.stage.FillWeight = 70F;
            this.stage.HeaderText = "Stage";
            this.stage.Name = "stage";
            this.stage.ReadOnly = true;
            // 
            // rank
            // 
            this.rank.DataPropertyName = "step.rank";
            this.rank.FillWeight = 50F;
            this.rank.HeaderText = "Rank";
            this.rank.Name = "rank";
            this.rank.ReadOnly = true;
            this.rank.Width = 50;
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
            // tracesize
            // 
            this.tracesize.HeaderText = "Trace Size";
            this.tracesize.Name = "tracesize";
            this.tracesize.ReadOnly = true;
            this.tracesize.Visible = false;
            this.tracesize.Width = 40;
            // 
            // correlationid
            // 
            this.correlationid.HeaderText = "Correlation GUID";
            this.correlationid.Name = "correlationid";
            this.correlationid.ReadOnly = true;
            this.correlationid.Visible = false;
            this.correlationid.Width = 150;
            // 
            // requestid
            // 
            this.requestid.HeaderText = "Request GUID";
            this.requestid.Name = "requestid";
            this.requestid.ReadOnly = true;
            this.requestid.Visible = false;
            this.requestid.Width = 150;
            // 
            // exceptionsummary
            // 
            this.exceptionsummary.HeaderText = "Exception";
            this.exceptionsummary.Name = "exceptionsummary";
            this.exceptionsummary.ReadOnly = true;
            this.exceptionsummary.Width = 200;
            // 
            // messagebody
            // 
            this.messagebody.HeaderText = "Trace Log (Hidden)";
            this.messagebody.Name = "messagebody";
            this.messagebody.ReadOnly = true;
            this.messagebody.Visible = false;
            // 
            // exceptiondetails
            // 
            this.exceptiondetails.HeaderText = "Exception Details (Hidden)";
            this.exceptiondetails.Name = "exceptiondetails";
            this.exceptiondetails.ReadOnly = true;
            this.exceptiondetails.Visible = false;
            this.exceptiondetails.Width = 150;
            // 
            // contextMenuGridView
            // 
            this.contextMenuGridView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFilterBy,
            this.tsmiCorrelation,
            this.tsmiDelete,
            this.tsmiShowColCorrelation,
            this.tsmiShowColStartTime,
            this.tsmiShowColDuration,
            this.tsmiShowColOperation,
            this.tsmiShowColPlugin,
            this.tsmiShowColStep,
            this.tsmiShowColDepth,
            this.tsmiShowColMode,
            this.tsmiShowColStage,
            this.tsmiShowColRank,
            this.tsmiShowColMessage,
            this.tsmiShowColEntity,
            this.tsmiShowColTraceSize,
            this.tsmiShowColCorrelationId,
            this.tsmiShowColRequestId,
            this.tsmiShowColException});
            this.contextMenuGridView.Name = "contextStripMain";
            this.contextMenuGridView.Size = new System.Drawing.Size(164, 422);
            this.contextMenuGridView.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuGridView_Opening);
            // 
            // tsmiFilterBy
            // 
            this.tsmiFilterBy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFilterByEntity,
            this.tsmiFilterByMessage,
            this.tsmiFilterByPlugin,
            this.tsmiFilterByCorrelation});
            this.tsmiFilterBy.Name = "tsmiFilterBy";
            this.tsmiFilterBy.Size = new System.Drawing.Size(163, 22);
            this.tsmiFilterBy.Text = "Filter by selected";
            // 
            // tsmiFilterByEntity
            // 
            this.tsmiFilterByEntity.Name = "tsmiFilterByEntity";
            this.tsmiFilterByEntity.Size = new System.Drawing.Size(133, 22);
            this.tsmiFilterByEntity.Text = "Entity";
            this.tsmiFilterByEntity.Click += new System.EventHandler(this.tsmiFilterByEntity_Click);
            // 
            // tsmiFilterByMessage
            // 
            this.tsmiFilterByMessage.Name = "tsmiFilterByMessage";
            this.tsmiFilterByMessage.Size = new System.Drawing.Size(133, 22);
            this.tsmiFilterByMessage.Text = "Message";
            this.tsmiFilterByMessage.Click += new System.EventHandler(this.tsmiFilterByMessage_Click);
            // 
            // tsmiFilterByPlugin
            // 
            this.tsmiFilterByPlugin.Name = "tsmiFilterByPlugin";
            this.tsmiFilterByPlugin.Size = new System.Drawing.Size(133, 22);
            this.tsmiFilterByPlugin.Text = "Plugin";
            this.tsmiFilterByPlugin.Click += new System.EventHandler(this.tsmiFilterByPlugin_Click);
            // 
            // tsmiFilterByCorrelation
            // 
            this.tsmiFilterByCorrelation.Name = "tsmiFilterByCorrelation";
            this.tsmiFilterByCorrelation.Size = new System.Drawing.Size(133, 22);
            this.tsmiFilterByCorrelation.Text = "Correlation";
            this.tsmiFilterByCorrelation.Click += new System.EventHandler(this.tsmiFilterByCorrelation_Click);
            // 
            // tsmiCorrelation
            // 
            this.tsmiCorrelation.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCorrelationId,
            this.tsmiCorrelationSelectThis});
            this.tsmiCorrelation.Name = "tsmiCorrelation";
            this.tsmiCorrelation.Size = new System.Drawing.Size(163, 22);
            this.tsmiCorrelation.Text = "Correlation";
            // 
            // tsmiCorrelationId
            // 
            this.tsmiCorrelationId.Name = "tsmiCorrelationId";
            this.tsmiCorrelationId.Size = new System.Drawing.Size(313, 22);
            this.tsmiCorrelationId.Text = "Id: ";
            // 
            // tsmiCorrelationSelectThis
            // 
            this.tsmiCorrelationSelectThis.Name = "tsmiCorrelationSelectThis";
            this.tsmiCorrelationSelectThis.ShortcutKeyDisplayString = "Shift+C";
            this.tsmiCorrelationSelectThis.Size = new System.Drawing.Size(313, 22);
            this.tsmiCorrelationSelectThis.Text = "Select all logs with this correlation id";
            this.tsmiCorrelationSelectThis.Click += new System.EventHandler(this.tsmiCorrelationSelectThis_Click);
            // 
            // tsmiDelete
            // 
            this.tsmiDelete.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDeleteSelected,
            this.tsmiDeleteAll});
            this.tsmiDelete.Name = "tsmiDelete";
            this.tsmiDelete.Size = new System.Drawing.Size(163, 22);
            this.tsmiDelete.Text = "Delete";
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
            // tsmiShowColCorrelation
            // 
            this.tsmiShowColCorrelation.Checked = true;
            this.tsmiShowColCorrelation.CheckOnClick = true;
            this.tsmiShowColCorrelation.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiShowColCorrelation.Name = "tsmiShowColCorrelation";
            this.tsmiShowColCorrelation.Size = new System.Drawing.Size(163, 22);
            this.tsmiShowColCorrelation.Tag = "correlation";
            this.tsmiShowColCorrelation.Text = "Correlation";
            this.tsmiShowColCorrelation.CheckStateChanged += new System.EventHandler(this.tsmiShowColumn_CheckedChanged);
            // 
            // tsmiShowColStartTime
            // 
            this.tsmiShowColStartTime.Checked = true;
            this.tsmiShowColStartTime.CheckOnClick = true;
            this.tsmiShowColStartTime.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiShowColStartTime.Name = "tsmiShowColStartTime";
            this.tsmiShowColStartTime.Size = new System.Drawing.Size(163, 22);
            this.tsmiShowColStartTime.Tag = "performanceexecutionstarttime";
            this.tsmiShowColStartTime.Text = "Start Time";
            this.tsmiShowColStartTime.CheckStateChanged += new System.EventHandler(this.tsmiShowColumn_CheckedChanged);
            // 
            // tsmiShowColDuration
            // 
            this.tsmiShowColDuration.Checked = true;
            this.tsmiShowColDuration.CheckOnClick = true;
            this.tsmiShowColDuration.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiShowColDuration.Name = "tsmiShowColDuration";
            this.tsmiShowColDuration.Size = new System.Drawing.Size(163, 22);
            this.tsmiShowColDuration.Tag = "performanceexecutionduration";
            this.tsmiShowColDuration.Text = "Duration";
            this.tsmiShowColDuration.CheckStateChanged += new System.EventHandler(this.tsmiShowColumn_CheckedChanged);
            // 
            // tsmiShowColOperation
            // 
            this.tsmiShowColOperation.Checked = true;
            this.tsmiShowColOperation.CheckOnClick = true;
            this.tsmiShowColOperation.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiShowColOperation.Name = "tsmiShowColOperation";
            this.tsmiShowColOperation.Size = new System.Drawing.Size(163, 22);
            this.tsmiShowColOperation.Tag = "operationtype";
            this.tsmiShowColOperation.Text = "Operation";
            this.tsmiShowColOperation.CheckStateChanged += new System.EventHandler(this.tsmiShowColumn_CheckedChanged);
            // 
            // tsmiShowColPlugin
            // 
            this.tsmiShowColPlugin.Checked = true;
            this.tsmiShowColPlugin.CheckOnClick = true;
            this.tsmiShowColPlugin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiShowColPlugin.Name = "tsmiShowColPlugin";
            this.tsmiShowColPlugin.Size = new System.Drawing.Size(163, 22);
            this.tsmiShowColPlugin.Tag = "typename";
            this.tsmiShowColPlugin.Text = "Plugin";
            this.tsmiShowColPlugin.CheckStateChanged += new System.EventHandler(this.tsmiShowColumn_CheckedChanged);
            // 
            // tsmiShowColStep
            // 
            this.tsmiShowColStep.Checked = true;
            this.tsmiShowColStep.CheckOnClick = true;
            this.tsmiShowColStep.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiShowColStep.Name = "tsmiShowColStep";
            this.tsmiShowColStep.Size = new System.Drawing.Size(163, 22);
            this.tsmiShowColStep.Tag = "stepname";
            this.tsmiShowColStep.Text = "Step";
            this.tsmiShowColStep.CheckStateChanged += new System.EventHandler(this.tsmiShowColumn_CheckedChanged);
            // 
            // tsmiShowColDepth
            // 
            this.tsmiShowColDepth.Checked = true;
            this.tsmiShowColDepth.CheckOnClick = true;
            this.tsmiShowColDepth.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiShowColDepth.Name = "tsmiShowColDepth";
            this.tsmiShowColDepth.Size = new System.Drawing.Size(163, 22);
            this.tsmiShowColDepth.Tag = "depth";
            this.tsmiShowColDepth.Text = "Depth";
            this.tsmiShowColDepth.CheckStateChanged += new System.EventHandler(this.tsmiShowColumn_CheckedChanged);
            // 
            // tsmiShowColMode
            // 
            this.tsmiShowColMode.Checked = true;
            this.tsmiShowColMode.CheckOnClick = true;
            this.tsmiShowColMode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiShowColMode.Name = "tsmiShowColMode";
            this.tsmiShowColMode.Size = new System.Drawing.Size(163, 22);
            this.tsmiShowColMode.Tag = "mode";
            this.tsmiShowColMode.Text = "Mode";
            this.tsmiShowColMode.CheckStateChanged += new System.EventHandler(this.tsmiShowColumn_CheckedChanged);
            // 
            // tsmiShowColStage
            // 
            this.tsmiShowColStage.Checked = true;
            this.tsmiShowColStage.CheckOnClick = true;
            this.tsmiShowColStage.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiShowColStage.Name = "tsmiShowColStage";
            this.tsmiShowColStage.Size = new System.Drawing.Size(163, 22);
            this.tsmiShowColStage.Tag = "stage";
            this.tsmiShowColStage.Text = "Stage";
            this.tsmiShowColStage.CheckStateChanged += new System.EventHandler(this.tsmiShowColumn_CheckedChanged);
            // 
            // tsmiShowColRank
            // 
            this.tsmiShowColRank.Checked = true;
            this.tsmiShowColRank.CheckOnClick = true;
            this.tsmiShowColRank.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiShowColRank.Name = "tsmiShowColRank";
            this.tsmiShowColRank.Size = new System.Drawing.Size(163, 22);
            this.tsmiShowColRank.Tag = "rank";
            this.tsmiShowColRank.Text = "Rank";
            this.tsmiShowColRank.CheckStateChanged += new System.EventHandler(this.tsmiShowColumn_CheckedChanged);
            // 
            // tsmiShowColMessage
            // 
            this.tsmiShowColMessage.Checked = true;
            this.tsmiShowColMessage.CheckOnClick = true;
            this.tsmiShowColMessage.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiShowColMessage.Name = "tsmiShowColMessage";
            this.tsmiShowColMessage.Size = new System.Drawing.Size(163, 22);
            this.tsmiShowColMessage.Tag = "messagename";
            this.tsmiShowColMessage.Text = "Message";
            this.tsmiShowColMessage.CheckStateChanged += new System.EventHandler(this.tsmiShowColumn_CheckedChanged);
            // 
            // tsmiShowColEntity
            // 
            this.tsmiShowColEntity.Checked = true;
            this.tsmiShowColEntity.CheckOnClick = true;
            this.tsmiShowColEntity.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiShowColEntity.Name = "tsmiShowColEntity";
            this.tsmiShowColEntity.Size = new System.Drawing.Size(163, 22);
            this.tsmiShowColEntity.Tag = "primaryentity";
            this.tsmiShowColEntity.Text = "Entity";
            this.tsmiShowColEntity.CheckStateChanged += new System.EventHandler(this.tsmiShowColumn_CheckedChanged);
            // 
            // tsmiShowColTraceSize
            // 
            this.tsmiShowColTraceSize.CheckOnClick = true;
            this.tsmiShowColTraceSize.Name = "tsmiShowColTraceSize";
            this.tsmiShowColTraceSize.Size = new System.Drawing.Size(163, 22);
            this.tsmiShowColTraceSize.Tag = "tracesize";
            this.tsmiShowColTraceSize.Text = "Trace Size";
            this.tsmiShowColTraceSize.CheckStateChanged += new System.EventHandler(this.tsmiShowColumn_CheckedChanged);
            // 
            // tsmiShowColCorrelationId
            // 
            this.tsmiShowColCorrelationId.CheckOnClick = true;
            this.tsmiShowColCorrelationId.Name = "tsmiShowColCorrelationId";
            this.tsmiShowColCorrelationId.Size = new System.Drawing.Size(163, 22);
            this.tsmiShowColCorrelationId.Tag = "correlationid";
            this.tsmiShowColCorrelationId.Text = "Correlation GUID";
            this.tsmiShowColCorrelationId.CheckStateChanged += new System.EventHandler(this.tsmiShowColumn_CheckedChanged);
            // 
            // tsmiShowColRequestId
            // 
            this.tsmiShowColRequestId.CheckOnClick = true;
            this.tsmiShowColRequestId.Name = "tsmiShowColRequestId";
            this.tsmiShowColRequestId.Size = new System.Drawing.Size(163, 22);
            this.tsmiShowColRequestId.Tag = "requestid";
            this.tsmiShowColRequestId.Text = "Request GUID";
            this.tsmiShowColRequestId.CheckStateChanged += new System.EventHandler(this.tsmiShowColumn_CheckedChanged);
            // 
            // tsmiShowColException
            // 
            this.tsmiShowColException.Checked = true;
            this.tsmiShowColException.CheckOnClick = true;
            this.tsmiShowColException.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiShowColException.Name = "tsmiShowColException";
            this.tsmiShowColException.Size = new System.Drawing.Size(163, 22);
            this.tsmiShowColException.Tag = "exceptionsummary";
            this.tsmiShowColException.Text = "Exception";
            this.tsmiShowColException.CheckStateChanged += new System.EventHandler(this.tsmiShowColumn_CheckedChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripRecords,
            this.toolStripDuration,
            this.toolStripPlugins,
            this.toolStripEntities,
            this.toolStripCorrelations,
            this.toolStripMatch});
            this.statusStrip1.Location = new System.Drawing.Point(0, 274);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1065, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 27;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripRecords
            // 
            this.toolStripRecords.Name = "toolStripRecords";
            this.toolStripRecords.Size = new System.Drawing.Size(61, 17);
            this.toolStripRecords.Text = "Records: 0";
            // 
            // toolStripDuration
            // 
            this.toolStripDuration.Name = "toolStripDuration";
            this.toolStripDuration.Size = new System.Drawing.Size(65, 17);
            this.toolStripDuration.Text = "Duration: 0";
            // 
            // toolStripPlugins
            // 
            this.toolStripPlugins.Name = "toolStripPlugins";
            this.toolStripPlugins.Size = new System.Drawing.Size(58, 17);
            this.toolStripPlugins.Text = "Plugins: 0";
            // 
            // toolStripEntities
            // 
            this.toolStripEntities.Name = "toolStripEntities";
            this.toolStripEntities.Size = new System.Drawing.Size(57, 17);
            this.toolStripEntities.Text = "Entities: 0";
            // 
            // toolStripCorrelations
            // 
            this.toolStripCorrelations.Name = "toolStripCorrelations";
            this.toolStripCorrelations.Size = new System.Drawing.Size(83, 17);
            this.toolStripCorrelations.Text = "Correlations: 0";
            // 
            // toolStripMatch
            // 
            this.toolStripMatch.Name = "toolStripMatch";
            this.toolStripMatch.Size = new System.Drawing.Size(0, 17);
            // 
            // GridControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 296);
            this.CloseButton = false;
            this.CloseButtonVisible = false;
            this.Controls.Add(this.crmGridView);
            this.Controls.Add(this.statusStrip1);
            this.DockAreas = WeifenLuo.WinFormsUI.Docking.DockAreas.Document;
            this.HideOnClose = true;
            this.Name = "GridControl";
            this.TabText = "Plugin Trace Logs";
            ((System.ComponentModel.ISupportInitialize)(this.crmGridView)).EndInit();
            this.contextMenuGridView.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuGridView;
        private System.Windows.Forms.ToolStripMenuItem tsmiFilterBy;
        private System.Windows.Forms.ToolStripMenuItem tsmiFilterByEntity;
        private System.Windows.Forms.ToolStripMenuItem tsmiFilterByMessage;
        private System.Windows.Forms.ToolStripMenuItem tsmiFilterByPlugin;
        private System.Windows.Forms.ToolStripMenuItem tsmiFilterByCorrelation;
        private System.Windows.Forms.ToolStripMenuItem tsmiCorrelation;
        private System.Windows.Forms.ToolStripMenuItem tsmiCorrelationId;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeleteSelected;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeleteAll;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowColCorrelation;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowColStartTime;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowColDuration;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowColOperation;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowColPlugin;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowColStep;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowColDepth;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowColMode;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowColStage;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowColRank;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowColMessage;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowColEntity;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowColCorrelationId;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowColRequestId;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowColException;
        internal Xrm.CRMWinForm.CRMGridView crmGridView;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripRecords;
        private System.Windows.Forms.ToolStripStatusLabel toolStripDuration;
        private System.Windows.Forms.ToolStripStatusLabel toolStripPlugins;
        private System.Windows.Forms.ToolStripStatusLabel toolStripEntities;
        private System.Windows.Forms.ToolStripStatusLabel toolStripCorrelations;
        private System.Windows.Forms.ToolStripStatusLabel toolStripMatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn correlation;
        private System.Windows.Forms.DataGridViewTextBoxColumn performanceexecutionstarttime;
        private System.Windows.Forms.DataGridViewTextBoxColumn performanceexecutionduration;
        private System.Windows.Forms.DataGridViewTextBoxColumn operationtype;
        private System.Windows.Forms.DataGridViewTextBoxColumn typename;
        private System.Windows.Forms.DataGridViewTextBoxColumn stepname;
        private System.Windows.Forms.DataGridViewTextBoxColumn depth;
        private System.Windows.Forms.DataGridViewTextBoxColumn mode;
        private System.Windows.Forms.DataGridViewTextBoxColumn stage;
        private System.Windows.Forms.DataGridViewTextBoxColumn rank;
        private System.Windows.Forms.DataGridViewTextBoxColumn messagename;
        private System.Windows.Forms.DataGridViewTextBoxColumn primaryentity;
        private System.Windows.Forms.DataGridViewTextBoxColumn tracesize;
        private System.Windows.Forms.DataGridViewTextBoxColumn correlationid;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestid;
        private System.Windows.Forms.DataGridViewTextBoxColumn exceptionsummary;
        private System.Windows.Forms.DataGridViewTextBoxColumn messagebody;
        private System.Windows.Forms.DataGridViewTextBoxColumn exceptiondetails;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowColTraceSize;
        internal System.Windows.Forms.ToolStripMenuItem tsmiCorrelationSelectThis;
    }
}
