using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinteros.XTB.PluginTraceViewer
{
    public partial class About : Form
    {
        private PluginTraceViewer pluginTraceViewer;

        public About(PluginTraceViewer pluginTraceViewer)
        {
            InitializeComponent();
            this.pluginTraceViewer = pluginTraceViewer;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pluginTraceViewer.LogUse("About-OpenHomepage");
            System.Diagnostics.Process.Start("http://ptv.xrmtoolbox.com");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pluginTraceViewer.LogUse("About-OpenBlog");
            System.Diagnostics.Process.Start("http://jonasrapp.innofactor.se");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pluginTraceViewer.LogUse("About-OpenInnofactor");
            System.Diagnostics.Process.Start("http://www.innofactor.se");
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pluginTraceViewer.LogUse("About-OpenTwitter");
            System.Diagnostics.Process.Start("http://twitter.com/rappen");
        }

        private void chkStatAllow_CheckedChanged(object sender, EventArgs e)
        {
            if (Visible && chkStatAllow.Checked)
            {
                MessageBox.Show("Thank You!\n\nHappy debugging :)\n\n/Jonas", "Statistics", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
