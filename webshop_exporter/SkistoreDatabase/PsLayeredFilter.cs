using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsLayeredFilter
    {
        public int IdLayeredFilter { get; set; }
        public string Name { get; set; }
        public string Filters { get; set; }
        public int NCategories { get; set; }
        public DateTime DateAdd { get; set; }
    }
}
