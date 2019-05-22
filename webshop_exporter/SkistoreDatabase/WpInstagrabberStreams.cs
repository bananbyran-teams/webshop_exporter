using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class WpInstagrabberStreams
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public long? Userid { get; set; }
        public string Tag { get; set; }
        public string AccessToken { get; set; }
        public byte? AutoPost { get; set; }
        public byte? SaveImages { get; set; }
        public byte? AutoTags { get; set; }
        public string PostType { get; set; }
        public string PostStatus { get; set; }
        public string LastId { get; set; }
        public string ImageAttachment { get; set; }
        public string ImageLink { get; set; }
        public string CustomlinkUrl { get; set; }
        public int? CreatedBy { get; set; }
        public string PlaceholderTitle { get; set; }
        public string BackupPlaceholderTitle { get; set; }
        public byte? AllowHashtags { get; set; }
        public string Taxonomy { get; set; }
        public int? TaxTerm { get; set; }
        public string LocalTags { get; set; }
        public string TagsTax { get; set; }
        public string PostFormat { get; set; }
        public string ImageSize { get; set; }
        public string Administrators { get; set; }
        public DateTime? GetToDate { get; set; }
        public int? Error { get; set; }
        public string ErrorMessage { get; set; }
    }
}
