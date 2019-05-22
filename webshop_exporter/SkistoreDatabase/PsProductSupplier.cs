using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsProductSupplier
    {
        public int IdProductSupplier { get; set; }
        public int IdProduct { get; set; }
        public int IdProductAttribute { get; set; }
        public int IdSupplier { get; set; }
        public string ProductSupplierReference { get; set; }
        public decimal ProductSupplierPriceTe { get; set; }
        public int IdCurrency { get; set; }
    }
}
