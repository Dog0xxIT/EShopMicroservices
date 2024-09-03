using Microsoft.AspNetCore.Identity;

namespace EShop.Application.Entities
{
    public class User : IdentityUser<int>
    {
        public string? Street { get; set; }

        public string? City { get; set; }

        public string? State { get; set; }

        public string? Country { get; set; }

        public string? ZipCode { get; set; }

        public ICollection<Order>? Orders { get; set; }

        public ICollection<Payment>? Payments { get; set; }
    }
}
