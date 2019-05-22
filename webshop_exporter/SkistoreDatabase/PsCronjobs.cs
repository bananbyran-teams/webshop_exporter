using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsCronjobs
    {
        public int IdCronjob { get; set; }
        public int? IdModule { get; set; }
        public string Description { get; set; }
        public string Task { get; set; }
        public int? Hour { get; set; }
        public int? Day { get; set; }
        public int? Month { get; set; }
        public int? DayOfWeek { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public byte OneShot { get; set; }
        public byte? Active { get; set; }
        public int? IdShop { get; set; }
        public int? IdShopGroup { get; set; }
    }
}
