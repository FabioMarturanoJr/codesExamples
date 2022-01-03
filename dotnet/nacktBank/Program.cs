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

                fabio.Transfer(700, bruna);
            }
            catch (System.ArgumentException e)
            {                
                System.Console.WriteLine(e.Message);
            }
            catch (InsufficientBalanceException e) {
                System.Console.WriteLine(e.Message);
            }
            catch (DepositInvalidException e) {
                System.Console.WriteLine(e.Message);
            }
            catch (Exception e) {
                System.Console.WriteLine(e.Message);
            }
            System.Console.WriteLine(CurrentAccount.TransactionFee);
            System.Console.WriteLine(CurrentAccount.TotalAccounts);
        }
    }
}