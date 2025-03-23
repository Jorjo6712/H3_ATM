using H3_ATM.Entities;

namespace H3_ATM.Interfaces.Services
{
    public interface ICreditCardService
    {
        Task<CreditCard?> GetCreditCardByIdAsync(int id);
        Task<IEnumerable<CreditCard>> GetAllCreditCardsAsync();
        Task<CreditCard> CreateCreditCardAsync(CreditCard creditCard);
        Task<bool> DeleteCreditCardAsync(int id);
        Task<bool> ChangePinAsync(int id, ushort newPin);
        Task<bool> BlockCardAsync(int id);
    }
}