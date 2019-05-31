using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace webshop_exporter.CSV
{
    public class ExportOptions
    {
        public bool WriteSep { get; set; } = true;
        public bool WriteHeader { get; set; } = true;
    }

    public class CsvExporter
    {
        class Column<T>
        {
            public string Name { get; set; }
            public Func<T, string, string> GetValue { get; set; }
        }

        private static readonly string SEPARATOR = ";";

        public static async Task Export<T>(Stream stream, IEnumerable<T> rows, ExportOptions options)
        {
            var columns = typeof(T)
                .GetProperties()
                .Where(p => p.GetCustomAttribute(typeof(IgnoreAttribute)) == null)
                .Select(x => new Column<T>
                {
                    Name = (x.GetCustomAttribute(typeof(HeaderAttribute)) as HeaderAttribute)?.Header ?? x.Name,
                    GetValue = (o, n) => x.GetValue(o)?.ToString() ?? ""
                })
                .ToList();

            foreach (var row in rows)
            {
                if (row is IDynamicColumns dynamicColumns)
                {
                    var newCols = dynamicColumns.GetColumns()
                            .Select(x => new Column<T>
                            {
                                Name = x,
                                GetValue = (o, n) => (o as IDynamicColumns)?.GetValue(n) ?? ""
                            });

                    foreach (var col in newCols)
                    {
                        if (!columns.Any(c => c.Name == col.Name))
                            columns.Add(col);
                    }
                }
            }

            using (var writer = new StreamWriter(stream))
            {
                if (options.WriteSep)
                    await writer.WriteLineAsync($"sep={SEPARATOR}");

                if (options.WriteHeader)
                    await WriteHeaderRow(columns, writer);

                foreach (var row in rows)
                    await WriteRow(columns, row, writer);
            }
        }

        private static async Task WriteRow<T>(List<Column<T>> columns, T row, StreamWriter writer)
        {
            var textColumns = columns.Select(column =>
            {
                var rawValue = column.GetValue(row, column.Name);
                return Regex.Replace(rawValue, @"\r\n?|\n", "").Replace(SEPARATOR, "");
            });

            await writer.WriteLineAsync(string.Join(SEPARATOR, textColumns));
        }

        private static async Task WriteHeaderRow<T>(List<Column<T>> columns, StreamWriter writer)
        {
            var headers = columns.Select(column =>
                Regex.Replace(column.Name, @"\r\n?|\n", "").Replace(SEPARATOR, ""));

            await writer.WriteLineAsync(string.Join(SEPARATOR, headers));
        }
    }
}
