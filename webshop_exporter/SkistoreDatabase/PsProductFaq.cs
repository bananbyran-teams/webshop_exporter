using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsProductFaq
    {
        public int IdProductComment { get; set; }
        public int IdProduct { get; set; }
        public int IdLang { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public string Ip { get; set; }
        public byte Validate { get; set; }
        public DateTime DateAdd { get; set; }
    }
}
