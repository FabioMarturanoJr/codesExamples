namespace nacktBank.CustomExceptions
{
    public class InsufficientBalanceException : FinancialOperationException
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
        public InsufficientBalanceException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        public InsufficientBalanceException()
        {
        }
    }
}