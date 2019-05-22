using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsSekeyword
    {
        public int IdSekeyword { get; set; }
        public int IdShop { get; set; }
        public int IdShopGroup { get; set; }
        public string Keyword { get; set; }
        public DateTime DateAdd { get; set; }
    }
}
