using OriginalTestDataBuilders;

namespace DisplayApplication
{
    public static class Build
    {
        public static readonly Builder<Address> Address;
        static Build()
        {
            Address = new Builder<Address>(new Address("", "", new PostCode("")));
        }
        public static Builder<Address> WithCity(this Builder<Address> b, string city)
        {
            return b.Select(a => a.WithCity(city));
        }
    }
}