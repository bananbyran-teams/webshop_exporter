using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace webshop_exporter.CSV
{
    public class CsvExporter
    {
        private static string SEPARATOR = ";";

        public static async Task Export<T>(Stream stream, IEnumerable<T> rows)
        {
            var columns = typeof(T).GetProperties();

            using (var writer = new StreamWriter(stream))
            {
                await writer.WriteLineAsync($"sep={SEPARATOR}");
                await WriteHeaderRow(columns, writer);

                foreach (var row in rows)
                    await WriteRow(columns, row, writer);
            }
        }

        private static async Task WriteRow<T>(PropertyInfo[] columns, T row, StreamWriter writer)
        {
            var textColumns = columns.Select(column =>
                column.GetValue(row).ToString()
            );

            await writer.WriteLineAsync(string.Join(SEPARATOR, textColumns));
        }

        private static async Task WriteHeaderRow(PropertyInfo[] columns, StreamWriter writer)
        {
            var headers = columns.Select(column =>
            {
                var headerAttribute = column.GetCustomAttribute(typeof(HeaderAttribute)) as HeaderAttribute;
                return headerAttribute?.Header ?? column.Name;
            });

            await writer.WriteLineAsync(string.Join(SEPARATOR, headers));
        }
    }
}
