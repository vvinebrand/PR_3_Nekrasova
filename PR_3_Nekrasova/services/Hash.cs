using System.Text;
using System.Security.Cryptography;

namespace PR5_Class_Library
{
    public static class Hash
    {
        public static string CreateHash(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }

        public static bool
     VerifyHash(string password, string hashedPassword)
        {
            string newHash = CreateHash(password);
            return newHash == hashedPassword;
        }
    }
}
