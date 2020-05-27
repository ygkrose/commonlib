using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace NewCity.Common
{
    public class NCCipher
    {
        public static string AESEncrypt(string text) { return AESEncrypt(text, "The.Imitation.Game", "Alan_Turing:The_Enigma"); }
        public static string AESEncrypt(string text, string password, string iv)
        {
            byte[] pwdBytes = System.Text.Encoding.UTF8.GetBytes(password),
                keyBytes = new byte[16],
                ivBytes = System.Text.Encoding.UTF8.GetBytes(iv);

            int len = pwdBytes.Length;

            if (len > keyBytes.Length) len = keyBytes.Length;

            System.Array.Copy(pwdBytes, keyBytes, len);

            RijndaelManaged rijndaelCipher = new RijndaelManaged
            {
                Mode = CipherMode.CBC,
                Padding = PaddingMode.PKCS7,
                KeySize = 128,
                BlockSize = 128,
                Key = keyBytes,
                IV = ivBytes
            };

            ICryptoTransform transform = rijndaelCipher.CreateEncryptor();

            byte[] plainText = Encoding.UTF8.GetBytes(text),
                cipherBytes = transform.TransformFinalBlock(plainText, 0, plainText.Length);

            return Convert.ToBase64String(cipherBytes);
        }
    }
}
