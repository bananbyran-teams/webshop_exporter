using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsStBannerGroup
    {
        public int IdStBannerGroup { get; set; }
        public string Name { get; set; }
        public int Location { get; set; }
        public int IdCategory { get; set; }
        public int IdManufacturer { get; set; }
        public int Layout { get; set; }
        public byte HideOnMobile { get; set; }
        public byte HoverEffect { get; set; }
        public byte Active { get; set; }
        public int Position { get; set; }
    }
}
