using System;
using System.Linq;
using webshop_exporter.SkistoreDatabase;

namespace webshop_exporter
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var db = new skistore_seContext())
            {
                var products = db.PsProduct.ToList();
                Console.WriteLine(products.Count);
            }

            Console.ReadKey();
        }
    }
}
