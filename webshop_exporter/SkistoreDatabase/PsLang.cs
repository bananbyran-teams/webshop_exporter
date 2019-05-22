using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsLang
    {
        public int IdLang { get; set; }
        public string Name { get; set; }
        public byte Active { get; set; }
        public string IsoCode { get; set; }
        public string LanguageCode { get; set; }
        public string DateFormatLite { get; set; }
        public string DateFormatFull { get; set; }
        public int IdLangImporterosc { get; set; }
        public byte IsRtl { get; set; }
    }
}
