namespace nacktBank.CustomExceptions
{
    public class InsufficientBalanceException : Exception
    {
        public double Balance { get; }
        public double Value { get; }
        public InsufficientBalanceException(string? message) : base(message)
        {
        }
        public InsufficientBalanceException(string? message, double balance, double value) : this(message)
        {
            this.Balance = balance;
            this.Value = value;
        }
    }
}