namespace Basket.Api.Data
{
    // dotnet ef migrations add InitialCreate --output-dir .\Data\Migrations

    public class BasketContext : EventStoreDbContext
    {
        public DbSet<Entities.Basket> Baskets { get; set; }
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
