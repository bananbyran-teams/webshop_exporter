using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsDibsSimplifiedCheckout
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string CardType { get; set; }
        public string CardNum { get; set; }
        public string TicketId { get; set; }
    }
}
