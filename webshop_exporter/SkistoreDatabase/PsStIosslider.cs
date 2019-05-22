using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsStIosslider
    {
        public int IdStIosslider { get; set; }
        public int IdStIossliderGroup { get; set; }
        public int? IdCurrency { get; set; }
        public byte NewWindow { get; set; }
        public string TextPosition { get; set; }
        public byte TextAlign { get; set; }
        public string TitleColor { get; set; }
        public string TitleBg { get; set; }
        public string TitleFontFamily { get; set; }
        public string DescriptionColor { get; set; }
        public string DescriptionBg { get; set; }
        public string TextConBg { get; set; }
        public byte Active { get; set; }
        public int Position { get; set; }
        public byte Isbanner { get; set; }
        public byte TextWidth { get; set; }
        public byte HideTextOnMobile { get; set; }
        public byte TextAnimation { get; set; }
    }
}
