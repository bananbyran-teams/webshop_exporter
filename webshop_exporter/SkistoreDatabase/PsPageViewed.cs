using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsPageViewed
    {
        public int IdPage { get; set; }
        public int IdShopGroup { get; set; }
        public int IdShop { get; set; }
        public int IdDateRange { get; set; }
        public int Counter { get; set; }
    }
}
