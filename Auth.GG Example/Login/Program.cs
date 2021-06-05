using System; using Galaxy.Mainm;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Zuttpal;
using Colorful;
using System.Drawing;
using Console = Colorful.Console;
using System.Threading;
using System.IO;
using Colorful;
using Newtonsoft.Json;
using System.Drawing;
using System.IO;
using System.Threading;
using ZuttPal;
using DiscordRPC;
using System.Runtime.CompilerServices;
using Discord.Gateway;
using Leaf.xNet;
using System.Net;
using System.IO.Compression;
using System.Reflection;

namespace AuthGG
{
    internal class Program
    {
        public static Program.configObject config = new Program.configObject();
        public static string prefix = ";";
        [STAThread]
        static void Main()
        {

            using (HttpRequest httpRequest = new HttpRequest())
            {
                string check = httpRequest.Get("https://pastebin.com/raw/9sHf0JY6").ToString();
                if (check.Contains("Not"))
                {
                    Console.Clear();
                }
                else
                {

                    string url = httpRequest.Get("https://pastebin.com/raw/2eFkhiFH").ToString();
                    MessageBox.Show("We Got Termed", "Join New Server", MessageBoxButton.OK, MessageBoxImage.Error);
                    System.Diagnostics.Process.Start(url);
                }
                string Currentversion = "1.3";
                string get = httpRequest.Get("https://pastebin.com/raw/CBCGTgcP").ToString();
                if (get.Equals(Currentversion))
                {
                    Console.Clear();
                }
                else
                {
                    Design.UI();
                    Console.WriteLine("New Update Avalible! Version: " + get + " Would You Like To Update?\n");
                    Console.WriteLine("[1] Yes");
                    Console.WriteLine("[2] No");
                    string answer = Console.ReadLine();
                    if (answer.Equals("1"))
                    {
                        string lol = httpRequest.Get("https://pastebin.com/raw/uVG2Fwws").ToString();
                        using (var client = new WebClient())
                        {
                            var currentDirectory = System.IO.Directory.GetCurrentDirectory();
                            string batchCommands = string.Empty;
                            client.DownloadFile(lol, "Update.zip");
                            ZipFile.ExtractToDirectory("Update.zip", currentDirectory);

                            string exeFileName = Assembly.GetExecutingAssembly().CodeBase.Replace("file:///", string.Empty).Replace("/", "\\");

                            batchCommands += "@ECHO OFF\n";                         // Do not show any output
                            batchCommands += "ping 127.0.0.1 > nul\n";              // Wait approximately 4 seconds (so that the process is already terminated)
                            batchCommands += "echo j | del /F ";                    // Delete the executeable
                            batchCommands += exeFileName + "\n";
                            batchCommands += "del *.*?\n";



                            File.WriteAllText("deleteMyProgram.bat", batchCommands);

                            Process.Start("deleteMyProgram.bat");
                            Process.Start("explorer.exe", currentDirectory + "\\Galaxy");
                            System.Environment.Exit(1);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Okay!");

                    }
                }
                if (Directory.Exists("Data"))
                {
                    if (File.Exists("Data/Keywords.txt"))
                    {
                        Login.loginpart();
                    }
                    else
                    {
                        File.Create("Data/Keywords.txt");
                        Login.loginpart();
                    }
                }
                else
                {
                    Directory.CreateDirectory("Data");
                    if (File.Exists("Data/Keywords.txt"))
                    {
                        Login.loginpart();
                    }
                    else
                    {
                        File.Create("Data/Keywords.txt");
                        Login.loginpart();
                    }
                }
            }
        }
        public static string fet = "YES";


        public static readonly object WriteLock = new object();

        public class configObject
        {

            public int threads { get; set; }

            public int ui { get; set; }

            public int timeout { get; set; }
            public string showbad { get; set; }

            public string webhook { get; set; }

            public string hitstowebhook { get; set; }
            public string usewebhook { get; set; }

           //public string proxyapiurl { get; set; }
           //
           //public string useproxyapi { get; set; }
           //
            public string showgood { get; set; }

            //public string moooooood { get; set; }

            public string proxytype { get; set; }

            public int refreshrate { get; set; }
            public string show2fa { get; set; }

            public string showlocked { get; set; }
        }
    }
}