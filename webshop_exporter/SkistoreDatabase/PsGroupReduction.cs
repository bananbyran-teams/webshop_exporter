using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsGroupReduction
    {
        public int IdGroupReduction { get; set; }
        public int IdGroup { get; set; }
        public int IdCategory { get; set; }
        public decimal Reduction { get; set; }
    }
}
