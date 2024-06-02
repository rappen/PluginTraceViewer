namespace Cinteros.XTB.PluginTraceViewer.Controls
{
    partial class TraceControl
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
            this.textMessage = new System.Windows.Forms.RichTextBox();
            this.panLinks = new System.Windows.Forms.Panel();
            this.lblTrigger = new System.Windows.Forms.Label();
            this.lblLoading = new System.Windows.Forms.Label();
            this.btnShowAllRecordLinks = new System.Windows.Forms.Button();
            this.linkRecord = new System.Windows.Forms.LinkLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panLinks.SuspendLayout();
            this.SuspendLayout();
            // 
            // textMessage
            // 
            this.textMessage.BackColor = System.Drawing.SystemColors.Window;
            this.textMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textMessage.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMessage.Location = new System.Drawing.Point(0, 70);
            this.textMessage.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textMessage.MinimumSize = new System.Drawing.Size(7, 185);
            this.textMessage.Name = "textMessage";
            this.textMessage.ReadOnly = true;
            this.textMessage.ShowSelectionMargin = true;
            this.textMessage.Size = new System.Drawing.Size(1027, 412);
            this.textMessage.TabIndex = 10;
            this.textMessage.Text = "";
            this.textMessage.WordWrap = false;
            this.textMessage.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.textMessage_LinkClicked);
            // 
            // panLinks
            // 
            this.panLinks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panLinks.Controls.Add(this.lblLoading);
            this.panLinks.Controls.Add(this.btnShowAllRecordLinks);
            this.panLinks.Controls.Add(this.linkRecord);
            this.panLinks.Controls.Add(this.lblTrigger);
            this.panLinks.Dock = System.Windows.Forms.DockStyle.Top;
            this.panLinks.Location = new System.Drawing.Point(0, 0);
            this.panLinks.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panLinks.Name = "panLinks";
            this.panLinks.Size = new System.Drawing.Size(1027, 70);
            this.panLinks.TabIndex = 11;
            this.panLinks.Paint += new System.Windows.Forms.PaintEventHandler(this.panLinks_Paint);
            // 
            // lblTrigger
            // 
            this.lblTrigger.AutoSize = true;
            this.lblTrigger.Location = new System.Drawing.Point(7, 24);
            this.lblTrigger.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTrigger.Name = "lblTrigger";
            this.lblTrigger.Size = new System.Drawing.Size(105, 25);
            this.lblTrigger.TabIndex = 8;
            this.lblTrigger.Text = "Trigged by";
            // 
            // lblLoading
            // 
            this.lblLoading.BackColor = System.Drawing.SystemColors.Control;
            this.lblLoading.Location = new System.Drawing.Point(411, 15);
            this.lblLoading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(174, 41);
            this.lblLoading.TabIndex = 7;
            this.lblLoading.Text = "Finding records...";
            this.lblLoading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnShowAllRecordLinks
            // 
            this.btnShowAllRecordLinks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowAllRecordLinks.Enabled = false;
            this.btnShowAllRecordLinks.Location = new System.Drawing.Point(840, 15);
            this.btnShowAllRecordLinks.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnShowAllRecordLinks.Name = "btnShowAllRecordLinks";
            this.btnShowAllRecordLinks.Size = new System.Drawing.Size(163, 42);
            this.btnShowAllRecordLinks.TabIndex = 6;
            this.btnShowAllRecordLinks.Text = "All records...";
            this.btnShowAllRecordLinks.UseVisualStyleBackColor = true;
            this.btnShowAllRecordLinks.Click += new System.EventHandler(this.btnShowAllRecordLinks_Click);
            // 
            // linkRecord
            // 
            this.linkRecord.AutoSize = true;
            this.linkRecord.LinkArea = new System.Windows.Forms.LinkArea(0, 0);
            this.linkRecord.Location = new System.Drawing.Point(106, 26);
            this.linkRecord.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.linkRecord.Name = "linkRecord";
            this.linkRecord.Size = new System.Drawing.Size(94, 25);
            this.linkRecord.TabIndex = 5;
            this.linkRecord.Text = "Unknown";
            this.linkRecord.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_LinkClicked);
            // 
            // TraceControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1027, 482);
            this.Controls.Add(this.textMessage);
            this.Controls.Add(this.panLinks);
            this.HideOnClose = true;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TraceControl";
            this.TabText = "Trace Message";
            this.TopMost = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TraceControl_KeyDown);
            this.panLinks.ResumeLayout(false);
            this.panLinks.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.RichTextBox textMessage;
        private System.Windows.Forms.Panel panLinks;
        private System.Windows.Forms.LinkLabel linkRecord;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnShowAllRecordLinks;
        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.Label lblTrigger;
    }
}
