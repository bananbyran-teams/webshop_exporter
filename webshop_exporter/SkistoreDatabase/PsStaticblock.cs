using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsStaticblock
    {
        public int IdBlock { get; set; }
        public string IdentifierBlock { get; set; }
        public int? Hook { get; set; }
        public byte IsActive { get; set; }
        public int IdShop { get; set; }
    }
}
