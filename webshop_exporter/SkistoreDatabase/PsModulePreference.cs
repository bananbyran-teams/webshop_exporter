using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsModulePreference
    {
        public int IdModulePreference { get; set; }
        public int IdEmployee { get; set; }
        public string Module { get; set; }
        public byte? Interest { get; set; }
        public byte? Favorite { get; set; }
    }
}
