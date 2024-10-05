using EventStoreEF;
using Microsoft.EntityFrameworkCore;
using Ordering.Domain.Aggregates.BuyerAggregate;
using Ordering.Domain.Aggregates.OrderAggregate;
using Ordering.Infrastructure.EntityConfigurations;

namespace Ordering.Infrastructure;

/*
 * Add migrations using the following command inside the 'Ordering.Infrastructure' project directory:
 * dotnet ef migrations add --startup-project ..\Order.Api\Ordering.Api.csproj --context OrderContext [Name]
 * dotnet ef database update --startup-project ..\Order.Api\Ordering.Api.csproj
 */
public class OrderContext : EventStoreDbContext
{
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderItem> OrderItems { get; set; }
    public DbSet<PaymentMethod> Payments { get; set; }
    public DbSet<Buyer> Buyers { get; set; }
    public DbSet<CardType> CardTypes { get; set; }

    public OrderContext(DbContextOptions<OrderContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new PaymentMethodEntityConfig());
        modelBuilder.ApplyConfiguration(new BuyerEntityConfig());
        modelBuilder.ApplyConfiguration(new OrderEntityConfig());
        modelBuilder.ApplyConfiguration(new OrderItemEntityConfig());
        modelBuilder.ApplyConfiguration(new CartTypeEntityConfig());
    }
}