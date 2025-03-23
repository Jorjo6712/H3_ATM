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
    }
}