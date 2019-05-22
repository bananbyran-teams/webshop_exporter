using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsConfigurationKpi
    {
        public int IdConfigurationKpi { get; set; }
        public int? IdShopGroup { get; set; }
        public int? IdShop { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public DateTime DateAdd { get; set; }
        public DateTime DateUpd { get; set; }
    }
}
