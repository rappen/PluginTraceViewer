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
    public partial class StatsControl : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        public StatsControl()
        {
            InitializeComponent();
        }

        private void StatsControl_DockStateChanged(object sender, EventArgs e)
        {
            if (DockState == WeifenLuo.WinFormsUI.Docking.DockState.Float)
            {
                FloatPane.FloatWindow.Size = new Size(463, 172);
            }
        }
    }
}
