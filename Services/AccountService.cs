using H3_ATM.Entities;
using H3_ATM.Interfaces.Repositories;
using H3_ATM.Interfaces.Services;

namespace H3_ATM.Services
{

    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _repository;

        public AccountService(IAccountRepository repository)
        {
            _repository = repository;
        }
        
        public Task<IEnumerable<Account>> GetAccountsAsync()
        {
           return _repository.GetAllAccountsAsync();
        }

        public Task<Account?> GetAccountByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Account>> GetAllAccountsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Account> CreateAccountAsync(Account account)
        {
            return _repository.CreateAccountAsync(account);
        }

        public Task<bool> DeleteAccountAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DepositAsync(int id, decimal amount)
        {
            throw new NotImplementedException();
        }

        public Task<bool> WithdrawAsync(int id, decimal amount)
        {
            throw new NotImplementedException();
        }
    }
}