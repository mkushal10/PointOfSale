using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace PointOfSale.Helper
{
    public class AppHelper
    {
        public static string GetMd5Hash(string input)
        {
            MD5 md5Hash = MD5.Create();
            //Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            //Create a new StringBuilder to collect the bytes and creating a string
            StringBuilder sBuilder = new StringBuilder();

            //Loop through each byte of the hashed data and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            //return to hexadecimal string
            return sBuilder.ToString();
        }
    }
}