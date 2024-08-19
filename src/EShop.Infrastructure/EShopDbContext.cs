using EShop.Application.Entities;
using EShop.Infrastructure.SeedData;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EShop.Infrastructure
{
    /// <remarks>
    /// Add migrations using the following command inside the 'EShop.Data' project directory:
    ///  dotnet ef migrations add --startup-project '..\EShop.Api\EShop.Api.csproj' --context EShopDbContext [migration-name]
    ///
    /// Remove migrations
    /// dotnet ef migrations remove --startup-project ..\EShop.Api\EShop.Api.csproj
    ///
    /// 
    /// Update database
    /// dotnet ef database update --startup-project ..\EShop.Api\EShop.Api.csproj --project .\EShop.Data.csproj
    ///
    /// </remarks>
    /// 
    public class EShopDbContext : IdentityDbContext<User, IdentityRole<int>, int>
    {
        public DbSet<BasketItem> BasketItems { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Rating> Ratings { get; set; }

        public EShopDbContext(DbContextOptions<EShopDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.SeedData();
        }
    }
}