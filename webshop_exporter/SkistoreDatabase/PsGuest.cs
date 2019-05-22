using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsGuest
    {
        public int IdGuest { get; set; }
        public int? IdOperatingSystem { get; set; }
        public int? IdWebBrowser { get; set; }
        public int? IdCustomer { get; set; }
        public byte? Javascript { get; set; }
        public short? ScreenResolutionX { get; set; }
        public short? ScreenResolutionY { get; set; }
        public byte? ScreenColor { get; set; }
        public byte? SunJava { get; set; }
        public byte? AdobeFlash { get; set; }
        public byte? AdobeDirector { get; set; }
        public byte? AppleQuicktime { get; set; }
        public byte? RealPlayer { get; set; }
        public byte? WindowsMedia { get; set; }
        public string AcceptLanguage { get; set; }
        public byte MobileTheme { get; set; }
    }
}
