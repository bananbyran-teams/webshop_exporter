using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsPaypalCustomer
    {
        public int IdPaypalCustomer { get; set; }
        public int IdCustomer { get; set; }
        public string PaypalEmail { get; set; }
    }
}
