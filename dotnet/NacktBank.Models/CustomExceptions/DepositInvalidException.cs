namespace nacktBank.CustomExceptions
{
    public class DepositInvalidException : FinancialOperationException
    {
        public DepositInvalidException()
        {
        }

        public DepositInvalidException(string? message) : base(message)
        {
        }

        public DepositInvalidException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}