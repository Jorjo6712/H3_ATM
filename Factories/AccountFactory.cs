using H3_ATM.Entities;

namespace H3_ATM.Factories
{
    public static class AccountFactory
    {
        public static Account Create(
            int accountId = 1,
            string accountHolderName = "Test User",
            string accountType = "Savings",
            decimal initialBalance = 1000)
        {
            return new Account(accountId, accountHolderName, accountType, initialBalance);
        }
    }
}