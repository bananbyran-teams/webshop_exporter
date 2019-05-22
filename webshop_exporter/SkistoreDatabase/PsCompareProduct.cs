using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsCompareProduct
    {
        public int IdProduct { get; set; }
        public DateTime DateAdd { get; set; }
        public DateTime DateUpd { get; set; }
        public int IdCompare { get; set; }
    }
}
