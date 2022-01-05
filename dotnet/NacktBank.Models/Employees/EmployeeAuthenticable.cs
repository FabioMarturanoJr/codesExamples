using nacktBank.Systems;

namespace nacktBank.Employees
{
    public abstract class EmployeeAuthenticable : Employee, IAuthenticable
    {
        public string? Password { get; set; }
        protected EmployeeAuthenticable(double salary, string cpf) : base(salary, cpf)
        {
        }

        public bool Authenticate(string password)
        {
            return Password == password;
        }
    }
}