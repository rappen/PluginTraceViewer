using System.Windows.Forms;

namespace Cinteros.XTB.PluginTraceViewer.Controls
{
    public partial class TraceControl : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        private string findtext = "";

        public TraceControl()
        {
            InitializeComponent();
        }

        internal void SetLogText(string log)
        {
            textMessage.Clear();
            textMessage.Text = log;
            textMessage.SelectionStart = 0;
        }

        internal void Clear()
        {
            textMessage.Clear();
        }

        private void TraceControl_KeyDown(object sender, KeyEventArgs e)
        {
            var textBox = textMessage;
            findtext = FindTextHandler.HandleFindKeyPress(e, textBox, findtext);
        }
    }
}
