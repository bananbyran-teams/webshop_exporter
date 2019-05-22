using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsImportMatch
    {
        public int IdImportMatch { get; set; }
        public string Name { get; set; }
        public string Match { get; set; }
        public int Skip { get; set; }
    }
}
