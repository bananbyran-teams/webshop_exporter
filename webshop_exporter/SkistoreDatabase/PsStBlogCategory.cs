using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsStBlogCategory
    {
        public int IdStBlogCategory { get; set; }
        public int IdParent { get; set; }
        public byte LevelDepth { get; set; }
        public string Path { get; set; }
        public int Nleft { get; set; }
        public int Nright { get; set; }
        public byte Active { get; set; }
        public byte IsRootCategory { get; set; }
        public DateTime DateAdd { get; set; }
        public DateTime DateUpd { get; set; }
        public int Position { get; set; }
    }
}
