using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsLayeredCategory
    {
        public int IdLayeredCategory { get; set; }
        public int IdShop { get; set; }
        public int IdCategory { get; set; }
        public int? IdValue { get; set; }
        public string Type { get; set; }
        public int Position { get; set; }
        public int FilterType { get; set; }
        public int FilterShowLimit { get; set; }
    }
}
