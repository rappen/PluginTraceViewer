using System;
using System.Drawing;

namespace Cinteros.XTB.PluginTraceViewer.Controls
{
    public partial class StatsControl : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        private Size floatSize;

        public StatsControl()
        {
            InitializeComponent();
            floatSize = Size;
        }

        private void StatsControl_DockStateChanged(object sender, EventArgs e)
        {
            if (DockState == WeifenLuo.WinFormsUI.Docking.DockState.Float)
            {
                FloatPane.FloatWindow.Size = floatSize;
            }
        }
    }
}
