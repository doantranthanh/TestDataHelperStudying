using OriginalTestDataBuilders;

namespace DisplayApplication
{
    internal static class MyBuilder
    {
        public static readonly BuilderGeneric<Address> Address;
        public static readonly BuilderGeneric<PostCode> PostCode;
        static MyBuilder()
        {
            Address = new BuilderGeneric<Address>(new Address("", "", new PostCode("")));
            PostCode = new BuilderGeneric<PostCode>(new PostCode("CR85NG"));
        }
        public static BuilderGeneric<Address> WithCity(this BuilderGeneric<Address> b, string city)
        {
            return b.Select(a => a.WithCity(city));
        }
    }
}