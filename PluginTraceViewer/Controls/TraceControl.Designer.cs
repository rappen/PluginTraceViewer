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
            this.picLegend = new System.Windows.Forms.PictureBox();
            this.lblLoading = new System.Windows.Forms.Label();
            this.btnShowAllRecordLinks = new System.Windows.Forms.Button();
            this.linkRecord = new System.Windows.Forms.LinkLabel();
            this.lblTrigger = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.panLegend = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnLedgendClose = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panLinks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLegend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.panLegend.SuspendLayout();
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
            this.textMessage.Size = new System.Drawing.Size(584, 311);
            this.textMessage.TabIndex = 10;
            this.textMessage.Text = "";
            this.textMessage.WordWrap = false;
            this.textMessage.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.textMessage_LinkClicked);
            // 
            // panLinks
            // 
            this.panLinks.Controls.Add(this.picLegend);
            this.panLinks.Controls.Add(this.lblLoading);
            this.panLinks.Controls.Add(this.btnShowAllRecordLinks);
            this.panLinks.Controls.Add(this.linkRecord);
            this.panLinks.Controls.Add(this.lblTrigger);
            this.panLinks.Dock = System.Windows.Forms.DockStyle.Top;
            this.panLinks.Location = new System.Drawing.Point(0, 0);
            this.panLinks.Name = "panLinks";
            this.panLinks.Size = new System.Drawing.Size(584, 33);
            this.panLinks.TabIndex = 11;
            // 
            // picLegend
            // 
            this.picLegend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLegend.Image = ((System.Drawing.Image)(resources.GetObject("picLegend.Image")));
            this.picLegend.Location = new System.Drawing.Point(4, 4);
            this.picLegend.Name = "picLegend";
            this.picLegend.Size = new System.Drawing.Size(24, 24);
            this.picLegend.TabIndex = 9;
            this.picLegend.TabStop = false;
            this.picLegend.Click += new System.EventHandler(this.picLegend_Click);
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
            this.btnShowAllRecordLinks.Text = "No records";
            this.btnShowAllRecordLinks.UseVisualStyleBackColor = true;
            this.btnShowAllRecordLinks.Click += new System.EventHandler(this.btnShowAllRecordLinks_Click);
            // 
            // linkRecord
            // 
            this.linkRecord.AutoSize = true;
            this.linkRecord.LinkArea = new System.Windows.Forms.LinkArea(0, 0);
            this.linkRecord.Location = new System.Drawing.Point(83, 10);
            this.linkRecord.Name = "linkRecord";
            this.linkRecord.Size = new System.Drawing.Size(53, 13);
            this.linkRecord.TabIndex = 5;
            this.linkRecord.Text = "Unknown";
            this.linkRecord.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_LinkClicked);
            // 
            // lblTrigger
            // 
            this.lblTrigger.AutoSize = true;
            this.lblTrigger.Location = new System.Drawing.Point(29, 9);
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
            // panLegend
            // 
            this.panLegend.BackColor = System.Drawing.SystemColors.Control;
            this.panLegend.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panLegend.Controls.Add(this.label10);
            this.panLegend.Controls.Add(this.label11);
            this.panLegend.Controls.Add(this.label9);
            this.panLegend.Controls.Add(this.linkLabel1);
            this.panLegend.Controls.Add(this.btnLedgendClose);
            this.panLegend.Controls.Add(this.label8);
            this.panLegend.Controls.Add(this.label7);
            this.panLegend.Controls.Add(this.label6);
            this.panLegend.Controls.Add(this.label5);
            this.panLegend.Controls.Add(this.label4);
            this.panLegend.Controls.Add(this.label3);
            this.panLegend.Controls.Add(this.label2);
            this.panLegend.Controls.Add(this.label1);
            this.panLegend.Location = new System.Drawing.Point(12, 39);
            this.panLegend.Name = "panLegend";
            this.panLegend.Size = new System.Drawing.Size(319, 284);
            this.panLegend.TabIndex = 13;
            this.panLegend.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Red;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(20, 146);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "a25fcc81";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 132);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(133, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Red: Found by Quick Filter";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 227);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "More ideas? Go to:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(12, 240);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(122, 13);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Tag = "https://github.com/rappen/PluginTraceViewer/issues/193";
            this.linkLabel1.Text = "Find more records! #193";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_LinkClicked);
            // 
            // btnLedgendClose
            // 
            this.btnLedgendClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLedgendClose.Image = ((System.Drawing.Image)(resources.GetObject("btnLedgendClose.Image")));
            this.btnLedgendClose.Location = new System.Drawing.Point(281, 3);
            this.btnLedgendClose.Name = "btnLedgendClose";
            this.btnLedgendClose.Size = new System.Drawing.Size(31, 29);
            this.btnLedgendClose.TabIndex = 8;
            this.btnLedgendClose.UseVisualStyleBackColor = true;
            this.btnLedgendClose.Click += new System.EventHandler(this.btnLedgendClose_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(253, 39);
            this.label8.TabIndex = 7;
            this.label8.Text = "Note:\r\nThe \'found record\' is inserted in the log.\r\nIdentified guid and table are " +
    "found in the original log.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LightGreen;
            this.label7.Location = new System.Drawing.Point(20, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Apollo XV";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Green: Found Record";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightGray;
            this.label5.Location = new System.Drawing.Point(20, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "rapp_rocket";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gray: Identified Table";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(20, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "a25fcc81-a39d-ee11-be37-002248a071f6 ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yellow: Identified Guid";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Legend";
            // 
            // TraceControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(584, 344);
            this.Controls.Add(this.panLegend);
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
            ((System.ComponentModel.ISupportInitialize)(this.picLegend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.panLegend.ResumeLayout(false);
            this.panLegend.PerformLayout();
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
        private System.Windows.Forms.Panel panLegend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLedgendClose;
        private System.Windows.Forms.PictureBox picLegend;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}
