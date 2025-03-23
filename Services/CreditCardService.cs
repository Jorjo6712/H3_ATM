using H3_ATM.Entities;
using H3_ATM.Interfaces.Services;

namespace H3_ATM.Services;

public class CreditCardService : ICreditCardService
{
    public Task<CreditCard?> GetCreditCardByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<CreditCard>> GetAllCreditCardsAsync()
    {
        throw new NotImplementedException();
    }

    public Task<CreditCard> CreateCreditCardAsync(CreditCard creditCard)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteCreditCardAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> ChangePinAsync(int id, ushort newPin)
    {
        throw new NotImplementedException();
    }

    public Task<bool> BlockCardAsync(int id)
    {
        throw new NotImplementedException();
    }
}