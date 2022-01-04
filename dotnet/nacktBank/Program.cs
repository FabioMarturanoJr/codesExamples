using nacktBank.CurrentAccounts;
using nacktBank.CustomExceptions;
using nacktBank.Employees;
using nacktBank.Partners;
using nacktBank.reports;
using nacktBank.Systems;

namespace nacktBank
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                CurrentAccount fabio = new CurrentAccount(4242,123456);
                CurrentAccount bruna = new CurrentAccount(4242,1234567);

                fabio.Deposit(600);
                bruna.Deposit(600);

                // fabio.Withdraw(601);

                fabio.Transfer(9000, bruna);
            }
            catch (FinancialOperationException e) {
                System.Console.WriteLine($"Unexpected Error: {e.Message}");
                System.Console.WriteLine(e.StackTrace);
                // System.Console.WriteLine("=============================");
                // System.Console.WriteLine(e.InnerException.StackTrace);
            }
            System.Console.WriteLine(CurrentAccount.TransactionFee);
            System.Console.WriteLine(CurrentAccount.TotalAccounts);
        }
    }
}