using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinteros.XTB.PluginTraceViewer
{
    public class Settings
    {
        public bool FilterHidden { get; set; } = false;
        public bool WordWrap { get; set; }
        public bool Statistics { get; set; } = true;
        public bool? UseLog { get; set; } = null;
        public string Version { get; set; }
        public bool LocalTime { get; set; } = false;
        public bool HighlightIdentical { get; set; } = true;
        public string HighligtColor { get; set; } = "#FFEEEEEE";
    }
}
