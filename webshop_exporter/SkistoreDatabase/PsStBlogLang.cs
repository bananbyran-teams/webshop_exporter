using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsStBlogLang
    {
        public int IdStBlog { get; set; }
        public int IdLang { get; set; }
        public string Name { get; set; }
        public string MetaTitle { get; set; }
        public string MetaDescription { get; set; }
        public string MetaKeywords { get; set; }
        public string Content { get; set; }
        public string ContentShort { get; set; }
        public string LinkRewrite { get; set; }
        public string Video { get; set; }
        public string Author { get; set; }
    }
}
