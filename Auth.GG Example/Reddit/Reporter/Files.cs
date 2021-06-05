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
	internal class reporterfiles
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
						reportercheck.ProxyList.Add(HttpProxyClient.Parse(proxyAddress));
					}
					else
					{
						bool flag2 = Checking.proxytype == 2;
						if (flag2)
						{
							reportercheck.ProxyList.Add(Socks4ProxyClient.Parse(proxyAddress));
						}
						else
						{
							bool flag3 = Checking.proxytype == 3;
							if (flag3)
							{

								reportercheck.ProxyList.Add(Socks5ProxyClient.Parse(proxyAddress));
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
		}


	
	}
}
