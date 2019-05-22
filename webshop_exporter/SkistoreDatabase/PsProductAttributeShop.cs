using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsProductAttributeShop
    {
        public int IdProductAttribute { get; set; }
        public int IdShop { get; set; }
        public decimal WholesalePrice { get; set; }
        public decimal Price { get; set; }
        public decimal Ecotax { get; set; }
        public decimal Weight { get; set; }
        public decimal UnitPriceImpact { get; set; }
        public byte DefaultOn { get; set; }
        public int MinimalQuantity { get; set; }
        public DateTime AvailableDate { get; set; }
    }
}
