namespace WebApp.Models.ResponseModels.Basket
{
    public class GetBasketByCustomerIdResponse
    {
        public int Id { get; set; }
        public double UnitPrice { get; set; }
        public int Quantity { get; set; }
        public string PictureUrl { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string CustomerId { get; set; }
    }
}
