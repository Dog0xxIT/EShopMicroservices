namespace EShop.Shared.ResponseModels.Catalog
{
    public class GetListProductResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Summary { get; set; }
        public string Sku { get; set; }
        public double Price { get; set; }
        public double Discount { get; set; }
        public int Quantity { get; set; }
        public int BrandId { get; set; }
    }
}