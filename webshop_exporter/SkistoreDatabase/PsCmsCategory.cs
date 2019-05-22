using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsCmsCategory
    {
        public int IdCmsCategory { get; set; }
        public int IdParent { get; set; }
        public byte LevelDepth { get; set; }
        public byte Active { get; set; }
        public DateTime DateAdd { get; set; }
        public DateTime DateUpd { get; set; }
        public int Position { get; set; }
    }
}
