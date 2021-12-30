namespace nacktBank.Employees
{
    public class Employee
    {
        public static int TotalEmployees { get; private set; }
        public string? Name { get; set; }
        public string CPF { get; private set; }
        public int Salary { get; set; }
        public Employee(string cpf)
        {
            TotalEmployees++;
            CPF = cpf;
        }
        public virtual double GetBonus() {
            return Salary * 0.10;
        }
    }
}