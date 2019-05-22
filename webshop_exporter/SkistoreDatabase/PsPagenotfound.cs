using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsPagenotfound
    {
        public int IdPagenotfound { get; set; }
        public int? IdShop { get; set; }
        public int? IdShopGroup { get; set; }
        public string RequestUri { get; set; }
        public string HttpReferer { get; set; }
        public DateTime DateAdd { get; set; }
    }
}
