using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsSupplyOrderDetail
    {
        public int IdSupplyOrderDetail { get; set; }
        public int IdSupplyOrder { get; set; }
        public int IdCurrency { get; set; }
        public int IdProduct { get; set; }
        public int IdProductAttribute { get; set; }
        public string Reference { get; set; }
        public string SupplierReference { get; set; }
        public string Name { get; set; }
        public string Ean13 { get; set; }
        public string Upc { get; set; }
        public decimal? ExchangeRate { get; set; }
        public decimal? UnitPriceTe { get; set; }
        public int QuantityExpected { get; set; }
        public int QuantityReceived { get; set; }
        public decimal? PriceTe { get; set; }
        public decimal? DiscountRate { get; set; }
        public decimal? DiscountValueTe { get; set; }
        public decimal? PriceWithDiscountTe { get; set; }
        public decimal? TaxRate { get; set; }
        public decimal? TaxValue { get; set; }
        public decimal? PriceTi { get; set; }
        public decimal? TaxValueWithOrderDiscount { get; set; }
        public decimal? PriceWithOrderDiscountTe { get; set; }
    }
}
