using System;

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
        public string RequestId { get; set; }
        public bool Exceptions { get; set; }
        public bool OperationPlugin { get; set; } = true;
        public bool OperationWF { get; set; } = true;
        public bool ModeSync { get; set; } = true;
        public bool ModeAsync { get; set; } = true;
        public bool StagePreVal { get; set; } = true;
        public bool StagePreOp { get; set; } = true;
        public bool StagePostOp { get; set; } = true;
        public int MinDuration { get; set; } = -1;
        public int MaxDuration { get; set; } = -1;
        public int Records { get; set; } = 100;
        public bool SuppressSettingWarning { get; set; }
    }
}
