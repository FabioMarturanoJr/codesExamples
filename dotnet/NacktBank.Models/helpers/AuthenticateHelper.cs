namespace NacktBank.Models.helpers
{
    // class without access modifier is the same of internal
    class AuthenticateHelper
    {
        public bool ComparePass(string truePass, string checkPass) {
            return truePass == checkPass;
        }
    }
}