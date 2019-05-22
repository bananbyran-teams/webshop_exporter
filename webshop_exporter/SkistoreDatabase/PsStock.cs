using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsStock
    {
        public int IdStock { get; set; }
        public int IdWarehouse { get; set; }
        public int IdProduct { get; set; }
        public int IdProductAttribute { get; set; }
        public string Reference { get; set; }
        public string Ean13 { get; set; }
        public string Upc { get; set; }
        public int PhysicalQuantity { get; set; }
        public int UsableQuantity { get; set; }
        public decimal? PriceTe { get; set; }
    }
}
