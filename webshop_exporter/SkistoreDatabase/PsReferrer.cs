using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsReferrer
    {
        public int IdReferrer { get; set; }
        public string Name { get; set; }
        public string Passwd { get; set; }
        public string HttpRefererRegexp { get; set; }
        public string HttpRefererLike { get; set; }
        public string RequestUriRegexp { get; set; }
        public string RequestUriLike { get; set; }
        public string HttpRefererRegexpNot { get; set; }
        public string HttpRefererLikeNot { get; set; }
        public string RequestUriRegexpNot { get; set; }
        public string RequestUriLikeNot { get; set; }
        public decimal BaseFee { get; set; }
        public decimal PercentFee { get; set; }
        public decimal ClickFee { get; set; }
        public DateTime DateAdd { get; set; }
    }
}
