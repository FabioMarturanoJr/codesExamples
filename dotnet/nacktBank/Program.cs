using nacktBank.Employees;

namespace nacktBank
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Employee fabio = new Employee();
            Manager bruna = new Manager();

            fabio.Name = "Fabio Marturano";
            fabio.CPF = "123.123.123-0";
            fabio.Salary = 2500;

            bruna.Name = "Bruna Mara";
            bruna.CPF = "321.321.321-0";
            bruna.Salary = 5000;

            System.Console.WriteLine(fabio.GetBonus());
            System.Console.WriteLine(bruna.GetBonus());
        }
    }
}