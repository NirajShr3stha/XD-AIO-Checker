using System; using Galaxy.Mainm;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using AuthGG;
using Colorful;
using Leaf.xNet;
using Zuttpal;
using Console = Colorful.Console;
namespace ZuttPal
{
	internal class Checking
	{
		public static IEnumerable<string> combos;
		public static int comboTotal = 0;
		public static IEnumerable<string> proxies;
		public static int proxiesCount = 0;
		public static List<Thread> threads = new List<Thread>();
		public static void Start()
		{
			if (Program.config.proxytype.ToUpper().ToUpper() == "HTTP")
			{
				Checking.proxytype = 1;
			}
			else if (Program.config.proxytype.ToUpper().ToUpper() == "HTTPS")
			{
				Checking.proxytype = 1;
			}
			else if (Program.config.proxytype.ToUpper().ToUpper() == "SOCKS4")
			{
				Checking.proxytype = 2;
			}
			else if (Program.config.proxytype.ToUpper().ToUpper() == "PROXYLESS") { Checking.proxytype = 4; } else if (Program.config.proxytype.ToUpper().ToUpper() == "SOCKS5")
			{
				Checking.proxytype = 3;
			}
			else if (Program.config.proxytype.ToUpper().ToUpper() == "PROXYLESS")
			{
				Checking.proxytype = 4;
			}
			if (Program.config.showbad.ToUpper() == "YES")
			{
				Checking.showbad = 1;
			}
			else if (Program.config.showbad.ToUpper() == "Y")
			{
				Checking.showbad = 1;
			}
			else if (Program.config.showbad.ToUpper() == "NO")
			{
				Checking.showbad = 2;
			}
			else if (Program.config.showbad.ToUpper() == "N")
			{
				Checking.showbad = 2;
			}
			if (Program.config.showgood.ToUpper() == "YES")
			{
				Checking.showgood = 1;
			}
			else if (Program.config.showgood.ToUpper() == "Y")
			{
				Checking.showgood = 1;
			}
			else if (Program.config.showgood.ToUpper() == "NO")
			{
				Checking.showgood = 2;
			}
			else if (Program.config.showgood.ToUpper() == "N")
			{
				Checking.showgood = 2;
			}
			if (Program.fet.ToUpper() == "YES")
			{
				Checking.userpc = 1;
			}
			else if (Program.fet.ToUpper() == "Y")
			{
				Checking.userpc = 1;
			}
			else if (Program.fet.ToUpper() == "NO")
			{
				Checking.userpc = 2;
			}
			else if (Program.fet.ToUpper() == "N")
			{
				Checking.userpc = 2;
			}
			
			{
				
				
				
			}
			if (Program.config.showlocked.ToUpper() == "YES")
			{
				Checking.showlocked = 1;
			}
			else if (Program.config.showlocked.ToUpper() == "Y")
			{
				Checking.showlocked = 1;
			}
			else if (Program.config.showlocked.ToUpper() == "NO")
			{
				Checking.showlocked = 2;
			}
			else if (Program.config.showlocked.ToUpper() == "N")
			{
				Checking.showlocked = 2;
			}
			if (Program.config.show2fa.ToUpper() == "YES")
			{
				Checking.show2fa = 1;
			}
			else if (Program.config.show2fa.ToUpper() == "Y")
			{
				Checking.show2fa = 1;
			}
			else if (Program.config.show2fa.ToUpper() == "NO")
			{
				Checking.show2fa = 2;
			}
			else if (Program.config.show2fa.ToUpper() == "N")
			{
				Checking.show2fa = 2;
			}
			//if (Program.config.moooooood.ToUpper() == "LOG")
			//{
			//	Checking.modes = 1;
			//}
			//else if (Program.config.moooooood.ToUpper() == "CUI")
			//{
			//	Checking.modes = 2;
			//}

		}

		public static void LoadFile()
		{
			Colorful.Console.Title = "AIO Checker by Adamski#2935";

		}

		
		public static ProxyClient RandomProxies()
		{
			return Checking.ProxyList[new Random().Next(0, Checking.ProxyList.Count)];
		}


		internal static void Start1()
		{
			string des = "";
			Colorful.Console.Title = "Galaxy AIO Coded By Adamski#2935";
			if (Program.config.ui == 1)
            {
				des = "CUI";

            }
			else if (Program.config.ui == 2)
            {
				des = "LOG";
			}
			else
            {
				Console.Clear();
				Console.WriteLine("Config Error");
				Console.ReadLine();
            }
			System.Console.Clear();
			Design.UI();
			Console.WriteLine();
			Checking.currentrun = "Checking Paypal API 1";
		IL21:
			{
				Console.Clear();
				Design.UI();
				Colorful.Console.Write("[~] Current Config", Color.Cyan);
				Colorful.Console.Write("\n\n[~] Design: ", Color.Cyan);
				Colorful.Console.Write(des, Color.LawnGreen);
				Colorful.Console.Write("\n\n[~] Threads: ", Color.Cyan);
				Colorful.Console.Write(Program.config.threads, Color.LawnGreen);
				Colorful.Console.Write("\n[~] TimeOut: ", Color.Cyan);
				Colorful.Console.Write(Program.config.timeout, Color.LawnGreen);
				Colorful.Console.Write("\n[~] ProxyType: ", Color.Cyan);
				Colorful.Console.Write(Program.config.proxytype, Color.LawnGreen);
				Colorful.Console.Write("\n[~] Print Valid: ", Color.Cyan);
				Colorful.Console.Write(Program.config.showgood, Color.LawnGreen);
				Colorful.Console.Write("\n[~] Print Invalid: ", Color.Cyan);
				Colorful.Console.Write(Program.config.showbad, Color.LawnGreen);
				Colorful.Console.Write("\n[~] Print Locked: ", Color.Cyan);
				Colorful.Console.Write(Program.config.showlocked, Color.LawnGreen);
				Colorful.Console.Write("\n[~] Print 2FA: ", Color.Cyan);
				Colorful.Console.Write(Program.config.show2fa, Color.LawnGreen);
				Colorful.Console.Write("\n[~] Use Discord Webhook: ", Color.Cyan);
				Colorful.Console.Write(Program.config.usewebhook, Color.LawnGreen);
				if (Checking.usewebhook == true)
				{
					Colorful.Console.Write("\n[~] Discord Webhook: ", Color.Cyan);
					Colorful.Console.Write(Program.config.webhook, Color.LawnGreen);
				}
				Colorful.Console.Write("\n[~] Send Hits To Webhook: ", Color.Cyan);
				Colorful.Console.Write(Program.config.hitstowebhook, Color.LawnGreen);

				//olorful.Console.Write("\n\n\n[~] UI: ", Color.Cyan);
				//olorful.Console.Write(Program.config.moooooood, Color.LawnGreen);
				Colorful.Console.WriteLine("\n\n[~] Press X To Go Start | Press V To Edit Config", Color.Cyan);
				var option = System.Console.ReadKey();
				if (option.Key == (ConsoleKey.X))
				{
					Colorful.Console.Clear();
					Design.UI1();
					Checking.Start();
		
				}
				if (option.Key == (ConsoleKey.V))
				{
					Checking.currentrun = "Editing Config";
					Login.renewconfig(true);
				}
				else
					goto IL21;
			}

		}

		public static int GetCurrentCPM()
		{
			DateTime dateTime = Checking.currentCpmDatetime;
			if ((DateTime.Now - Checking.currentCpmDatetime).Minutes >= 1)
			{
				Checking.lastCpms.Add(Checking.currentCpm); Interlocked.Increment(ref stats.currentCpm);
				Checking.currentCpm = 0;
				Checking.currentCpmDatetime = DateTime.Now;
			}
			int num = Checking.currentCpm;
			for (int i = 0; i < Checking.lastCpms.Count; i++)
			{
				num += Checking.lastCpms[i];
			}
			int result;
			if (Checking.lastCpms.Count == 0)
			{
				result = num;
			}
			else
			{
				result = num / Checking.lastCpms.Count;
			}
			return result;
		}

		public static int ComboLines;
		public static int CheckedLines;

		public static int Hits;


		public static int Bad;


		public static int retry;


		public static int counter;


		public static int Errors;

		public static int proxytype;



		public static ConcurrentQueue<string> Combo = new ConcurrentQueue<string>();

		public static int threadsnig;

		public static int currentCpm;


		public static DateTime currentCpmDatetime;


		public static List<int> lastCpms = new List<int>();

		public static ConcurrentBag<string> ComboList = new ConcurrentBag<string>();

		public static List<ProxyClient> ProxyList = new List<ProxyClient>();

		public static string currentrun;
		public static int custom;

		public static string hasid;
		public static int unknown;

		public static int expired;

		public static int username;

		public static bool showbad1;

		public static int showbad;

		public static bool userpc1;

		public static int userpc;

		public static string ui;

		public static bool hitstowebhook;

		public static bool useproxyapi;


		public static bool showgood1;

		public static int showgood;

		public static bool show2fa1;

		public static int modes;

		public static int show2fa;

		public static bool usewebhook;

		public static bool log;

		public static bool showlocked1;

		public static int showlocked;

		public static string tokentype = "";

		public static string gaytype = "";

		public static string gaytype1 = "";

		public static string niggggger = "";

		public static string nigballs = "";

		public static string level = "";

		public static string nigballs1 = "";

		public static int twofa;

		public static int embedecolor;

		public static int embedecolor1;

		public static int embedecolor2;
		public static string Cstyle;

		public static bool paused = false;
	}
}
