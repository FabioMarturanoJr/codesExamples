namespace nacktBank.Employees
{
    public class Manager : Employee
    {
        public override double GetBonus() {
            return Salary + base.GetBonus();
        }
    }
}