using nacktBank.Systems;

namespace nacktBank.Employees
{
    public class Manager : EmployeeAuthenticable
    {
        public Manager(string cpf) : base(5000, cpf)
        {
        }
        public override void IncreaseSalary()
        {
            Salary *= 1.15;
        }
        public override double GetBonus() {
            return Salary * 0.5;
        }
    }
}