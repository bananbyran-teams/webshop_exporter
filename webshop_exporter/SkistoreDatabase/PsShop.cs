using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsShop
    {
        public int IdShop { get; set; }
        public int IdShopGroup { get; set; }
        public string Name { get; set; }
        public int IdCategory { get; set; }
        public int IdTheme { get; set; }
        public byte Active { get; set; }
        public byte Deleted { get; set; }
    }
}
