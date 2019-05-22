using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsKlarnaErrors
    {
        public int Id { get; set; }
        public int IdOrder { get; set; }
        public string ErrorMessage { get; set; }
    }
}
