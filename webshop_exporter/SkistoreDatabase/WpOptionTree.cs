using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class WpOptionTree
    {
        public int Id { get; set; }
        public string ItemId { get; set; }
        public string ItemTitle { get; set; }
        public string ItemDesc { get; set; }
        public string ItemType { get; set; }
        public string ItemOptions { get; set; }
        public int ItemSort { get; set; }
    }
}
