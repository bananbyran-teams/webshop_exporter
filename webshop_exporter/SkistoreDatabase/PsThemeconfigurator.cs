using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsThemeconfigurator
    {
        public int IdItem { get; set; }
        public int IdShop { get; set; }
        public int IdLang { get; set; }
        public int ItemOrder { get; set; }
        public string Title { get; set; }
        public byte TitleUse { get; set; }
        public string Hook { get; set; }
        public string Url { get; set; }
        public byte Target { get; set; }
        public string Image { get; set; }
        public string ImageW { get; set; }
        public string ImageH { get; set; }
        public string Html { get; set; }
        public byte Active { get; set; }
    }
}
