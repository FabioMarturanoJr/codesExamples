namespace NacktBank.Models.helpers
{
    public class AuthenticateHelper
    {
        public bool ComparePass(string truePass, string checkPass) {
            return truePass == checkPass;
        }
    }
}