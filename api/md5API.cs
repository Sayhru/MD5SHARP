using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace md5Generator.api
{
    internal class md5API
    {
        public string retornarMD5(String senha)
        {
            using(MD5 md5Hash = MD5.Create())
            {
                return returnHash(md5Hash, senha);
            }
        }
        public bool compararMD5(String senha, string hash)
        {
            string senha2 = retornarMD5(senha);
            if(verificarHash(hash, senha2))
            {
                return true;


            } else
            {
                return false;
            }

        }
        private String returnHash(MD5 hash, string input)
        {
                byte[] data = hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder sB = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sB.Append(data[i].ToString("X2"));
            }
            return sB.ToString();
        }        
        
        private Boolean verificarHash(string input, string hash)
        {
            //Compare (NO CASE sEnSiTiVe)
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;
            //if both is equals
            if(comparer.Compare(input, hash) == 0)
            {

                return true;

            } else
            {
                return false;
            }
        }
    }
}
