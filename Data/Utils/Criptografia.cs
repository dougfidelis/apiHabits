using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Data.Utils
{
    internal class Criptografia
    {
        public static string Criptografar(string entrada)
        {
            MD5 md5 = MD5.Create();
            byte[] entradaBytes = Encoding.UTF8.GetBytes(entrada);
            byte[] hash = md5.ComputeHash(entradaBytes);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }
    }
}
