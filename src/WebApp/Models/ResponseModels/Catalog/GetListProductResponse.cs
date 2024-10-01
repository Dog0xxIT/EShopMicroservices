namespace WebApp.Models.ResponseModels
{
    public class GetListProductResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double Discount { get; set; }
        public double RatingAverage { get; set; }
        public int ReviewCount { get; set; }
        public string ThumbnailUrl { get; set; }
        public int CategoryId { get; set; }
        public int BrandId { get; set; }
        public int TotalBuyer { get; set; }
        public string Sku { get; set; }
        public string ShortDescription { get; set; }
    }
}
