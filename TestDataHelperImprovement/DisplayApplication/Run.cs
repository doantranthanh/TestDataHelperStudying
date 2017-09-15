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

            var address = MyBuilder.Address.Select(a => a.WithCity("Paris")).Build();

            Console.WriteLine(address.City);

            Address newAddress =
                from pc in MyBuilder.PostCode
                select new Address("Rue Morgue", "Paris", pc);

            Console.WriteLine(newAddress.PostCode.PostCodeDetails);

            Address newAddress2 =
                from ad in MyBuilder.Address
                select ad.WithCity("Cuba");

            Console.WriteLine(newAddress2.City);
        }
    }
}
