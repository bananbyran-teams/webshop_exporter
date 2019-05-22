using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsTaxRule
    {
        public int IdTaxRule { get; set; }
        public int IdTaxRulesGroup { get; set; }
        public int IdCountry { get; set; }
        public int IdState { get; set; }
        public string ZipcodeFrom { get; set; }
        public string ZipcodeTo { get; set; }
        public int Behavior { get; set; }
        public int IdTax { get; set; }
        public string Description { get; set; }
    }
}
