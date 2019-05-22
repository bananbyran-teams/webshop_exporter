using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsNostotaggingCustomerLink
    {
        public int IdCart { get; set; }
        public string IdNostoCustomer { get; set; }
        public DateTime DateAdd { get; set; }
        public DateTime? DateUpd { get; set; }
    }
}
