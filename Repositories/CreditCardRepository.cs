using H3_ATM.Data;
using H3_ATM.Entities;
using H3_ATM.Interfaces.Repositories;

namespace H3_ATM.Repositories;

public class CreditCardRepository : ICreditCardRepository
{
    private readonly BankContext _context;
    
    public CreditCardRepository(BankContext context)
    {
        _context = context;
    }

    public async Task<CreditCard> AddAsync(CreditCard creditCard)
    {
        await _context.CreditCards.AddAsync(creditCard);
        await _context.SaveChangesAsync();
        return creditCard;
    }
    
    public async Task<IEnumerable<CreditCard>> GetAllAsync()
    {
        return await Task.FromResult(_context.CreditCards.AsQueryable());
    }
}