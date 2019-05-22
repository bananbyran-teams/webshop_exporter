using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class WpInstagrabberImages
    {
        public long Id { get; set; }
        public string PicId { get; set; }
        public string PicUrl { get; set; }
        public string PicThumbnail { get; set; }
        public string PicLink { get; set; }
        public DateTime? PicTimestamp { get; set; }
        public DateTimeOffset TimeAdded { get; set; }
        public string Caption { get; set; }
        public string Tags { get; set; }
        public int? CommentCount { get; set; }
        public int? LikeCount { get; set; }
        public byte? Published { get; set; }
        public long? MediaId { get; set; }
        public int? Stream { get; set; }
        public string UserName { get; set; }
        public string UserId { get; set; }
        public string Filter { get; set; }
        public string Location { get; set; }
    }
}
