using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsTax
    {
        public int IdTax { get; set; }
        public decimal Rate { get; set; }
        public byte Active { get; set; }
        public byte Deleted { get; set; }
    }
}
