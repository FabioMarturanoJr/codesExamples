using nacktBank.Employees;
using nacktBank.reports;

namespace nacktBank
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ManageBonus manageBonus = new ManageBonus();
            Employee fabio = new Employee();
            Manager bruna = new Manager();

            fabio.Name = "Fabio Marturano";
            fabio.CPF = "123.123.123-0";
            fabio.Salary = 2500;
            manageBonus.Register(fabio);

            bruna.Name = "Bruna Mara";
            bruna.CPF = "321.321.321-0";
            bruna.Salary = 5000;
            manageBonus.Register(bruna);

            System.Console.WriteLine(fabio.GetBonus());
            System.Console.WriteLine(bruna.GetBonus());
            System.Console.WriteLine("Total Bonus: " + manageBonus.getTotalBonus());
        }
    }
}