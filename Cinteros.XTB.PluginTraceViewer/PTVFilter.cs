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
        public bool OperationPlugin { get; set; } = true;
        public bool OperationWF { get; set; } = true;
        public bool ModeSync { get; set; } = true;
        public bool ModeAsync { get; set; } = true;
        public bool StagePreVal { get; set; } = true;
        public bool StagePreOp { get; set; } = true;
        public bool StagePostOp { get; set; } = true;
        public int MinDuration { get; set; }
        public int MaxDuration { get; set; }
        public int Records { get; set; }
        public List<string> VisibleColumns { get; set; }
    }
}
