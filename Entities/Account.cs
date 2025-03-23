namespace H3_ATM.Entities
{
    public class Account(int accountId, string accountHolderName, string accountType, decimal initialBalance)
    {
        public Guid Id { get; set; }
        public string AccountHolderName { get; set; } = string.Empty;
        public string AccountType { get; set; } = string.Empty;
        public decimal Balance { get; set; }
        public string Status { get; set; } = "Active";
        
        public void Deposit(decimal amount)
        {
            if (amount <= 0) throw new ArgumentException("Deposit amount must be greater than zero.");
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0) throw new ArgumentException("Withdrawal amount must be greater than zero.");
            if (Balance < amount) throw new InvalidOperationException("Insufficient balance.");
            Balance -= amount;
        }
    }
}