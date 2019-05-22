using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsCmsBlock
    {
        public int IdCmsBlock { get; set; }
        public int IdCmsCategory { get; set; }
        public string Name { get; set; }
        public byte Location { get; set; }
        public int Position { get; set; }
        public byte DisplayStore { get; set; }
    }
}
