using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsCmsBlockPage
    {
        public int IdCmsBlockPage { get; set; }
        public int IdCmsBlock { get; set; }
        public int IdCms { get; set; }
        public byte IsCategory { get; set; }
    }
}
