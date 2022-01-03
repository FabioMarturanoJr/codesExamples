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
            CurrentAccount fabio = new CurrentAccount(4242,123456);
            CurrentAccount bruna = new CurrentAccount(4242,1234567);
            System.Console.WriteLine(CurrentAccount.TransactionFee);
            System.Console.WriteLine(CurrentAccount.TotalAccounts);
        }
    }
}