using H3_ATM.Data;
using Microsoft.EntityFrameworkCore;

namespace H3_ATM.Factories
{

    public static class InMemoryBankContextFactory
    {
        public static BankContext Create(string databaseName = "TestDb")
        {
            var options = new DbContextOptionsBuilder<BankContext>()
                .UseInMemoryDatabase(databaseName)
                .Options;

            return new BankContext(options);
        }
    }
}
