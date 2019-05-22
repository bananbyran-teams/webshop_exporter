using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsStMultiLinkGroup
    {
        public int IdStMultiLinkGroup { get; set; }
        public int Location { get; set; }
        public byte NewWindow { get; set; }
        public byte Nofollow { get; set; }
        public byte Active { get; set; }
        public int Position { get; set; }
        public byte HideOnMobile { get; set; }
    }
}
