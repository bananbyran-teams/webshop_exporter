using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsMemcachedServers
    {
        public int IdMemcachedServer { get; set; }
        public string Ip { get; set; }
        public int Port { get; set; }
        public int Weight { get; set; }
    }
}
