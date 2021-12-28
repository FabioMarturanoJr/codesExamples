namespace nacktBank
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CurrentAccount fabioAccount = new CurrentAccount();

            fabioAccount.owner = "fabio";
            fabioAccount.agencyNumb = 4242;
            fabioAccount.accountNumb = 098765;
            fabioAccount.balance = 6500;

            System.Console.WriteLine(fabioAccount);
        }
    }
}