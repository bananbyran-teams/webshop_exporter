using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsWishlist
    {
        public int IdWishlist { get; set; }
        public int IdCustomer { get; set; }
        public string Token { get; set; }
        public string Name { get; set; }
        public int? Counter { get; set; }
        public int? IdShop { get; set; }
        public int? IdShopGroup { get; set; }
        public DateTime DateAdd { get; set; }
        public DateTime DateUpd { get; set; }
        public int Default { get; set; }
    }
}
