using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsStIossliderGroup
    {
        public int IdStIossliderGroup { get; set; }
        public string Name { get; set; }
        public int Location { get; set; }
        public int IdCms { get; set; }
        public int IdCmsCategory { get; set; }
        public int IdCategory { get; set; }
        public int Height { get; set; }
        public byte PrevNext { get; set; }
        public byte PagNav { get; set; }
        public byte HideOnMobile { get; set; }
        public int Time { get; set; }
        public int TransPeriod { get; set; }
        public byte AutoAdvance { get; set; }
        public byte Pause { get; set; }
        public byte Scrollbar { get; set; }
        public string ScrollbarBg { get; set; }
        public string ScrollbarColor { get; set; }
        public byte Active { get; set; }
        public int Position { get; set; }
        public byte DesktopClickDrag { get; set; }
        public byte InfiniteSlider { get; set; }
        public byte Templates { get; set; }
        public string BgColor { get; set; }
        public byte BgPattern { get; set; }
        public string BgImg { get; set; }
        public byte BgRepeat { get; set; }
        public byte BgPosition { get; set; }
        public byte PaddingTb { get; set; }
        public int Width { get; set; }
        public byte SlidePadding { get; set; }
        public byte SlideShadow { get; set; }
        public string PrevNextColor { get; set; }
        public string PrevNextBg { get; set; }
        public string PagNavBg { get; set; }
        public string PagNavBgActive { get; set; }
    }
}
