namespace nacktBank
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Client fabio = new Client();
            Client bruna = new Client();

            fabio.Name = "Fabio Marturano";
            fabio.CPF = "123123123-0";
            fabio.Occupation = "Dev";

            bruna.Name = "Bruna Mara";
            bruna.CPF = "321321321-0";
            bruna.Occupation = "AssisAdmin";

            CurrentAccount brunaAcount = new CurrentAccount();
            CurrentAccount fabioAcount = new CurrentAccount();

            fabioAcount.Owner = fabio;
            brunaAcount.Owner = bruna;

            fabioAcount.Balance = 300;
            brunaAcount.Balance = 600;

            System.Console.WriteLine($"{brunaAcount.Owner.Name} - {brunaAcount.Balance}");
            System.Console.WriteLine($"{fabioAcount.Owner.Name} - {fabioAcount.Balance}");
            System.Console.WriteLine(fabioAcount.Transfer(300,brunaAcount));
            System.Console.WriteLine($"{brunaAcount.Owner.Name} - {brunaAcount.Balance}");
            System.Console.WriteLine($"{fabioAcount.Owner.Name} - {fabioAcount.Balance}");
        }
    }
}