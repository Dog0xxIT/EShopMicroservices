using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ordering.Domain.Aggregates.BuyerAggregate;
using Ordering.Domain.Aggregates.OrderAggregate;

namespace Ordering.Infrastructure.EntityConfigurations
{
    internal class PaymentMethodEntityConfig : IEntityTypeConfiguration<PaymentMethod>
    {
        public void Configure(EntityTypeBuilder<PaymentMethod> builder)
        {
            builder.ToTable("PaymentMethods");

            builder.Ignore(b => b.DomainEvents);

            builder.Property(b => b.Id)
                .ValueGeneratedOnAdd();

            builder
                .Property("_cardHolderName")
                .HasColumnName("CardHolderName")
                .HasMaxLength(200);

            builder
                .Property("_alias")
                .HasColumnName("Alias")
                .HasMaxLength(200);

            builder
                .Property("_cardNumber")
                .HasColumnName("CardNumber")
                .HasMaxLength(25)
                .IsRequired();

            builder
                .Property("_expiration")
                .HasColumnName("Expiration")
                .HasMaxLength(25);

            builder
                .Property("_cardTypeId")
                .HasColumnName("CardTypeId");

            builder.HasOne(p => p.CardType)
                .WithMany()
                .HasForeignKey("_cardTypeId");
        }
    }
}
