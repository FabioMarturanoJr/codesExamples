
namespace nacktBank.Systems
{
    public interface Authenticable
    {
        bool Authenticate(string password);
    }
}