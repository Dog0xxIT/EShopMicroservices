namespace Basket.Api.Models.ResponseModel
{
    public class GetBaseInfoProductResponse
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string Price { get; set; }
        public int UnitPrice { get; set; }
        public string PictureUrl { get; set; }
        public string Sku { get; set; }
    }
}
