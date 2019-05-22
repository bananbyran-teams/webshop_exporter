using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsCountry
    {
        public int IdCountry { get; set; }
        public int IdZone { get; set; }
        public int IdCurrency { get; set; }
        public string IsoCode { get; set; }
        public int CallPrefix { get; set; }
        public byte Active { get; set; }
        public byte ContainsStates { get; set; }
        public byte NeedIdentificationNumber { get; set; }
        public byte NeedZipCode { get; set; }
        public string ZipCodeFormat { get; set; }
        public byte DisplayTaxLabel { get; set; }
    }
}
