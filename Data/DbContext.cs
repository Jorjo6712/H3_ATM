using H3_ATM.Entities;
using Microsoft.EntityFrameworkCore;

namespace H3_ATM.Data
{
    public class BankContext : DbContext
    {
        public BankContext(DbContextOptions<BankContext> options) : base(options)
        {

        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<CreditCard> CreditCards { get; set; }
    }
}