using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsPmAdvancedsearchCriterionGroup6
    {
        public int IdCriterionGroup { get; set; }
        public int IdSearch { get; set; }
        public string CriterionGroupType { get; set; }
        public string SortBy { get; set; }
        public string SortWay { get; set; }
        public int IdCriterionGroupLinked { get; set; }
        public byte DisplayType { get; set; }
        public byte IsMulticriteria { get; set; }
        public byte Range { get; set; }
        public decimal RangeNb { get; set; }
        public byte ShowAllDepth { get; set; }
        public byte OnlyChildren { get; set; }
        public byte IsCollapsed { get; set; }
        public byte Hidden { get; set; }
        public byte MaxDisplay { get; set; }
        public short Width { get; set; }
        public short OverflowHeight { get; set; }
        public byte Position { get; set; }
        public byte Visible { get; set; }
    }
}
