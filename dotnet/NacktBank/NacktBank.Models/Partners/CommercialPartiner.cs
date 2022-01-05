using NacktBank.Models.Helpers;
using NacktBank.Models.Interfaces;

namespace NacktBank.Models.Partners
{
    public class CommercialPartiner : IAuthenticable
    {
        private AuthenticateHelper _auth = new AuthenticateHelper();
        public string Password { get; set; } = "undefined";
        public string? Name { get; set; }
        public bool Authenticate(string password)
        {
            return _auth.ComparePass(Password, password);
        }
    }
}