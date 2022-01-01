using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesLib
{
    public class ClsCrypto
    {
        string hash = "f0xle@rn";
        public string Encrypt(string txt)
        {
            byte[] data = UTF8Encoding.UTF8.GetBytes(txt);
            string textEncrypt = "";
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateEncryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    textEncrypt = Convert.ToBase64String(results, 0, results.Length);
                }
            }
            return textEncrypt;

        }
        public string Decrypt(string txt)
        {
            byte[] data = Convert.FromBase64String(txt);
            string textDecrypt = "";
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateDecryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    textDecrypt = UTF8Encoding.UTF8.GetString(results);
                }
            }
            return textDecrypt;

        }
    }
}
