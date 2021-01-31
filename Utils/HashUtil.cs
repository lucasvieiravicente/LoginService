using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LoginService.Utils
{
    public static class HashUtil
    {
        public static string HashPassword(string password)
        {
            byte[] encodedPassword = Encoding.UTF8.GetBytes(password);
            var sha1 = new SHA1CryptoServiceProvider();
            var sha1data = sha1.ComputeHash(encodedPassword);
            return sha1data.ToString();
        }
    }
}
