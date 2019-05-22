using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsOrderSlip
    {
        public int IdOrderSlip { get; set; }
        public decimal ConversionRate { get; set; }
        public int IdCustomer { get; set; }
        public int IdOrder { get; set; }
        public byte ShippingCost { get; set; }
        public decimal Amount { get; set; }
        public decimal ShippingCostAmount { get; set; }
        public byte Partial { get; set; }
        public DateTime DateAdd { get; set; }
        public DateTime DateUpd { get; set; }
    }
}
