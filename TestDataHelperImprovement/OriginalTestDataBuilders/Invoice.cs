namespace OriginalTestDataBuilders
{
    public class Invoice
    {
        public Invoice(Recipient recipient)
        {
            this.Recipient = recipient;
        }

        public Recipient Recipient { get; }
    }
}