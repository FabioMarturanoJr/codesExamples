using nacktBank.Employees;
using nacktBank.reports;

namespace nacktBank
{
    public class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine(CalcBonus());
            System.Console.WriteLine(Designer.TotalDesigner);
            System.Console.WriteLine(Designer.TotalEmployees);
        }

        private static double CalcBonus()
        {
            ManageBonus manageBonus = new ManageBonus();

            Designer bruna = new Designer("123.123.123-0");
            bruna.Name = "Bruna Mara";

            Manager ravena = new Manager("321.321.321-9");
            ravena.Name = "Ravena Amora";

            Assistant matheus = new Assistant("987.987.987-5");
            matheus.Name = "Matheus Marturano";

            AccountManager ana = new AccountManager("456.567.678-9");
            ana.Name = "Ana Julia";

            manageBonus.Register(bruna);
            manageBonus.Register(ravena);
            manageBonus.Register(matheus);
            manageBonus.Register(ana);

            return manageBonus.getTotalBonus();
        }
    }
}