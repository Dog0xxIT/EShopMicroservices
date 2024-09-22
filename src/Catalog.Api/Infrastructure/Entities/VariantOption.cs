using Catalog.Api.Infrastructure.Entites;
using Microsoft.EntityFrameworkCore;

namespace Catalog.Api.Infrastructure.Entities
{
    public class VariantOption : Entity
    {
        public int ProductVariantId { get; set; }
        public int OptionTypeId { get; set; }
        public string OptionValue { get; set; }

        [DeleteBehavior(DeleteBehavior.NoAction)]
        public ProductVariant ProductVariant { get; set; }

        [DeleteBehavior(DeleteBehavior.NoAction)]
        public OptionType OptionType { get; set; }
    }
}
