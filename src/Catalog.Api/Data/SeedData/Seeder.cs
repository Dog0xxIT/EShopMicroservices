using Newtonsoft.Json;

namespace Catalog.Api.Data.SeedData
{
    public static class Seeder
    {
        public static void SeedData(this ModelBuilder modelBuilder)
        {
            var textJson = File.ReadAllText("./Data/SeedData/brands.json");
            var brandList = JsonConvert.DeserializeObject<List<Brand>>(textJson);
            modelBuilder.Entity<Brand>()
                .HasData(brandList!);

            textJson = File.ReadAllText("./Data/SeedData/categories.json");
            var categoryList = JsonConvert.DeserializeObject<List<Category>>(textJson);
            modelBuilder.Entity<Category>()
                .HasData(categoryList!);

            textJson = File.ReadAllText("./Data/SeedData/optionTypes.json");
            var optionTypeList = JsonConvert.DeserializeObject<List<OptionType>>(textJson);
            modelBuilder.Entity<OptionType>()
                .HasData(optionTypeList!);

            textJson = File.ReadAllText("./Data/SeedData/products.json");
            var productList = JsonConvert.DeserializeObject<List<Product>>(textJson);
            productList = productList.Where(p => categoryList
                    .Select(i => i.Id).Contains(p.CategoryId))
                    .ToList();
            modelBuilder.Entity<Product>()
                .HasData(productList!);

            textJson = File.ReadAllText("./Data/SeedData/productVariants.json");
            var productVariantList = JsonConvert.DeserializeObject<List<ProductVariant>>(textJson);
            productVariantList = productVariantList
                .Where(p => productList.Select(i => i.Id).Contains(p.ProductId))
                .ToList();
            modelBuilder.Entity<ProductVariant>()
                .HasData(productVariantList!);

            textJson = File.ReadAllText("./Data/SeedData/productOptions.json");
            var productOptionList = JsonConvert.DeserializeObject<List<ProductOption>>(textJson);
            productOptionList = productOptionList
                .Where(i => 
                    productVariantList.Select(i => i.Id).Contains(i.ProductVariantId))
                .Where(i => 
                    optionTypeList.Select(i => i.Id).Contains(i.OptionTypeId))
                .ToList();
            modelBuilder.Entity<ProductOption>()
                .HasData(productOptionList!);
        }
    }
}
