using System; using Galaxy.Mainm;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Leaf.xNet;
using Newtonsoft.Json;
using ZuttPal;

namespace Zuttpal
{
	// Token: 0x02000008 RID: 8
	internal class hbonordic1files
	{
		// Token: 0x06000029 RID: 41 RVA: 0x00002610 File Offset: 0x00000810
		public static void CheckAllFile()
		{
			bool flag = !Directory.Exists("Results");
			if (flag)
			{
				Directory.CreateDirectory("Results");
			}
		}

		// Token: 0x0600002A RID: 42 RVA: 0x0000263C File Offset: 0x0000083C

		public static List<string> CCombo = new List<string>();

		public static void ComboFile(ConcurrentQueue<string> Combo)
		{

			OpenFileDialog opencombo = new OpenFileDialog();
			string cname;
			do
			{
				opencombo.Title = "Select Combo";
				opencombo.DefaultExt = "txt";
				opencombo.Filter = "Text files|*.txt";
				opencombo.ShowDialog();
				cname = opencombo.FileName;
			}
			while (!File.Exists(cname) || cname == null);
			CCombo = new List<string>(File.ReadAllLines(cname));
			foreach (string coline in CCombo)
			{
				if (coline.Contains(":") || coline.Contains(";"))
				{
					Combo.Enqueue(coline); stats.filecount++;
				}
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x0000271C File Offset: 0x0000091C
		public static void ComboProxy()
		{
			using (OpenFileDialog openFileDialog = new OpenFileDialog())
			{
				openFileDialog.Filter = "Text files (*.txt)|*.txt";
				openFileDialog.Multiselect = false;
				openFileDialog.Title = "Select your proxies file";
				int num = (int)openFileDialog.ShowDialog();
				foreach (string proxyAddress in File.ReadAllLines(openFileDialog.FileName))
				{
					bool flag = Checking.proxytype == 1;
					if (flag)
					{
						hbonordic1check.ProxyList.Add(HttpProxyClient.Parse(proxyAddress));
					}
					else
					{
						bool flag2 = Checking.proxytype == 2;
						if (flag2)
						{
							hbonordic1check.ProxyList.Add(Socks4ProxyClient.Parse(proxyAddress));
						}
						else
						{
							bool flag3 = Checking.proxytype == 3;
							if (flag3)
							{

								hbonordic1check.ProxyList.Add(Socks5ProxyClient.Parse(proxyAddress));
							}
							else
							{
								Console.ForegroundColor = ConsoleColor.Red;
								Console.WriteLine("ERROR: Proxies Type Invalid, exiting...");
								Thread.Sleep(4000);
								Environment.Exit(0);
							}
						}
					}
				}
			}
			hbonordic1check.ComboLines = hbonordic1check.ComboList.Count<string>();
		}

		internal static void ComboFile(ConcurrentQueue<string> concurrentQueues, object combo)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002878 File Offset: 0x00000A78

		// Token: 0x0400001D RID: 29
		public static string ComboName;
	}
}
