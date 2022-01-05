using nacktBank.Systems;

namespace nacktBank.Partners
{
    public class CommercialPartiner : IAuthenticable
    {
        public string? Password { get; set; }
        public string? Name { get; set; }
        public bool Authenticate(string password)
        {
            return Password == password;
        }
    }
}