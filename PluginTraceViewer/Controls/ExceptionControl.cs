using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace Cinteros.XTB.PluginTraceViewer.Controls
{
    public partial class ExceptionControl : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        private string findtext = "";

        public ExceptionControl()
        {
            InitializeComponent();
        }

        internal void SetException(string text, string caption)
        {
            textException.Clear();
            textException.Text = text;
            textException.SelectionStart = 0;
            TabText = caption;
            if (string.IsNullOrWhiteSpace(text))
            {
                DockState =
                    DockState == DockState.DockTop ? DockState.DockTopAutoHide :
                    DockState == DockState.DockBottom ? DockState.DockBottomAutoHide :
                    DockState == DockState.DockLeft ? DockState.DockLeftAutoHide :
                    DockState == DockState.DockRight ? DockState.DockRightAutoHide :
                    DockState;
            }
            else
            {
                DockState =
                    DockState == DockState.DockTopAutoHide ? DockState.DockTop :
                    DockState == DockState.DockBottomAutoHide ? DockState.DockBottom :
                    DockState == DockState.DockLeftAutoHide ? DockState.DockLeft :
                    DockState == DockState.DockRightAutoHide ? DockState.DockRight :
                    DockState;
            }
        }

        internal void Clear()
        {
            textException.Clear();
            TabText = "Exception";
        }

        private void ExceptionControl_KeyDown(object sender, KeyEventArgs e)
        {
            var textBox = textException;
            findtext = FindTextHandler.HandleFindKeyPress(e, textBox, findtext);
        }
    }
}
