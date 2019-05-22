using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsStCameraSlideshowLang
    {
        public int IdStCameraSlideshow { get; set; }
        public int IdLang { get; set; }
        public string Url { get; set; }
        public string Video { get; set; }
        public string Description { get; set; }
        public string Button { get; set; }
        public string ImageMultiLang { get; set; }
        public string ThumbMultiLang { get; set; }
        public string Title { get; set; }
    }
}
