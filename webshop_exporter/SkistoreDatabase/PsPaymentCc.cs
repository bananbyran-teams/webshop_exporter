using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsPaymentCc
    {
        public int IdOrderPayment { get; set; }
        public string IdOrderInvoice { get; set; }
        public int? IdOrder { get; set; }
        public int IdCurrency { get; set; }
        public decimal Amount { get; set; }
        public string PaymentMethod { get; set; }
        public decimal ConversionRate { get; set; }
        public string TransactionId { get; set; }
        public string CardNumber { get; set; }
        public string CardBrand { get; set; }
        public string CardExpiration { get; set; }
        public string CardHolder { get; set; }
        public DateTime DateAdd { get; set; }
    }
}
