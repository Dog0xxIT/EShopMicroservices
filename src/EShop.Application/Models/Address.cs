namespace EShop.Application.Models
{
    public class Address : Entity
    {
        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Country { get; set; }

        public string ZipCode { get; set; }

        public string PhoneNumber { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }
    }
}
