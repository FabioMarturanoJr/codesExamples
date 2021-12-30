namespace nacktBank.Employees
{
    public abstract class Employee
    {
        public static int TotalEmployees { get; private set; }
        public string? Name { get; set; }
        public string CPF { get; private set; }
        public double Salary { get; protected set; }
        public Employee(double salary ,string cpf)
        {
            TotalEmployees++;
            CPF = cpf;
            Salary = salary;
        }
        public virtual void IncreaseSalary() {
            Salary *= 1.1;
        }
        public virtual double GetBonus() {
            return Salary * 0.10;
        }
    }
}