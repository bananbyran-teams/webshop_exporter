using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsStEasyContent
    {
        public int IdStEasyContent { get; set; }
        public int Location { get; set; }
        public byte Span { get; set; }
        public byte HideOnMobile { get; set; }
        public byte Active { get; set; }
        public int Position { get; set; }
        public int IdCategory { get; set; }
        public int IdManufacturer { get; set; }
    }
}
