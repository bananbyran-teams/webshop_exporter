using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsFeatureValue
    {
        public int IdFeatureValue { get; set; }
        public int IdFeature { get; set; }
        public byte? Custom { get; set; }
    }
}
