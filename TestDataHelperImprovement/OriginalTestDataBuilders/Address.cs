using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OriginalTestDataBuilders
{
    public class Address
    {
        public string Street { get; }
        public string City { get; }
        public PostCode PostCode { get; }

        public Address(string street, string city, PostCode postCode)
        {
            if (street == null)
                throw new ArgumentNullException(nameof(street));
            if (city == null)
                throw new ArgumentNullException(nameof(city));
            if (postCode == null)
                throw new ArgumentNullException(nameof(postCode));
            Street = street;
            City = city;
            PostCode = postCode;
        }

        public Address WithStreet(string newStreet)
        {
            return new Address(newStreet, this.City, this.PostCode);
        }

        public Address WithCity(string city)
        {
            return new Address(this.Street, city, this.PostCode);
        }

        public Address WithPostcode(PostCode newPostCode)
        {
            return new Address(this.Street, this.City, newPostCode);
        }

        public override bool Equals(object obj)
        {
            var other = obj as Address;
            if (other == null)
                return base.Equals(obj);

            return object.Equals(this.Street, other.Street)
                && object.Equals(this.City, other.City)
                && object.Equals(this.PostCode, other.PostCode);
        }

        public override int GetHashCode()
        {
            return this.Street.GetHashCode() ^
                this.City.GetHashCode() ^
                this.PostCode.GetHashCode();
        }
    }
}
