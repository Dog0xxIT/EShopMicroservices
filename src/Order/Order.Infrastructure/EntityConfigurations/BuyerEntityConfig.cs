using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ordering.Domain.Aggregates.BuyerAggregate;

namespace Ordering.Infrastructure.EntityConfigurations
{
    internal class BuyerEntityConfig : IEntityTypeConfiguration<Buyer>
    {
        public void Configure(EntityTypeBuilder<Buyer> builder)
        {
            builder.ToTable("Buyers");

            builder.Ignore(b => b.DomainEvents);

            builder.Property(b => b.Id)
                .ValueGeneratedOnAdd();

            builder.HasIndex("Id")
                .IsUnique();

            builder.HasMany(b => b.PaymentMethods)
                .WithOne();
        }
    }
}
