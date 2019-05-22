using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsImageType
    {
        public int IdImageType { get; set; }
        public string Name { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public byte Products { get; set; }
        public byte Categories { get; set; }
        public byte Manufacturers { get; set; }
        public byte Suppliers { get; set; }
        public byte Scenes { get; set; }
        public byte Stores { get; set; }
    }
}
