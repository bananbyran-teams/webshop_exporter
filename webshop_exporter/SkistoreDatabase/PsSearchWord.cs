using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsSearchWord
    {
        public int IdWord { get; set; }
        public int IdShop { get; set; }
        public int IdLang { get; set; }
        public string Word { get; set; }
    }
}
