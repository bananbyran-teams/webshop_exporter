using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsAjaxFilters
    {
        public int IdAjaxFilter { get; set; }
        public int IdFilter { get; set; }
        public byte FilterType { get; set; }
        public int IdFilterValue { get; set; }
        public byte GroupEnabled { get; set; }
        public byte Enabled { get; set; }
        public byte Element { get; set; }
        public int Increment { get; set; }
        public string Prefix { get; set; }
        public string Postfix { get; set; }
        public string Extra { get; set; }
        public byte Location { get; set; }
        public byte GroupPosition { get; set; }
        public byte FilterPosition { get; set; }
    }
}
