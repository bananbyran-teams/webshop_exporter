using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsWarehouseProductLocation
    {
        public int IdWarehouseProductLocation { get; set; }
        public int IdProduct { get; set; }
        public int IdProductAttribute { get; set; }
        public int IdWarehouse { get; set; }
        public string Location { get; set; }
    }
}
