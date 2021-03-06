namespace NacktBank.Models.Employees
{
    public class Assistant : Employee
    {
        public Assistant(string cpf) : base(2000, cpf)
        {
        }
        public override void IncreaseSalary()
        {
            Salary *= 1.1;
        }
        internal protected override double GetBonus() {
            return Salary * 0.2;
        }
    }
}