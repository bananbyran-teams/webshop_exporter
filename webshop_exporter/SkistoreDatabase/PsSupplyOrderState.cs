using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsSupplyOrderState
    {
        public int IdSupplyOrderState { get; set; }
        public byte DeliveryNote { get; set; }
        public byte Editable { get; set; }
        public byte ReceiptState { get; set; }
        public byte PendingReceipt { get; set; }
        public byte Enclosed { get; set; }
        public string Color { get; set; }
    }
}
