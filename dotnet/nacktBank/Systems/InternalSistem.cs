
namespace nacktBank.Systems
{
    public class InternalSistem
    {
        public bool Login(Authenticable user, string password) {
            bool userAuthenticated = user.Authenticate(password);

            if (userAuthenticated) {
                System.Console.WriteLine("Login User");
                return userAuthenticated;
            }
            System.Console.WriteLine("Login failed");
            return userAuthenticated;
        }
    }
}