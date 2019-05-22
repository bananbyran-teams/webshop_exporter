using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsCurrency
    {
        public int IdCurrency { get; set; }
        public string Name { get; set; }
        public string IsoCode { get; set; }
        public string IsoCodeNum { get; set; }
        public string Sign { get; set; }
        public byte Blank { get; set; }
        public byte Format { get; set; }
        public byte Decimals { get; set; }
        public decimal ConversionRate { get; set; }
        public byte Deleted { get; set; }
        public byte Active { get; set; }
    }
}
