using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsPmAdvancedsearchSeo
    {
        public int IdSeo { get; set; }
        public int IdSearch { get; set; }
        public int IdCurrency { get; set; }
        public string Criteria { get; set; }
        public string SeoKey { get; set; }
        public byte Deleted { get; set; }
    }
}
