using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsLoyalty
    {
        public int IdLoyalty { get; set; }
        public int IdLoyaltyState { get; set; }
        public int IdCustomer { get; set; }
        public int? IdOrder { get; set; }
        public int? IdCartRule { get; set; }
        public int Points { get; set; }
        public DateTime DateAdd { get; set; }
        public DateTime DateUpd { get; set; }
    }
}
