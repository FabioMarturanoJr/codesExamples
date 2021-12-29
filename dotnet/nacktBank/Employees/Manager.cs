namespace nacktBank.Employees
{
    public class Manager
    {
        public string? Name { get; set; }
        public string? CPF { get; set; }
        public int Salary { get; set; }
        
        public double GetBonus() {
            return Salary;
        }
    }
}