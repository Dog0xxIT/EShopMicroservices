using System.Collections.ObjectModel;
using EShop.Application.Constants;
using EShop.Application.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.FileIO;
using System.Globalization;

namespace EShop.Infrastructure.SeedData
{
    internal static class Seeder
    {
        public static void SeedData(this ModelBuilder modelBuilder)
        {
            #region IdentityRole

            modelBuilder.Entity<IdentityRole<int>>().HasData(
                new IdentityRole<int>
                {
                    Id = 1,
                    Name = RolesConstant.Administrator,
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                    NormalizedName = RolesConstant.Administrator.ToUpper(),
                },
                new IdentityRole<int>
                {
                    Id = 2,
                    Name = RolesConstant.Customer,
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                    NormalizedName = RolesConstant.Customer.ToUpper(),
                },
                new IdentityRole<int>
                {
                    Id = 3,
                    Name = RolesConstant.SalesManager,
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                    NormalizedName = RolesConstant.SalesManager.ToUpper(),
                },
                new IdentityRole<int>
                {
                    Id = 4,
                    Name = RolesConstant.StoreManager,
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                    NormalizedName = RolesConstant.StoreManager.ToUpper(),
                },
                new IdentityRole<int>
                {
                    Id = 5,
                    Name = RolesConstant.SystemAdministrator,
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                    NormalizedName = RolesConstant.SystemAdministrator.ToUpper(),
                }
            );

            #endregion

            #region Category

            var categories = new Collection<Category>();
            using (var reader = new StreamReader("../../EShop.Infrastructure/SeedData/dataset/amazon_categories.csv"))
            {
                var headerLine = reader.ReadLine(); // Read and discard header line
                var id = 1;

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    if (string.IsNullOrWhiteSpace(line)) continue;

                    var values = ParseCsvLine(line);


                    // Assign values from the CSV to your product properties
                    categories.Add(new Category
                    {
                        // id,category_name
                        Id = id++,
                        Name = values[1],
                        Description = $"Description for category {values[1]}",
                        Code = values[1].Trim().ToUpper(),
                        ThumbnailUrl = "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>",
                    });
                }
            }

            modelBuilder.Entity<Category>().HasData(categories);
            categories.Clear();
            #endregion

            #region Brand

            modelBuilder.Entity<Brand>().HasData(
                 new Brand { Id = 1, Name = "Apple", Code = "APPLE", AvatarUrl = "", Description = "" },
                 new Brand { Id = 2, Name = "Samsung", Code = "SAMSUNG", AvatarUrl = "", Description = "" },
                 new Brand { Id = 3, Name = "Microsoft", Code = "MICROSOFT", AvatarUrl = "", Description = "" },
                 new Brand { Id = 4, Name = "Google", Code = "GOOGLE", AvatarUrl = "", Description = "" },
                 new Brand { Id = 5, Name = "Amazon", Code = "AMAZON", AvatarUrl = "", Description = "" },
                 new Brand { Id = 6, Name = "Facebook", Code = "FACEBOOK", AvatarUrl = "", Description = "" },
                 new Brand { Id = 7, Name = "Intel", Code = "INTEL", AvatarUrl = "", Description = "" },
                 new Brand { Id = 8, Name = "IBM", Code = "IBM", AvatarUrl = "", Description = "" },
                 new Brand { Id = 9, Name = "Sony", Code = "SONY", AvatarUrl = "", Description = "" },
                 new Brand { Id = 10, Name = "Dell", Code = "DELL", AvatarUrl = "", Description = "" },
                 new Brand { Id = 11, Name = "HP", Code = "HP", AvatarUrl = "", Description = "" },
                 new Brand { Id = 12, Name = "LG", Code = "LG", AvatarUrl = "", Description = "" },
                 new Brand { Id = 13, Name = "Huawei", Code = "HUAWEI", AvatarUrl = "", Description = "" },
                 new Brand { Id = 14, Name = "Cisco", Code = "CISCO", AvatarUrl = "", Description = "" },
                 new Brand { Id = 15, Name = "Oracle", Code = "ORACLE", AvatarUrl = "", Description = "" },
                 new Brand { Id = 16, Name = "Nvidia", Code = "NVIDIA", AvatarUrl = "", Description = "" },
                 new Brand { Id = 17, Name = "AMD", Code = "AMD", AvatarUrl = "", Description = "" },
                 new Brand { Id = 18, Name = "Lenovo", Code = "LENOVO", AvatarUrl = "", Description = "" },
                 new Brand { Id = 19, Name = "Asus", Code = "ASUS", AvatarUrl = "", Description = "" },
                 new Brand { Id = 20, Name = "Acer", Code = "ACER", AvatarUrl = "", Description = "" },
                 new Brand { Id = 21, Name = "Nike", Code = "NIKE", AvatarUrl = "", Description = "" },
                 new Brand { Id = 22, Name = "Adidas", Code = "ADIDAS", AvatarUrl = "", Description = "" },
                 new Brand { Id = 23, Name = "Puma", Code = "PUMA", AvatarUrl = "", Description = "" },
                 new Brand { Id = 24, Name = "Under Armour", Code = "UA", AvatarUrl = "", Description = "" },
                 new Brand { Id = 25, Name = "Reebok", Code = "REEBOK", AvatarUrl = "", Description = "" },
                 new Brand { Id = 26, Name = "New Balance", Code = "NB", AvatarUrl = "", Description = "" },
                 new Brand { Id = 27, Name = "Asics", Code = "ASICS", AvatarUrl = "", Description = "" },
                 new Brand { Id = 28, Name = "Converse", Code = "CONV", AvatarUrl = "", Description = "" },
                 new Brand { Id = 29, Name = "Vans", Code = "VANS", AvatarUrl = "", Description = "" },
                 new Brand { Id = 30, Name = "Sketchers", Code = "SKETCH", AvatarUrl = "", Description = "" },
                 new Brand { Id = 31, Name = "Fila", Code = "FILA", AvatarUrl = "", Description = "" },
                 new Brand { Id = 32, Name = "H&M", Code = "HM", AvatarUrl = "", Description = "" },
                 new Brand { Id = 33, Name = "Zara", Code = "ZARA", AvatarUrl = "", Description = "" },
                 new Brand { Id = 34, Name = "Uniqlo", Code = "UNIQLO", AvatarUrl = "", Description = "" },
                 new Brand { Id = 35, Name = "Gucci", Code = "GUCCI", AvatarUrl = "", Description = "" },
                 new Brand { Id = 36, Name = "Louis Vuitton", Code = "LV", AvatarUrl = "", Description = "" },
                 new Brand { Id = 37, Name = "Prada", Code = "PRADA", AvatarUrl = "", Description = "" },
                 new Brand { Id = 38, Name = "Chanel", Code = "CHANEL", AvatarUrl = "", Description = "" },
                 new Brand { Id = 39, Name = "Hermès", Code = "HERMES", AvatarUrl = "", Description = "" },
                 new Brand { Id = 40, Name = "Burberry", Code = "BURBERRY", AvatarUrl = "", Description = "" });
            #endregion

            #region Product
            /*
            var products = new Collection<Product>();
            using (var reader = new StreamReader("../../EShop.Infrastructure/SeedData/dataset/final-products.csv"))
            {
                var headerLine = reader.ReadLine(); // Read and discard header line
                var id = 1;

                while (!reader.EndOfStream && id < 15000)
                {
                    var line = reader.ReadLine();
                    if (string.IsNullOrWhiteSpace(line)) continue;

                    var values = ParseCsvLine(line);

                    // Assign values from the CSV to your product properties
                    products.Add(new Product
                    {
                        //0, 1,    2,    3,    4,    5,      6,      7           8
                        // ,asin,title,imgUrl,stars,reviews,price,category_id,boughtInLastMonth
                        Id = id++,
                        Name = values[2],
                        Description = $"Description for product {values[2]}",
                        Price = double.Parse(values[6]),
                        ImageUrl = values[3],
                        CategoryId = int.Parse(values[7]),
                        Brands = (id % 40) + 1,
                        Summary = $"Summary for product {values[1]}",
                        OtherAttributes = "",
                        Sku = $"{values[1]}",
                        TotalBuyers = int.Parse(values[8]),
                        ReviewsCount = int.Parse(values[5]),
                        Discount = 0,
                        Star = double.Parse(values[4]),
                    });
                }
            }

            modelBuilder.Entity<Product>().HasData(products);
            products.Clear();
             */
            #endregion

            #region Options
            modelBuilder.Entity<OptionValue>().HasData(
                // Size (OptionTypeId = 1)
                new OptionValue { Id = 1, Value = "S", OptionTypeId = 1 },
                new OptionValue { Id = 2, Value = "M", OptionTypeId = 1 },
                new OptionValue { Id = 3, Value = "L", OptionTypeId = 1 },
                new OptionValue { Id = 4, Value = "XL", OptionTypeId = 1 },

                // Color (OptionTypeId = 2)
                new OptionValue { Id = 5, Value = "Red", OptionTypeId = 2 },
                new OptionValue { Id = 6, Value = "Blue", OptionTypeId = 2 },
                new OptionValue { Id = 7, Value = "Green", OptionTypeId = 2 },
                new OptionValue { Id = 8, Value = "Black", OptionTypeId = 2 },

                // Material (OptionTypeId = 3)
                new OptionValue { Id = 9, Value = "Cotton", OptionTypeId = 3 },
                new OptionValue { Id = 10, Value = "Polyester", OptionTypeId = 3 },
                new OptionValue { Id = 11, Value = "Leather", OptionTypeId = 3 },

                // Capacity (OptionTypeId = 4)
                new OptionValue { Id = 12, Value = "64GB", OptionTypeId = 4 },
                new OptionValue { Id = 13, Value = "128GB", OptionTypeId = 4 },
                new OptionValue { Id = 14, Value = "256GB", OptionTypeId = 4 },

                // Dimension (OptionTypeId = 5)
                new OptionValue { Id = 15, Value = "40x60 cm", OptionTypeId = 5 },
                new OptionValue { Id = 16, Value = "50x70 cm", OptionTypeId = 5 },
                new OptionValue { Id = 17, Value = "60x80 cm", OptionTypeId = 5 },

                // Weight (OptionTypeId = 6)
                new OptionValue { Id = 18, Value = "500g", OptionTypeId = 6 },
                new OptionValue { Id = 19, Value = "1kg", OptionTypeId = 6 },
                new OptionValue { Id = 20, Value = "2kg", OptionTypeId = 6 }
            );

            modelBuilder.Entity<OptionType>().HasData(
                new OptionType { Id = 1, Name = "Size", Description = "" , OptionValues = new() },
                new OptionType { Id = 2, Name = "Color", Description = "", OptionValues = new() },
                new OptionType { Id = 3, Name = "Material", Description = "", OptionValues = new() },
                new OptionType { Id = 4, Name = "Capacity", Description = "", OptionValues = new() },
                new OptionType { Id = 5, Name = "Dimension", Description = "" , OptionValues = new() },
                new OptionType { Id = 6, Name = "Weight", Description = "", OptionValues = new() }
             );
            #endregion
        }

        public static string[] ParseCsvLine(string csvLine)
        {
            var parser = new TextFieldParser(new StringReader(csvLine));
            parser.SetDelimiters(",");
            parser.HasFieldsEnclosedInQuotes = true;
            return parser.ReadFields();
        }
    }
}
