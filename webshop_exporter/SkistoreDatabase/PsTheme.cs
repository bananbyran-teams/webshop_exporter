using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsTheme
    {
        public int IdTheme { get; set; }
        public string Name { get; set; }
        public string Directory { get; set; }
        public byte Responsive { get; set; }
        public byte DefaultLeftColumn { get; set; }
        public byte DefaultRightColumn { get; set; }
        public int ProductPerPage { get; set; }
    }
}
