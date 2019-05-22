using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsOrderReturn
    {
        public int IdOrderReturn { get; set; }
        public int IdCustomer { get; set; }
        public int IdOrder { get; set; }
        public byte State { get; set; }
        public string Question { get; set; }
        public DateTime DateAdd { get; set; }
        public DateTime DateUpd { get; set; }
    }
}
