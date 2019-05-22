using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsOrderSlipDetail
    {
        public int IdOrderSlip { get; set; }
        public int IdOrderDetail { get; set; }
        public int ProductQuantity { get; set; }
        public decimal? AmountTaxExcl { get; set; }
        public decimal? AmountTaxIncl { get; set; }
    }
}
