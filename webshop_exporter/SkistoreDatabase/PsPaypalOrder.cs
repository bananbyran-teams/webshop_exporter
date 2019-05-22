using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsPaypalOrder
    {
        public int IdOrder { get; set; }
        public string IdTransaction { get; set; }
        public string IdInvoice { get; set; }
        public string Currency { get; set; }
        public string TotalPaid { get; set; }
        public string Shipping { get; set; }
        public int Capture { get; set; }
        public string PaymentDate { get; set; }
        public int PaymentMethod { get; set; }
        public string PaymentStatus { get; set; }
    }
}
