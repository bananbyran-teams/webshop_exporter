using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsSupplyOrder
    {
        public int IdSupplyOrder { get; set; }
        public int IdSupplier { get; set; }
        public string SupplierName { get; set; }
        public int IdLang { get; set; }
        public int IdWarehouse { get; set; }
        public int IdSupplyOrderState { get; set; }
        public int IdCurrency { get; set; }
        public int IdRefCurrency { get; set; }
        public string Reference { get; set; }
        public DateTime DateAdd { get; set; }
        public DateTime DateUpd { get; set; }
        public DateTime? DateDeliveryExpected { get; set; }
        public decimal? TotalTe { get; set; }
        public decimal? TotalWithDiscountTe { get; set; }
        public decimal? TotalTax { get; set; }
        public decimal? TotalTi { get; set; }
        public decimal? DiscountRate { get; set; }
        public decimal? DiscountValueTe { get; set; }
        public byte? IsTemplate { get; set; }
    }
}
