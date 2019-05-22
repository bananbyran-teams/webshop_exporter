using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsEditorialLang
    {
        public int IdEditorial { get; set; }
        public int IdLang { get; set; }
        public string BodyTitle { get; set; }
        public string BodySubheading { get; set; }
        public string BodyParagraph { get; set; }
        public string BodyLogoSubheading { get; set; }
    }
}
