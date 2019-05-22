using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsStBlogProductLink
    {
        public int IdStBlog { get; set; }
        public int IdProduct { get; set; }
        public byte Active { get; set; }
        public int Position { get; set; }
    }
}
