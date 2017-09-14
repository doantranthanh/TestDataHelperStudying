namespace OriginalTestDataBuilders
{
    public class InvoiceBuilder
    {
        private Recipient recipient;

        public InvoiceBuilder()
        {
            this.recipient = new RecipientBuilder().Build();
        }

        public InvoiceBuilder WithRecipient(Recipient newRecipient)
        {
            this.recipient = newRecipient;
            return this;
        }

        public Invoice Build()
        {
            return new Invoice(recipient);
        }
    }
}
