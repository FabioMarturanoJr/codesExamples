
namespace nacktBank.Systems
{
    public class InternalSistem
    {
        public bool Login(IAuthenticable user, string password) {
            bool userAuthenticated = user.Authenticate(password);

            if (userAuthenticated) {
                System.Console.WriteLine($"Login User {user}");
                return userAuthenticated;
            }
            System.Console.WriteLine($"Login failed {user}");
            return userAuthenticated;
        }
    }
}