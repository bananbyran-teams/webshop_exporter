using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsPmAdvancedsearchCriterion4
    {
        public int IdCriterion { get; set; }
        public int IdCriterionGroup { get; set; }
        public int? Position { get; set; }
        public string Color { get; set; }
        public string SingleValue { get; set; }
        public byte LevelDepth { get; set; }
        public int? IdParent { get; set; }
        public byte Visible { get; set; }
        public byte IsCustom { get; set; }
    }
}
