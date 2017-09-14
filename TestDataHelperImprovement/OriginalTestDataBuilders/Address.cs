using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OriginalTestDataBuilders
{
    public class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public PostCode PostCode { get; set; }

        public Address(string street, string city, PostCode postCode)
        {
            Street = street;
            City = city;
            PostCode = postCode;
        }
    }
}
