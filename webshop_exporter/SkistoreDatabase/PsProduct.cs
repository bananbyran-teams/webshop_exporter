using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsProduct
    {
        public int IdProduct { get; set; }
        public int? IdSupplier { get; set; }
        public int? IdManufacturer { get; set; }
        public int? IdCategoryDefault { get; set; }
        public int IdShopDefault { get; set; }
        public byte OnSale { get; set; }
        public byte OnlineOnly { get; set; }
        public string Ean13 { get; set; }
        public string Upc { get; set; }
        public decimal Ecotax { get; set; }
        public int Quantity { get; set; }
        public int MinimalQuantity { get; set; }
        public decimal Price { get; set; }
        public decimal WholesalePrice { get; set; }
        public string Unity { get; set; }
        public decimal UnitPriceRatio { get; set; }
        public decimal AdditionalShippingCost { get; set; }
        public string Reference { get; set; }
        public string SupplierReference { get; set; }
        public string Location { get; set; }
        public decimal Width { get; set; }
        public decimal Height { get; set; }
        public decimal Depth { get; set; }
        public decimal Weight { get; set; }
        public int OutOfStock { get; set; }
        public byte? QuantityDiscount { get; set; }
        public byte Customizable { get; set; }
        public byte UploadableFiles { get; set; }
        public byte TextFields { get; set; }
        public byte Active { get; set; }
        public string RedirectType { get; set; }
        public int IdProductRedirected { get; set; }
        public byte AvailableForOrder { get; set; }
        public DateTime AvailableDate { get; set; }
        public string Condition { get; set; }
        public byte ShowPrice { get; set; }
        public byte Indexed { get; set; }
        public string Visibility { get; set; }
        public byte CacheIsPack { get; set; }
        public byte CacheHasAttachments { get; set; }
        public byte IsVirtual { get; set; }
        public int? CacheDefaultAttribute { get; set; }
        public DateTime DateAdd { get; set; }
        public DateTime DateUpd { get; set; }
        public int IdProductImporterosc { get; set; }
        public int? ExtraImg { get; set; }
        public byte AdvancedStockManagement { get; set; }
        public int IdTaxRulesGroup { get; set; }
    }
}
