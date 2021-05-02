using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace sys_ConData
{
    internal sealed class sys_Con
    {
        // Fields
        public static string ConnectionString;

        // Methods
        static sys_Con()
        {
            ConnectionString = "";
        }

        public static string MaHoa03(string str, string key, bool useHashing)
        {
            string str2;
            try
            {
                byte[] bytes = Encoding.UTF8.GetBytes(str);
                byte[] buffer = !useHashing ? Encoding.UTF8.GetBytes(key) : new MD5CryptoServiceProvider().ComputeHash(Encoding.UTF8.GetBytes(key));
                TripleDESCryptoServiceProvider provider = new TripleDESCryptoServiceProvider
                {
                    Key = buffer,
                    Mode = CipherMode.ECB,
                    Padding = PaddingMode.PKCS7
                };
                byte[] inArray = provider.CreateEncryptor().TransformFinalBlock(bytes, 0, bytes.Length);
                str2 = Convert.ToBase64String(inArray, 0, inArray.Length);
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                throw ex;
            }
            return str2;
        }

        public static string MaHoa04(string str, string key, bool useHashing)
        {
            string str2;
            try
            {
                byte[] inputBuffer = Convert.FromBase64String(str);
                byte[] buffer = !useHashing ? Encoding.UTF8.GetBytes(key) : new MD5CryptoServiceProvider().ComputeHash(Encoding.UTF8.GetBytes(key));
                TripleDESCryptoServiceProvider provider = new TripleDESCryptoServiceProvider
                {
                    Key = buffer,
                    Mode = CipherMode.ECB,
                    Padding = PaddingMode.PKCS7
                };
                byte[] bytes = provider.CreateDecryptor().TransformFinalBlock(inputBuffer, 0, inputBuffer.Length);
                str2 = Encoding.UTF8.GetString(bytes);
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                throw ex;
            }
            return str2;
        }



    }
}
