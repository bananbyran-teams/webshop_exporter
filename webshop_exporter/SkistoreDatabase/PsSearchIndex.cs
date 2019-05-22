using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsSearchIndex
    {
        public int IdProduct { get; set; }
        public int IdWord { get; set; }
        public short Weight { get; set; }
    }
}
