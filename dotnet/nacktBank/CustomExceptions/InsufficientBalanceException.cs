namespace nacktBank.CustomExceptions
{
    public class InsufficientBalanceException : Exception
    {
        public InsufficientBalanceException(string? message) : base(message)
        {
        }
    }
}