using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsState
    {
        public int IdState { get; set; }
        public int IdCountry { get; set; }
        public int IdZone { get; set; }
        public string Name { get; set; }
        public string IsoCode { get; set; }
        public short TaxBehavior { get; set; }
        public byte Active { get; set; }
    }
}
