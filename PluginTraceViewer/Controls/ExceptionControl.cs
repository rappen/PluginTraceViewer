using System.Windows.Forms;

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
