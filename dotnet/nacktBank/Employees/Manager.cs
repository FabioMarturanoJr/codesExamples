namespace nacktBank.Employees
{
    public class Manager : Employee
    {
        public string Password { get; set; }
        public Manager(string cpf) : base(5000, cpf)
        {
        }
        public bool Authenticate(string password) {
            return (Password == password);
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