using OriginalTestDataBuilders;

namespace DisplayApplication
{
    internal static class Build
    {
        public static Builder<Address> Address()
        {
            return new Builder<Address>(new Address("", "London", new PostCode("CR85NG")));
        }
    }
}