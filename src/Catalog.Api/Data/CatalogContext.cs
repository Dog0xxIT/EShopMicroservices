using Catalog.Api.Data.SeedData;
using EventStoreEF;

namespace Catalog.Api.Data
{
    // dotnet ef migrations add InitialCreate --output-dir .\Data\Migrations

    public class CatalogContext : EventStoreDbContext
    {
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<OptionType> OptionType { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductOption> ProductOptions { get; set; }
        public DbSet<ProductVariant> ProductVariants { get; set; }

        public CatalogContext(DbContextOptions<CatalogContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.SeedData();
            base.OnModelCreating(modelBuilder);
        }
    }
}
