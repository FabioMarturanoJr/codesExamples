namespace nacktBank.CustomExceptions
{
    public class DepositInvalidException : Exception
    {
        public DepositInvalidException(string? message) : base(message)
        {
        }
    }
}