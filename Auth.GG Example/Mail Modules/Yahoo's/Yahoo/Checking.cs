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
	// Token: 0x02000003 RID: 3
	internal class Yahoo1check
	{
		// Token: 0x06000003 RID: 3 RVA: 0x00002058 File Offset: 0x00000258
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
			Yahoo1files.CheckAllFile();
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002069 File Offset: 0x00000269
		public static void UpdateTitle()
		{
			Task.Factory.StartNew(delegate ()
			{
				for (; ; )
				{
					int remaining = Yahoo1files.CCombo.Count - Yahoo1check.CheckedLines;
					Colorful.Console.Title = string.Format("Yahoo API 1 | Checked: {1}/{2} | Hits: {3} | Custom: {6} | Bad: {4} | Retries: {5} | Errors: {8} | CPM: {0}  | Logged In As {7} - [Press TAB To Send Stats To Webhook]", new object[]
					{
						Yahoo1check.GetCurrentCPM(),
						Yahoo1check.CheckedLines,
						remaining,
						Yahoo1check.Hits,
						Yahoo1check.Bad,
						Yahoo1check.retry,
						Yahoo1check.custom,
						User.Username,
						Yahoo1check.Errors,
						Yahoo1check.twofa,
						Yahoo1check.unknown,
						Yahoo1check.Unssuported
					});
					Thread.Sleep(Program.config.refreshrate);
				}
			});
		}
		public static void cui()
		{
			Task.Factory.StartNew(delegate ()
			{
				for (; ; )
				{
					int remaining = Yahoo1files.CCombo.Count - Yahoo1check.CheckedLines;
					Colorful.Console.Title = string.Format("Yahoo API 1 | Checked: {1}/{2} | Hits: {3} | Custom: {6} | Bad: {4} | Retries: {5} | Errors: {8} | CPM: {0}  | Logged In As {7} - [Press TAB To Send Stats To Webhook]", new object[]
					{
						Yahoo1check.GetCurrentCPM(),
						Yahoo1check.CheckedLines,
						remaining,
						Yahoo1check.Hits,
						Yahoo1check.Bad,
						Yahoo1check.retry,
						Yahoo1check.custom,
						User.Username,
						Yahoo1check.Errors,
						Yahoo1check.twofa,
						Yahoo1check.unknown,
						Yahoo1check.Unssuported
					});
					Galaxy.Mainm.cui.start(Yahoo1check.Hits, Yahoo1check.Bad, Yahoo1check.custom, Yahoo1check.twofa, Yahoo1check.retry, Yahoo1check.Errors, Yahoo1files.CCombo.Count, Yahoo1check.CheckedLines, Yahoo1check.GetCurrentCPM());
					Console.Clear();
					Thread.Sleep(Program.config.refreshrate);
				}
			});
		}

		public static void LoadFile()
		{ 
			Colorful.Console.Title = "Galaxy AIO Coded By Adamski#2935";
			Yahoo1files.ComboFile(Combo); if (Program.config.proxytype.ToUpper() == "PROXYLESS") { string Hora = "Yes"; } else
			Yahoo1files.ComboProxy();
		}
		public static List<Thread> threads = new List<Thread>();
		public static void Startkker()
		{
			
			Yahoo1files.ComboFile(Combo); if (Program.config.proxytype.ToUpper() == "PROXYLESS") { string Hora = "Yes"; } else
			Yahoo1files.ComboProxy();

			if (Program.config.ui == 1)
			{
				Yahoo1check.cui();
			}
			else if (Program.config.ui == 2)
			{
				Yahoo1check.UpdateTitle();
			}

			Yahoo1kek.Path = "Results\\YahooAPI1\\" + Process.GetCurrentProcess().StartTime.ToString("dd-MM-yyyy-hh-mm");
			if (!Directory.Exists(Yahoo1kek.Path))
			{
				Checking.currentrun = "Checking YahooAPI1";
				Directory.CreateDirectory(Yahoo1kek.Path);
			}
			for (int i = 0; i < Program.config.threads; i++)
			{
				Thread item = new Thread((ThreadStart)Yahoo1kek.startchecker1);
				threads.Add(item);
			}
			foreach (var thread in threads)
				thread.Start();
			foreach (var thread in threads)
				thread.Join();
		}
		public static string capppp;
		public static ProxyClient RandomProxies()
		{
			return Yahoo1check.ProxyList[new Random().Next(0, Yahoo1check.ProxyList.Count)];
		}

		internal static void Start1()
		{
			Colorful.Console.Title = "Galaxy AIO";
			Start();
			System.Console.Clear();
			Design.UI();
			Console.WriteLine();
			Yahoo1check.Start();
			Yahoo1check.Startkker();


		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002328 File Offset: 0x00000528
		public static int GetCurrentCPM()
		{
			DateTime dateTime = Yahoo1check.currentCpmDatetime;
			if ((DateTime.Now - Yahoo1check.currentCpmDatetime).Minutes >= 1)
			{
				Yahoo1check.lastCpms.Add(Yahoo1check.currentCpm); Interlocked.Increment(ref stats.currentCpm);
				Yahoo1check.currentCpm = 0;
				Yahoo1check.currentCpmDatetime = DateTime.Now;
			}
			int num = Yahoo1check.currentCpm;
			for (int i = 0; i < Yahoo1check.lastCpms.Count; i++)
			{
				num += Yahoo1check.lastCpms[i];
			}
			int result;
			if (Yahoo1check.lastCpms.Count == 0)
			{
				result = num;
			}
			else
			{
				result = num / Yahoo1check.lastCpms.Count;
			}
			return result;
		}

		// Token: 0x04000002 RID: 2
		public static int ComboLines;

		// Token: 0x04000003 RID: 3
		public static int CheckedLines;

		// Token: 0x04000004 RID: 4
		public static int Hits;

		// Token: 0x04000005 RID: 5
		public static int Bad;

		// Token: 0x04000006 RID: 6
		public static int retry;

		// Token: 0x04000007 RID: 7
		public static int counter;
		public static int Unssuported;
		// Token: 0x04000008 RID: 8
		public static int Errors;

		public static int proxytype;

		public static string currentrun;
		// Token: 0x04000009 RID: 9

		public static ConcurrentQueue<string> Combo = new ConcurrentQueue<string>();

		public static int threadsnig;
		// how to search in all files. search for a word like you did before
		public static int currentCpm;

		// Token: 0x0400000A RID: 10
		public static DateTime currentCpmDatetime;

		// Token: 0x0400000B RID: 11
		public static List<int> lastCpms = new List<int>();

		// Token: 0x0400000C RID: 12
		public static ConcurrentBag<string> ComboList = new ConcurrentBag<string>();

		// Token: 0x0400000D RID: 13
		public static List<ProxyClient> ProxyList = new List<ProxyClient>();

		// Token: 0x0400000E RID: 14
		public static int custom;

		public static int unknown;

		public static int expired;

		public static int username;

		public static bool showbad1;

		public static int showbad;

		public static bool userpc1;

		public static int userpc;

		public static bool showgood1;

		public static int showgood;

		public static bool show2fa1;

		public static int show2fa;

		public static bool showlocked1;

		public static int showlocked;

		public static string tokentype = "";

		public static string gaytype = "";

		public static string gaytype1 = "";

		public static string niggggger = "";

		public static string nigballs = "";

		public static string nigballs1 = "";

		public static int twofa;

		public static int embedecolor;

		public static int embedecolor1;

		public static int embedecolor2;
		public static string Cstyle;

		public static bool paused = false;
	}
}
