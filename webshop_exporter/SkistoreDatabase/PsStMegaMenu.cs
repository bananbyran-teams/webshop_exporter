using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsStMegaMenu
    {
        public int IdStMegaMenu { get; set; }
        public int IdParent { get; set; }
        public byte LevelDepth { get; set; }
        public int Nleft { get; set; }
        public int Nright { get; set; }
        public int IdShop { get; set; }
        public int ShopId { get; set; }
        public int IdCms { get; set; }
        public int IdCmsCategory { get; set; }
        public int IdCategory { get; set; }
        public int IdSupplier { get; set; }
        public int IdManufacturer { get; set; }
        public int IdProduct { get; set; }
        public int IdIcon { get; set; }
        public int IdStBlogCategory { get; set; }
        public int IdStBlog { get; set; }
        public string Pagename { get; set; }
        public int Spans { get; set; }
        public int Position { get; set; }
        public byte NewWindow { get; set; }
        public string TxtColor { get; set; }
        public string BgColor { get; set; }
        public string TxtColorOver { get; set; }
        public string BgColorOver { get; set; }
        public string TabContentBg { get; set; }
        public short? Height { get; set; }
        public short? Width { get; set; }
        public short? Left { get; set; }
        public byte Active { get; set; }
        public byte Style { get; set; }
        public byte AutoSub { get; set; }
        public byte Nofollow { get; set; }
        public byte HideOnMobile { get; set; }
        public byte Alignment { get; set; }
    }
}
