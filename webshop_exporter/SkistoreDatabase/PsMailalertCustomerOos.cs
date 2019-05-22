using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsMailalertCustomerOos
    {
        public int IdCustomer { get; set; }
        public string CustomerEmail { get; set; }
        public int IdProduct { get; set; }
        public int IdProductAttribute { get; set; }
        public int IdShop { get; set; }
        public int IdLang { get; set; }
    }
}
