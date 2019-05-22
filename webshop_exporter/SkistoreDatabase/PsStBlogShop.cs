using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsStBlogShop
    {
        public int IdStBlog { get; set; }
        public int IdShop { get; set; }
        public byte Active { get; set; }
        public int? IdStBlogCategoryDefault { get; set; }
        public int Counter { get; set; }
    }
}
