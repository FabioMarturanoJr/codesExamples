namespace NacktBank.Models.CurrentAccounts
{
    public class Client
    {
        public string Name { get; set; } = "Non-filled";
        public string CPF { get; set; } = "Non-filled";
        public string Occupation { get; set; } = "Non-filled";
        public DateTime AccountExpiration { get; set; }
    }
}