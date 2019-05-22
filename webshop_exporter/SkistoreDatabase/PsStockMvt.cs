using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsStockMvt
    {
        public long IdStockMvt { get; set; }
        public int IdStock { get; set; }
        public int? IdOrder { get; set; }
        public int? IdSupplyOrder { get; set; }
        public int IdStockMvtReason { get; set; }
        public int IdEmployee { get; set; }
        public string EmployeeLastname { get; set; }
        public string EmployeeFirstname { get; set; }
        public int PhysicalQuantity { get; set; }
        public DateTime DateAdd { get; set; }
        public byte Sign { get; set; }
        public decimal? PriceTe { get; set; }
        public decimal? LastWa { get; set; }
        public decimal? CurrentWa { get; set; }
        public long? Referer { get; set; }
    }
}
