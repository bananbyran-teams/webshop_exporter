using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsScExport
    {
        public int IdScExport { get; set; }
        public string Name { get; set; }
        public DateTime? LastExport { get; set; }
        public byte Exporting { get; set; }
        public int IdNext { get; set; }
        public int IdCombinationNext { get; set; }
        public int TotalLines { get; set; }
    }
}
