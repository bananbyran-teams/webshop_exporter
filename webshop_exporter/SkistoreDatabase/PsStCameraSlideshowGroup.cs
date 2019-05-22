using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsStCameraSlideshowGroup
    {
        public int IdStCameraSlideshowGroup { get; set; }
        public string Name { get; set; }
        public int Location { get; set; }
        public int IdCategory { get; set; }
        public int IdCms { get; set; }
        public int IdCmsCategory { get; set; }
        public float HeightRatio { get; set; }
        public byte PrevNext { get; set; }
        public byte PrevNextOnHover { get; set; }
        public byte PagNav { get; set; }
        public byte HideOnMobile { get; set; }
        public string Effects { get; set; }
        public byte Easing { get; set; }
        public int Time { get; set; }
        public int TransPeriod { get; set; }
        public byte AutoAdvance { get; set; }
        public byte Pause { get; set; }
        public int MosaicRows { get; set; }
        public int MosaicColumns { get; set; }
        public int BlindRows { get; set; }
        public int CurtainColumns { get; set; }
        public byte Loader { get; set; }
        public string BarPosition { get; set; }
        public string PiePosition { get; set; }
        public string LoaderBg { get; set; }
        public string LoaderColor { get; set; }
        public byte Active { get; set; }
        public int Position { get; set; }
    }
}
