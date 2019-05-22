using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsProductGroupReductionCache
    {
        public int IdProduct { get; set; }
        public int IdGroup { get; set; }
        public decimal Reduction { get; set; }
    }
}
