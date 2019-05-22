using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsPmAdvancedsearchSeoLang
    {
        public int IdSeo { get; set; }
        public int IdLang { get; set; }
        public string MetaTitle { get; set; }
        public string MetaDescription { get; set; }
        public string MetaKeywords { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string SeoUrl { get; set; }
    }
}
