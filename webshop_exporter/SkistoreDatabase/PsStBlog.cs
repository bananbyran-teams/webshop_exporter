using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsStBlog
    {
        public int IdStBlog { get; set; }
        public byte Status { get; set; }
        public byte CommentsStatus { get; set; }
        public byte Active { get; set; }
        public byte Type { get; set; }
        public int Position { get; set; }
        public int? IdStBlogCategoryDefault { get; set; }
        public int Counter { get; set; }
        public DateTime DateAdd { get; set; }
        public DateTime DateUpd { get; set; }
        public byte AcceptComment { get; set; }
    }
}
