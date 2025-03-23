using H3_ATM.Entities;

namespace H3_ATM.Interfaces.Repositories;

public interface ICreditCardRepository
{
    public Task<CreditCard> AddAsync(CreditCard creditCard);
    public Task<IEnumerable<CreditCard>> GetAllAsync();
}