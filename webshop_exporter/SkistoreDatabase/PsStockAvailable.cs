using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsStockAvailable
    {
        public int IdStockAvailable { get; set; }
        public int IdProduct { get; set; }
        public int IdProductAttribute { get; set; }
        public int IdShop { get; set; }
        public int IdShopGroup { get; set; }
        public int Quantity { get; set; }
        public byte DependsOnStock { get; set; }
        public int OutOfStock { get; set; }
    }
}
