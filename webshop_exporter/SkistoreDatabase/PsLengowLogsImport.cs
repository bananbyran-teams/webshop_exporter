using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsLengowLogsImport
    {
        public int Id { get; set; }
        public string LengowOrderId { get; set; }
        public int? IsProcessing { get; set; }
        public int? IsFinished { get; set; }
        public string Message { get; set; }
        public DateTime? Date { get; set; }
        public string Extra { get; set; }
        public byte Mail { get; set; }
        public int? DeliveryAddressId { get; set; }
    }
}
