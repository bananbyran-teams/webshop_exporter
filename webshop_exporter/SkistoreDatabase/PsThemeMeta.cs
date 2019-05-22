using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsThemeMeta
    {
        public int IdThemeMeta { get; set; }
        public int IdTheme { get; set; }
        public int IdMeta { get; set; }
        public byte LeftColumn { get; set; }
        public byte RightColumn { get; set; }
    }
}
