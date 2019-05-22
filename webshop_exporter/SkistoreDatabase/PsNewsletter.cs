using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsNewsletter
    {
        public int Id { get; set; }
        public int IdShop { get; set; }
        public int IdShopGroup { get; set; }
        public string Email { get; set; }
        public DateTime? NewsletterDateAdd { get; set; }
        public string IpRegistrationNewsletter { get; set; }
        public string HttpReferer { get; set; }
        public byte Active { get; set; }
    }
}
