using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class EncryptionAndDecryption
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string SHA(string name)
        {
            SHA256Managed sha256 = new SHA256Managed();
            byte[] buffer = Encoding.UTF8.GetBytes(name);
            byte[] result = sha256.ComputeHash(buffer);
            return Convert.ToBase64String(result);
        }
    }
}
