using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsPmAdvancedsearch
    {
        public int IdSearch { get; set; }
        public int IdHook { get; set; }
        public byte Active { get; set; }
        public string InternalName { get; set; }
        public short Height { get; set; }
        public short Width { get; set; }
        public byte DisplayNbResultOnBlc { get; set; }
        public byte DisplayNbResultCriterion { get; set; }
        public byte SaveSelection { get; set; }
        public byte RemindSelection { get; set; }
        public byte ShowHideCritMethod { get; set; }
        public byte FilterByEmplacement { get; set; }
        public byte SearchOnStock { get; set; }
        public byte HideEmptyCritGroup { get; set; }
        public byte SearchMethod { get; set; }
        public byte DynamicCriterion { get; set; }
        public byte StepSearch { get; set; }
        public byte Share { get; set; }
        public byte UniqueSearch { get; set; }
        public byte ScrolltopActive { get; set; }
        public int IdCategoryRoot { get; set; }
        public byte RedirectOneProduct { get; set; }
        public byte AddAnchorToUrl { get; set; }
        public byte ResetGroup { get; set; }
        public byte CollapsableCriterias { get; set; }
        public byte InsertInCenterColumn { get; set; }
        public string SmartyVarName { get; set; }
        public string SearchResultsSelector { get; set; }
        public byte RecursingIndexing { get; set; }
        public byte DisplayEmptyCriteria { get; set; }
        public byte KeepCategoryInformation { get; set; }
        public byte PriorityOnCombinationImage { get; set; }
        public byte UseCache { get; set; }
        public byte ProductsPerPage { get; set; }
        public byte ProductsOrderBy { get; set; }
        public byte ProductsOrderWay { get; set; }
        public string BackgroundColor { get; set; }
        public string BorderColor { get; set; }
        public string BorderSize { get; set; }
        public string ColorGroupTitle { get; set; }
        public short? FontSizeGroupTitle { get; set; }
        public short? BorderRadius { get; set; }
        public string ColorTitle { get; set; }
        public short? FontSizeTitle { get; set; }
    }
}
