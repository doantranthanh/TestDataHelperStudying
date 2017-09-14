using System;

namespace OriginalTestDataBuilders
{
    public class AddressBuilder
    {
        private string street;
        private string city;
        private PostCode postCode;

        public AddressBuilder()
        {
            this.street = "";
            this.city = "";
            this.postCode = new PostCodeBuilder().Build();
        }

        public AddressBuilder WithStreet(string newStreet)
        {
            this.street = newStreet;
            return this;
        }

        public AddressBuilder WithCity(string newCity)
        {
            this.city = newCity;
            return this;
        }

        public AddressBuilder WithPostCode(PostCode newPostCode)
        {
            this.postCode = newPostCode;
            return this;
        }

        public AddressBuilder WithNoPostcode()
        {
            this.postCode = new PostCode(String.Empty);
            return this;
        }

        public Address Build()
        {
            return new Address(this.street, this.city, this.postCode);
        }
    }

    public class PostCodeBuilder
    {
        public PostCode Build()
        {
            return new PostCode("CR85NG");
        }
    }
}
