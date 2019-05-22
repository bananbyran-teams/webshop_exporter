using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsMetaLang
    {
        public int IdMeta { get; set; }
        public int IdShop { get; set; }
        public int IdLang { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Keywords { get; set; }
        public string UrlRewrite { get; set; }
    }
}
