using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsStBanner
    {
        public int IdStBanner { get; set; }
        public int IdStBannerGroup { get; set; }
        public int? IdCurrency { get; set; }
        public string Image { get; set; }
        public byte NewWindow { get; set; }
        public byte Active { get; set; }
        public int Position { get; set; }
    }
}
