using NacktBank.Models.helpers;
using NacktBank.Models.Interfaces;

namespace NacktBank.Models.Employees
{
    public abstract class EmployeeAuthenticable : Employee, IAuthenticable
    {
        private AuthenticateHelper _auth = new AuthenticateHelper();
        public string? Password { get; set; }
        protected EmployeeAuthenticable(double salary, string cpf) : base(salary, cpf)
        {
        }

        public bool Authenticate(string password)
        {
            return _auth.ComparePass(Password, password);
        }
    }
}