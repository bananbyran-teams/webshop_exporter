using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsHookModule
    {
        public int IdModule { get; set; }
        public int IdHook { get; set; }
        public int IdShop { get; set; }
        public byte Position { get; set; }
    }
}
