using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsPmAdsandslideshowElement
    {
        public int IdElement { get; set; }
        public int IdSlideshow { get; set; }
        public byte Type { get; set; }
        public byte Active { get; set; }
        public DateTime DateAdd { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public string Products { get; set; }
        public string BackgroundColor { get; set; }
        public short Position { get; set; }
        public short PauseDuration { get; set; }
        public byte DeleteAfter { get; set; }
        public string Target { get; set; }
        public byte Privacy { get; set; }
        public byte FitBackgroundImage { get; set; }
        public string ProductsImageSize { get; set; }
    }
}
