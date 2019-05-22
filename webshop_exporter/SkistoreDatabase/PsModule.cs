using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsModule
    {
        public int IdModule { get; set; }
        public string Name { get; set; }
        public byte Active { get; set; }
        public string Version { get; set; }
    }
}
