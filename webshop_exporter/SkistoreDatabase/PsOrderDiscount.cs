using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsOrderDiscount
    {
        public int IdOrderCartRule { get; set; }
        public int IdOrder { get; set; }
        public int IdCartRule { get; set; }
        public string Name { get; set; }
        public decimal Value { get; set; }
    }
}
