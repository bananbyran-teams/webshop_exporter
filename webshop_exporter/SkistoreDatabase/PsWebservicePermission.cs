using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsWebservicePermission
    {
        public int IdWebservicePermission { get; set; }
        public string Resource { get; set; }
        public string Method { get; set; }
        public int IdWebserviceAccount { get; set; }
    }
}
