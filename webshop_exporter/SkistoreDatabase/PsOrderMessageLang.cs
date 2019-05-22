using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsOrderMessageLang
    {
        public int IdOrderMessage { get; set; }
        public int IdLang { get; set; }
        public string Name { get; set; }
        public string Message { get; set; }
    }
}
