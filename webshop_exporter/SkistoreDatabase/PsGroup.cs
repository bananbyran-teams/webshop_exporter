using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsGroup
    {
        public int IdGroup { get; set; }
        public decimal Reduction { get; set; }
        public byte PriceDisplayMethod { get; set; }
        public byte ShowPrices { get; set; }
        public DateTime DateAdd { get; set; }
        public DateTime DateUpd { get; set; }
    }
}
