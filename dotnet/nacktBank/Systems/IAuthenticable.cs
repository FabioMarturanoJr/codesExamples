namespace nacktBank.Systems
{
    public interface IAuthenticable
    {
        bool Authenticate(string password);
    }
}