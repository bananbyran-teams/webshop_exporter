using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsManufacturer
    {
        public int IdManufacturer { get; set; }
        public string Name { get; set; }
        public DateTime DateAdd { get; set; }
        public DateTime DateUpd { get; set; }
        public byte Active { get; set; }
        public byte ShowOnFront { get; set; }
        public int IdManufacturerImporterosc { get; set; }
    }
}
