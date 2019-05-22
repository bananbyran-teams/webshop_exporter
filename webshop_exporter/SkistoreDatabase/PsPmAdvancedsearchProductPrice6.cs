using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsPmAdvancedsearchProductPrice6
    {
        public int IdCacheProduct { get; set; }
        public int IdCriterionGroup { get; set; }
        public int IdShop { get; set; }
        public int IdCurrency { get; set; }
        public int IdCountry { get; set; }
        public int IdGroup { get; set; }
        public decimal PriceWt { get; set; }
        public decimal ReductionAmount { get; set; }
        public string ReductionType { get; set; }
        public byte ReductionTax { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public byte IsSpecific { get; set; }
        public byte HasNoSpecific { get; set; }
        public int? IdSpecificPrice { get; set; }
        public int? ValidIdSpecificPrice { get; set; }
    }
}
