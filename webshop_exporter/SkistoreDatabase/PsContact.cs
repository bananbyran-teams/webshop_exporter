using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsContact
    {
        public int IdContact { get; set; }
        public string Email { get; set; }
        public byte CustomerService { get; set; }
        public byte Position { get; set; }
    }
}
