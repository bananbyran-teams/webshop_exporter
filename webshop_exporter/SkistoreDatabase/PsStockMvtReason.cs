using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsStockMvtReason
    {
        public int IdStockMvtReason { get; set; }
        public byte Sign { get; set; }
        public DateTime DateAdd { get; set; }
        public DateTime DateUpd { get; set; }
        public byte Deleted { get; set; }
    }
}
