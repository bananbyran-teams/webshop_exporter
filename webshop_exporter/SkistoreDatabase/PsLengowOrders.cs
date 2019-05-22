using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsLengowOrders
    {
        public int IdOrder { get; set; }
        public string IdOrderLengow { get; set; }
        public int? DeliveryAddressId { get; set; }
        public int IdShop { get; set; }
        public int IdShopGroup { get; set; }
        public int IdLang { get; set; }
        public int? IdFlux { get; set; }
        public string Marketplace { get; set; }
        public string Message { get; set; }
        public decimal TotalPaid { get; set; }
        public string Carrier { get; set; }
        public string Method { get; set; }
        public string Tracking { get; set; }
        public byte? SentMarketplace { get; set; }
        public string Extra { get; set; }
        public DateTime DateAdd { get; set; }
        public byte? IsDisabled { get; set; }
    }
}
