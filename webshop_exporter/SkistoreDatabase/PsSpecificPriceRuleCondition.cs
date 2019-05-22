using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsSpecificPriceRuleCondition
    {
        public int IdSpecificPriceRuleCondition { get; set; }
        public int IdSpecificPriceRuleConditionGroup { get; set; }
        public string Type { get; set; }
        public string Value { get; set; }
    }
}
