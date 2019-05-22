using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsLengowProduct
    {
        public int IdProduct { get; set; }
        public int IdShop { get; set; }
        public int IdShopGroup { get; set; }
        public int IdLang { get; set; }
    }
}
