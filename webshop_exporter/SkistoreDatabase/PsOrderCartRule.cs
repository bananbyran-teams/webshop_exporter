using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsOrderCartRule
    {
        public int IdOrderCartRule { get; set; }
        public int IdOrder { get; set; }
        public int IdCartRule { get; set; }
        public int IdOrderInvoice { get; set; }
        public string Name { get; set; }
        public decimal Value { get; set; }
        public decimal ValueTaxExcl { get; set; }
        public byte FreeShipping { get; set; }
    }
}
