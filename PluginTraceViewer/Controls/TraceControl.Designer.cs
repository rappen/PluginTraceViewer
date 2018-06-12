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
            this.textMessage = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // textMessage
            // 
            this.textMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textMessage.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMessage.Location = new System.Drawing.Point(0, 0);
            this.textMessage.MinimumSize = new System.Drawing.Size(4, 100);
            this.textMessage.Name = "textMessage";
            this.textMessage.ReadOnly = true;
            this.textMessage.Size = new System.Drawing.Size(560, 261);
            this.textMessage.TabIndex = 10;
            this.textMessage.Text = "";
            this.textMessage.WordWrap = false;
            // 
            // TraceControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 261);
            this.Controls.Add(this.textMessage);
            this.HideOnClose = true;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TraceControl";
            this.TabText = "Trace Message";
            this.TopMost = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TraceControl_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.RichTextBox textMessage;
    }
}
