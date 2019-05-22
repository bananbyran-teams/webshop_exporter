using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsPsgdprLog
    {
        public int IdGdprLog { get; set; }
        public int? IdCustomer { get; set; }
        public int? IdGuest { get; set; }
        public string ClientName { get; set; }
        public int IdModule { get; set; }
        public int RequestType { get; set; }
        public DateTime DateAdd { get; set; }
        public DateTime DateUpd { get; set; }
    }
}
