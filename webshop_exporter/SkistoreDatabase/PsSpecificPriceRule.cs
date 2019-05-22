using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsSpecificPriceRule
    {
        public int IdSpecificPriceRule { get; set; }
        public string Name { get; set; }
        public int IdShop { get; set; }
        public int IdCurrency { get; set; }
        public int IdCountry { get; set; }
        public int IdGroup { get; set; }
        public int FromQuantity { get; set; }
        public decimal? Price { get; set; }
        public decimal Reduction { get; set; }
        public string ReductionType { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
    }
}
