using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsProductSale
    {
        public int IdProduct { get; set; }
        public int Quantity { get; set; }
        public int SaleNbr { get; set; }
        public DateTime DateUpd { get; set; }
    }
}
