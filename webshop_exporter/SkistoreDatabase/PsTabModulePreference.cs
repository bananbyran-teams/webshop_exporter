using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsTabModulePreference
    {
        public int IdTabModulePreference { get; set; }
        public int IdEmployee { get; set; }
        public int IdTab { get; set; }
        public string Module { get; set; }
    }
}
