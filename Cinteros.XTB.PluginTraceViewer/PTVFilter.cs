using System;
using System.Collections.Generic;

namespace Cinteros.XTB.PluginTraceViewer
{
    public class PTVFilter
    {
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public string Plugin { get; set; }
        public string Message { get; set; }
        public string Entity { get; set; }
        public string CorrelationId { get; set; }
        public bool Exceptions { get; set; }
        public int Operation { get; set; }
        public int Mode { get; set; }
        public int MinDuration { get; set; }
        public int MaxDuration { get; set; }
        public int Records { get; set; }
        public List<string> VisibleColumns { get; set; }
    }
}
