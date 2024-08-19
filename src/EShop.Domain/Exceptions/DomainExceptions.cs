namespace EShop.Domain.Exceptions;

public static class DomainExceptions
{
    public static Exception CardExpiry => new Exception("Card expiry");
    public static Exception ExistingPayment => new Exception("Existing payment");
    public static Exception InvalidDiscount => new Exception("Invalid Discount");
    public static Exception InvalidUnits => new Exception("Invalid Units");
}