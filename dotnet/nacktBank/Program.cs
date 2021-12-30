using nacktBank.Employees;
using nacktBank.reports;

namespace nacktBank
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ManageBonus manageBonus = new ManageBonus();
            Employee fabio = new Employee(2000, "123.123.123-0");
            Manager bruna = new Manager(5000, "321.321.321-0");

            fabio.Name = "Fabio Marturano";
            fabio.IncreaseSalary();
            manageBonus.Register(fabio);

            bruna.Name = "Bruna Mara";
            bruna.IncreaseSalary();
            manageBonus.Register(bruna);

            System.Console.WriteLine(fabio.Salary);
            System.Console.WriteLine(bruna.Salary);
            System.Console.WriteLine(fabio.GetBonus());
            System.Console.WriteLine(bruna.GetBonus());
            System.Console.WriteLine("Total Bonus: " + manageBonus.getTotalBonus());
            System.Console.WriteLine("Total Employee: " + Employee.TotalEmployees);
        }
    }
}