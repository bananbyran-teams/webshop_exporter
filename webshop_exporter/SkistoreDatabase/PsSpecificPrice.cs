using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsSpecificPrice
    {
        public int IdSpecificPrice { get; set; }
        public int IdSpecificPriceRule { get; set; }
        public int IdCart { get; set; }
        public int IdProduct { get; set; }
        public int IdProductAttribute { get; set; }
        public int IdShop { get; set; }
        public int IdShopGroup { get; set; }
        public int IdCurrency { get; set; }
        public int IdCountry { get; set; }
        public int IdGroup { get; set; }
        public int IdCustomer { get; set; }
        public decimal Price { get; set; }
        public short FromQuantity { get; set; }
        public decimal Reduction { get; set; }
        public string ReductionType { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
    }
}
