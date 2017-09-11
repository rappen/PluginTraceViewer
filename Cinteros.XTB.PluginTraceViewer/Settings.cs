using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinteros.XTB.PluginTraceViewer
{
    public class Settings
    {
        public bool WordWrap { get; set; }
        public bool? UseLog { get; set; } = null;
        public string Version { get; set; }
        public bool LocalTime { get; set; } = false;
        public bool HighlightIdentical { get; set; } = true;
        public string HighlightColor { get; set; } = "#FFD0D0";
    }
}
