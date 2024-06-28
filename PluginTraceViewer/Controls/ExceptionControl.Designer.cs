namespace Cinteros.XTB.PluginTraceViewer.Controls
{
    partial class ExceptionControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExceptionControl));
            this.textException = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnShowAllRecordLinks = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textException
            // 
            this.textException.BackColor = System.Drawing.SystemColors.Window;
            this.textException.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textException.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textException.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textException.Location = new System.Drawing.Point(0, 0);
            this.textException.Name = "textException";
            this.textException.ReadOnly = true;
            this.textException.Size = new System.Drawing.Size(584, 261);
            this.textException.TabIndex = 6;
            this.textException.Text = "";
            this.textException.WordWrap = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(534, 229);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnShowAllRecordLinks
            // 
            this.btnShowAllRecordLinks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowAllRecordLinks.Enabled = false;
            this.btnShowAllRecordLinks.Location = new System.Drawing.Point(422, 233);
            this.btnShowAllRecordLinks.Name = "btnShowAllRecordLinks";
            this.btnShowAllRecordLinks.Size = new System.Drawing.Size(106, 23);
            this.btnShowAllRecordLinks.TabIndex = 8;
            this.btnShowAllRecordLinks.Text = "No records";
            this.btnShowAllRecordLinks.UseVisualStyleBackColor = true;
            this.btnShowAllRecordLinks.Click += new System.EventHandler(this.btnShowAllRecordLinks_Click);
            // 
            // ExceptionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.btnShowAllRecordLinks);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textException);
            this.HideOnClose = true;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExceptionControl";
            this.TabText = "Exception";
            this.TopMost = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ExceptionControl_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.RichTextBox textException;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnShowAllRecordLinks;
    }
}
