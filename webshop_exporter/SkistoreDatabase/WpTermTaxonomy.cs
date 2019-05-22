using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class WpTermTaxonomy
    {
        public long TermTaxonomyId { get; set; }
        public long TermId { get; set; }
        public string Taxonomy { get; set; }
        public string Description { get; set; }
        public long Parent { get; set; }
        public long Count { get; set; }
    }
}
