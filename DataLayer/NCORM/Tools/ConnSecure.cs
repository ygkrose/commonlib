using Renci.SshNet.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace NewCity.DataAccess.Tools
{
    public static class ConnSecure
    {
        const string key = "NCEnigma";
        const string iv = "Alan_Turing:The_Enigma";
        ///   
        /// 加密  
        ///   
        /// 需要加密的值  
        /// 加密後的結果  
        public static string Encrypt(string text)
        {
            DESCryptoServiceProvider dsp = new DESCryptoServiceProvider();
            using (MemoryStream memStream = new MemoryStream())
            {
                CryptoStream crypStream = new CryptoStream(memStream, dsp.CreateEncryptor(Encoding.UTF8.GetBytes(key), Encoding.UTF8.GetBytes(iv)), CryptoStreamMode.Write);
                StreamWriter sWriter = new StreamWriter(crypStream);
                sWriter.Write(text);
                sWriter.Flush();
                crypStream.FlushFinalBlock();
                memStream.Flush();
                return Convert.ToBase64String(memStream.GetBuffer(), 0, (int)memStream.Length);
            }
        }

        ///   
        /// 解密  
        ///   
        /// 解密後的結果  
        public static string Decrypt(string encryptText)
        {
            DESCryptoServiceProvider dsp = new DESCryptoServiceProvider();
            byte[] buffer = Convert.FromBase64String(encryptText);

            using (MemoryStream memStream = new MemoryStream())
            {
                CryptoStream crypStream = new CryptoStream(memStream, dsp.CreateDecryptor(Encoding.UTF8.GetBytes(key), Encoding.UTF8.GetBytes(iv)), CryptoStreamMode.Write);
                crypStream.Write(buffer, 0, buffer.Length);
                crypStream.FlushFinalBlock();
                return UTF8Encoding.UTF8.GetString(memStream.ToArray());
            }
        }


        public static string GenerateUID()
        {
            try
            {
                int maxSize = 15;
                int minSize = 10;
                char[] chars = new char[63];
                string a;
                a = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
                chars = a.ToCharArray();
                int size = maxSize;
                byte[] data = new byte[2];
                System.Security.Cryptography.RNGCryptoServiceProvider crypto = new System.Security.Cryptography.RNGCryptoServiceProvider();
                crypto.GetNonZeroBytes(data);
                size = maxSize;
                data = new byte[size + 1];
                crypto.GetNonZeroBytes(data);
                StringBuilder result = new StringBuilder(size);
                foreach (byte b in data)
                    result.Append(chars[b % (chars.Length - 1)]);
                return result.ToString().Trim();
            }
            catch (Exception ex)
            {
                return "";
            }
        }



    }
}
