using System;

namespace Cinteros.XTB.PluginTraceViewer
{
    public class PTVFilter
    {
        public bool FilterHidden { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public string Plugin { get; set; }
        public string Message { get; set; }
        public string Entity { get; set; }
        public bool Exceptions { get; set; }
        public int Mode { get; set; }
        public int MinDuration { get; set; }
        public int MaxDuration { get; set; }
        public int Records { get; set; }
        public bool WordWrap { get; set; }
    }
}
