using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsHookModuleExceptions
    {
        public int IdHookModuleExceptions { get; set; }
        public int IdModule { get; set; }
        public int IdHook { get; set; }
        public int IdShop { get; set; }
        public string FileName { get; set; }
    }
}
