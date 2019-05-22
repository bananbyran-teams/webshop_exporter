using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsDelivery
    {
        public int IdDelivery { get; set; }
        public int? IdShop { get; set; }
        public int? IdShopGroup { get; set; }
        public int IdCarrier { get; set; }
        public int? IdRangePrice { get; set; }
        public int? IdRangeWeight { get; set; }
        public int IdZone { get; set; }
        public decimal Price { get; set; }
    }
}
