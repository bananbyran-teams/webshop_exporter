using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsRcPgtagmanagerOrdersSent
    {
        public int IdOrder { get; set; }
        public int IdShop { get; set; }
        public string SentFrom { get; set; }
        public DateTime SentAt { get; set; }
    }
}
