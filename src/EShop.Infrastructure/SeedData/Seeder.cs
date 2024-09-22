using System.Collections.ObjectModel;
using EShop.Application.Constants;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.FileIO;
using System.Globalization;
using EShop.Application.Models;
using Microsoft.AspNetCore.WebUtilities;
using Newtonsoft.Json;

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

            var categoryJson = "";
            using (var rs = new StreamReader("../../EShop.Infrastructure/SeedData/dataset/Tiki/categories.json"))
            {
                categoryJson = rs.ReadToEnd();
            }
            var cateList = JsonConvert.DeserializeObject<List<Category>>(categoryJson);
            modelBuilder.Entity<Category>().HasData(cateList);

            #endregion

            #region Brand

            var brandJson = "";
            using (var rs = new StreamReader("../../EShop.Infrastructure/SeedData/dataset/Tiki/brands.json"))
            {
                brandJson = rs.ReadToEnd();
            }
            var brandList = JsonConvert.DeserializeObject<List<Brand>>(brandJson);
            modelBuilder.Entity<Brand>().HasData(brandList);
            #endregion

            #region Product

            var productsJson = "";
            using (var rs = new StreamReader("../../EShop.Infrastructure/SeedData/dataset/Tiki/products.json"))
            {
                productsJson = rs.ReadToEnd();
            }
            var productList = JsonConvert.DeserializeObject<List<Product>>(productsJson);
            modelBuilder.Entity<Product>().HasData(productList);
            #endregion

            #region ProductVariant

            var productsVariantJson = "";
            using (var rs = new StreamReader("../../EShop.Infrastructure/SeedData/dataset/Tiki/productVariants.json"))
            {
                productsVariantJson = rs.ReadToEnd();
            }
            var productsVarianList = JsonConvert.DeserializeObject<List<ProductVariant>>(productsVariantJson);
            modelBuilder.Entity<ProductVariant>().HasData(productsVarianList);
            #endregion

            #region OptionType

            var optionTypeJson = "";
            using (var rs = new StreamReader("../../EShop.Infrastructure/SeedData/dataset/Tiki/optionTypes.json"))
            {
                optionTypeJson = rs.ReadToEnd();
            }
            var optionTypeList = JsonConvert.DeserializeObject<List<OptionType>>(optionTypeJson);
            modelBuilder.Entity<OptionType>().HasData(optionTypeList);

            #endregion

            #region VariantOption

            var variantOptionJson = "";
            using (var rs = new StreamReader("../../EShop.Infrastructure/SeedData/dataset/Tiki/variantOptions.json"))
            {
                variantOptionJson = rs.ReadToEnd();
            }
            var variantOptionList = JsonConvert.DeserializeObject<List<VariantOption>>(variantOptionJson);
            modelBuilder.Entity<VariantOption>().HasData(variantOptionList);

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
