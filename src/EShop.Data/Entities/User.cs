using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace EShop.Data.Entities
{
    public class User : IdentityUser<int>
    {
        public string Street { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Country { get; set; }

        public string ZipCode { get; set; }

        public IReadOnlyCollection<Order> Orders { get; set; }

        public User(string street, string city, string state, string country, string zipCode)
        {
            Street = street ?? throw new ArgumentNullException(nameof(street));
            City = city ?? throw new ArgumentNullException(nameof(city));
            State = state ?? throw new ArgumentNullException(nameof(state));
            Country = country ?? throw new ArgumentNullException(nameof(country));
            ZipCode = zipCode ?? throw new ArgumentNullException(nameof(zipCode));
        }

        public User(string userName, string street, string city, string state, string country, string zipCode) :
            base(userName)
        {
            Street = street ?? throw new ArgumentNullException(nameof(street));
            City = city ?? throw new ArgumentNullException(nameof(city));
            State = state ?? throw new ArgumentNullException(nameof(state));
            Country = country ?? throw new ArgumentNullException(nameof(country));
            ZipCode = zipCode ?? throw new ArgumentNullException(nameof(zipCode));
        }

        public User()
        {
        }
    }
}
