using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsStEasyTabs
    {
        public int IdStEasyTabs { get; set; }
        public int IdShop { get; set; }
        public int IdCategory { get; set; }
        public int IdProduct { get; set; }
        public int IdProductSpecific { get; set; }
        public int IdManufacturer { get; set; }
        public byte Allitems { get; set; }
        public byte Active { get; set; }
        public int Position { get; set; }
    }
}
