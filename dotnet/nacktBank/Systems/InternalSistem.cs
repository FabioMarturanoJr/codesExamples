using nacktBank.Employees;

namespace nacktBank.Systems
{
    public class InternalSistem
    {
        public bool Login(Authenticable employee, string password) {
            bool userAuthenticated = employee.Authenticate(password);

            if (userAuthenticated) {
                System.Console.WriteLine("Login User");
                return userAuthenticated;
            }
            System.Console.WriteLine("Login failed");
            return userAuthenticated;
        }
    }
}