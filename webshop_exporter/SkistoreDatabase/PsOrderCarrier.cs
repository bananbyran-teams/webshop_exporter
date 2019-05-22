using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsOrderCarrier
    {
        public int IdOrderCarrier { get; set; }
        public int IdOrder { get; set; }
        public int IdCarrier { get; set; }
        public int? IdOrderInvoice { get; set; }
        public decimal Weight { get; set; }
        public decimal? ShippingCostTaxExcl { get; set; }
        public decimal? ShippingCostTaxIncl { get; set; }
        public string TrackingNumber { get; set; }
        public DateTime DateAdd { get; set; }
    }
}
