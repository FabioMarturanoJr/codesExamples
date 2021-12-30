namespace nacktBank.Employees
{
    public class Designer : Employee
    {
        public Designer(string cpf) : base(3000, cpf)
        {
        }
        public override void IncreaseSalary()
        {
            Salary *= 1.11;
        }
        public override double GetBonus() {
            return Salary * 0.17;
        }
    }
}