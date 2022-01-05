namespace NacktBank.Models.Employees
{
    public class Developer : Employee
    {
        public static int TotalDeveloper { get; private set; }
        public Developer(string cpf) : base(4000, cpf)
        {
            TotalDeveloper++;
        }

        public override void IncreaseSalary()
        {
            Salary *= 1.3;
        }
        public override double GetBonus()
        {
            return Salary;
        }
    }
}