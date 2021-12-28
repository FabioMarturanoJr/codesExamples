namespace nacktBank
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CurrentAccount fabioAccount = new CurrentAccount();
            CurrentAccount brunaAccount = new CurrentAccount();

            fabioAccount.owner = "fabio";
            fabioAccount.agencyNumb = 4242;
            fabioAccount.accountNumb = 098765;
            fabioAccount.balance = 300;

            brunaAccount.owner = "bruna";
            brunaAccount.agencyNumb = 4242;
            brunaAccount.accountNumb = 198765;
            brunaAccount.balance = 4300;

            System.Console.WriteLine(fabioAccount.balance);
            System.Console.WriteLine(brunaAccount.balance);
            System.Console.WriteLine(fabioAccount.Transfer(500,brunaAccount));
            System.Console.WriteLine(fabioAccount.balance);
            System.Console.WriteLine(brunaAccount.balance);
        }
    }
}