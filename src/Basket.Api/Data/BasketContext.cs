using Basket.Api.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace Basket.Api.Data
{
    public class BasketContext : DbContext
    {
        public DbSet<Data.Entities.Basket> Baskets { get; set; }
        public DbSet<BasketItem> BasketItems { get; set; }

        public BasketContext(DbContextOptions<BasketContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
