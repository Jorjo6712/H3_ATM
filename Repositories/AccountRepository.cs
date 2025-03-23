using H3_ATM.Data;
using H3_ATM.Entities;
using H3_ATM.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace H3_ATM.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private readonly BankContext _context;

        public AccountRepository(BankContext context)
        {
            _context = context;
        }
        
        public async Task<Account> CreateAccountAsync(Account account)
        {
            _context.Accounts.Add(account);
            await _context.SaveChangesAsync();
            return account;
        }
        public async Task<IEnumerable<Account>> GetAllAccountsAsync()
        {
            return await Task.FromResult(_context.Accounts.AsQueryable());
        }
    }
}