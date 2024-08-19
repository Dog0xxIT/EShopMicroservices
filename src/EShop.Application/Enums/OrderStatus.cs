namespace EShop.Application.Enums
{
    public enum OrderStatus
    {
        Draft = 0,
        Submitted = 1,
        AwaitingValidation = 2,
        StockConfirmed = 3,
        Paid = 4,
        Shipped = 5,
        Cancelled = 6
    }
}