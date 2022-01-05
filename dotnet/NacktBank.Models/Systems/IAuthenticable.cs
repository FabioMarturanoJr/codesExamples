namespace NacktBank.Models.Systems
{
    public interface IAuthenticable
    {
        bool Authenticate(string password);
    }
}