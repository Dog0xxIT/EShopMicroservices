using System;
using System.Collections.Generic;
using Ordering.Domain.Common;

namespace Ordering.Domain.Aggregates.OrderAggregate
{
    public class Address : ValueObject
    {
        public string Street { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
        public string Country { get; private set; }
        public string ZipCode { get; private set; }

        public Address() { }

        public Address(string street, string city, string state, string country, string zipcode)
        {
            Street = string.IsNullOrWhiteSpace(street) ? throw new ArgumentNullException(nameof(street)) : street;
            City = string.IsNullOrWhiteSpace(city) ? throw new ArgumentNullException(nameof(city)) : city;
            State = string.IsNullOrWhiteSpace(state) ? throw new ArgumentNullException(nameof(state)) : state;
            Country = string.IsNullOrWhiteSpace(country) ? throw new ArgumentNullException(nameof(country)) : country;
            ZipCode = string.IsNullOrWhiteSpace(zipcode) ? throw new ArgumentNullException(nameof(zipcode)) : zipcode;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            // Using a yield return statement to return each element one at a time
            yield return Street;
            yield return City;
            yield return State;
            yield return Country;
            yield return ZipCode;
        }
    }
}
