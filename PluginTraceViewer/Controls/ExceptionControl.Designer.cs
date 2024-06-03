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
            this.textException = new System.Windows.Forms.RichTextBox();
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
            this.textException.Size = new System.Drawing.Size(581, 261);
            this.textException.TabIndex = 6;
            this.textException.Text = "";
            this.textException.WordWrap = false;
            // 
            // ExceptionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(581, 261);
            this.Controls.Add(this.textException);
            this.HideOnClose = true;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExceptionControl";
            this.TabText = "Exception";
            this.TopMost = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ExceptionControl_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.RichTextBox textException;
    }
}
