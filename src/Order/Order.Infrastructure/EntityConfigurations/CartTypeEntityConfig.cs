using Microsoft.EntityFrameworkCore;
using Ordering.Domain.Aggregates.BuyerAggregate;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ordering.Infrastructure.EntityConfigurations
{
    internal class CartTypeEntityConfig : IEntityTypeConfiguration<CardType>
    {
        public void Configure(EntityTypeBuilder<CardType> builder)
        {
            builder.ToTable("CardTypes");

            builder.Property(ct => ct.Id)
                .ValueGeneratedNever();

            builder.Property(ct => ct.Name)
                .HasMaxLength(200);

            var cardTypes = new List<CardType>
            {
                new(Guid.NewGuid().ToString(), "Amex"),
                new(Guid.NewGuid().ToString(), "Visa"),
                new(Guid.NewGuid().ToString(), "MasterCard"),
            };
            builder.HasData(cardTypes);
        }
    }
}
