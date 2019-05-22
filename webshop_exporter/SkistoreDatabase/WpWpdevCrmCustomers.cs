using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class WpWpdevCrmCustomers
    {
        public long CustomerId { get; set; }
        public string Name { get; set; }
        public string SecondName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Adress { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Info { get; set; }
        public string Comments { get; set; }
        public long Tags { get; set; }
        public DateTime CustomerDate { get; set; }
        public string Remark { get; set; }
    }
}
