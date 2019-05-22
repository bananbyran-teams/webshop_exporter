using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsCsslider
    {
        public int IdSlider { get; set; }
        public string Url { get; set; }
        public int? Position { get; set; }
        public byte Display { get; set; }
        public int IdShop { get; set; }
    }
}
