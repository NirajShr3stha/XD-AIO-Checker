using System; using Galaxy.Mainm;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Zuttpal
{ 
	// Token: 0x0200000B RID: 11
	internal class ResultsSaver
	{
		// Token: 0x06000035 RID: 53 RVA: 0x00002B00 File Offset: 0x00000D00
		public static void Save(string path, string line)
		{
			for (;;)
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
	}
}
