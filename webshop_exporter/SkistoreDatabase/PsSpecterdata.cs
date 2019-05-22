using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsSpecterdata
    {
        public int IdSpecterData { get; set; }
        public int Type { get; set; }
        public string ArticleNumber { get; set; }
        public int InStock { get; set; }
        public string SpecterOrderId { get; set; }
        public string TrackingNumber { get; set; }
        public string InvoiceId { get; set; }
        public string ProductData { get; set; }
    }
}
