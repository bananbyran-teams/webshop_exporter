using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsProductShop
    {
        public int IdProduct { get; set; }
        public int IdShop { get; set; }
        public int? IdCategoryDefault { get; set; }
        public int IdTaxRulesGroup { get; set; }
        public byte OnSale { get; set; }
        public byte OnlineOnly { get; set; }
        public decimal Ecotax { get; set; }
        public int MinimalQuantity { get; set; }
        public decimal Price { get; set; }
        public decimal WholesalePrice { get; set; }
        public string Unity { get; set; }
        public decimal UnitPriceRatio { get; set; }
        public decimal AdditionalShippingCost { get; set; }
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
        public int? CacheDefaultAttribute { get; set; }
        public byte AdvancedStockManagement { get; set; }
        public DateTime DateAdd { get; set; }
        public DateTime DateUpd { get; set; }
    }
}
