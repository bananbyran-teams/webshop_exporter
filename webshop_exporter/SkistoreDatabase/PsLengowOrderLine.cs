using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsLengowOrderLine
    {
        public int Id { get; set; }
        public int IdOrder { get; set; }
        public string IdOrderLine { get; set; }
    }
}
