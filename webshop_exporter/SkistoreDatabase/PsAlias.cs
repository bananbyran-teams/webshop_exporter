using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsAlias
    {
        public int IdAlias { get; set; }
        public string Alias { get; set; }
        public string Search { get; set; }
        public byte Active { get; set; }
    }
}
