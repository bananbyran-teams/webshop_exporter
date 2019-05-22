using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsAddress
    {
        public int IdAddress { get; set; }
        public int IdCountry { get; set; }
        public int? IdState { get; set; }
        public int IdCustomer { get; set; }
        public int IdManufacturer { get; set; }
        public int IdSupplier { get; set; }
        public int IdWarehouse { get; set; }
        public string Alias { get; set; }
        public string Company { get; set; }
        public string Lastname { get; set; }
        public string Firstname { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Postcode { get; set; }
        public string City { get; set; }
        public string Other { get; set; }
        public string Phone { get; set; }
        public string PhoneMobile { get; set; }
        public string VatNumber { get; set; }
        public string Dni { get; set; }
        public DateTime DateAdd { get; set; }
        public DateTime DateUpd { get; set; }
        public byte Active { get; set; }
        public byte Deleted { get; set; }
        public int IdAddressImporterosc { get; set; }
    }
}
