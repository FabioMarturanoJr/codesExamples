namespace nacktBank
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Client fabio = new Client();
            Client bruna = new Client();

            fabio.name = "Fabio Marturano";
            fabio.cpf = "123123123-0";
            fabio.occupation = "Dev";

            bruna.name = "Bruna Mara";
            bruna.cpf = "321321321-0";
            bruna.occupation = "AssisAdmin";

            CurrentAccount brunaAcount = new CurrentAccount();
            CurrentAccount fabioAcount = new CurrentAccount();

            fabioAcount.owner = fabio;
            brunaAcount.owner = bruna;

            fabioAcount.Balance = 300;
            brunaAcount.Balance = 600;

            System.Console.WriteLine(brunaAcount.Balance);
            System.Console.WriteLine(fabioAcount.Balance);
            System.Console.WriteLine(fabioAcount.Transfer(300,brunaAcount));
            System.Console.WriteLine(brunaAcount.Balance);
            System.Console.WriteLine(fabioAcount.Balance);
        }
    }
}