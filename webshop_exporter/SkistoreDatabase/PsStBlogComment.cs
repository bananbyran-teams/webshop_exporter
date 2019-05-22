using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsStBlogComment
    {
        public int IdStBlogComment { get; set; }
        public int IdParent { get; set; }
        public int IdStBlog { get; set; }
        public int IdShop { get; set; }
        public int IdCustomer { get; set; }
        public int? IdGuest { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string Content { get; set; }
        public string CustomerWebsite { get; set; }
        public byte Active { get; set; }
        public byte Deleted { get; set; }
        public DateTime DateAdd { get; set; }
    }
}
