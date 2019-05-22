using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsCarrierLang
    {
        public int IdCarrier { get; set; }
        public int IdShop { get; set; }
        public int IdLang { get; set; }
        public string Delay { get; set; }
    }
}
