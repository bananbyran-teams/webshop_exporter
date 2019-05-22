using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsManufacturerLang
    {
        public int IdManufacturer { get; set; }
        public int IdLang { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }
        public string MetaTitle { get; set; }
        public string MetaKeywords { get; set; }
        public string MetaDescription { get; set; }
    }
}
