using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsProductCommentGrade
    {
        public int IdProductComment { get; set; }
        public int IdProductCommentCriterion { get; set; }
        public int Grade { get; set; }
    }
}
