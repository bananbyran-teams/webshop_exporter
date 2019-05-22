using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsTab
    {
        public int IdTab { get; set; }
        public int IdParent { get; set; }
        public string ClassName { get; set; }
        public string Module { get; set; }
        public int Position { get; set; }
        public byte Active { get; set; }
        public byte HideHostMode { get; set; }
    }
}
