using System;

namespace Ordering.Domain.Exceptions;

public class DomainException : Exception
{
    public DomainException()
    {

    }

    public DomainException(string message)
        : base(message)
    {

    }

    public DomainException(string message, Exception innerException)
        : base(message, innerException)
    {

    }

    public static Exception CardExpiry => new("Card expiry");
    public static Exception ExistingPayment => new("Existing payment");
    public static Exception InvalidDiscount => new("Invalid Discount");
    public static Exception InvalidUnits => new("Invalid Units");
}