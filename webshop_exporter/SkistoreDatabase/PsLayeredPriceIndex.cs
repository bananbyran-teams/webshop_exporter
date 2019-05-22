using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsLayeredPriceIndex
    {
        public int IdProduct { get; set; }
        public int IdCurrency { get; set; }
        public int IdShop { get; set; }
        public int PriceMin { get; set; }
        public int PriceMax { get; set; }
    }
}
