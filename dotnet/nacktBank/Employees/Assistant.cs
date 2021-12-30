namespace nacktBank.Employees
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
        public override double GetBonus() {
            return Salary * 0.2;
        }
    }
}