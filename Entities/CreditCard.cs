namespace H3_ATM.Entities
{
    public class CreditCard
    {
        public int Id { get; set; }
        public string CardHolderName { get; set; }
        public string CardNumber { get; set; }
        public ushort Pin { get; set; }
        public decimal CurrentBalance { get; set; }
        public string Status { get; set; }

        public CreditCard(string cardHolderName, string cardNumber, ushort pin, decimal initialBalance)
        {
            CardHolderName = cardHolderName;
            CardNumber = cardNumber;
            Pin = pin;
            CurrentBalance = initialBalance;
            Status = "Active";
        }
        
        public void Charge(decimal amount)
        {
            if (Status == "Locked")
                throw new InvalidOperationException("Cannot charge a locked card.");
            if (amount <= 0)
                throw new InvalidOperationException("Charge amount must be greater than zero.");
            CurrentBalance += amount;
        }

        public void MakePayment(decimal amount)
        {
            if (Status == "Locked")
                throw new InvalidOperationException("Cannot make payment on a locked card.");
            if (amount <= 0)
                throw new InvalidOperationException("Payment amount must be greater than zero.");
            CurrentBalance -= amount;
        }
        public void LockCard()
        {
            Status = "Locked";
        }
    }
}