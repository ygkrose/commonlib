using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Linq;
using System.Net;
using System.Net.Mail;

using System.Threading;
using System.Drawing;
using System.Security.Cryptography;

namespace NewCity.Common
{
    public class NCUtility
    {
        public static string ByteArrayToHex(byte[] bytes)
        {
            string hexString = string.Empty;
            if (bytes != null)
            {
                StringBuilder str = new StringBuilder();

                for (int i = 0; i < bytes.Length; i++)
                {
                    str.Append(bytes[i].ToString("x2"));
                }
                hexString = str.ToString();
            }
            return hexString;
        }

        public static string TimestampToDatetimeStr(string str)
        {
            string r = "";
            if (str.Length != 14) return r;
            r = str.Substring(0, 4) + "/" + str.Substring(4, 2) + "/" + str.Substring(6, 2) + " " + str.Substring(8, 2) + ":" + str.Substring(10, 2) + ":" + str.Substring(12, 2);
            return r;
        }
        public static DateTime TimestampToDatetime(string str)
        {
            DateTime r = DateTime.MinValue;
            DateTime.TryParse(TimestampToDatetimeStr(str), out r);
            return r;
        }

        public enum TAlign { alLeft, alCenter, alRight };
        public static string FixedLengthStr(string str,int len, TAlign alg=TAlign.alLeft,char fillchar=' ')
        {
            string s = str.Substring(0, len);
            if (alg == TAlign.alLeft)
            {
                s = s.PadRight(len, fillchar);
            }
            else if (alg == TAlign.alRight)
            {
                s = s.PadLeft(len, fillchar);
            }
            else
            {
                int avglen = (len - s.Length) / 2;
                s = s.PadLeft(avglen + s.Length, fillchar);
                s = s.PadRight(len, fillchar);
            }
            return s;
        }

        public static string BoolToBin(bool b)
        {
            return (b ? "1" : "0");
        }

        public static string ReturnError(string errcode,string errmsg)
        {
            return $"{{\"ErrorCode\":\"{errcode}\",\"ErrorMessage\":\"{errmsg}\"}}";
        }
        public static string ReturnError(Dictionary<int,string> dic,int ndx)
        {
            string code = "9999";
            string msg = "";
            if (dic.ContainsKey(ndx))
            {
                code = ndx.ToString();
                msg = dic[ndx];
            }
            return ReturnError(code, msg);
        }

        public static string GetMd5Hash(string input)
        {
            using (MD5 md5Hash = MD5.Create())
            {
                // Convert the input string to a byte array and compute the hash.
                byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

                // Create a new Stringbuilder to collect the bytes
                // and create a string.
                StringBuilder sBuilder = new StringBuilder();

                // Loop through each byte of the hashed data
                // and format each one as a hexadecimal string.
                for (int i = 0; i < data.Length; i++)
                {
                    sBuilder.Append(data[i].ToString("x2"));
                }

                // Return the hexadecimal string.
                return sBuilder.ToString();
            }
        }

        // Verify a hash against a string.
        public static bool VerifyMd5Hash(MD5 md5Hash, string input, string hash)
        {
            // Hash the input.
            string hashOfInput = GetMd5Hash(input);

            // Create a StringComparer an compare the hashes.
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            if (0 == comparer.Compare(hashOfInput, hash))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }


 

}
