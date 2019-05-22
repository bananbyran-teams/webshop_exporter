using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsStatssearch
    {
        public int IdStatssearch { get; set; }
        public int IdShop { get; set; }
        public int IdShopGroup { get; set; }
        public string Keywords { get; set; }
        public int Results { get; set; }
        public DateTime DateAdd { get; set; }
    }
}
