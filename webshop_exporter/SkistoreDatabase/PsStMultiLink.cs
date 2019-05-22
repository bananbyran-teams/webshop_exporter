using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsStMultiLink
    {
        public int IdStMultiLink { get; set; }
        public int IdCms { get; set; }
        public int IdCmsCategory { get; set; }
        public int IdSupplier { get; set; }
        public int IdManufacturer { get; set; }
        public string Pagename { get; set; }
        public byte NewWindow { get; set; }
        public byte Nofollow { get; set; }
        public int IdStMultiLinkGroup { get; set; }
        public byte Active { get; set; }
        public int Position { get; set; }
    }
}
