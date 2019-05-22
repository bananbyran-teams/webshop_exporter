using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsCategoryLang
    {
        public int IdCategory { get; set; }
        public int IdShop { get; set; }
        public int IdLang { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string LinkRewrite { get; set; }
        public string MetaTitle { get; set; }
        public string MetaKeywords { get; set; }
        public string MetaDescription { get; set; }
    }
}
