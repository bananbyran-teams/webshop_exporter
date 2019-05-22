using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsConnectionsSource
    {
        public int IdConnectionsSource { get; set; }
        public int IdConnections { get; set; }
        public string HttpReferer { get; set; }
        public string RequestUri { get; set; }
        public string Keywords { get; set; }
        public DateTime DateAdd { get; set; }
    }
}
