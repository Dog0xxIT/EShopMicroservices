using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ordering.Domain.Aggregates.BuyerAggregate;
using Ordering.Domain.Aggregates.OrderAggregate;

namespace Ordering.Infrastructure.EntityConfigurations
{
    internal class OrderEntityConfig : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Orders");

            builder.Ignore(b => b.DomainEvents);

            builder.Property(o => o.Id)
                .ValueGeneratedOnAdd();

            //Address value object persisted as owned entity type supported since EF Core 2.0
            builder.OwnsOne(o => o.Address);

            builder
                .Property(o => o.OrderStatus)
                .HasConversion<string>()
                .HasMaxLength(30);

            builder
                .Property(o => o.PaymentId)
                .HasColumnName("PaymentMethodId");

            builder.HasOne<PaymentMethod>()
                .WithMany()
                .HasForeignKey(o => o.PaymentId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(o => o.Buyer)
                .WithMany()
                .HasForeignKey(o => o.BuyerId);
        }
    }
}
