using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsCartRuleProductRuleGroup
    {
        public int IdProductRuleGroup { get; set; }
        public int IdCartRule { get; set; }
        public int Quantity { get; set; }
    }
}
