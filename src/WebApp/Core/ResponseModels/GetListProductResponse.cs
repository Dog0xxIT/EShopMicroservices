namespace WebApp.Core.ResponseModels
{
    public class GetListProductResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double Discount { get; set; }
        public double Star { get; set; }
        public int ReviewsCount { get; set; }
        public string ImageUrl { get; set; }
        public int CategoryId { get; set; }
        public int BrandId { get; set; }
        public int TotalBuyers { get; set; }
        public string Sku { get; set; }
        public string Summary { get; set; }
    }
}
