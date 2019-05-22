using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsSpecificPricePriority
    {
        public int IdSpecificPricePriority { get; set; }
        public int IdProduct { get; set; }
        public string Priority { get; set; }
    }
}
