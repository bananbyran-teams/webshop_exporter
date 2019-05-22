using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsLayeredFriendlyUrl
    {
        public int IdLayeredFriendlyUrl { get; set; }
        public string UrlKey { get; set; }
        public string Data { get; set; }
        public int IdLang { get; set; }
    }
}
