using nacktBank.Employees;

namespace nacktBank.Systems
{
    public abstract class Authenticable : Employee
    {
        protected Authenticable(double salary, string cpf) : base(salary, cpf)
        {
        }
        public string? Password { get; set; }
        public bool Authenticate(string password) {
            return Password == password;
        }
    }
}