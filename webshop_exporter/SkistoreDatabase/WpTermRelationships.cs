﻿using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class WpTermRelationships
    {
        public long ObjectId { get; set; }
        public long TermTaxonomyId { get; set; }
        public int TermOrder { get; set; }
    }
}
