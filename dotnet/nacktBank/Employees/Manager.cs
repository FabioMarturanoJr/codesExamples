namespace nacktBank.Employees
{
    public class Manager : Employee
    {
        public Manager(double salaray, string cpf) : base(salaray, cpf)
        {
        }
        public override void IncreaseSalary()
        {
            Salary *= 1.15;
        }
        public override double GetBonus() {
            return Salary + base.GetBonus();
        }
    }
}