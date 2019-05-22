using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsStProductCategoriesSlider
    {
        public int IdStProductCategoriesSlider { get; set; }
        public int IdCategory { get; set; }
        public int IdShop { get; set; }
        public int ProductNbr { get; set; }
        public int ProductOrder { get; set; }
        public byte Active { get; set; }
        public int Position { get; set; }
        public byte DisplayOn { get; set; }
    }
}
