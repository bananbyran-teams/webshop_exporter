using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsStFeaturedCategory
    {
        public int IdStFeaturedCategory { get; set; }
        public int IdParent { get; set; }
        public byte LevelDepth { get; set; }
        public int IdShop { get; set; }
        public int IdCategory { get; set; }
        public int Position { get; set; }
        public string TxtColor { get; set; }
        public string TxtColorOver { get; set; }
        public byte Active { get; set; }
        public byte AutoSub { get; set; }
        public string Cover { get; set; }
    }
}
