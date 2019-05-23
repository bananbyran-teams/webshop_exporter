using System;
using System.Collections;
using System.Collections.Generic;

namespace webshop_exporter.CSV
{
    public interface IDynamicColumns
    {
        IEnumerable<string> GetColumns();
        string GetValue(string columnName);
    }
}
