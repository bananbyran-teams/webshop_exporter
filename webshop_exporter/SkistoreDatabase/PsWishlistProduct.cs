using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsWishlistProduct
    {
        public int IdWishlistProduct { get; set; }
        public int IdWishlist { get; set; }
        public int IdProduct { get; set; }
        public int IdProductAttribute { get; set; }
        public int Quantity { get; set; }
        public int Priority { get; set; }
    }
}
