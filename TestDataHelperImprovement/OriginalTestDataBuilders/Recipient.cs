namespace OriginalTestDataBuilders
{
    public class Recipient
    {
        public string Name { get; set; }
        public Address Address { get; set; }

        public Recipient(string name, Address address)
        {
            Name = name;
            Address = address;
        }
    }
}