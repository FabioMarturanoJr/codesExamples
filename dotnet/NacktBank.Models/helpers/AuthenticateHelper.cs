namespace NacktBank.Models.helpers
{
    internal class AuthenticateHelper
    {
        public bool ComparePass(string truePass, string checkPass) {
            return truePass == checkPass;
        }
    }
}