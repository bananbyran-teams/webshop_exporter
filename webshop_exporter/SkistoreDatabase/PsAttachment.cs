using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsAttachment
    {
        public int IdAttachment { get; set; }
        public string File { get; set; }
        public string FileName { get; set; }
        public long FileSize { get; set; }
        public string Mime { get; set; }
    }
}
