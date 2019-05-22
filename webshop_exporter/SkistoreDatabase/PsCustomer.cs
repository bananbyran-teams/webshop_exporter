using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsCustomer
    {
        public int IdCustomer { get; set; }
        public int IdShopGroup { get; set; }
        public int IdShop { get; set; }
        public int IdGender { get; set; }
        public int IdDefaultGroup { get; set; }
        public int? IdLang { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Passwd { get; set; }
        public DateTimeOffset LastPasswdGen { get; set; }
        public DateTime? Birthday { get; set; }
        public byte Newsletter { get; set; }
        public string IpRegistrationNewsletter { get; set; }
        public DateTime? NewsletterDateAdd { get; set; }
        public byte Optin { get; set; }
        public string SecureKey { get; set; }
        public string Note { get; set; }
        public byte Active { get; set; }
        public byte IsGuest { get; set; }
        public byte Deleted { get; set; }
        public DateTime DateAdd { get; set; }
        public DateTime DateUpd { get; set; }
        public int IdCustomerImporterosc { get; set; }
        public string PasswdImporterosc { get; set; }
        public int? IdSpecter { get; set; }
        public int IdRisk { get; set; }
        public string Company { get; set; }
        public string Siret { get; set; }
        public string Ape { get; set; }
        public string Website { get; set; }
        public decimal OutstandingAllowAmount { get; set; }
        public byte ShowPublicPrices { get; set; }
        public int MaxPaymentDays { get; set; }
    }
}
