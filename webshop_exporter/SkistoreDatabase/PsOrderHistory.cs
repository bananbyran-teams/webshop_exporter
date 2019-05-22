using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsOrderHistory
    {
        public int IdOrderHistory { get; set; }
        public int IdEmployee { get; set; }
        public int IdOrder { get; set; }
        public int IdOrderState { get; set; }
        public DateTime DateAdd { get; set; }
    }
}
