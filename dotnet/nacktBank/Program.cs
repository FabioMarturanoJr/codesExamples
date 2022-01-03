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
            // System.Console.WriteLine(CalcBonus());
            // System.Console.WriteLine(Developer.TotalDeveloper);
            // System.Console.WriteLine(Developer.TotalEmployees);
            UsingSistem();
        }
        public static void UsingSistem() {
            InternalSistem internalSistem = new InternalSistem();

            Manager ravena = new Manager("321.321.321-9");
            ravena.Name = "Ravena Amora";
            ravena.Password = "123";

            AccountManager bruna = new AccountManager("123.654.987-5");
            bruna.Name = "Bruna Mara";
            bruna.Password = "321";

            CommercialPartiner dani = new CommercialPartiner();
            dani.Password = "456";


            Developer fabio = new Developer("999.999.999-0");
            fabio.Name = "Fabio Marturano";

            internalSistem.Login(ravena, "1253");
            internalSistem.Login(bruna, "321");
            internalSistem.Login(dani, "987");

        }
        public static double CalcBonus()
        {
            ManageBonus manageBonus = new ManageBonus();

            Designer bruna = new Designer("123.123.123-0");
            bruna.Name = "Bruna Mara";

            Manager ravena = new Manager("321.321.321-9");
            ravena.Name = "Ravena Amora";

            Assistant matheus = new Assistant("987.987.987-5");
            matheus.Name = "Matheus Montes";

            AccountManager ana = new AccountManager("456.567.678-9");
            ana.Name = "Ana Julia";

            Developer fabio = new Developer("999.999.999-9");
            fabio.Name = "Fabio Marturano";

            manageBonus.Register(bruna);
            manageBonus.Register(ravena);
            manageBonus.Register(matheus);
            manageBonus.Register(ana);
            manageBonus.Register(fabio);

            return manageBonus.getTotalBonus();
        }
    }
}