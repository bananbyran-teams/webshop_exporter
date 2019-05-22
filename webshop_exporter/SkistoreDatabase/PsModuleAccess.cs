using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsModuleAccess
    {
        public int IdProfile { get; set; }
        public int IdModule { get; set; }
        public byte View { get; set; }
        public byte Configure { get; set; }
    }
}
