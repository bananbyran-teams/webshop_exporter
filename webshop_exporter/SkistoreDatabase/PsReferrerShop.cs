using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsReferrerShop
    {
        public int IdReferrer { get; set; }
        public int IdShop { get; set; }
        public int? CacheVisitors { get; set; }
        public int? CacheVisits { get; set; }
        public int? CachePages { get; set; }
        public int? CacheRegistrations { get; set; }
        public int? CacheOrders { get; set; }
        public decimal? CacheSales { get; set; }
        public decimal? CacheRegRate { get; set; }
        public decimal? CacheOrderRate { get; set; }
    }
}
