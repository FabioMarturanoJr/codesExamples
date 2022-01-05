namespace NacktBank.Models.Employees
{
    public class Designer : Employee
    {
        public static int TotalDesigner { get; private set; }
        public Designer(string cpf) : base(3000, cpf)
        {
            TotalDesigner++;
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