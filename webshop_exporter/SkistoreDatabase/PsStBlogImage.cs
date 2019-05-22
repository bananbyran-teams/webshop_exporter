using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsStBlogImage
    {
        public int IdStBlogImage { get; set; }
        public int IdStBlog { get; set; }
        public byte? Type { get; set; }
        public short Position { get; set; }
    }
}
