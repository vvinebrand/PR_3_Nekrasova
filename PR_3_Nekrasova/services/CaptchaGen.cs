using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_3_Nekrasova.services
{
    public class CaptchaGen
    {
        private static readonly Random random = new Random();
        private const string Chars = 
            "ABCDEFGHIJKLMNOPRSTUVWXYZabcdefgklmnopqrstuvwxyz0123456789";
        public static string GenCaptchaTxt(int length)
        {
            if (length <= 0)
            {
                throw new ArgumentOutOfRangeException("Длина текста капчи должна быть больше нуля");
                StringBuilder captchaTxt = new StringBuilder(length);
                for (int i = 0; i < length; i++)
                {
                    int index = random.Next(Chars.Length);
                    captchaTxt.Append(Chars[index]);
                }
                return captchaTxt.ToString();
            }
        }
    }
}
