using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using webshop_exporter.CSV;
using webshop_exporter.Models;
using webshop_exporter.SkistoreDatabase;

namespace webshop_exporter
{
    class Program
    {
        static async Task Main(string[] args)
        {

            using (var db = new skistore_seContext())
            {
                var shops = await db.PsShop.Where(x => x.Name == "Mtbstore").ToListAsync();
                foreach (var shop in shops)
                {
                    var langs = await db.PsLang.ToListAsync();
                    foreach (var lang in langs)
                    {
                        var imageNames = new List<string>();
                        var exports = new List<ExportModel>();
                        Console.WriteLine($"Starting export for {lang.IsoCode} on {shop.Name}");
                        await ExportProductsFromCategory(db, shop.IdCategory, new List<string>(), shop.IdShop, lang, exports, imageNames);

                        var fileName = $"export-{shop.Name}-{lang.IsoCode}.csv";
                        await CsvExporter.Export(File.OpenWrite(fileName), exports, new ExportOptions { WriteSep = false });

                        GenerateImageDownloadFilelist(shop, imageNames);

                        Console.WriteLine($"Exported {exports.Count} products");
                    }
                }

            }

            Console.WriteLine("Finished! Press any key to exit");
            Console.ReadKey();
        }

        private static void GenerateImageDownloadFilelist(PsShop shop, List<string> imageNames)
        {
            File.WriteAllLines($"images-{shop.Name}.txt", imageNames
                .Distinct()
                .Select(x => $"{x}"));
        }

        private static async Task ExportProductsFromCategory(skistore_seContext db, int parentCategoryId, List<string> categoryPath, int shopId, PsLang lang, List<ExportModel> exports, List<string> imageNames)
        {
            Console.WriteLine($"About to find children to category {parentCategoryId}({categoryPath.LastOrDefault() ?? ""})");

            var categories = await db.PsCategory
                                    .Where(x => x.IdParent == parentCategoryId)
                                    .Join(db.PsCategoryLang.Where(x => x.IdLang == lang.IdLang && x.IdShop == shopId),
                                          x => x.IdCategory, x => x.IdCategory, (a, b) => new { a.IdCategory, a.IdParent, a.IsRootCategory, b.Name })
                                    .ToListAsync();

            foreach (var category in categories)
            {
                var localCategoryPath = categoryPath.Append(category.Name).ToList();

                Console.WriteLine($"Processing category {category.Name}");

                var products = await db.PsCategoryProduct
                    .Where(x => x.IdCategory == category.IdCategory)
                    .Join(db.PsProduct, x => x.IdProduct, x => x.IdProduct, (a, b) => b)
                    .ToListAsync();

                foreach (var product in products)
                {
                    var productLang = await db.PsProductLang.FirstOrDefaultAsync(x => x.IdLang == lang.IdLang && x.IdProduct == product.IdProduct);
                    if (productLang == null)
                        continue;

                    var manufacturer = await db.PsManufacturer.FirstOrDefaultAsync(x => x.IdManufacturer == product.IdManufacturer);
                    var images = await db.PsImage.Where(x => x.IdProduct == product.IdProduct).OrderBy(x => x.Position).ToListAsync();
                    imageNames.AddRange(images.Select(x => $"{x.IdImage}.jpg"));

                    var tags = await db.PsTag
                        .Where(x => x.IdLang == lang.IdLang)
                        .Join(db.PsProductTag.Where(x => x.IdProduct == product.IdProduct), x => x.IdTag, x => x.IdTag, (a, b) => a.Name)
                        .ToListAsync();

                    var productAttributes = await db.PsProductAttribute.Where(x => x.IdProduct == product.IdProduct).ToListAsync();

                    if (productAttributes.Any())
                    {
                        //Add parent row
                        AddOrReplaceExportModel(exports, new ExportModel
                        {
                            Ean = product.Ean13,
                            Reference = product.Reference,
                            Title = productLang.Name,
                            Description = productLang.DescriptionShort,
                            Text = productLang.Description,
                            Manufacturer = manufacturer?.Name ?? "",
                            Parent = "",
                            Category = localCategoryPath.ElementAtOrDefault(0) ?? "",
                            SubCategory1 = localCategoryPath.ElementAtOrDefault(1) ?? "",
                            SubCategory2 = localCategoryPath.ElementAtOrDefault(2) ?? "",
                            SubCategory3 = localCategoryPath.ElementAtOrDefault(3) ?? "",
                            Measurment = $"{Convert.ToInt32(product.Width)}x{Convert.ToInt32(product.Height)}x{Convert.ToInt32(product.Depth)}",
                            Weight = Convert.ToInt32(product.Weight).ToString(),
                            Image1 = images.ElementAtOrDefault(0) != null ? $"{images.ElementAtOrDefault(0).IdImage}.jpg" : "",
                            Image2 = images.ElementAtOrDefault(1) != null ? $"{images.ElementAtOrDefault(1).IdImage}.jpg" : "",
                            Image3 = images.ElementAtOrDefault(2) != null ? $"{images.ElementAtOrDefault(2).IdImage}.jpg" : "",
                            Image4 = images.ElementAtOrDefault(3) != null ? $"{images.ElementAtOrDefault(3).IdImage}.jpg" : "",
                            Image5 = images.ElementAtOrDefault(4) != null ? $"{images.ElementAtOrDefault(4).IdImage}.jpg" : "",
                            Tags = string.Join(',', tags),
                            CategoryDepth = localCategoryPath.Count
                        });

                        //Add child rows
                        foreach (var productAttribute in productAttributes)
                        {
                            var attributes = await db.PsProductAttributeCombination
                                .Where(x => x.IdProductAttribute == productAttribute.IdProductAttribute)
                                .Join(db.PsAttribute, x => x.IdAttribute, x => x.IdAttribute, (a, b) => b)
                                .Join(db.PsAttributeLang.Where(x => x.IdLang == lang.IdLang), x => x.IdAttribute, x => x.IdAttribute, (a, b) => new
                                {
                                    a.IdAttribute,
                                    a.IdAttributeGroup,
                                    b.Name,
                                    GroupName = db.PsAttributeGroupLang
                                        .Where(x => x.IdLang == lang.IdLang && x.IdAttributeGroup == a.IdAttributeGroup)
                                        .Select(x => x.PublicName)
                                        .FirstOrDefault()
                                })
                                .FirstOrDefaultAsync();


                            AddOrReplaceExportModel(exports, new ExportModel
                            {
                                Ean = productAttribute.Ean13,
                                Reference = productAttribute.Reference,
                                Price = product.Price.ToString(),
                                Title = productLang.Name,
                                Description = productLang.DescriptionShort,
                                Text = productLang.Description,
                                Manufacturer = manufacturer?.Name ?? "",
                                Parent = product.Reference,
                                Category = localCategoryPath.ElementAtOrDefault(0) ?? "",
                                SubCategory1 = localCategoryPath.ElementAtOrDefault(1) ?? "",
                                SubCategory2 = localCategoryPath.ElementAtOrDefault(2) ?? "",
                                SubCategory3 = localCategoryPath.ElementAtOrDefault(3) ?? "",
                                Attributes = new Dictionary<string, string> { { attributes?.GroupName ?? "", attributes?.Name ?? "" } },
                                Measurment = $"{Convert.ToInt32(product.Width)}x{Convert.ToInt32(product.Height)}x{Convert.ToInt32(product.Depth)}",
                                Weight = Convert.ToInt32(productAttribute.Weight).ToString(),
                                Image1 = images.ElementAtOrDefault(0) != null ? $"{images.ElementAtOrDefault(0).IdImage}.jpg" : "",
                                Image2 = images.ElementAtOrDefault(1) != null ? $"{images.ElementAtOrDefault(1).IdImage}.jpg" : "",
                                Image3 = images.ElementAtOrDefault(2) != null ? $"{images.ElementAtOrDefault(2).IdImage}.jpg" : "",
                                Image4 = images.ElementAtOrDefault(3) != null ? $"{images.ElementAtOrDefault(3).IdImage}.jpg" : "",
                                Image5 = images.ElementAtOrDefault(4) != null ? $"{images.ElementAtOrDefault(4).IdImage}.jpg" : "",
                                Tags = string.Join(',', tags),
                                CategoryDepth = localCategoryPath.Count
                            });
                        }
                    }
                    else
                    {
                        //Add parent row
                        AddOrReplaceExportModel(exports, new ExportModel
                        {
                            Ean = product.Ean13,
                            Reference = product.Reference,
                            Title = productLang.Name,
                            Description = productLang.DescriptionShort,
                            Text = productLang.Description,
                            Manufacturer = manufacturer?.Name ?? "",
                            Price = product.Price.ToString(),
                            Category = localCategoryPath.ElementAtOrDefault(0) ?? "",
                            SubCategory1 = localCategoryPath.ElementAtOrDefault(1) ?? "",
                            SubCategory2 = localCategoryPath.ElementAtOrDefault(2) ?? "",
                            SubCategory3 = localCategoryPath.ElementAtOrDefault(3) ?? "",
                            Measurment = $"{Convert.ToInt32(product.Width)}x{Convert.ToInt32(product.Height)}x{Convert.ToInt32(product.Depth)}",
                            Weight = Convert.ToInt32(product.Weight).ToString(),
                            Image1 = images.ElementAtOrDefault(0) != null ? $"{images.ElementAtOrDefault(0).IdImage}.jpg" : "",
                            Image2 = images.ElementAtOrDefault(1) != null ? $"{images.ElementAtOrDefault(1).IdImage}.jpg" : "",
                            Image3 = images.ElementAtOrDefault(2) != null ? $"{images.ElementAtOrDefault(2).IdImage}.jpg" : "",
                            Image4 = images.ElementAtOrDefault(3) != null ? $"{images.ElementAtOrDefault(3).IdImage}.jpg" : "",
                            Image5 = images.ElementAtOrDefault(4) != null ? $"{images.ElementAtOrDefault(4).IdImage}.jpg" : "",
                            Tags = string.Join(',', tags),
                            CategoryDepth = localCategoryPath.Count
                        });
                    }
                }

                await ExportProductsFromCategory(db, category.IdCategory, localCategoryPath, shopId, lang, exports, imageNames);
            }
        }

        private static void AddOrReplaceExportModel(List<ExportModel> exports, ExportModel export)
        {
            var existingExport = exports.FirstOrDefault(x => x.Reference == export.Reference);
            if (existingExport != null)
            {
                if(existingExport.CategoryDepth < export.CategoryDepth)
                {
                    var index = exports.IndexOf(existingExport);
                    exports.Insert(index, export);
                    exports.Remove(existingExport);
                }
            }
            else
            {
                exports.Add(export);
            }
        }
    }
}
