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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TraceControl));
            this.textMessage = new System.Windows.Forms.RichTextBox();
            this.panLinks = new System.Windows.Forms.Panel();
            this.lblLoading = new System.Windows.Forms.Label();
            this.btnShowAllRecordLinks = new System.Windows.Forms.Button();
            this.linkRecord = new System.Windows.Forms.LinkLabel();
            this.lblTrigger = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.panLinks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // textMessage
            // 
            this.textMessage.BackColor = System.Drawing.SystemColors.Window;
            this.textMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textMessage.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMessage.Location = new System.Drawing.Point(0, 33);
            this.textMessage.MinimumSize = new System.Drawing.Size(4, 100);
            this.textMessage.Name = "textMessage";
            this.textMessage.ReadOnly = true;
            this.textMessage.ShowSelectionMargin = true;
            this.textMessage.Size = new System.Drawing.Size(584, 228);
            this.textMessage.TabIndex = 10;
            this.textMessage.Text = "";
            this.textMessage.WordWrap = false;
            this.textMessage.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.textMessage_LinkClicked);
            // 
            // panLinks
            // 
            this.panLinks.Controls.Add(this.lblLoading);
            this.panLinks.Controls.Add(this.btnShowAllRecordLinks);
            this.panLinks.Controls.Add(this.linkRecord);
            this.panLinks.Controls.Add(this.lblTrigger);
            this.panLinks.Dock = System.Windows.Forms.DockStyle.Top;
            this.panLinks.Location = new System.Drawing.Point(0, 0);
            this.panLinks.Name = "panLinks";
            this.panLinks.Size = new System.Drawing.Size(584, 33);
            this.panLinks.TabIndex = 11;
            this.panLinks.Paint += new System.Windows.Forms.PaintEventHandler(this.panLinks_Paint);
            // 
            // lblLoading
            // 
            this.lblLoading.BackColor = System.Drawing.SystemColors.Control;
            this.lblLoading.Location = new System.Drawing.Point(224, 4);
            this.lblLoading.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(95, 22);
            this.lblLoading.TabIndex = 7;
            this.lblLoading.Text = "Finding records...";
            this.lblLoading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnShowAllRecordLinks
            // 
            this.btnShowAllRecordLinks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowAllRecordLinks.Enabled = false;
            this.btnShowAllRecordLinks.Location = new System.Drawing.Point(424, 4);
            this.btnShowAllRecordLinks.Name = "btnShowAllRecordLinks";
            this.btnShowAllRecordLinks.Size = new System.Drawing.Size(106, 23);
            this.btnShowAllRecordLinks.TabIndex = 6;
            this.btnShowAllRecordLinks.Text = "All records...";
            this.btnShowAllRecordLinks.UseVisualStyleBackColor = true;
            this.btnShowAllRecordLinks.Click += new System.EventHandler(this.btnShowAllRecordLinks_Click);
            // 
            // linkRecord
            // 
            this.linkRecord.AutoSize = true;
            this.linkRecord.LinkArea = new System.Windows.Forms.LinkArea(0, 0);
            this.linkRecord.Location = new System.Drawing.Point(58, 10);
            this.linkRecord.Name = "linkRecord";
            this.linkRecord.Size = new System.Drawing.Size(53, 13);
            this.linkRecord.TabIndex = 5;
            this.linkRecord.Text = "Unknown";
            this.linkRecord.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_LinkClicked);
            // 
            // lblTrigger
            // 
            this.lblTrigger.AutoSize = true;
            this.lblTrigger.Location = new System.Drawing.Point(4, 9);
            this.lblTrigger.Name = "lblTrigger";
            this.lblTrigger.Size = new System.Drawing.Size(57, 13);
            this.lblTrigger.TabIndex = 8;
            this.lblTrigger.Text = "Trigged by";
            // 
            // picIcon
            // 
            this.picIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picIcon.Image = ((System.Drawing.Image)(resources.GetObject("picIcon.Image")));
            this.picIcon.Location = new System.Drawing.Point(536, 0);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(32, 32);
            this.picIcon.TabIndex = 12;
            this.picIcon.TabStop = false;
            // 
            // TraceControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.picIcon);
            this.Controls.Add(this.textMessage);
            this.Controls.Add(this.panLinks);
            this.HideOnClose = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TraceControl";
            this.TabText = "Trace Message";
            this.TopMost = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TraceControl_KeyDown);
            this.panLinks.ResumeLayout(false);
            this.panLinks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
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
        private System.Windows.Forms.PictureBox picIcon;
    }
}
