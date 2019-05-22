using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsCustomizationField
    {
        public int IdCustomizationField { get; set; }
        public int IdProduct { get; set; }
        public byte Type { get; set; }
        public byte Required { get; set; }
    }
}
