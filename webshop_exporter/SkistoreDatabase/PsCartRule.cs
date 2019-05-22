using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsCartRule
    {
        public int IdCartRule { get; set; }
        public int IdCustomer { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public int QuantityPerUser { get; set; }
        public int Priority { get; set; }
        public byte PartialUse { get; set; }
        public string Code { get; set; }
        public decimal MinimumAmount { get; set; }
        public byte MinimumAmountTax { get; set; }
        public int MinimumAmountCurrency { get; set; }
        public byte MinimumAmountShipping { get; set; }
        public byte CountryRestriction { get; set; }
        public byte CarrierRestriction { get; set; }
        public byte GroupRestriction { get; set; }
        public byte CartRuleRestriction { get; set; }
        public byte ProductRestriction { get; set; }
        public byte ShopRestriction { get; set; }
        public byte FreeShipping { get; set; }
        public decimal ReductionPercent { get; set; }
        public decimal ReductionAmount { get; set; }
        public byte ReductionTax { get; set; }
        public int ReductionCurrency { get; set; }
        public int ReductionProduct { get; set; }
        public int GiftProduct { get; set; }
        public int GiftProductAttribute { get; set; }
        public byte Highlight { get; set; }
        public byte Active { get; set; }
        public DateTime DateAdd { get; set; }
        public DateTime DateUpd { get; set; }
    }
}
