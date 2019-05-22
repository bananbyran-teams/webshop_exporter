using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsStorecomHistory
    {
        public int IdHistory { get; set; }
        public int IdEmployee { get; set; }
        public string Section { get; set; }
        public string Action { get; set; }
        public string Object { get; set; }
        public int ObjectId { get; set; }
        public int LangId { get; set; }
        public string Dbtable { get; set; }
        public DateTime DateAdd { get; set; }
        public string Oldvalue { get; set; }
        public string Newvalue { get; set; }
        public byte Flag { get; set; }
        public string Shops { get; set; }
    }
}
