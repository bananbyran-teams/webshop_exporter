using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsCart
    {
        public int IdCart { get; set; }
        public int IdShopGroup { get; set; }
        public int IdShop { get; set; }
        public int IdCarrier { get; set; }
        public string DeliveryOption { get; set; }
        public int IdLang { get; set; }
        public int IdAddressDelivery { get; set; }
        public int IdAddressInvoice { get; set; }
        public int IdCurrency { get; set; }
        public int IdCustomer { get; set; }
        public int IdGuest { get; set; }
        public string SecureKey { get; set; }
        public byte Recyclable { get; set; }
        public byte Gift { get; set; }
        public string GiftMessage { get; set; }
        public byte MobileTheme { get; set; }
        public byte AllowSeperatedPackage { get; set; }
        public DateTime DateAdd { get; set; }
        public DateTime DateUpd { get; set; }
    }
}
