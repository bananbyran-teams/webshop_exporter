using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsBdDiscount
    {
        public int IdDiscount { get; set; }
        public byte Type { get; set; }
        public double Amount { get; set; }
        public byte Enabled { get; set; }
        public byte Cumulable { get; set; }
        public int Priority { get; set; }
    }
}
