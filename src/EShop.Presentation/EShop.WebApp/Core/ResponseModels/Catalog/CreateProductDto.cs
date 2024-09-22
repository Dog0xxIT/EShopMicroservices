namespace EShop.WebApp.Core.ResponseModels.Catalog
{
    public class CreateProductDto
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int CategoryId { get; set; }
        public int BrandId { get; set; }
        public int AvailableStock { get; set; }
        public int RestockThreshold { get; set; }
        public string Description { get; set; }
        public int MaxStockThreshold { get; set; }
    }
}
