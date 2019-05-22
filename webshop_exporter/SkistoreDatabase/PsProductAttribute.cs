using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsProductAttribute
    {
        public int IdProductAttribute { get; set; }
        public int IdProduct { get; set; }
        public string Reference { get; set; }
        public string SupplierReference { get; set; }
        public string Location { get; set; }
        public string Ean13 { get; set; }
        public string Upc { get; set; }
        public decimal WholesalePrice { get; set; }
        public decimal Price { get; set; }
        public decimal Ecotax { get; set; }
        public int Quantity { get; set; }
        public decimal Weight { get; set; }
        public decimal UnitPriceImpact { get; set; }
        public byte DefaultOn { get; set; }
        public int MinimalQuantity { get; set; }
        public int IdProductAttributeImporterosc { get; set; }
        public int IdProductImporterosc { get; set; }
        public DateTime DateUpd { get; set; }
        public DateTime AvailableDate { get; set; }
    }
}
