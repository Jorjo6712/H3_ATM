using H3_ATM.Entities;

namespace H3_ATM.Interfaces.Services
{
    public interface IAccountService
    {
        Task<Account?> GetAccountByIdAsync(int id);
        Task<IEnumerable<Account>> GetAllAccountsAsync();
        Task<Account> CreateAccountAsync(Account account);
        Task<bool> DeleteAccountAsync(int id);
        Task<bool> DepositAsync(int id, decimal amount);
        Task<bool> WithdrawAsync(int id, decimal amount);
    }
}