﻿using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsCurrencyShop
    {
        public int IdCurrency { get; set; }
        public int IdShop { get; set; }
        public decimal ConversionRate { get; set; }
    }
}
