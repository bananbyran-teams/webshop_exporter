using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsOrderReturnDetail
    {
        public int IdOrderReturn { get; set; }
        public int IdOrderDetail { get; set; }
        public int IdCustomization { get; set; }
        public int ProductQuantity { get; set; }
    }
}
