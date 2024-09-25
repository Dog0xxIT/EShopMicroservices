using Newtonsoft.Json;

namespace Catalog.Api.Data.SeedData
{
    public static class Seeder
    {
        public static void SeedData(this ModelBuilder modelBuilder)
        {
            var textJson = File.ReadAllText("./Data/SeedData/brands.json");
            var brandList = JsonConvert.DeserializeObject<List<Brand>>(textJson);
            brandList = brandList.DistinctBy(i => i.Id)
                .Where(i => i.Id != 0)
                .ToList();
            modelBuilder.Entity<Brand>()
                .HasData(brandList!);

            textJson = File.ReadAllText("./Data/SeedData/categories.json");
            var categoryList = JsonConvert.DeserializeObject<List<Category>>(textJson);

            categoryList = categoryList.DistinctBy(i => i.Id).ToList();

            categoryList
                .ForEach(i => i.ThumbnailUrl ??= "");
            categoryList
                .ForEach(i => i.ParentId = i.ParentId == 1 ? null : i.ParentId);
            modelBuilder.Entity<Category>()
                .HasData(categoryList!);

            textJson = File.ReadAllText("./Data/SeedData/products.json");
            var productList = JsonConvert.DeserializeObject<List<Product>>(textJson);
            productList = productList
                .Where(p => 
                    categoryList.Select(i => i.Id).Contains(p.CategoryId))
                .Where(p =>
                    brandList.Select(i => i.Id).Contains(p.BrandId))
                .ToList();
            modelBuilder.Entity<Product>()
                .HasData(productList!);
        }
    }
}
