using AuthGG;
using System; using Galaxy.Mainm;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Zuttpal;

namespace Galaxy.Mainm
{
    class cui
    {
		public static void start(int hits, int bad, int custom, int twofa, int retries, int error, int combocount, int checkedlines, int cpm)
		{
			Task.Factory.StartNew(delegate ()
			{
				for (; ; )
				{

					int remaining = combocount - checkedlines;
					Colorful.Console.WriteLine();
					Colorful.Console.WriteLine("                         ██████╗  █████╗ ██╗      █████╗ ██╗  ██╗██╗   ██╗     █████╗ ██╗ ██████╗ ", Color.Cyan);
					Colorful.Console.WriteLine("                        ██╔════╝ ██╔══██╗██║     ██╔══██╗╚██╗██╔╝╚██╗ ██╔╝    ██╔══██╗██║██╔═══██╗", Color.Cyan);
					Colorful.Console.WriteLine("                        ██║  ███╗███████║██║     ███████║ ╚███╔╝  ╚████╔╝     ███████║██║██║   ██║", Color.Cyan);
					Colorful.Console.WriteLine("                        ██║   ██║██╔══██║██║     ██╔══██║ ██╔██╗   ╚██╔╝      ██╔══██║██║██║   ██║", Color.Cyan);
					Colorful.Console.WriteLine("                        ╚██████╔╝██║  ██║███████╗██║  ██║██╔╝ ██╗   ██║       ██║  ██║██║╚██████╔╝", Color.Cyan);
					Colorful.Console.WriteLine("                         ╚═════╝ ╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝╚═╝  ╚═╝   ╚═╝       ╚═╝  ╚═╝╚═╝ ╚═════╝ ", Color.Cyan);
					Console.WriteLine();
					Colorful.Console.WriteLine("[~ Checking Stats ~]\n", Color.PapayaWhip);
					Colorful.Console.WriteLineFormatted("[{0}] Hits: {1}", Color.LimeGreen, Color.LimeGreen, new object[]
					{
					"~",
					string.Format("{0}", hits)
					});
					Colorful.Console.WriteLineFormatted("[{0}] 2FA: {1}", Color.Orange, Color.Orange, new object[]
					{
					"~",
					string.Format("{0}", twofa)
					});
					Colorful.Console.WriteLineFormatted("[{0}] Custom: {1}", Color.Purple, Color.Purple, new object[]
					{
					"~",
					string.Format("{0}", custom)
					});
					Colorful.Console.WriteLineFormatted("[{0}] Invalid: {1}", Color.Red, Color.Red, new object[]
					{
					"~",
					string.Format("{0}", bad)
					});
					Colorful.Console.WriteLine("\n[~ Checking Status ~]\n", Color.PapayaWhip);
					Colorful.Console.WriteLineFormatted("[{0}] Checked: {1}", Color.Cyan, Color.Cyan, new object[]
					{
					"~",
					string.Format("{0}", checkedlines)
					});
					Colorful.Console.WriteLineFormatted("[{0}] Remaining: {1}", Color.Cyan, Color.Cyan, new object[]
					{
					"~",
					string.Format("{0}", remaining)
					});
					Colorful.Console.WriteLineFormatted("[{0}] Retries: {1}", Color.Cyan, Color.Cyan, new object[]
					{
					"~",
					string.Format("{0}", retries)
					});
					Colorful.Console.WriteLineFormatted("[{0}] Errors: {1}", Color.Cyan, Color.Cyan, new object[]
					{
					"~",
					string.Format("{0}", error)
					});
					Colorful.Console.WriteLineFormatted("[{0}] CPM: {1}", Color.Cyan, Color.Cyan, new object[]
					{
					"~",
					string.Format("{0}", cpm)
					});
					break;
				}
			});
		}
	}
}
