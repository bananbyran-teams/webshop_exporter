using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsProductCarrier
    {
        public int IdProduct { get; set; }
        public int IdCarrierReference { get; set; }
        public int IdShop { get; set; }
    }
}
