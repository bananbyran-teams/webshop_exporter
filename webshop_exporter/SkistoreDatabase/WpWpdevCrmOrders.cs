using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class WpWpdevCrmOrders
    {
        public long OrderId { get; set; }
        public string OrderInfo { get; set; }
        public long CustomerId { get; set; }
        public string Type { get; set; }
        public float Cost { get; set; }
        public long Tags { get; set; }
        public DateTime OrderDate { get; set; }
        public string Remark { get; set; }
        public long InternalId { get; set; }
        public string InternalFilters { get; set; }
        public string InternalFilters1 { get; set; }
        public DateTime InternalFilters2 { get; set; }
        public DateTime InternalFilters3 { get; set; }
    }
}
