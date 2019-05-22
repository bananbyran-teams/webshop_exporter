using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsDibsSecurity
    {
        public int Id { get; set; }
        public int CartId { get; set; }
        public int? Severity { get; set; }
    }
}
