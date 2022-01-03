using nacktBank.Systems;

namespace nacktBank.Partners
{
    public class CommercialPartiner : Authenticable
    {
        public string? Password { get; set; }
        public bool Authenticate(string password)
        {
            return Password == password;
        }
    }
}