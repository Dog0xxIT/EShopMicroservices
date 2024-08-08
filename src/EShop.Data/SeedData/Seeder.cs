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
                new Category { Id = 1, Name = "Electronics", Code = "ELEC" },
                new Category { Id = 2, Name = "Books", Code = "BOOK" },
                new Category { Id = 3, Name = "Clothing", Code = "CLTH" },
                new Category { Id = 4, Name = "Home and Kitchen", Code = "HOME" },
                new Category { Id = 5, Name = "Sports and Outdoors", Code = "SPORT" },
                new Category { Id = 6, Name = "Beauty and Personal Care", Code = "BEAUTY" },
                new Category { Id = 7, Name = "Toys and Games", Code = "TOYS" },
                new Category { Id = 8, Name = "Automotive", Code = "AUTO" },
                new Category { Id = 9, Name = "Grocery and Gourmet Food", Code = "GROCERY" },
                new Category { Id = 10, Name = "Health and Household", Code = "HEALTH" },
                new Category { Id = 11, Name = "Industrial and Scientific", Code = "INDUST" },
                new Category { Id = 12, Name = "Pet Supplies", Code = "PET" },
                new Category { Id = 13, Name = "Office Products", Code = "OFFICE" },
                new Category { Id = 14, Name = "Software", Code = "SOFT" },
                new Category { Id = 15, Name = "Garden and Outdoor", Code = "GARDEN" },
                new Category { Id = 16, Name = "Tools and Home Improvement", Code = "TOOLS" },
                new Category { Id = 17, Name = "Baby", Code = "BABY" },
                new Category { Id = 18, Name = "Musical Instruments", Code = "MUSIC" },
                new Category { Id = 19, Name = "Arts, Crafts, and Sewing", Code = "ARTS" },
                new Category { Id = 20, Name = "Jewelry", Code = "JEWEL" }
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
