using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsSceneProducts
    {
        public int IdScene { get; set; }
        public int IdProduct { get; set; }
        public int XAxis { get; set; }
        public int YAxis { get; set; }
        public int ZoneWidth { get; set; }
        public int ZoneHeight { get; set; }
    }
}
