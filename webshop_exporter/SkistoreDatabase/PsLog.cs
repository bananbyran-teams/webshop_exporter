using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsLog
    {
        public int IdLog { get; set; }
        public byte Severity { get; set; }
        public int? ErrorCode { get; set; }
        public string Message { get; set; }
        public string ObjectType { get; set; }
        public int? ObjectId { get; set; }
        public int? IdEmployee { get; set; }
        public DateTime DateAdd { get; set; }
        public DateTime DateUpd { get; set; }
    }
}
