using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsAttributeGroup
    {
        public int IdAttributeGroup { get; set; }
        public byte IsColorGroup { get; set; }
        public int Position { get; set; }
        public string GroupType { get; set; }
    }
}
