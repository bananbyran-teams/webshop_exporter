using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsCustomerThread
    {
        public int IdCustomerThread { get; set; }
        public int IdShop { get; set; }
        public int IdLang { get; set; }
        public int IdContact { get; set; }
        public int? IdCustomer { get; set; }
        public int? IdOrder { get; set; }
        public int? IdProduct { get; set; }
        public string Status { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }
        public DateTime DateAdd { get; set; }
        public DateTime DateUpd { get; set; }
    }
}
