using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsCustomerMessage
    {
        public int IdCustomerMessage { get; set; }
        public int? IdCustomerThread { get; set; }
        public int? IdEmployee { get; set; }
        public string Message { get; set; }
        public string FileName { get; set; }
        public string IpAddress { get; set; }
        public string UserAgent { get; set; }
        public byte Private { get; set; }
        public byte Read { get; set; }
        public DateTime DateAdd { get; set; }
        public DateTime DateUpd { get; set; }
    }
}
