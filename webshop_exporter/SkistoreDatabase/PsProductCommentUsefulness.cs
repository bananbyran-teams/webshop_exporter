using System;
using System.Collections.Generic;

namespace webshop_exporter.SkistoreDatabase
{
    public partial class PsProductCommentUsefulness
    {
        public int IdProductComment { get; set; }
        public int IdCustomer { get; set; }
        public byte Usefulness { get; set; }
    }
}
