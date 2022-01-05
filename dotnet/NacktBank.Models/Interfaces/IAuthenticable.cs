namespace NacktBank.Models.Interfaces
{
    public interface IAuthenticable
    {
        bool Authenticate(string password);
    }
}