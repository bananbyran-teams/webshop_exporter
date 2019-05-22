using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsShopUrl
    {
        public int IdShopUrl { get; set; }
        public int IdShop { get; set; }
        public string Domain { get; set; }
        public string DomainSsl { get; set; }
        public string PhysicalUri { get; set; }
        public string VirtualUri { get; set; }
        public byte Main { get; set; }
        public byte Active { get; set; }
    }
}
