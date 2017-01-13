﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinteros.XTB.PluginTraceViewer
{
    public class Settings
    {
        public bool FilterHidden { get; set; }
        public bool WordWrap { get; set; }
        public bool? UseLog { get; set; } = null;
        public string Version { get; set; }
    }
}