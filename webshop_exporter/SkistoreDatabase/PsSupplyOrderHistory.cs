using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsSupplyOrderHistory
    {
        public int IdSupplyOrderHistory { get; set; }
        public int IdSupplyOrder { get; set; }
        public int IdEmployee { get; set; }
        public string EmployeeLastname { get; set; }
        public string EmployeeFirstname { get; set; }
        public int IdState { get; set; }
        public DateTime DateAdd { get; set; }
    }
}
