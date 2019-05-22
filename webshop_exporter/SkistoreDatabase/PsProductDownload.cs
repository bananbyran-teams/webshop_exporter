using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsProductDownload
    {
        public int IdProductDownload { get; set; }
        public int IdProduct { get; set; }
        public string DisplayFilename { get; set; }
        public string Filename { get; set; }
        public DateTime DateAdd { get; set; }
        public DateTime? DateExpiration { get; set; }
        public int? NbDaysAccessible { get; set; }
        public int? NbDownloadable { get; set; }
        public byte Active { get; set; }
        public byte IsShareable { get; set; }
    }
}
