using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsKlarnaOrders
    {
        public int Id { get; set; }
        public int IdOrder { get; set; }
        public int IdShop { get; set; }
        public string Ssn { get; set; }
        public string Invoicenumber { get; set; }
        public string Eid { get; set; }
        public string Reservation { get; set; }
        public string RiskStatus { get; set; }
    }
}
