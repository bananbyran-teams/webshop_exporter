using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsCustomizedData
    {
        public int IdCustomization { get; set; }
        public byte Type { get; set; }
        public int Index { get; set; }
        public string Value { get; set; }
    }
}
