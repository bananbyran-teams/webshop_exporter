using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsCustomization
    {
        public int IdCustomization { get; set; }
        public int IdProductAttribute { get; set; }
        public int IdAddressDelivery { get; set; }
        public int IdCart { get; set; }
        public int IdProduct { get; set; }
        public int Quantity { get; set; }
        public int QuantityRefunded { get; set; }
        public int QuantityReturned { get; set; }
        public byte InCart { get; set; }
    }
}
