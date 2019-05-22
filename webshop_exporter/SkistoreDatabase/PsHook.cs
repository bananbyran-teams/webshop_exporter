using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsHook
    {
        public int IdHook { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public byte Position { get; set; }
        public byte LiveEdit { get; set; }
    }
}
