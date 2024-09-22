using EShop.Application.Models;
using EShop.Infrastructure.SeedData;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace EShop.Infrastructure
{
    /// <remarks>
    /// Add migrations using the following command inside the 'EShop.Infrastructure' project directory:
    ///  dotnet ef migrations add --startup-project ..\EShop.Presentation\EShop.Api\EShop.Api.csproj --context EShopDbContext [migration-name]
    ///
    /// Remove migrations
    /// dotnet ef migrations remove --startup-project ..\EShop.Presentation\EShop.Api\EShop.Api.csproj
    ///
    /// 
    /// Update database
    /// dotnet ef database update --startup-project ..\EShop.Presentation\EShop.Api\EShop.Api.csproj
    ///
    /// </remarks>
    /// 
    public class EShopDbContext : IdentityDbContext<User, IdentityRole<int>, int>, IDbContext
    {
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<BasketItem> BasketItems { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<OptionType> OptionTypes { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductVariant> ProductVariants { get; set; }
        public DbSet<VariantOption> VariantOptions { get; set; }
        public DbSet<Rating> Ratings { get; set; }

        public EShopDbContext(DbContextOptions<EShopDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<User>().ToTable("Users", "dbo");
            //modelBuilder.Entity<IdentityRole>().ToTable("Roles", "dbo");
            //modelBuilder.Entity<IdentityUserRole<int>>().ToTable("UserRoles", "dbo");
            //modelBuilder.Entity<IdentityUserClaim<int>>().ToTable("UserClaims", "dbo");
            //modelBuilder.Entity<IdentityUserLogin<int>>().ToTable("UserLogins", "dbo");
            modelBuilder.SeedData();
        }
    }
}