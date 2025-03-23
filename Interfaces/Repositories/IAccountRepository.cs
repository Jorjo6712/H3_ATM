using H3_ATM.Entities;

namespace H3_ATM.Interfaces.Repositories
{
    public interface IAccountRepository
    {
        Task<Account> CreateAccountAsync(Account account);
        Task<IEnumerable<Account>> GetAllAccountsAsync();
    }
}