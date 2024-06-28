using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace Cinteros.XTB.PluginTraceViewer.Controls
{
    public partial class ExceptionControl : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        private PluginTraceViewer ptv;
        private string findtext = "";
        private Links links;
        private string originallog;

        public ExceptionControl(PluginTraceViewer ptv)
        {
            this.ptv = ptv;
            InitializeComponent();
        }

        internal void SetException(string log, string caption)
        {
            textException.Clear();
            TabText = caption;
            if (string.IsNullOrWhiteSpace(log))
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
            originallog = log.Replace("\r\n", "\n");
            _ = ShowMessageTextAsync(ptv.tsmiHighlightGuids.Checked, ptv.tsmiIdentifyRecords.Checked);
        }

        internal async Task ShowMessageTextAsync(bool highlightguids, bool showlinks)
        {
            btnShowAllRecordLinks.Visible = showlinks;
            btnShowAllRecordLinks.Enabled = false;
            btnShowAllRecordLinks.Text = $"- records";
            textException.Text = originallog;
            if (string.IsNullOrWhiteSpace(originallog))
            {
                return;
            }
            if (highlightguids || showlinks)
            {
                links = new Links(textException.Text, ptv.recordlist, string.Empty);
                ptv.StopRefreshTimer();
                await Task.Run(() => links.MatchGuids(showlinks));
                ptv.StartRefreshTimer(false);
                if (showlinks)
                {
                    btnShowAllRecordLinks.Enabled = links.LinkRecords.Any();
                    btnShowAllRecordLinks.Text =
                        links.Count == 1 ? $"1 record" :
                        links.LinkRecords.Any() ? $"{links.LinkRecords.Count()} records" :
                        "No records";
                    textException.Text = links.InsertRecordsInLog();
                }
                links.HighlightRecords(textException);
            }
            textException.Select(0, 0);
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

        private void btnShowAllRecordLinks_Click(object sender, System.EventArgs e)
        {
            var allrecords = new RecordLinks();
            allrecords.SetRecords(links.LinkRecords, links.Target?.Record, ptv.ConnectionDetail);
            allrecords.ShowDialog();
        }
    }
}