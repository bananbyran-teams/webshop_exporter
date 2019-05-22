using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsShopGroup
    {
        public int IdShopGroup { get; set; }
        public string Name { get; set; }
        public byte ShareCustomer { get; set; }
        public byte ShareOrder { get; set; }
        public byte ShareStock { get; set; }
        public byte Active { get; set; }
        public byte Deleted { get; set; }
    }
}
