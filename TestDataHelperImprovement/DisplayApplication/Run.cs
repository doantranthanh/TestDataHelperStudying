using System;
using OriginalTestDataBuilders;

namespace DisplayApplication
{
    class Run
    {
        static void Main()
        {
            var invoice = new InvoiceBuilder().WithRecipient(new RecipientBuilder()
                                                                 .WithName("Thanh Doan").WithAddress(new AddressBuilder().WithCity("London").WithPostCode(new PostCodeBuilder().Build()).Build())
                                                                 .Build()).Build();

            Console.WriteLine(invoice.Recipient.Address.PostCode.PostCodeDetails);
        }
    }
}
