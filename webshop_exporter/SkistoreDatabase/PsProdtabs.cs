using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsProdtabs
    {
        public int Id { get; set; }
        public int IdProduct { get; set; }
        public int Status { get; set; }
        public int IdShop { get; set; }
    }
}
