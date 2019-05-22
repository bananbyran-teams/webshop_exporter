using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsPsgdprConsent
    {
        public int IdGdprConsent { get; set; }
        public int IdModule { get; set; }
        public int Active { get; set; }
        public int? Error { get; set; }
        public string ErrorMessage { get; set; }
        public DateTime DateAdd { get; set; }
        public DateTime DateUpd { get; set; }
    }
}
