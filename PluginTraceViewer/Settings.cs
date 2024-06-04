using System.Collections.Generic;

namespace Cinteros.XTB.PluginTraceViewer
{
    public class Settings
    {
        public bool WordWrap { get; set; }
        public string Version { get; set; }
        public bool LocalTime { get; set; } = false;
        public bool FullyQualifiedPluginNames { get; set; } = false;
        public bool HighlightIdentical { get; set; } = true;
        public string HighlightColor { get; set; } = "#FFD0D0";
        public List<string> Columns { get; set; }
        public int RefreshMode { get; set; }
        public int RefreshInterval { get; set; } = 2000;
        public bool ShowQuickFilter { get; set; } = true;
        public bool HidePluginFromStep { get; set; } = true;
        public bool HideEntityFromStep { get; set; } = true;
        public bool IdentifyRecords { get; set; } = true;
        public bool HighlightGuids { get; set; } = true;
    }
}