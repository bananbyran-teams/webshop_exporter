using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsConfigurationLang
    {
        public int IdConfiguration { get; set; }
        public int IdLang { get; set; }
        public string Value { get; set; }
        public DateTime? DateUpd { get; set; }
    }
}
