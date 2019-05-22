using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class WpBooking
    {
        public long BookingId { get; set; }
        public long IsNew { get; set; }
        public string Status { get; set; }
        public DateTime? SortDate { get; set; }
        public DateTime? ModificationDate { get; set; }
        public string Form { get; set; }
        public long BookingType { get; set; }
    }
}
