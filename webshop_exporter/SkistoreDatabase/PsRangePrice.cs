using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsRangePrice
    {
        public int IdRangePrice { get; set; }
        public int IdCarrier { get; set; }
        public decimal Delimiter1 { get; set; }
        public decimal Delimiter2 { get; set; }
    }
}
