using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsConnections
    {
        public int IdConnections { get; set; }
        public int IdShopGroup { get; set; }
        public int IdGuest { get; set; }
        public int IdPage { get; set; }
        public long? IpAddress { get; set; }
        public DateTime DateAdd { get; set; }
        public string HttpReferer { get; set; }
        public int IdShop { get; set; }
    }
}
