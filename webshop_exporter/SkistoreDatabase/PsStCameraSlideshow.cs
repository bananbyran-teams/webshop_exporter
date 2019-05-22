using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsStCameraSlideshow
    {
        public int IdStCameraSlideshow { get; set; }
        public int IdStCameraSlideshowGroup { get; set; }
        public int? IdCurrency { get; set; }
        public string Image { get; set; }
        public string Thumb { get; set; }
        public byte NewWindow { get; set; }
        public string TextPosition { get; set; }
        public byte TextAlign { get; set; }
        public string TitleColor { get; set; }
        public string TitleBg { get; set; }
        public string TitleFontFamily { get; set; }
        public string DescriptionColor { get; set; }
        public string DescriptionBg { get; set; }
        public byte Active { get; set; }
        public int Position { get; set; }
        public byte Isbanner { get; set; }
    }
}
