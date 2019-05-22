using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsPmAdsandslideshowAutoConf
    {
        public int IdSlideshowConf { get; set; }
        public string Margin { get; set; }
        public string BackgroundColor { get; set; }
        public string TransitionEffect { get; set; }
        public byte Ramdom { get; set; }
        public byte SlideAuto { get; set; }
        public byte SlideContinuous { get; set; }
        public byte ShowPrevnext { get; set; }
        public byte PrevnextPosition { get; set; }
        public byte PrevnextInner { get; set; }
        public string PrevnextMargin { get; set; }
        public byte NavigationType { get; set; }
        public short NavigationHeight { get; set; }
        public short NavigationWidth { get; set; }
        public byte NavigationPosition { get; set; }
        public string NavigationBackgroundColor { get; set; }
        public string NavigationBackgroundColorOver { get; set; }
        public string NavigationGlobalBackgroundColor { get; set; }
        public string NavigationTextColor { get; set; }
        public string NavigationTextColorOver { get; set; }
        public string NavigationBorderColor { get; set; }
        public string NavigationBorderColorOver { get; set; }
        public string NavigationBorderSize { get; set; }
        public byte NavigationInner { get; set; }
        public string NavigationMargin { get; set; }
        public string NavigationElementMargin { get; set; }
        public byte ShowCaption { get; set; }
        public byte CaptionPosition { get; set; }
        public string CaptionBackgroundColor { get; set; }
        public string CaptionTextColor { get; set; }
        public short CaptionHeight { get; set; }
        public byte CaptionOpacity { get; set; }
        public short EffectDuration { get; set; }
        public short PauseDuration { get; set; }
    }
}
