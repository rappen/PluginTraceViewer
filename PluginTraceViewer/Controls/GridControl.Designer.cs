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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GridControl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.contextMenuGridView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiFilterBy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFilterByEntity = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFilterByMessage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFilterByPlugin = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFilterByCorrelation = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFilterByRequestId = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCorrelation = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCorrelationId = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCorrelationSelectThis = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeleteSelected = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeleteAll = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShowColCorrelation = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShowColCreated = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShowColStartDate = new System.Windows.Forms.ToolStripMenuItem();
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
            this.panQuickFilter = new System.Windows.Forms.Panel();
            this.txtQuickFilter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mnuQuickFilter = new System.Windows.Forms.MenuStrip();
            this.mnuQFOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQFColHeader = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQFColTrace = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQFColException = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQFColPlugin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQFColStep = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQFSep1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuQFCombHeader = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQFCombOr = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQFCombAnd = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQFSep2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuQFAdvHeader = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQFAdvNot = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQFAdvRegEx = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.crmGridView = new Rappen.XTB.Helpers.Controls.XRMDataGridView();
            this.correlation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.performanceexecutionstartdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.messageblock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exceptiondetails = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuGridView.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panQuickFilter.SuspendLayout();
            this.mnuQuickFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crmGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuGridView
            // 
            this.contextMenuGridView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFilterBy,
            this.tsmiCorrelation,
            this.tsmiDelete,
            this.tsmiShowColCorrelation,
            this.tsmiShowColCreated,
            this.tsmiShowColStartDate,
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
            this.contextMenuGridView.Size = new System.Drawing.Size(164, 466);
            this.contextMenuGridView.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuGridView_Opening);
            // 
            // tsmiFilterBy
            // 
            this.tsmiFilterBy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFilterByEntity,
            this.tsmiFilterByMessage,
            this.tsmiFilterByPlugin,
            this.tsmiFilterByCorrelation,
            this.tsmiFilterByRequestId});
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
            // tsmiFilterByRequestId
            // 
            this.tsmiFilterByRequestId.Name = "tsmiFilterByRequestId";
            this.tsmiFilterByRequestId.Size = new System.Drawing.Size(133, 22);
            this.tsmiFilterByRequestId.Text = "Request Id";
            this.tsmiFilterByRequestId.Click += new System.EventHandler(this.tsmiFilterByRequestId_Click);
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
            // tsmiShowColCreated
            // 
            this.tsmiShowColCreated.CheckOnClick = true;
            this.tsmiShowColCreated.Name = "tsmiShowColCreated";
            this.tsmiShowColCreated.Size = new System.Drawing.Size(163, 22);
            this.tsmiShowColCreated.Tag = "createdon";
            this.tsmiShowColCreated.Text = "Created";
            this.tsmiShowColCreated.CheckStateChanged += new System.EventHandler(this.tsmiShowColumn_CheckedChanged);
            // 
            // tsmiShowColStartDate
            // 
            this.tsmiShowColStartDate.Checked = true;
            this.tsmiShowColStartDate.CheckOnClick = true;
            this.tsmiShowColStartDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiShowColStartDate.Name = "tsmiShowColStartDate";
            this.tsmiShowColStartDate.Size = new System.Drawing.Size(163, 22);
            this.tsmiShowColStartDate.Tag = "performanceexecutionstartdate";
            this.tsmiShowColStartDate.Text = "Start Date";
            this.tsmiShowColStartDate.CheckStateChanged += new System.EventHandler(this.tsmiShowColumn_CheckedChanged);
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
            this.statusStrip1.Size = new System.Drawing.Size(1116, 22);
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
            // panQuickFilter
            // 
            this.panQuickFilter.Controls.Add(this.txtQuickFilter);
            this.panQuickFilter.Controls.Add(this.label2);
            this.panQuickFilter.Controls.Add(this.mnuQuickFilter);
            this.panQuickFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.panQuickFilter.Location = new System.Drawing.Point(0, 0);
            this.panQuickFilter.Name = "panQuickFilter";
            this.panQuickFilter.Size = new System.Drawing.Size(1116, 32);
            this.panQuickFilter.TabIndex = 28;
            this.panQuickFilter.Visible = false;
            // 
            // txtQuickFilter
            // 
            this.txtQuickFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuickFilter.Location = new System.Drawing.Point(104, 6);
            this.txtQuickFilter.Name = "txtQuickFilter";
            this.txtQuickFilter.Size = new System.Drawing.Size(945, 20);
            this.txtQuickFilter.TabIndex = 19;
            this.txtQuickFilter.TextChanged += new System.EventHandler(this.txtQuickFilter_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Quick Filter";
            // 
            // mnuQuickFilter
            // 
            this.mnuQuickFilter.AutoSize = false;
            this.mnuQuickFilter.BackColor = System.Drawing.SystemColors.Window;
            this.mnuQuickFilter.Dock = System.Windows.Forms.DockStyle.Right;
            this.mnuQuickFilter.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuQFOptions});
            this.mnuQuickFilter.Location = new System.Drawing.Point(1052, 0);
            this.mnuQuickFilter.Name = "mnuQuickFilter";
            this.mnuQuickFilter.Padding = new System.Windows.Forms.Padding(6, 5, 0, 2);
            this.mnuQuickFilter.Size = new System.Drawing.Size(64, 32);
            this.mnuQuickFilter.TabIndex = 22;
            this.mnuQuickFilter.Text = "menuStrip1";
            this.toolTip1.SetToolTip(this.mnuQuickFilter, "Click here to change behaviors for Quck Filter");
            // 
            // mnuQFOptions
            // 
            this.mnuQFOptions.BackColor = System.Drawing.SystemColors.Window;
            this.mnuQFOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuQFColHeader,
            this.mnuQFColTrace,
            this.mnuQFColException,
            this.mnuQFColPlugin,
            this.mnuQFColStep,
            this.mnuQFSep1,
            this.mnuQFCombHeader,
            this.mnuQFCombOr,
            this.mnuQFCombAnd,
            this.mnuQFSep2,
            this.mnuQFAdvHeader,
            this.mnuQFAdvNot,
            this.mnuQFAdvRegEx});
            this.mnuQFOptions.Name = "mnuQFOptions";
            this.mnuQFOptions.Size = new System.Drawing.Size(57, 19);
            this.mnuQFOptions.Text = "Options...";
            this.mnuQFOptions.ToolTipText = "Click here to change behaviors for Quck Filter";
            // 
            // mnuQFColHeader
            // 
            this.mnuQFColHeader.Enabled = false;
            this.mnuQFColHeader.Name = "mnuQFColHeader";
            this.mnuQFColHeader.Size = new System.Drawing.Size(172, 22);
            this.mnuQFColHeader.Text = "Filter by columns:";
            this.mnuQFColHeader.ToolTipText = "Select which columns will be searching in";
            // 
            // mnuQFColTrace
            // 
            this.mnuQFColTrace.Checked = true;
            this.mnuQFColTrace.CheckOnClick = true;
            this.mnuQFColTrace.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuQFColTrace.Name = "mnuQFColTrace";
            this.mnuQFColTrace.Size = new System.Drawing.Size(172, 22);
            this.mnuQFColTrace.Text = "  Trace";
            this.mnuQFColTrace.ToolTipText = "Searching in Plugin Trace Message Block";
            this.mnuQFColTrace.CheckedChanged += new System.EventHandler(this.mnuQFChanged_CheckedChanged);
            // 
            // mnuQFColException
            // 
            this.mnuQFColException.Checked = true;
            this.mnuQFColException.CheckOnClick = true;
            this.mnuQFColException.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuQFColException.Name = "mnuQFColException";
            this.mnuQFColException.Size = new System.Drawing.Size(172, 22);
            this.mnuQFColException.Text = "  Exception";
            this.mnuQFColException.ToolTipText = "Searching in Exception Details";
            this.mnuQFColException.CheckedChanged += new System.EventHandler(this.mnuQFChanged_CheckedChanged);
            // 
            // mnuQFColPlugin
            // 
            this.mnuQFColPlugin.Checked = true;
            this.mnuQFColPlugin.CheckOnClick = true;
            this.mnuQFColPlugin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuQFColPlugin.Name = "mnuQFColPlugin";
            this.mnuQFColPlugin.Size = new System.Drawing.Size(172, 22);
            this.mnuQFColPlugin.Text = "  Plugin";
            this.mnuQFColPlugin.ToolTipText = "Searching in Plugin Type Name";
            this.mnuQFColPlugin.CheckedChanged += new System.EventHandler(this.mnuQFChanged_CheckedChanged);
            // 
            // mnuQFColStep
            // 
            this.mnuQFColStep.Checked = true;
            this.mnuQFColStep.CheckOnClick = true;
            this.mnuQFColStep.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuQFColStep.Name = "mnuQFColStep";
            this.mnuQFColStep.Size = new System.Drawing.Size(172, 22);
            this.mnuQFColStep.Text = "  Step";
            this.mnuQFColStep.ToolTipText = "Searching in Plugin Step Name";
            this.mnuQFColStep.CheckedChanged += new System.EventHandler(this.mnuQFChanged_CheckedChanged);
            // 
            // mnuQFSep1
            // 
            this.mnuQFSep1.Name = "mnuQFSep1";
            this.mnuQFSep1.Size = new System.Drawing.Size(169, 6);
            // 
            // mnuQFCombHeader
            // 
            this.mnuQFCombHeader.Enabled = false;
            this.mnuQFCombHeader.Name = "mnuQFCombHeader";
            this.mnuQFCombHeader.Size = new System.Drawing.Size(172, 22);
            this.mnuQFCombHeader.Text = "Combine columns";
            this.mnuQFCombHeader.ToolTipText = "Select here if all columns selected will find the text, or one hit is enough";
            // 
            // mnuQFCombOr
            // 
            this.mnuQFCombOr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mnuQFCombOr.Checked = true;
            this.mnuQFCombOr.CheckOnClick = true;
            this.mnuQFCombOr.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuQFCombOr.Name = "mnuQFCombOr";
            this.mnuQFCombOr.Size = new System.Drawing.Size(172, 22);
            this.mnuQFCombOr.Text = "  Or";
            this.mnuQFCombOr.ToolTipText = "Select Or to show the record if at least one column gets a hit";
            this.mnuQFCombOr.CheckedChanged += new System.EventHandler(this.mnuQFChanged_CheckedChanged);
            // 
            // mnuQFCombAnd
            // 
            this.mnuQFCombAnd.CheckOnClick = true;
            this.mnuQFCombAnd.Name = "mnuQFCombAnd";
            this.mnuQFCombAnd.Size = new System.Drawing.Size(172, 22);
            this.mnuQFCombAnd.Text = "  And";
            this.mnuQFCombAnd.ToolTipText = "Select And to only show records that find it on all selected columns";
            this.mnuQFCombAnd.CheckedChanged += new System.EventHandler(this.mnuQFChanged_CheckedChanged);
            // 
            // mnuQFSep2
            // 
            this.mnuQFSep2.Name = "mnuQFSep2";
            this.mnuQFSep2.Size = new System.Drawing.Size(169, 6);
            // 
            // mnuQFAdvHeader
            // 
            this.mnuQFAdvHeader.Enabled = false;
            this.mnuQFAdvHeader.Name = "mnuQFAdvHeader";
            this.mnuQFAdvHeader.Size = new System.Drawing.Size(172, 22);
            this.mnuQFAdvHeader.Text = "Advanced";
            // 
            // mnuQFAdvNot
            // 
            this.mnuQFAdvNot.CheckOnClick = true;
            this.mnuQFAdvNot.Name = "mnuQFAdvNot";
            this.mnuQFAdvNot.Size = new System.Drawing.Size(172, 22);
            this.mnuQFAdvNot.Text = "  Not";
            this.mnuQFAdvNot.ToolTipText = "Check this to revert the result of all records";
            this.mnuQFAdvNot.CheckedChanged += new System.EventHandler(this.mnuQFChanged_CheckedChanged);
            // 
            // mnuQFAdvRegEx
            // 
            this.mnuQFAdvRegEx.CheckOnClick = true;
            this.mnuQFAdvRegEx.Name = "mnuQFAdvRegEx";
            this.mnuQFAdvRegEx.Size = new System.Drawing.Size(172, 22);
            this.mnuQFAdvRegEx.Text = "  RegEx";
            this.mnuQFAdvRegEx.ToolTipText = "To you know RegEx?\r\nTry to use it for more advanced finding of records.";
            this.mnuQFAdvRegEx.CheckedChanged += new System.EventHandler(this.mnuQFChanged_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 30);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // crmGridView
            // 
            this.crmGridView.AllowUserToAddRows = false;
            this.crmGridView.AllowUserToDeleteRows = false;
            this.crmGridView.AllowUserToOrderColumns = true;
            this.crmGridView.AllowUserToResizeRows = false;
            this.crmGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.crmGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.crmGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.crmGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.crmGridView.ColumnOrder = "";
            this.crmGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.correlation,
            this.createdon,
            this.performanceexecutionstartdate,
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
            this.messageblock,
            this.exceptiondetails});
            this.crmGridView.ContextMenuStrip = this.contextMenuGridView;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.crmGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.crmGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crmGridView.EnableHeadersVisualStyles = false;
            this.crmGridView.Filtering.And = false;
            this.crmGridView.Filtering.Columns = "messageblock, exceptiondetails, typename, step.name";
            this.crmGridView.Filtering.Not = false;
            this.crmGridView.Filtering.RegEx = false;
            this.crmGridView.Filtering.Text = "";
            this.crmGridView.LayoutXML = "";
            this.crmGridView.Location = new System.Drawing.Point(0, 32);
            this.crmGridView.Name = "crmGridView";
            this.crmGridView.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.crmGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.crmGridView.RowHeadersVisible = false;
            this.crmGridView.RowHeadersWidth = 20;
            this.crmGridView.Service = null;
            this.crmGridView.ShowFriendlyNames = true;
            this.crmGridView.ShowIdColumn = false;
            this.crmGridView.ShowIndexColumn = false;
            this.crmGridView.Size = new System.Drawing.Size(1116, 242);
            this.crmGridView.TabIndex = 26;
            this.crmGridView.RecordDoubleClick += new Rappen.XTB.Helpers.Controls.XRMRecordEventHandler(this.crmGridView_RecordDoubleClick);
            this.crmGridView.RecordEnter += new Rappen.XTB.Helpers.Controls.XRMRecordEventHandler(this.crmGridView_RecordEnter);
            this.crmGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.crmGridView_CellFormatting);
            this.crmGridView.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.crmGridView_CellMouseDown);
            this.crmGridView.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.crmGridView_CellMouseUp);
            this.crmGridView.ColumnDisplayIndexChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.crmGridView_ColumnChanged);
            this.crmGridView.ColumnWidthChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.crmGridView_ColumnChanged);
            this.crmGridView.SelectionChanged += new System.EventHandler(this.crmGridView_SelectionChanged);
            // 
            // correlation
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.correlation.DefaultCellStyle = dataGridViewCellStyle2;
            this.correlation.HeaderText = "Corr";
            this.correlation.Name = "correlation";
            this.correlation.ReadOnly = true;
            this.correlation.Width = 35;
            // 
            // createdon
            // 
            this.createdon.HeaderText = "Created";
            this.createdon.Name = "createdon";
            this.createdon.ReadOnly = true;
            this.createdon.Visible = false;
            this.createdon.Width = 80;
            // 
            // performanceexecutionstartdate
            // 
            this.performanceexecutionstartdate.DataPropertyName = "startdate";
            dataGridViewCellStyle3.Format = "yyyy-MM-dd";
            this.performanceexecutionstartdate.DefaultCellStyle = dataGridViewCellStyle3;
            this.performanceexecutionstartdate.HeaderText = "Start Date";
            this.performanceexecutionstartdate.Name = "performanceexecutionstartdate";
            this.performanceexecutionstartdate.ReadOnly = true;
            this.performanceexecutionstartdate.Width = 65;
            // 
            // performanceexecutionstarttime
            // 
            dataGridViewCellStyle4.Format = "HH:mm:ss.fff";
            this.performanceexecutionstarttime.DefaultCellStyle = dataGridViewCellStyle4;
            this.performanceexecutionstarttime.HeaderText = "Start Time";
            this.performanceexecutionstarttime.Name = "performanceexecutionstarttime";
            this.performanceexecutionstarttime.ReadOnly = true;
            this.performanceexecutionstarttime.Width = 75;
            // 
            // performanceexecutionduration
            // 
            this.performanceexecutionduration.HeaderText = "Duration";
            this.performanceexecutionduration.Name = "performanceexecutionduration";
            this.performanceexecutionduration.ReadOnly = true;
            this.performanceexecutionduration.Width = 40;
            // 
            // operationtype
            // 
            this.operationtype.HeaderText = "Operation";
            this.operationtype.Name = "operationtype";
            this.operationtype.ReadOnly = true;
            this.operationtype.Width = 80;
            // 
            // typename
            // 
            this.typename.HeaderText = "Plugin";
            this.typename.Name = "typename";
            this.typename.ReadOnly = true;
            this.typename.Width = 150;
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
            this.depth.Width = 40;
            // 
            // mode
            // 
            this.mode.HeaderText = "Mode";
            this.mode.Name = "mode";
            this.mode.ReadOnly = true;
            this.mode.Width = 60;
            // 
            // stage
            // 
            this.stage.DataPropertyName = "step.stage";
            this.stage.FillWeight = 70F;
            this.stage.HeaderText = "Stage";
            this.stage.Name = "stage";
            this.stage.ReadOnly = true;
            this.stage.Width = 80;
            // 
            // rank
            // 
            this.rank.DataPropertyName = "step.rank";
            this.rank.FillWeight = 50F;
            this.rank.HeaderText = "Rank";
            this.rank.Name = "rank";
            this.rank.ReadOnly = true;
            this.rank.Width = 40;
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
            // messageblock
            // 
            this.messageblock.HeaderText = "Trace Log (Hidden)";
            this.messageblock.Name = "messageblock";
            this.messageblock.ReadOnly = true;
            this.messageblock.Visible = false;
            // 
            // exceptiondetails
            // 
            this.exceptiondetails.HeaderText = "Exception Details (Hidden)";
            this.exceptiondetails.Name = "exceptiondetails";
            this.exceptiondetails.ReadOnly = true;
            this.exceptiondetails.Visible = false;
            this.exceptiondetails.Width = 150;
            // 
            // GridControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1116, 296);
            this.CloseButton = false;
            this.CloseButtonVisible = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.crmGridView);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panQuickFilter);
            this.DockAreas = WeifenLuo.WinFormsUI.Docking.DockAreas.Document;
            this.HideOnClose = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuQuickFilter;
            this.Name = "GridControl";
            this.TabText = "Plugin Trace Logs";
            this.contextMenuGridView.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panQuickFilter.ResumeLayout(false);
            this.panQuickFilter.PerformLayout();
            this.mnuQuickFilter.ResumeLayout(false);
            this.mnuQuickFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crmGridView)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem tsmiFilterByRequestId;
        private System.Windows.Forms.ToolStripMenuItem tsmiCorrelation;
        private System.Windows.Forms.ToolStripMenuItem tsmiCorrelationId;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeleteSelected;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeleteAll;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowColCorrelation;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowColCreated;
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
        internal Rappen.XTB.Helpers.Controls.XRMDataGridView crmGridView;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripRecords;
        private System.Windows.Forms.ToolStripStatusLabel toolStripDuration;
        private System.Windows.Forms.ToolStripStatusLabel toolStripPlugins;
        private System.Windows.Forms.ToolStripStatusLabel toolStripEntities;
        private System.Windows.Forms.ToolStripStatusLabel toolStripCorrelations;
        private System.Windows.Forms.ToolStripStatusLabel toolStripMatch;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowColTraceSize;
        internal System.Windows.Forms.ToolStripMenuItem tsmiCorrelationSelectThis;
        private System.Windows.Forms.TextBox txtQuickFilter;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Panel panQuickFilter;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowColStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn correlation;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdon;
        private System.Windows.Forms.DataGridViewTextBoxColumn performanceexecutionstartdate;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn messageblock;
        private System.Windows.Forms.DataGridViewTextBoxColumn exceptiondetails;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip mnuQuickFilter;
        private System.Windows.Forms.ToolStripMenuItem mnuQFOptions;
        private System.Windows.Forms.ToolStripSeparator mnuQFSep2;
        private System.Windows.Forms.ToolStripMenuItem mnuQFAdvRegEx;
        private System.Windows.Forms.ToolStripSeparator mnuQFSep1;
        private System.Windows.Forms.ToolStripMenuItem mnuQFColTrace;
        private System.Windows.Forms.ToolStripMenuItem mnuQFColException;
        private System.Windows.Forms.ToolStripMenuItem mnuQFColPlugin;
        private System.Windows.Forms.ToolStripMenuItem mnuQFColHeader;
        private System.Windows.Forms.ToolStripMenuItem mnuQFCombHeader;
        private System.Windows.Forms.ToolStripMenuItem mnuQFCombOr;
        private System.Windows.Forms.ToolStripMenuItem mnuQFCombAnd;
        private System.Windows.Forms.ToolStripMenuItem mnuQFAdvHeader;
        private System.Windows.Forms.ToolStripMenuItem mnuQFAdvNot;
        private System.Windows.Forms.ToolStripMenuItem mnuQFColStep;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
