using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsAttributeImpact
    {
        public int IdAttributeImpact { get; set; }
        public int IdProduct { get; set; }
        public int IdAttribute { get; set; }
        public decimal Weight { get; set; }
        public decimal Price { get; set; }
    }
}
