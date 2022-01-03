using nacktBank.CurrentAccounts;
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
                CurrentAccount fabio = new CurrentAccount(0,0);
            }
            catch (System.ArgumentException e)
            {                
                System.Console.WriteLine(e.Message);
            }
            CurrentAccount bruna = new CurrentAccount(4242,1234567);
            System.Console.WriteLine(CurrentAccount.TransactionFee);
            System.Console.WriteLine(CurrentAccount.TotalAccounts);
        }
    }
}