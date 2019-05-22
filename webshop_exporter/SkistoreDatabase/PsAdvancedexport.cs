using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsAdvancedexport
    {
        public int IdAdvancedexport { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string Fields { get; set; }
        public string Manufacturer { get; set; }
        public string Category { get; set; }
        public string Supplier { get; set; }
        public string Image { get; set; }
        public string Delimiter { get; set; }
        public int IdLang { get; set; }
        public byte Cron { get; set; }
        public int IdShop { get; set; }
        public string CustomersGroups { get; set; }
        public string Payment { get; set; }
        public string Carrier { get; set; }
        public string Status { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
    }
}
