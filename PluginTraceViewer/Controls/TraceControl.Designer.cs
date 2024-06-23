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
            this.label9 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
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
            this.textMessage.Location = new System.Drawing.Point(0, 61);
            this.textMessage.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textMessage.MinimumSize = new System.Drawing.Size(7, 185);
            this.textMessage.Name = "textMessage";
            this.textMessage.ReadOnly = true;
            this.textMessage.ShowSelectionMargin = true;
            this.textMessage.Size = new System.Drawing.Size(1071, 574);
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
            this.panLinks.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panLinks.Name = "panLinks";
            this.panLinks.Size = new System.Drawing.Size(1071, 61);
            this.panLinks.TabIndex = 11;
            // 
            // picLegend
            // 
            this.picLegend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLegend.Image = ((System.Drawing.Image)(resources.GetObject("picLegend.Image")));
            this.picLegend.Location = new System.Drawing.Point(7, 7);
            this.picLegend.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.picLegend.Name = "picLegend";
            this.picLegend.Size = new System.Drawing.Size(44, 44);
            this.picLegend.TabIndex = 9;
            this.picLegend.TabStop = false;
            this.picLegend.Click += new System.EventHandler(this.picLegend_Click);
            // 
            // lblLoading
            // 
            this.lblLoading.BackColor = System.Drawing.SystemColors.Control;
            this.lblLoading.Location = new System.Drawing.Point(411, 7);
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
            this.btnShowAllRecordLinks.Location = new System.Drawing.Point(777, 7);
            this.btnShowAllRecordLinks.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnShowAllRecordLinks.Name = "btnShowAllRecordLinks";
            this.btnShowAllRecordLinks.Size = new System.Drawing.Size(194, 42);
            this.btnShowAllRecordLinks.TabIndex = 6;
            this.btnShowAllRecordLinks.Text = "No records";
            this.btnShowAllRecordLinks.UseVisualStyleBackColor = true;
            this.btnShowAllRecordLinks.Click += new System.EventHandler(this.btnShowAllRecordLinks_Click);
            // 
            // linkRecord
            // 
            this.linkRecord.AutoSize = true;
            this.linkRecord.LinkArea = new System.Windows.Forms.LinkArea(0, 0);
            this.linkRecord.Location = new System.Drawing.Point(152, 18);
            this.linkRecord.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.linkRecord.Name = "linkRecord";
            this.linkRecord.Size = new System.Drawing.Size(94, 25);
            this.linkRecord.TabIndex = 5;
            this.linkRecord.Text = "Unknown";
            this.linkRecord.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_LinkClicked);
            // 
            // lblTrigger
            // 
            this.lblTrigger.AutoSize = true;
            this.lblTrigger.Location = new System.Drawing.Point(53, 17);
            this.lblTrigger.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTrigger.Name = "lblTrigger";
            this.lblTrigger.Size = new System.Drawing.Size(105, 25);
            this.lblTrigger.TabIndex = 8;
            this.lblTrigger.Text = "Trigged by";
            // 
            // picIcon
            // 
            this.picIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picIcon.Image = ((System.Drawing.Image)(resources.GetObject("picIcon.Image")));
            this.picIcon.Location = new System.Drawing.Point(983, 0);
            this.picIcon.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(59, 59);
            this.picIcon.TabIndex = 12;
            this.picIcon.TabStop = false;
            // 
            // panLegend
            // 
            this.panLegend.BackColor = System.Drawing.SystemColors.Control;
            this.panLegend.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panLegend.Controls.Add(this.label9);
            this.panLegend.Controls.Add(this.linkLabel1);
            this.panLegend.Controls.Add(this.button1);
            this.panLegend.Controls.Add(this.label8);
            this.panLegend.Controls.Add(this.label7);
            this.panLegend.Controls.Add(this.label6);
            this.panLegend.Controls.Add(this.label5);
            this.panLegend.Controls.Add(this.label4);
            this.panLegend.Controls.Add(this.label3);
            this.panLegend.Controls.Add(this.label2);
            this.panLegend.Controls.Add(this.label1);
            this.panLegend.Location = new System.Drawing.Point(22, 72);
            this.panLegend.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panLegend.Name = "panLegend";
            this.panLegend.Size = new System.Drawing.Size(525, 427);
            this.panLegend.TabIndex = 13;
            this.panLegend.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 349);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(178, 25);
            this.label9.TabIndex = 9;
            this.label9.Text = "More ideas? Go to:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(22, 373);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(224, 25);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Tag = "https://github.com/rappen/PluginTraceViewer/issues/193";
            this.linkLabel1.Text = "Find more records! #193";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_LinkClicked);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(458, 6);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 54);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 260);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(459, 75);
            this.label8.TabIndex = 7;
            this.label8.Text = "Note:\r\nThe \'found record\' is inserted in the log.\r\nIdentified guid and table are " +
    "found in the original log.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LightGreen;
            this.label7.Location = new System.Drawing.Point(37, 210);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Apollo XV";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 181);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Green: Found Record";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightGray;
            this.label5.Location = new System.Drawing.Point(37, 144);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "rapp_rocket";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 118);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gray: Identified Table";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(37, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(383, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "a25fcc81-a39d-ee11-be37-002248a071f6 ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yellow: Identified Guid";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Legend";
            // 
            // TraceControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1071, 635);
            this.Controls.Add(this.panLegend);
            this.Controls.Add(this.picIcon);
            this.Controls.Add(this.textMessage);
            this.Controls.Add(this.panLinks);
            this.HideOnClose = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox picLegend;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}
