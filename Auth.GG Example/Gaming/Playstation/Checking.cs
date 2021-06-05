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
	internal class psn1check
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
			psn1files.CheckAllFile();
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002069 File Offset: 0x00000269

		private static void cui()
		{
			Task.Factory.StartNew(delegate ()
			{
				for (; ; )
				{
					Colorful.Console.Clear();
					Design.UI();
					int remaining = psn1files.CCombo.Count - psn1check.CheckedLines;
					Colorful.Console.Title = string.Format("Playstation | Checked: {1}/{2} | Hits: {3} | Custom: {6} | Bad: {4} | Retries: {5} | Errors: {8} | CPM: {0}  | Logged In As {7} - [Press TAB To Send Stats To Webhook]", new object[]
					{
						psn1check.GetCurrentCPM(),
						psn1check.CheckedLines,
						remaining,
						psn1check.Hits,
						psn1check.Bad,
						psn1check.retry,
						psn1check.custom,
						User.Username,
						psn1check.Errors,
						psn1check.twofa,
						psn1check.unknown,
						psn1check.Unssuported
					});
					Galaxy.Mainm.cui.start(psn1check.Hits, psn1check.Bad, psn1check.custom, psn1check.twofa, psn1check.retry, psn1check.Errors, psn1files.CCombo.Count, psn1check.CheckedLines, psn1check.GetCurrentCPM());
					Console.Clear();
					Thread.Sleep(Program.config.refreshrate);

				}
			});
		}
		public static void UpdateTitle()
		{
			Task.Factory.StartNew(delegate ()
			{
				for (; ; )
				{
					int remaining = psn1files.CCombo.Count - psn1check.CheckedLines;
					Colorful.Console.Title = string.Format("Playstation | Checked: {1}/{2} | Hits: {3} | Custom: {6} | Bad: {4} | Retries: {5} | Errors: {8} | CPM: {0}  | Logged In As {7} - [Press TAB To Send Stats To Webhook]", new object[]
					{
						psn1check.GetCurrentCPM(),
						psn1check.CheckedLines,
						remaining,
						psn1check.Hits,
						psn1check.Bad,
						psn1check.retry,
						psn1check.custom,
						User.Username,
						psn1check.Errors,
						psn1check.twofa,
						psn1check.unknown,
						psn1check.Unssuported
					});
					Thread.Sleep(Program.config.refreshrate);
				}
			});
		}
		
		public static void LoadFile()
		{ 
			Colorful.Console.Title = "Galaxy AIO Coded By Adamski#2935";
			psn1files.ComboFile(Combo); if (Program.config.proxytype.ToUpper() == "PROXYLESS") { string Hora = "Yes"; } else if (Program.config.proxytype.ToUpper() == "PROXYLESS") { string Hora = "Yes"; } else
			psn1files.ComboProxy();
		}
		public static List<Thread> threads = new List<Thread>();
		public static void Startkker()
		{
			
			psn1files.ComboFile(Combo); if (Program.config.proxytype.ToUpper() == "PROXYLESS") { string Hora = "Yes"; } else
			psn1files.ComboProxy();
			if (Program.config.ui == 1)
            {
				psn1check.cui();
            }
			else if (Program.config.ui == 2)
			{
				psn1check.UpdateTitle();
			}
			psn1kek.Path = "Results\\Playstation\\" + Process.GetCurrentProcess().StartTime.ToString("dd-MM-yyyy-hh-mm");

			if (!Directory.Exists(psn1kek.Path))
			{
				Checking.currentrun = "Checking Playstation";
				Directory.CreateDirectory(psn1kek.Path);
			}
			for (int i = 0; i < Program.config.threads; i++)
			{
				Thread item = new Thread((ThreadStart)psn1kek.startchecker1);
				threads.Add(item);
			}
			foreach (var thread in threads)
				thread.Start();
			foreach (var thread in threads)
				thread.Join();
		}
		public static ProxyClient RandomProxies()
		{
			return psn1check.ProxyList[new Random().Next(0, psn1check.ProxyList.Count)];
		}

		internal static void Start1()
		{
			Colorful.Console.Title = "Galaxy AIO";
			Start();
			System.Console.Clear();
			Design.UI();
			Console.WriteLine();
			psn1check.Start();
			psn1check.Startkker();
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002328 File Offset: 0x00000528
		public static int GetCurrentCPM()
		{
			DateTime dateTime = psn1check.currentCpmDatetime;
			if ((DateTime.Now - psn1check.currentCpmDatetime).Minutes >= 1)
			{
				psn1check.lastCpms.Add(psn1check.currentCpm); Interlocked.Increment(ref stats.currentCpm);
				psn1check.currentCpm = 0;
				psn1check.currentCpmDatetime = DateTime.Now;
			}
			int num = psn1check.currentCpm;
			for (int i = 0; i < psn1check.lastCpms.Count; i++)
			{
				num += psn1check.lastCpms[i];
			}
			int result;
			if (psn1check.lastCpms.Count == 0)
			{
				result = num;
			}
			else
			{
				result = num / psn1check.lastCpms.Count;
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
