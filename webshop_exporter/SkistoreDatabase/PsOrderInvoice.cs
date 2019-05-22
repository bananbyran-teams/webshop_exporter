using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsOrderInvoice
    {
        public int IdOrderInvoice { get; set; }
        public int IdOrder { get; set; }
        public int Number { get; set; }
        public int DeliveryNumber { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public decimal TotalDiscountTaxExcl { get; set; }
        public decimal TotalDiscountTaxIncl { get; set; }
        public decimal TotalPaidTaxExcl { get; set; }
        public decimal TotalPaidTaxIncl { get; set; }
        public decimal TotalProducts { get; set; }
        public decimal TotalProductsWt { get; set; }
        public decimal TotalShippingTaxExcl { get; set; }
        public decimal TotalShippingTaxIncl { get; set; }
        public int ShippingTaxComputationMethod { get; set; }
        public decimal TotalWrappingTaxExcl { get; set; }
        public decimal TotalWrappingTaxIncl { get; set; }
        public string Note { get; set; }
        public DateTime DateAdd { get; set; }
    }
}
