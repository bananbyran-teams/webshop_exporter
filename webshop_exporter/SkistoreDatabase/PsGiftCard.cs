using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsGiftCard
    {
        public int IdGiftCard { get; set; }
        public int IdProduct { get; set; }
        public int IdProductAttribute { get; set; }
        public int IdCart { get; set; }
        public int IdShop { get; set; }
        public int? IdOrderDetail { get; set; }
        public int? IdCartRule { get; set; }
        public decimal? Price { get; set; }
        public string MailFrom { get; set; }
        public string MailTo { get; set; }
        public string MailBody { get; set; }
        public DateTime MailDate { get; set; }
        public int MailIdImage { get; set; }
        public byte MailStatus { get; set; }
        public DateTime DateAdd { get; set; }
        public DateTime DateUpd { get; set; }
    }
}
