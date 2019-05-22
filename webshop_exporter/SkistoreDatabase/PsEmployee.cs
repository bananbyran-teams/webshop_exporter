using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsEmployee
    {
        public int IdEmployee { get; set; }
        public int IdProfile { get; set; }
        public int IdLang { get; set; }
        public string Lastname { get; set; }
        public string Firstname { get; set; }
        public string Email { get; set; }
        public string Passwd { get; set; }
        public DateTimeOffset LastPasswdGen { get; set; }
        public DateTime? StatsDateFrom { get; set; }
        public DateTime? StatsDateTo { get; set; }
        public DateTime? StatsCompareFrom { get; set; }
        public DateTime? StatsCompareTo { get; set; }
        public int StatsCompareOption { get; set; }
        public string PreselectDateRange { get; set; }
        public string BoColor { get; set; }
        public string BoTheme { get; set; }
        public string BoCss { get; set; }
        public int DefaultTab { get; set; }
        public int BoWidth { get; set; }
        public byte BoMenu { get; set; }
        public byte Active { get; set; }
        public byte Optin { get; set; }
        public int IdLastOrder { get; set; }
        public int IdLastCustomerMessage { get; set; }
        public int IdLastCustomer { get; set; }
    }
}
