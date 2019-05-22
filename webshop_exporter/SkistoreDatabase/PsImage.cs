using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsImage
    {
        public int IdImage { get; set; }
        public int IdProduct { get; set; }
        public short Position { get; set; }
        public byte Cover { get; set; }
        public string ScPath { get; set; }
        public byte Hover { get; set; }
    }
}
