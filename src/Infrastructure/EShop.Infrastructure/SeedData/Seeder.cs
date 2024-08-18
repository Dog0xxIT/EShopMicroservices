using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EShop.Data.Constants;
using EShop.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace EShop.Data.SeedData
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

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Computers & Office Supplies", Code = "COMP" },
                new Category { Id = 2, Name = "Collectibles & Toys", Code = "COLL" },
                new Category { Id = 3, Name = "Books", Code = "BOOK" },
                new Category { Id = 4, Name = "Fashion & Clothes", Code = "FASH" },
                new Category { Id = 5, Name = "Electronics", Code = "ELEC" },
                new Category { Id = 6, Name = "Food & Groceries", Code = "FOOD" },
                new Category { Id = 7, Name = "Music", Code = "MUSC" },
                new Category { Id = 8, Name = "TVs & Projectors", Code = "TVPJ" },
                new Category { Id = 9, Name = "Health & Beauty", Code = "HEAL" },
                new Category { Id = 10, Name = "Home Air Quality", Code = "HAIR" },
                new Category { Id = 11, Name = "Gaming Consoles", Code = "GAMC" },
                new Category { Id = 12, Name = "Car & Motorbike Accessories", Code = "CAR" },
                new Category { Id = 13, Name = "Photo & Video Equipment", Code = "PHOT" },
                new Category { Id = 14, Name = "Security & Wi-Fi Devices", Code = "SEC" },
                new Category { Id = 15, Name = "Computer Peripherals", Code = "PERI" },
                new Category { Id = 16, Name = "Phone Accessories", Code = "PHON" },
                new Category { Id = 17, Name = "Watches", Code = "WATCH" },
                new Category { Id = 18, Name = "Printers", Code = "PRNT" },
                new Category { Id = 19, Name = "Projectors", Code = "PROJ" },
                new Category { Id = 20, Name = "Skin Care Products", Code = "SKIN" },
                new Category { Id = 21, Name = "Photo & Video Equipment", Code = "PHOT" },
                new Category { Id = 22, Name = "Office Supplies", Code = "OFFS" }
            );

            #endregion

            #region Brand

            modelBuilder.Entity<Brand>().HasData(
                 new Brand { Id = 1, Name = "Apple", Code = "APPLE" },
                 new Brand { Id = 2, Name = "Samsung", Code = "SAMSUNG" },
                 new Brand { Id = 3, Name = "Microsoft", Code = "MICROSOFT" },
                 new Brand { Id = 4, Name = "Google", Code = "GOOGLE" },
                 new Brand { Id = 5, Name = "Amazon", Code = "AMAZON" },
                 new Brand { Id = 6, Name = "Facebook", Code = "FACEBOOK" },
                 new Brand { Id = 7, Name = "Intel", Code = "INTEL" },
                 new Brand { Id = 8, Name = "IBM", Code = "IBM" },
                 new Brand { Id = 9, Name = "Sony", Code = "SONY" },
                 new Brand { Id = 10, Name = "Dell", Code = "DELL" },
                 new Brand { Id = 11, Name = "HP", Code = "HP" },
                 new Brand { Id = 12, Name = "LG", Code = "LG" },
                 new Brand { Id = 13, Name = "Huawei", Code = "HUAWEI" },
                 new Brand { Id = 14, Name = "Cisco", Code = "CISCO" },
                 new Brand { Id = 15, Name = "Oracle", Code = "ORACLE" },
                 new Brand { Id = 16, Name = "Nvidia", Code = "NVIDIA" },
                 new Brand { Id = 17, Name = "AMD", Code = "AMD" },
                 new Brand { Id = 18, Name = "Lenovo", Code = "LENOVO" },
                 new Brand { Id = 19, Name = "Asus", Code = "ASUS" },
                 new Brand { Id = 20, Name = "Acer", Code = "ACER" },
                 new Brand { Id = 21, Name = "Nike", Code = "NIKE" },
                 new Brand { Id = 22, Name = "Adidas", Code = "ADIDAS" },
                 new Brand { Id = 23, Name = "Puma", Code = "PUMA" },
                 new Brand { Id = 24, Name = "Under Armour", Code = "UA" },
                 new Brand { Id = 25, Name = "Reebok", Code = "REEBOK" },
                 new Brand { Id = 26, Name = "New Balance", Code = "NB" },
                 new Brand { Id = 27, Name = "Asics", Code = "ASICS" },
                 new Brand { Id = 28, Name = "Converse", Code = "CONV" },
                 new Brand { Id = 29, Name = "Vans", Code = "VANS" },
                 new Brand { Id = 30, Name = "Sketchers", Code = "SKETCH" },
                 new Brand { Id = 31, Name = "Fila", Code = "FILA" },
                 new Brand { Id = 32, Name = "H&M", Code = "HM" },
                 new Brand { Id = 33, Name = "Zara", Code = "ZARA" },
                 new Brand { Id = 34, Name = "Uniqlo", Code = "UNIQLO" },
                 new Brand { Id = 35, Name = "Gucci", Code = "GUCCI" },
                 new Brand { Id = 36, Name = "Louis Vuitton", Code = "LV" },
                 new Brand { Id = 37, Name = "Prada", Code = "PRADA" },
                 new Brand { Id = 38, Name = "Chanel", Code = "CHANEL" },
                 new Brand { Id = 39, Name = "Hermès", Code = "HERMES" },
                 new Brand { Id = 40, Name = "Burberry", Code = "BURBERRY" });
            #endregion

            #region Product

            var products = new List<Product>();
            for (var i = 1; i <= 400; i++)
            {
                products.Add(new Product
                {
                    Id = i,
                    Name = $"Product {i}",
                    Description = $"Description for product {i}",
                    Price = Math.Round(new Random().NextDouble() * 1000, 2),
                    PictureFileName = $"product{i}.jpg",
                    CategoryId = (i % 20) + 1, // Assuming you have 20 categories
                    BrandId = (i % 40) + 1,    // Assuming you have 40 brands
                    AvailableStock = new Random().Next(1, 100),
                    RestockThreshold = new Random().Next(1, 20),
                    MaxStockThreshold = new Random().Next(20, 200)
                });
            }

            modelBuilder.Entity<Product>().HasData(products);

            #endregion
        }
    }
}
