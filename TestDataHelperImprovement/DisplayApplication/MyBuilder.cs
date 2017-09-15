using OriginalTestDataBuilders;

namespace DisplayApplication
{
    internal static class MyBuilder
    {
        public static readonly BuilderGeneric<Address> Address;
        static MyBuilder()
        {
            Address = new BuilderGeneric<Address>(new Address("", "", new PostCode("")));
        }
        public static BuilderGeneric<Address> WithCity(this BuilderGeneric<Address> b, string city)
        {
            return b.Select(a => a.WithCity(city));
        }
    }
}