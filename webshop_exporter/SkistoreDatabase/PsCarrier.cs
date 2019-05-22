using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsCarrier
    {
        public int IdCarrier { get; set; }
        public int IdReference { get; set; }
        public int? IdTaxRulesGroup { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public byte Active { get; set; }
        public byte Deleted { get; set; }
        public byte ShippingHandling { get; set; }
        public byte RangeBehavior { get; set; }
        public byte IsModule { get; set; }
        public byte IsFree { get; set; }
        public byte ShippingExternal { get; set; }
        public byte NeedRange { get; set; }
        public string ExternalModuleName { get; set; }
        public int ShippingMethod { get; set; }
        public int Position { get; set; }
        public int? MaxWidth { get; set; }
        public int? MaxHeight { get; set; }
        public int? MaxDepth { get; set; }
        public decimal? MaxWeight { get; set; }
        public int? Grade { get; set; }
    }
}
