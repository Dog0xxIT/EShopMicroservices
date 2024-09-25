namespace Catalog.Api.Data.Entities
{
    public class ProductOption : BaseEntity
    {
        public int ProductVariantId { get; set; }

        public int OptionTypeId { get; set; }

        public string Value { get; set; }

        public OptionType OptionType { get; set; }

        [DeleteBehavior(DeleteBehavior.NoAction)]
        public ProductVariant ProductVariant { get; set; }
    }
}
