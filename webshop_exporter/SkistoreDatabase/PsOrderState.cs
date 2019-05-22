using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsOrderState
    {
        public int IdOrderState { get; set; }
        public byte? Invoice { get; set; }
        public byte SendEmail { get; set; }
        public string ModuleName { get; set; }
        public string Color { get; set; }
        public byte Unremovable { get; set; }
        public byte Hidden { get; set; }
        public byte Logable { get; set; }
        public byte Delivery { get; set; }
        public byte Shipped { get; set; }
        public byte Paid { get; set; }
        public byte Deleted { get; set; }
    }
}
