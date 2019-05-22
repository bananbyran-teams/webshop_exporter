using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsLoyaltyHistory
    {
        public int IdLoyaltyHistory { get; set; }
        public int? IdLoyalty { get; set; }
        public int IdLoyaltyState { get; set; }
        public int Points { get; set; }
        public DateTime DateAdd { get; set; }
    }
}
