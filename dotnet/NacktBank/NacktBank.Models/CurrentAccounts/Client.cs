namespace NacktBank.Models.CurrentAccounts
{
    public class Client
    {
        public string Name { get; set; } = "Non-filled";
        public string CPF { get; set; } = "Non-filled";
        public string Occupation { get; set; } = "Non-filled";
        public DateTime AccountExpiration { get; set; }
        
        public override bool Equals(object? obj)
        {
            Client objClient = obj as Client;

            if (objClient == null) return false;

            return CPF == objClient.CPF;
        }
    }
}