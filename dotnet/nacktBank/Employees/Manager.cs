namespace nacktBank.Employees
{
    public class Manager : Employee
    {
        public Manager(string cpf) : base(cpf)
        {
        }

        public override double GetBonus() {
            return Salary + base.GetBonus();
        }
    }
}