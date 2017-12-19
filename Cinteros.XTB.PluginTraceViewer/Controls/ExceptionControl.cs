using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinteros.XTB.PluginTraceViewer.Controls
{
    public partial class ExceptionControl : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        public ExceptionControl()
        {
            InitializeComponent();
        }

        internal void SetException(string text, string caption)
        {
            textException.Text = text;
            textException.SelectionStart = 0;
            TabText = caption;
        }

        internal void Clear()
        {
            textException.Clear();
            TabText = "Exception";
        }
    }
}
