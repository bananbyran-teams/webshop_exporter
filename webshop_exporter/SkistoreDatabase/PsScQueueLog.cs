using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsScQueueLog
    {
        public int IdScQueueLog { get; set; }
        public string Name { get; set; }
        public string Row { get; set; }
        public string Action { get; set; }
        public string Params { get; set; }
        public string Callback { get; set; }
        public int IdEmployee { get; set; }
        public DateTime DateAdd { get; set; }
    }
}
