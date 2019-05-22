using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsMessage
    {
        public int IdMessage { get; set; }
        public int? IdCart { get; set; }
        public int IdCustomer { get; set; }
        public int? IdEmployee { get; set; }
        public int IdOrder { get; set; }
        public string Message { get; set; }
        public byte Private { get; set; }
        public DateTime DateAdd { get; set; }
    }
}
