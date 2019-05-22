using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsWebserviceAccount
    {
        public int IdWebserviceAccount { get; set; }
        public string Key { get; set; }
        public string Description { get; set; }
        public string ClassName { get; set; }
        public byte IsModule { get; set; }
        public string ModuleName { get; set; }
        public byte Active { get; set; }
    }
}
