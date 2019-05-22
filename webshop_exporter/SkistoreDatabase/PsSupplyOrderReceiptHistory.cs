using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsSupplyOrderReceiptHistory
    {
        public int IdSupplyOrderReceiptHistory { get; set; }
        public int IdSupplyOrderDetail { get; set; }
        public int IdEmployee { get; set; }
        public string EmployeeLastname { get; set; }
        public string EmployeeFirstname { get; set; }
        public int IdSupplyOrderState { get; set; }
        public int Quantity { get; set; }
        public DateTime DateAdd { get; set; }
    }
}
