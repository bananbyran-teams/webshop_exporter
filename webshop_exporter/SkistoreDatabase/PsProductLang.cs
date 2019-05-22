using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsProductLang
    {
        public int IdProduct { get; set; }
        public int IdShop { get; set; }
        public int IdLang { get; set; }
        public string Description { get; set; }
        public string DescriptionShort { get; set; }
        public string LinkRewrite { get; set; }
        public string MetaDescription { get; set; }
        public string MetaKeywords { get; set; }
        public string MetaTitle { get; set; }
        public string Name { get; set; }
        public string AvailableNow { get; set; }
        public string AvailableLater { get; set; }
    }
}
