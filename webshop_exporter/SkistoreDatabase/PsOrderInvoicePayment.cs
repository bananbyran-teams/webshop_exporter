using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsOrderInvoicePayment
    {
        public int IdOrderInvoice { get; set; }
        public int IdOrderPayment { get; set; }
        public int IdOrder { get; set; }
    }
}
