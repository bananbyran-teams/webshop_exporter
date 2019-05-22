using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsCms
    {
        public int IdCms { get; set; }
        public int IdShop { get; set; }
        public int IdCmsCategory { get; set; }
        public int Position { get; set; }
        public byte Active { get; set; }
        public byte? Indexation { get; set; }
    }
}
