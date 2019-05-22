using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsProductComment
    {
        public int IdProductComment { get; set; }
        public int IdProduct { get; set; }
        public int IdCustomer { get; set; }
        public int? IdGuest { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string CustomerName { get; set; }
        public float Grade { get; set; }
        public byte Validate { get; set; }
        public byte Deleted { get; set; }
        public DateTime DateAdd { get; set; }
    }
}
