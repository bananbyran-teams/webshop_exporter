using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsScExportProduct
    {
        public int IdScExportProduct { get; set; }
        public int IdScExport { get; set; }
        public int IdProduct { get; set; }
        public int IdProductAttribute { get; set; }
        public byte Handled { get; set; }
        public byte Exported { get; set; }
    }
}
