using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsWarehouse
    {
        public int IdWarehouse { get; set; }
        public int IdCurrency { get; set; }
        public int IdAddress { get; set; }
        public int IdEmployee { get; set; }
        public string Reference { get; set; }
        public string Name { get; set; }
        public string ManagementType { get; set; }
        public byte Deleted { get; set; }
    }
}
