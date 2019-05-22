using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsStBannerLang
    {
        public int IdStBanner { get; set; }
        public int IdLang { get; set; }
        public string Url { get; set; }
        public string Title { get; set; }
        public string ImageMultiLang { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
    }
}
