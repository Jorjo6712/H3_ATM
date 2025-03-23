using H3_ATM.Entities;

namespace H3_ATM.Factories
{
    public static class CreditCardFactory
    {
        public static CreditCard Create(
            string cardHolderName = "Test User",
            string cardNumber = "1234-5678-9012-3456",
            ushort pin = 1234,
            decimal initialBalance = 500m)
        {
            return new CreditCard(cardHolderName, cardNumber, pin, initialBalance);
        }
    }
}