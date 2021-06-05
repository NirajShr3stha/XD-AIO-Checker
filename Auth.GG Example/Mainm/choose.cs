using AuthGG;
using DiscordRPC;
using Galaxy.Mainm;
using Leaf.xNet;
using Newtonsoft.Json;
using System; using Galaxy.Mainm;
using System.Collections.Generic;

using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using Zuttpal;
using ZuttPal;
namespace ZuttPal
{
    class niggers
    {
        private static List<Func<string[], string, bool>> pickedModules = new List<Func<string[], string, bool>>();
        public static List<string> pickedModulesNames = new List<string>();
        public static int Modules = 0;
        internal static void chooose()
        {

            string path = "Data/Config.json";
            Program.config = File.Exists(path) ? JsonConvert.DeserializeObject<Program.configObject>(File.ReadAllText(path)) : Login.renewconfig(true);

            Console.Clear();
            Design.UI();
            Console.WriteLine();

            if (Program.config.usewebhook == "True")
            {
                stats.url = Program.config.webhook;
            }
            using (HttpRequest httpRequest = new HttpRequest())
            {
                
                Colorful.Console.Title = "Galaxy AIO - Choosing Module";
                Checking.currentrun = "In Main Menu";
                Colorful.Console.WriteLine("                                            [V] - Valid Mail Modules", Color.Cyan);
                Colorful.Console.WriteLine("                                            [E] - Email Modules", Color.Cyan);
                Colorful.Console.WriteLine("                                            [P] - Porn Modules", Color.Cyan);
                Colorful.Console.WriteLine("                                            [G] - Gaming Modules", Color.Cyan);
                Colorful.Console.WriteLine("                                            [D] - VPN Modules", Color.Cyan);
                Colorful.Console.WriteLine("                                            [S] - Streaming Modules", Color.Cyan);
                Colorful.Console.WriteLine("                                            [I] - Inbox Searcher Modules", Color.Cyan);
                Colorful.Console.WriteLine("                                            [F] - Dating Modules", Color.Cyan);
                Colorful.Console.WriteLine("                                            [A] - Shopping & Social Media Modules\n", Color.Cyan);
                Colorful.Console.WriteLine("                                            [M] - Other Modules\n\n", Color.Cyan);
                Colorful.Console.WriteLine("                                            [R] - Reddit Tools", Color.Cyan);
                Colorful.Console.WriteLine("                                            [K] - Own Checker", Color.Cyan);
                Colorful.Console.WriteLine("                                            [C] - Cheats", Color.Cyan);
                Colorful.Console.WriteLine("                                            [X] - Main Menu", Color.Cyan);
                Colorful.Console.Write("\n[~] Choice: ", Color.Cyan);
                string str = Colorful.Console.ReadLine();
                if (str.ToUpper() == "V")
                {
                    valid();
                }
                if (str.ToUpper() == "D")
                {
                    vpn();
                }
                if (str.ToUpper() == "K")
                {
                    System.Windows.MessageBox.Show("Soon", "Out Soon");
                    //customerkker1check.Start1();
                    chooose();
                }
                if (str.ToUpper() == "M")
                {
                    other();
                }
                if (str.ToUpper() == "C")
                {
                    cheats();
                }
                if (str.ToUpper() == "F")
                {
                    dating();
                }
                if (str.ToUpper() == "R")
                {
                    if (AuthGG.User.Rank == "1")
                    {
                        System.Windows.MessageBox.Show("Your Not Level 2", "Sorry");
                        chooose();
                    }
                    else if (AuthGG.User.Rank == "2")
                    {
                        reddiiit();
                    }
                    else
                    {
                        System.Windows.MessageBox.Show("Your Not Level 2", "Sorry");
                        chooose();
                    }

                }
                else if (str.ToUpper() == "I")
                {
                    inbox();
                }
                else if (str.ToUpper() == "X")
                {
                    menu();
                }

                else if (str.ToUpper() == "P")
                {
                    porn();
                }
                else if (str.ToUpper() == "A")
                {
                    shopping();
                }
                else if (str.ToUpper() == "E")
                {
                    mail();
                }
                else if (str.ToUpper() == "G")
                {
                    gaming();
                }
                else if (str.ToUpper() == "S")
                {
                    streaming();
                }
                else
                {
                    chooose();
                }
            }
        }

        internal static void free()
        {

            string path = "Data/Config.json";
            Program.config = File.Exists(path) ? JsonConvert.DeserializeObject<Program.configObject>(File.ReadAllText(path)) : Login.renewconfig(true);

            Console.Clear();
            Design.UI();
            Console.WriteLine();
            Colorful.Console.WriteLine("                                            [1] - Minecraft", Color.Cyan);
            Colorful.Console.WriteLine("                                            [2] - Nord VPN", Color.Cyan);
            Colorful.Console.Write("\n[~] Choice: ", Color.Cyan);
            string str = Colorful.Console.ReadLine();
            if (str.ToUpper() == "1")
            {
                
                minecraft1check.Start1();
            }
            else if (str.ToUpper() == "2")
            {
                
                nordvpn1check.Start1();
            }
            else
            {
                free();
            }
        }

        internal static void dating()
        {

            Console.Clear();
            Design.UI();
            Console.WriteLine();
            Console.WriteLine();
            Colorful.Console.Write("Dating Modules\n\n", Color.DarkCyan);
            Colorful.Console.Write("[", Color.DarkCyan);
            Colorful.Console.Write("1", Color.Cyan);
            Colorful.Console.Write("]", Color.DarkCyan);
            Colorful.Console.Write(" Lovoo\n", Color.Cyan);
            Colorful.Console.Write("\n[~] Choice: ", Color.Cyan);
            string str = Colorful.Console.ReadLine();
            if (str.ToUpper() == "1")
            {
                Console.Clear();
                Design.UI();
                Thread.Sleep(300); stats.save();
                Console.WriteLine();
                lovoo1check.Start1();
            }
            else
            {
                dating();
            }
        }
        internal static void other()
        {

            Console.Clear();
            Design.UI();
            Console.WriteLine();
            Console.WriteLine();
            Colorful.Console.Write("Other Modules\n\n", Color.DarkCyan);
            Colorful.Console.Write("[", Color.DarkCyan);
            Colorful.Console.Write("1", Color.Cyan);
            Colorful.Console.Write("]", Color.DarkCyan);
            Colorful.Console.Write(" IPVanish\n", Color.Cyan);
            Colorful.Console.Write("", Color.Cyan);
            Colorful.Console.Write("", Color.Cyan);
            Colorful.Console.WriteLine("                                                                                                   [T] - Module Menu", Color.Cyan);
            Colorful.Console.Write("\n[~] Choice: ", Color.Cyan);
            string str = Colorful.Console.ReadLine();
            if (str.ToUpper() == "1")
            {
                Console.Clear();
                Design.UI();
                Thread.Sleep(300); stats.save();
                Console.WriteLine();
                ipvanish1check.Start1();
            }
            if (str.ToUpper() == "T")
            {
                Console.Clear();
                Design.UI();
                chooose();
            }
            else
            {
                other();
            }
        }

        internal static void valid()
        {
            Console.Clear();
            Design.UI();
            Console.WriteLine();
            Console.WriteLine();
            Colorful.Console.Write("Valid Mail Modules\n\n", Color.DarkCyan);
            Colorful.Console.Write("[", Color.DarkCyan);
            Colorful.Console.Write("1", Color.Cyan);
            Colorful.Console.Write("]", Color.DarkCyan);
            Colorful.Console.Write(" Paypal\n", Color.Cyan);
            Colorful.Console.Write("[", Color.DarkCyan);
            Colorful.Console.Write("2", Color.Cyan);
            Colorful.Console.Write("]", Color.DarkCyan);
            Colorful.Console.Write(" Epic Games\n", Color.Cyan);
            Colorful.Console.Write("[", Color.DarkCyan);
            Colorful.Console.Write("3", Color.Cyan);
            Colorful.Console.Write("]", Color.DarkCyan);
            Colorful.Console.Write(" Xbox\n", Color.Cyan);
            Colorful.Console.Write("[", Color.DarkCyan);
            Colorful.Console.Write("4", Color.Cyan);
            Colorful.Console.Write("]", Color.DarkCyan);
            Colorful.Console.Write(" Spotify\n", Color.Cyan);
            Colorful.Console.Write("[", Color.DarkCyan);
            Colorful.Console.Write("5", Color.Cyan);
            Colorful.Console.Write("]", Color.DarkCyan);
            Colorful.Console.Write(" Twitter\n", Color.Cyan);
            Colorful.Console.Write("[", Color.DarkCyan);
            Colorful.Console.Write("6", Color.Cyan);
            Colorful.Console.Write("]", Color.DarkCyan);
            Colorful.Console.Write(" Snapchat\n", Color.Cyan);
            Colorful.Console.Write("[", Color.DarkCyan);
            Colorful.Console.Write("7", Color.Cyan);
            Colorful.Console.Write("]", Color.DarkCyan);
            Colorful.Console.Write(" Discord\n", Color.Cyan);
            Colorful.Console.Write("", Color.Cyan);
            Colorful.Console.Write("", Color.Cyan);
            Colorful.Console.WriteLine("                                                                                                   [T] - Module Menu", Color.Cyan);
            Colorful.Console.Write("\n[~] Choice: ", Color.Cyan);
            string str = Console.ReadLine();
            if (str.ToUpper() == "T")
            {
                chooose();
            }
            else if (str.ToUpper() == "1")
            {
                
                Console.Clear();
                Design.UI();
                Thread.Sleep(300); stats.save();
                Console.WriteLine();
                paypalvmcheck.Start1();
            }
            else if (str.ToUpper() == "7")
            {

                Console.Clear();
                Design.UI();
                Thread.Sleep(300); stats.save();
                Console.WriteLine();
                discordvm1check.Start1();
            }
            else if (str.ToUpper() == "2")
            {
                
                Console.Clear();
                Design.UI();
                Thread.Sleep(300); stats.save();
                Console.WriteLine();
                epicgamesvmcheck.Start1();
            }
            else if (str.ToUpper() == "5")
            {
                
                Console.Clear();
                Design.UI();
                Thread.Sleep(300); stats.save();
                Console.WriteLine();
                twittervmcheck.Start1();
            }
            else if (str.ToUpper() == "3")
            {
                
                Console.Clear();
                Design.UI();
                Thread.Sleep(300); stats.save();
                Console.WriteLine();
                xboxvmcheck.Start1();
            }
            else if (str.ToUpper() == "4")
            {
                
                Console.Clear();
                Design.UI();
                Thread.Sleep(300); stats.save();
                Console.WriteLine();
                spotifyvmcheck.Start1();
            }
            else if (str.ToUpper() == "6")
            {
                
                Console.Clear();
                Design.UI();
                Thread.Sleep(300); stats.save();
                Console.WriteLine();
                snapchatvmcheck.Start1();
            }
            else
            {
                valid();
            }
        }

        internal static void vpn()
        {
            Console.Clear();
            Design.UI();
            Console.WriteLine();
            Console.WriteLine();
            Colorful.Console.Write("VPN Modules\n\n", Color.DarkCyan);
            Colorful.Console.Write("[", Color.DarkCyan);
            Colorful.Console.Write("1", Color.Cyan);
            Colorful.Console.Write("]", Color.DarkCyan);
            Colorful.Console.Write(" Nord VPN\n", Color.Cyan);
            Colorful.Console.Write("[", Color.DarkCyan);
            Colorful.Console.Write("2", Color.Cyan);
            Colorful.Console.Write("]", Color.DarkCyan);
            Colorful.Console.Write(" Nolag VPN\n", Color.Cyan);

            Colorful.Console.Write("", Color.Cyan);
            Colorful.Console.Write("", Color.Cyan);
            Colorful.Console.WriteLine("                                                                                                   [T] - Module Menu", Color.Cyan);
            Colorful.Console.Write("\n[~] Choice: ", Color.Cyan);
            string str = Console.ReadLine();
            if (str.ToUpper() == "T")
            {
                chooose();
            }
            else if (str.ToUpper() == "1")
            {
                
                Console.Clear();
                Design.UI();
                Thread.Sleep(300); stats.save();
                Console.WriteLine();
                nordvpn1check.Start1();
            }
            else if (str.ToUpper() == "2")
            {

                Console.Clear();
                Design.UI();
                Thread.Sleep(300); stats.save();
                Console.WriteLine();
                nolag1check.Start1();
            }
            else
            {
                vpn();
            }
        }
        public static string sProcName = "csgo.exe";
        internal static void cheats()
        {
            using (HttpRequest httpRequest = new HttpRequest())
            {
                Console.Clear();
                Design.UI();
                Console.WriteLine();
                Console.WriteLine();
                Colorful.Console.Write("Cheats\n\n", Color.DarkCyan);
                Colorful.Console.Write("[", Color.DarkCyan);
                Colorful.Console.Write("1", Color.Cyan);
                Colorful.Console.Write("]", Color.DarkCyan);
                Colorful.Console.Write(" Fortnite [1909]\n", Color.Cyan);
                Colorful.Console.Write("", Color.Cyan);
                Colorful.Console.Write("", Color.Cyan);
                Colorful.Console.WriteLine("                                                                                                   [T] - Module Menu", Color.Cyan);
                Colorful.Console.Write("\n[~] Choice: ", Color.Cyan);
                string str = Console.ReadLine();
                if (str.ToUpper() == "T")
                {
                    chooose();
                }
                else if (str.ToUpper() == "1")
                {

                    Console.Clear();
                    Design.UI();
                    Thread.Sleep(300); stats.save();
                    string path = Directory.GetCurrentDirectory();
                    using (var client = new WebClient())
                    {
                        if (File.Exists("Fortnite.zip"))
                        {
                            File.Delete("Fortnite.zip");
                        }
                        if (Directory.Exists(path + "\\Fortnite"))
                        {
                            System.IO.DirectoryInfo di = new DirectoryInfo(path + "\\Fortnite");

                            foreach (FileInfo file in di.GetFiles())
                            {
                                file.Delete();
                            }
                            Directory.Delete(path + "\\Fortnite");
                        }
                        client.DownloadFile("https://cdn.discordapp.com/attachments/847455666511937596/847459810789294130/Fortnite.zip", "Fortnite.zip");

                        ZipFile.ExtractToDirectory("Fortnite.zip", "Fortnite");
                    }
                    Console.WriteLine("Downloaded Cheat + Drivers!");
                    System.Diagnostics.Process.Start("explorer.exe", path + "\\Fortnite");

                }
                else
                {
                    cheats();
                }
            }
        }
        internal static void porn()
        {
            Console.Clear();
            Design.UI();
            Console.WriteLine();
            Console.WriteLine();
            Colorful.Console.Write("Porn Modules\n\n", Color.DarkCyan);
            Colorful.Console.Write("[", Color.DarkCyan);
            Colorful.Console.Write("1", Color.Cyan);
            Colorful.Console.Write("]", Color.DarkCyan);
            Colorful.Console.Write(" All Japanesepass\n", Color.Cyan);
            Colorful.Console.Write("[", Color.DarkCyan);
            Colorful.Console.Write("2", Color.Cyan);
            Colorful.Console.Write("]", Color.DarkCyan);
            Colorful.Console.Write(" Nubiles Porn\n", Color.Cyan);
            Colorful.Console.Write("[", Color.DarkCyan);
            Colorful.Console.Write("3", Color.Cyan);
            Colorful.Console.Write("]", Color.DarkCyan);
            Colorful.Console.Write(" Pornhub\n", Color.Cyan);
            Colorful.Console.Write("[", Color.DarkCyan);
            Colorful.Console.Write("4", Color.Cyan);
            Colorful.Console.Write("]", Color.DarkCyan);
            Colorful.Console.Write(" Onlyfans Captchaless\n", Color.Cyan);
            Colorful.Console.Write("", Color.Cyan);
            Colorful.Console.Write("", Color.Cyan);
            Colorful.Console.WriteLine("                                                                                                   [T] - Module Menu", Color.Cyan);
            Colorful.Console.Write("\n[~] Choice: ", Color.Cyan);
            string str = Console.ReadLine();
            if (str.ToUpper() == "T")
            {
                chooose();
            }
            else if (str.ToUpper() == "1")
            {
                
                Console.Clear();
                Design.UI();
                Thread.Sleep(300); stats.save();
                Console.WriteLine();
                japanese1check.Start1();
            }
            else if (str.ToUpper() == "4")
            {
                if (AuthGG.User.Rank == "1")
                {
                    System.Windows.MessageBox.Show("Your Not Level 2", "Sorry");
                    porn();
                }
                else if (AuthGG.User.Rank == "2")
                {
                    Console.Clear();
                    Design.UI();
                    Thread.Sleep(300); stats.save();
                    Console.WriteLine();
                    onlyfans1check.Start1();
                }
                else
                {
                    System.Windows.MessageBox.Show("Your Not Level 2", "Sorry");
                    porn();
                }
            }
            else if (str.ToUpper() == "2")
            {
                
                Console.Clear();
                Design.UI();
                Thread.Sleep(300); stats.save();
                Console.WriteLine();
                nubiles1check.Start1();
            }

            else if (str.ToUpper() == "3")
            {
                
                Console.Clear();
                Design.UI();
                Thread.Sleep(300); stats.save();
                Console.WriteLine();
                pornhub1check.Start1();
            }
            else if (str.ToUpper() == "4")
            {
                
                Console.Clear();
                Design.UI();
                Thread.Sleep(300); stats.save();
                Console.WriteLine();
                spotifyvmcheck.Start1();
            }
            else if (str.ToUpper() == "6")
            {
                
                Console.Clear();
                Design.UI();
                Thread.Sleep(300); stats.save();
                Console.WriteLine();
                snapchatvmcheck.Start1();
            }
            else
            {
                porn();
            }
        }
        internal static void reddiiit()
        {
            Console.Clear();
            Design.UI();
            Console.WriteLine();
            Console.WriteLine();
            Colorful.Console.Write("Reddit Tools\n\n", Color.DarkCyan);
            Colorful.Console.Write("[", Color.DarkCyan);
            Colorful.Console.Write("1", Color.Cyan);
            Colorful.Console.Write("]", Color.DarkCyan);
            Colorful.Console.Write(" Award Spammer\n", Color.Cyan);
            Colorful.Console.Write("[", Color.DarkCyan);
            Colorful.Console.Write("2", Color.Cyan);
            Colorful.Console.Write("]", Color.DarkCyan);
            Colorful.Console.Write(" Follower Spammer\n", Color.Cyan);
            Colorful.Console.Write("[", Color.DarkCyan);
            Colorful.Console.Write("3", Color.Cyan);
            Colorful.Console.Write("]", Color.DarkCyan);
            Colorful.Console.Write(" Report Spammer\n", Color.Cyan);
            Colorful.Console.Write("[", Color.DarkCyan);
            Colorful.Console.Write("4", Color.Cyan);
            Colorful.Console.Write("]", Color.DarkCyan);
            Colorful.Console.Write(" Voter Spammer\n", Color.Cyan);
            Colorful.Console.Write("[", Color.DarkCyan);
            Colorful.Console.Write("5", Color.Cyan);
            Colorful.Console.Write("]", Color.DarkCyan);
            Colorful.Console.Write(" Account Generator\n", Color.Cyan);
            Colorful.Console.Write("", Color.Cyan);
            Colorful.Console.Write("", Color.Cyan);
            Colorful.Console.WriteLine("                                                                                                   [T] - Module Menu", Color.Cyan);
            Colorful.Console.Write("\n[~] Choice: ", Color.Cyan);
            string str = Console.ReadLine();
            if (str.ToUpper() == "T")
            {
                chooose();
            }
            if (str.ToUpper() == "1")
            {
                
                awardercheck.Start1();
            }
            if (str.ToUpper() == "2")
            {
                
                followercheck.Start1();
            }
            if (str.ToUpper() == "3")
            {
                
                reportercheck.Start1();
            }
            if (str.ToUpper() == "4")
            {
                
                Votercheck.Start1();
            }
            if (str.ToUpper() == "5")
            {
                
                Generatorcheck.Start1();
            }
            else
            {
                reddiiit();
            }
        }


        internal static void inbox()
        {
            Console.Clear();
            Design.UI();
            Console.WriteLine();
            Console.WriteLine();
            Colorful.Console.Write("Inbox Searcher Modules\n\n", Color.DarkCyan);
            Colorful.Console.Write("[", Color.DarkCyan);
            Colorful.Console.Write("1", Color.Cyan);
            Colorful.Console.Write("]", Color.DarkCyan);
            Colorful.Console.Write(" Yahoo API 1\n", Color.Cyan);
            Colorful.Console.Write("[", Color.DarkCyan);
            Colorful.Console.Write("2", Color.Cyan);
            Colorful.Console.Write("]", Color.DarkCyan);
            Colorful.Console.Write(" Yahoo API 2\n", Color.Cyan);
            Colorful.Console.Write("[", Color.DarkCyan);
            Colorful.Console.Write("3", Color.Cyan);
            Colorful.Console.Write("]", Color.DarkCyan);
            Colorful.Console.Write(" Yahoo API 3\n", Color.Cyan);
            Colorful.Console.Write("[", Color.DarkCyan);
            Colorful.Console.Write("4", Color.Cyan);
            Colorful.Console.Write("]", Color.DarkCyan);
            Colorful.Console.Write(" Abv.BG  \n", Color.Cyan);
            Colorful.Console.Write("[", Color.DarkCyan);
            Colorful.Console.Write("5", Color.Cyan);
            Colorful.Console.Write("]", Color.DarkCyan);
            Colorful.Console.Write(" Hotmail \n", Color.Cyan);
            Colorful.Console.Write("", Color.Cyan);
            Colorful.Console.Write("", Color.Cyan);
            Colorful.Console.WriteLine("                                                                                                   [T] - Module Menu", Color.Cyan);
            Colorful.Console.Write("\n[~] Choice: ", Color.Cyan);
            string str = Console.ReadLine();
            if (str.ToUpper() == "T")
            {
                chooose();
            }
            else if (str.ToUpper() == "1")
            {
                
                Console.Clear();
                Design.UI();
                Thread.Sleep(300); stats.save();
                Console.WriteLine();
                YahooInbox1check.Start1();
            }
            else if (str.ToUpper() == "2")
            {
                
                Console.Clear();
                Design.UI();
                Thread.Sleep(300); stats.save();
                Console.WriteLine();
                YahooInbox2check.Start1();
            }
            else if (str.ToUpper() == "5")
            {
                
                Console.Clear();
                Design.UI();
                Thread.Sleep(300); stats.save();
                Console.WriteLine();
                Hotmailinbox1check.Start1();
            }
            else if (str.ToUpper() == "3")
            {
                
                Console.Clear();
                Design.UI();
                Thread.Sleep(300); stats.save();
                Console.WriteLine();
                YahooInbox3check.Start1();
            }
            else if (str.ToUpper() == "4")
            {
                Console.Clear();
                Design.UI();
                Thread.Sleep(300); stats.save();
                Console.WriteLine();
                abvinbox1check.Start1();
            }
            else
            {
                inbox();
            }
        }
        internal static void shopping()
        {
            Console.Clear();
            Design.UI();
            Console.WriteLine();
            Console.WriteLine();
            Colorful.Console.Write("Shopping / Social Media Modules\n\n", Color.DarkCyan);
            Colorful.Console.Write("[", Color.DarkCyan);
            Colorful.Console.Write("1", Color.Cyan);
            Colorful.Console.Write("]", Color.DarkCyan);
            Colorful.Console.Write(" Paypal Checker \n", Color.Cyan);
            Colorful.Console.Write("[", Color.DarkCyan);
            Colorful.Console.Write("2", Color.Cyan);
            Colorful.Console.Write("]", Color.DarkCyan);
            Colorful.Console.Write(" Facebook \n", Color.Cyan);
            Colorful.Console.Write("[", Color.DarkCyan);
            Colorful.Console.Write("3", Color.Cyan);
            Colorful.Console.Write("]", Color.DarkCyan);
            Colorful.Console.Write(" Robinhood \n", Color.Cyan);
            Colorful.Console.Write("[", Color.DarkCyan);
            Colorful.Console.Write("4", Color.Cyan);
            Colorful.Console.Write("]", Color.DarkCyan);
            Colorful.Console.Write(" BWW \n", Color.Cyan);
            Colorful.Console.Write("[", Color.DarkCyan);
            Colorful.Console.Write("5", Color.Cyan);
            Colorful.Console.Write("]", Color.DarkCyan);
            Colorful.Console.Write(" Twitter \n", Color.Cyan);
            Colorful.Console.Write("", Color.Cyan);
            Colorful.Console.Write("", Color.Cyan);
            Colorful.Console.WriteLine("                                                                                                   [T] - Module Menu", Color.Cyan);
            Colorful.Console.Write("\n[~] Choice: ", Color.Cyan);
            string str = Console.ReadLine();
            if (str.ToUpper() == "T")
            {
                chooose();
            }
            else if (str.ToUpper() == "1")
            {
                Console.Clear();
                Design.UI();
                Thread.Sleep(300); stats.save();
                Console.WriteLine();
                paypalfa1check.Start1();
            }
            else if (str.ToUpper() == "4")
            {
                Console.Clear();
                Design.UI();
                Thread.Sleep(300); stats.save();
                Console.WriteLine();
                bww1check.Start1();
            }
            else if (str.ToUpper() == "5")
            {
                Console.Clear();
                Design.UI();
                Thread.Sleep(300); stats.save();
                Console.WriteLine();
                twitter1check.Start1();
            }
            else if (str.ToUpper() == "3")
            {
                Console.Clear();
                Design.UI();
                Thread.Sleep(300); stats.save();
                Console.WriteLine();
                robinhoodcheck.Start1();
            }
            else if (str.ToUpper() == "2")
            {
                Console.Clear();
                Design.UI();
                Thread.Sleep(300); stats.save();
                Console.WriteLine();
                facebook1check.Start1();
            }

            else
            {
                shopping();
            }
        }
        internal static void gaming()
        {
            Console.Clear();
            Design.UI();
            Console.WriteLine();
            Console.WriteLine();
            Colorful.Console.Write("Gaming Modules\n\n", Color.DarkCyan);
            Colorful.Console.Write("[", Color.DarkCyan);
            Colorful.Console.Write("1", Color.Cyan);
            Colorful.Console.Write("]", Color.DarkCyan);
            Colorful.Console.Write(" Minecraft\n", Color.Cyan);
            Colorful.Console.Write("[", Color.DarkCyan);
            Colorful.Console.Write("2", Color.Cyan);
            Colorful.Console.Write("]", Color.DarkCyan);
            Colorful.Console.Write(" Xbox Fortnite\n", Color.Cyan);
            Colorful.Console.Write("[", Color.DarkCyan);
            Colorful.Console.Write("3", Color.Cyan);
            Colorful.Console.Write("]", Color.DarkCyan);
            Colorful.Console.Write(" Fivem [forum.cfx.re]\n", Color.Cyan);
            Colorful.Console.Write("[", Color.DarkCyan);
            Colorful.Console.Write("4", Color.Cyan);
            Colorful.Console.Write("]", Color.DarkCyan);
            Colorful.Console.Write(" Playstation \n", Color.Cyan);
            Colorful.Console.Write("[", Color.DarkCyan);
            Colorful.Console.Write("5", Color.Cyan);
            Colorful.Console.Write("]", Color.DarkCyan);
            Colorful.Console.Write(" Valorant \n", Color.Cyan);
            Colorful.Console.Write("[", Color.DarkCyan);
            Colorful.Console.Write("6", Color.Cyan);
            Colorful.Console.Write("]", Color.DarkCyan);
            Colorful.Console.Write(" Uplay \n", Color.Cyan);
            Colorful.Console.Write("[", Color.DarkCyan);
            Colorful.Console.Write("7", Color.Cyan);
            Colorful.Console.Write("]", Color.DarkCyan);
            Colorful.Console.Write(" League Of Legends \n", Color.Cyan);
            Colorful.Console.Write("[", Color.DarkCyan);
            Colorful.Console.Write("8", Color.Cyan);
            Colorful.Console.Write("]", Color.DarkCyan);
            Colorful.Console.Write(" Razer Gold\n", Color.Cyan);
            Colorful.Console.Write("", Color.Cyan);
            Colorful.Console.Write("", Color.Cyan);
            Colorful.Console.WriteLine("                                                                                                   [T] - Module Menu", Color.Cyan);
            Colorful.Console.Write("\n[~] Choice: ", Color.Cyan);
            string str = Console.ReadLine();
            if (str.ToUpper() == "T")
            {
                chooose();
            }
            else if (str.ToUpper() == "1")
            {
                Console.Clear();
                Design.UI();
                Thread.Sleep(300); stats.save();
                Console.WriteLine();
                minecraft1check.Start1();
            }
            else if (str.ToUpper() == "8")
            {
                Console.Clear();
                Design.UI();
                Thread.Sleep(300); stats.save();
                Console.WriteLine();
                razer1check.Start1();
            }
            if (str.ToUpper() == "Ö")
            {
                Console.Clear();
                Design.UI();
                Thread.Sleep(300); stats.save();
                Console.WriteLine();
                fortnite1check.Start1();
            }
            else if (str.ToUpper() == "6")
            {
                Console.Clear();
                Design.UI();
                Thread.Sleep(300); stats.save();
                Console.WriteLine();
                door1check.Start1();
            }
            else if (str.ToUpper() == "7")
            {
                Console.Clear();
                Design.UI();
                Thread.Sleep(300); stats.save();
                Console.WriteLine();
                leuge1check.Start1();
            }
            else if (str.ToUpper() == "2")
            {
                Console.Clear();
                Design.UI();
                Thread.Sleep(300); stats.save();
                Console.WriteLine();
                
                xboxfn1check.Start1();
            }
            else if (str.ToUpper() == "5")
            {
                Console.Clear();
                Design.UI();
                Thread.Sleep(300); stats.save();
                Console.WriteLine();
                valorant1check.Start1();
            }
            else if (str.ToUpper() == "3")
            {
                Console.Clear();
                Design.UI();
                Thread.Sleep(300); stats.save();
                Console.WriteLine();
                
                fivem1check.Start1();
            }
            else if (str.ToUpper() == "4")
            {
                if (AuthGG.User.Rank == "1")
                {
                    System.Windows.MessageBox.Show("Your Not Level 2", "Sorry");
                    gaming();
                }
                else if (AuthGG.User.Rank == "2")
                {
                    Console.Clear();
                    Design.UI();
                    Thread.Sleep(300); stats.save();
                    Console.WriteLine();

                    psn1check.Start1();
                }
                else
                {
                    System.Windows.MessageBox.Show("Your Not Level 2", "Sorry");
                    gaming();
                }

            }
            else
            {
                gaming();
            }
        }

        internal static void streaming()
        {
            Console.Clear();
            Design.UI();
            Console.WriteLine();
            Console.WriteLine();
            Colorful.Console.Write("Streaming Modules\n\n", Color.DarkCyan);
            Colorful.Console.Write("[", Color.DarkCyan);
            Colorful.Console.Write("1", Color.Cyan);
            Colorful.Console.Write("]", Color.DarkCyan);
            Colorful.Console.Write(" Disney+\n", Color.Cyan);
            Colorful.Console.Write("[", Color.DarkCyan);
            Colorful.Console.Write("2", Color.Cyan);
            Colorful.Console.Write("]", Color.DarkCyan);
            Colorful.Console.Write(" Viaplay\n", Color.Cyan);
            Colorful.Console.Write("[", Color.DarkCyan);
            Colorful.Console.Write("3", Color.Cyan);
            Colorful.Console.Write("]", Color.DarkCyan);
            Colorful.Console.Write(" Hbo Nordic\n", Color.Cyan);
            Colorful.Console.Write("[", Color.DarkCyan);
            Colorful.Console.Write("4", Color.Cyan);
            Colorful.Console.Write("]", Color.DarkCyan);
            Colorful.Console.Write(" DirectTV\n", Color.Cyan);
            Colorful.Console.Write("[", Color.DarkCyan);
            Colorful.Console.Write("5", Color.Cyan);
            Colorful.Console.Write("]", Color.DarkCyan);
            Colorful.Console.Write(" Crunchyroll\n", Color.Cyan);
            Colorful.Console.Write("", Color.Cyan);
            Colorful.Console.Write("", Color.Cyan);
            Colorful.Console.WriteLine("                                                                                                   [T] - Module Menu", Color.Cyan);
            Colorful.Console.Write("\n[~] Choice: ", Color.Cyan);
            string str = Console.ReadLine();
            if (str.ToUpper() == "T")
            {
                chooose();
            }
            else if (str.ToUpper() == "1")
            {
                Console.Clear();
                Design.UI();
                Thread.Sleep(300); stats.save();
                Console.WriteLine();
                
                disney1check.Start1();
            }

            else if (str.ToUpper() == "5")
            {
                Console.Clear();
                Design.UI();
                Thread.Sleep(300); stats.save();
                Console.WriteLine();

                crucnh1check.Start1();
            }
            else if (str.ToUpper() == "2")
            {
                Console.Clear();
                Design.UI();
                Thread.Sleep(300); stats.save();
                Console.WriteLine();
                
                viaplay1check.Start1();
            }
            else if (str.ToUpper() == "4")
            {
                Console.Clear();
                Design.UI();
                Thread.Sleep(300); stats.save();
                Console.WriteLine();

                directtv1check.Start1();
            }
            else if (str.ToUpper() == "3")
            {
                Console.Clear();
                Design.UI();
                Thread.Sleep(300); stats.save();
                Console.WriteLine();

                hbonordic1check.Start1();
            }
            else
            {
                streaming();
            }
        }
        public static int capture;

        internal static void all()
        {
            capture = 0;
            Console.Clear();
            Design.UI();
            Console.WriteLine();
            Console.WriteLine();
            Colorful.Console.Write("All Modules Page 1/5\n\n", Color.DarkCyan);
            Colorful.Console.Write("[", Color.DarkCyan);
            Colorful.Console.Write("1", Color.Cyan);
            Colorful.Console.Write("]", Color.DarkCyan);
            Colorful.Console.Write(" Yahoo API 1\n", Color.Yellow);
            Colorful.Console.Write("[", Color.DarkCyan);
            Colorful.Console.Write("2", Color.Cyan);
            Colorful.Console.Write("]", Color.DarkCyan);
            Colorful.Console.Write(" Yahoo API 2\n", Color.Yellow);
            Colorful.Console.Write("[", Color.DarkCyan);
            Colorful.Console.Write("3", Color.Cyan);
            Colorful.Console.Write("]", Color.DarkCyan);
            Colorful.Console.Write(" Yahoo API 3\n", Color.Yellow);
            Colorful.Console.Write("[", Color.DarkCyan);
            Colorful.Console.Write("4", Color.Cyan);
            Colorful.Console.Write("]", Color.DarkCyan);
            Colorful.Console.Write(" Hotmail API 1\n", Color.Yellow);
            Colorful.Console.Write("[", Color.DarkCyan);
            Colorful.Console.Write("5", Color.Cyan);
            Colorful.Console.Write("]", Color.DarkCyan);
            Colorful.Console.Write(" Hotmail API 2\n", Color.Yellow);
            Colorful.Console.Write("[", Color.DarkCyan);
            Colorful.Console.Write("6", Color.Cyan);
            Colorful.Console.Write("]", Color.DarkCyan);
            Colorful.Console.Write(" GMX API 1\n", Color.Yellow);
            Colorful.Console.Write("[", Color.DarkCyan);
            Colorful.Console.Write("7", Color.Cyan);
            Colorful.Console.Write("]", Color.DarkCyan);
            Colorful.Console.Write(" GMX API 2\n", Color.Yellow);
            Colorful.Console.Write("[", Color.DarkCyan);
            Colorful.Console.Write("8", Color.Cyan);
            Colorful.Console.Write("]", Color.DarkCyan);
            Colorful.Console.Write(" GMX API 3 [Germany]\n", Color.Yellow);
            Colorful.Console.Write("[", Color.DarkCyan);
            Colorful.Console.Write("9", Color.Cyan);
            Colorful.Console.Write("]", Color.DarkCyan);
            Colorful.Console.Write(" Abv.bg API 1\n", Color.Yellow);
            Colorful.Console.Write("[", Color.DarkCyan);
            Colorful.Console.Write("10", Color.Cyan);
            Colorful.Console.Write("]", Color.DarkCyan);
            Colorful.Console.Write(" Abv.bg API 2\n", Color.Yellow);
            Colorful.Console.Write("", Color.Cyan);
            Colorful.Console.Write("", Color.Cyan);
            Colorful.Console.WriteLine("                                                                                                   [N] - Next Page", Color.Cyan);
            Colorful.Console.WriteLine("                                                                                                   [M] - Main Menu", Color.Cyan);
            Colorful.Console.WriteLine("                                                                                                   [T] - Module Menu", Color.Cyan);
            Colorful.Console.Write("\n[~] Choice: ", Color.Cyan);
            string str = Console.ReadLine();
            if (str.ToUpper() == "T")
            {
                chooose();
            }
            else if (str.ToUpper() == "1")
            {
                Console.Clear();
                Design.UI();
                Console.WriteLine("Do You Want To Capture Subscriptions?\n\n[A] - Yes \n[B] - No", Color.MediumSlateBlue);
                var option = System.Console.ReadKey();
                Console.Clear();
                if (option.Key == (ConsoleKey.A))
                {
                    capture = 1;
                    Thread.Sleep(300); stats.save();
                    Console.WriteLine();
                    Yahoo1check.Start1();
                }
                else if (option.Key == (ConsoleKey.B))
                {
                    capture = 0;
                    Thread.Sleep(300); stats.save();
                    Console.WriteLine();
                    Yahoo1check.Start1();
                }
                else
                {
                    all();
                }
            }
            else if (str.ToUpper() == "2")
            {
                Console.Clear();
                Design.UI();
                Console.WriteLine("Do You Want To Capture Subscriptions?\n\n[A] - Yes \n[B] - No", Color.MediumSlateBlue);
                var option = System.Console.ReadKey();
                Console.Clear();
                if (option.Key == (ConsoleKey.A))
                {
                    capture = 1;
                    Thread.Sleep(300); stats.save();
                    Console.WriteLine();
                    Yahoo2check.Start1();
                }

                else if (option.Key == (ConsoleKey.B))
                {
                    capture = 0;
                    Thread.Sleep(300); stats.save();
                    Console.WriteLine();
                    Yahoo2check.Start1();
                }
                else
                {
                    all();
                }
            }
            else if (str.ToUpper() == "N")
            {
                all2();
            }
            else if (str.ToUpper() == "3")
            {
                Console.Clear();
                Design.UI();
                Console.WriteLine("Do You Want To Capture Subscriptions?\n\n[A] - Yes \n[B] - No", Color.MediumSlateBlue);
                var option = System.Console.ReadKey();
                Console.Clear();
                if (option.Key == (ConsoleKey.A))
                {
                    capture = 1;
                    Thread.Sleep(300); stats.save();
                    Console.WriteLine();
                    Yahoo3check.Start1();
                }
                else if (option.Key == (ConsoleKey.B))
                {
                    capture = 0;
                    Thread.Sleep(300); stats.save();
                    Console.WriteLine();
                    Yahoo3check.Start1();
                }
                else
                {
                    all();
                }
            }
            else if (str.ToUpper() == "4")
            {
                Console.Clear();
                Design.UI();
                Console.WriteLine();
                Hotmail1check.Start1();
            }
            else if (str.ToUpper() == "5")
            {
                Console.Clear();
                Design.UI();
                Console.WriteLine();
                Hotmail2check.Start1();
            }
            else if (str.ToUpper() == "6")
            {
                Console.Clear();
                Design.UI();
                Console.WriteLine();
                gmx1check.Start1();
            }

            else if (str.ToUpper() == "7")
            {
                Console.Clear();
                Design.UI();
                Console.WriteLine();
                gmx2check.Start1();
            }
            else if (str.ToUpper() == "8")
            {
                Console.Clear();
                Design.UI();
                Console.WriteLine();
                gmx3check.Start1();
            }
            else if (str.ToUpper() == "9")
            {
                Console.Clear();
                Design.UI();
                Console.WriteLine();
                abv1check.Start1();
            }
            else if (str.ToUpper() == "10")
            {
                Console.Clear();
                Design.UI();
                Console.WriteLine();
                abv2check.Start1();
            }
            else
            {
                all();
            }
        }



        internal static void all2()
        {
            capture = 0;
            Console.Clear();
            Design.UI();
            Console.WriteLine();
            Console.WriteLine();
            Colorful.Console.Write("All Modules Page 2/5\n\n", Color.DarkCyan);
            Colorful.Console.Write("[", Color.DarkCyan);
            Colorful.Console.Write("1", Color.Cyan);
            Colorful.Console.Write("]", Color.DarkCyan);
            Colorful.Console.Write(" Paypal [VM]\n", Color.Yellow);
            Colorful.Console.Write("[", Color.DarkCyan);
            Colorful.Console.Write("2", Color.Cyan);
            Colorful.Console.Write("]", Color.DarkCyan);
            Colorful.Console.Write(" Epic Games [VM]\n", Color.Yellow);
            Colorful.Console.Write("[", Color.DarkCyan);
            Colorful.Console.Write("3", Color.Cyan);
            Colorful.Console.Write("]", Color.DarkCyan);
            Colorful.Console.Write(" Xbox [VM]\n", Color.Yellow);
            Colorful.Console.Write("[", Color.DarkCyan);
            Colorful.Console.Write("4", Color.Cyan);
            Colorful.Console.Write("]", Color.DarkCyan);
            Colorful.Console.Write(" Twitter [VM]\n", Color.Yellow);
            Colorful.Console.Write("[", Color.DarkCyan);
            Colorful.Console.Write("5", Color.Cyan);
            Colorful.Console.Write("]", Color.DarkCyan);
            Colorful.Console.Write(" Spotify [VM]\n", Color.Yellow);
            Colorful.Console.Write("[", Color.DarkCyan);
            Colorful.Console.Write("6", Color.Cyan);
            Colorful.Console.Write("]", Color.DarkCyan);
            Colorful.Console.Write(" Snapchat [VM]\n", Color.Yellow);
            Colorful.Console.Write("[", Color.DarkCyan);
            Colorful.Console.Write("7", Color.Cyan);
            Colorful.Console.Write("]", Color.DarkCyan);
            Colorful.Console.Write(" Minecraft\n", Color.Yellow);
            Colorful.Console.Write("[", Color.DarkCyan);
            Colorful.Console.Write("8", Color.Cyan);
            Colorful.Console.Write("]", Color.DarkCyan);
            Colorful.Console.Write(" Xbox Fortnite\n", Color.Yellow);
            Colorful.Console.Write("[", Color.DarkCyan);
            Colorful.Console.Write("9", Color.Cyan);
            Colorful.Console.Write("]", Color.DarkCyan);
            Colorful.Console.Write(" Fivem [forum.cfx.re]\n", Color.Yellow);
            Colorful.Console.Write("[", Color.DarkCyan);
            Colorful.Console.Write("10", Color.Cyan);
            Colorful.Console.Write("]", Color.DarkCyan);
            Colorful.Console.Write(" Playstation\n", Color.Yellow);
            Colorful.Console.Write("", Color.Cyan);
            Colorful.Console.Write("", Color.Cyan);
            Colorful.Console.WriteLine("                                                                                                   [B] - Previous Page", Color.Cyan);
            Colorful.Console.WriteLine("                                                                                                   [N] - Next Page", Color.Cyan);
            Colorful.Console.WriteLine("                                                                                                   [M] - Main Menu", Color.Cyan);
            Colorful.Console.WriteLine("                                                                                                   [T] - Module Menu", Color.Cyan);
            Colorful.Console.Write("\n[~] Choice: ", Color.Cyan);
            string str = Console.ReadLine();
            if (str.ToUpper() == "T")
            {
                chooose();
            }
            if (str.ToUpper() == "N")
            {
                all3();
            }
            else if (str.ToUpper() == "B")
            {
                all();
            }
            else if (str.ToUpper() == "4")
            {
                Console.Clear();
                Design.UI();
                Thread.Sleep(300); stats.save();
                Console.WriteLine();
                twittervmcheck.Start1();
            }
   
            else if (str.ToUpper() == "1")
            {
                Console.Clear();
                Design.UI();
                Thread.Sleep(300); stats.save();
                Console.WriteLine();
                paypalvmcheck.Start1();
            }

            else if (str.ToUpper() == "2")
            {
                Console.Clear();
                Design.UI();
                Thread.Sleep(300); stats.save();
                Console.WriteLine();
                epicgamesvmcheck.Start1();
            }

            else if (str.ToUpper() == "3")
            {
                Console.Clear();
                Design.UI();
                Thread.Sleep(300); stats.save();
                Console.WriteLine();
                xboxvmcheck.Start1();
            }
            else if (str.ToUpper() == "5")
            {
                Console.Clear();
                Design.UI();
                Thread.Sleep(300); stats.save();
                Console.WriteLine();
                spotifyvmcheck.Start1();
            }
            else if (str.ToUpper() == "7")
            {
                Console.Clear();
                Design.UI();
                Thread.Sleep(300); stats.save();
                Console.WriteLine();
                minecraft1check.Start1();
            }
            else if (str.ToUpper() == "8")
            {
                Console.Clear();
                Design.UI();
                Thread.Sleep(300); stats.save();
                Console.WriteLine();
                xboxfn1check.Start1();
            }
            else if (str.ToUpper() == "6")
            {
                Console.Clear();
                Design.UI();
                Thread.Sleep(300); stats.save();
                Console.WriteLine();
                snapchatvmcheck.Start1();
            }

            else if (str.ToUpper() == "9")
            {
                Console.Clear();
                Design.UI();
                Thread.Sleep(300); stats.save();
                Console.WriteLine();
                fivem1check.Start1();
            }
            else if (str.ToUpper() == "10")
            {
                Console.Clear();
                Design.UI();
                Thread.Sleep(300); stats.save();
                Console.WriteLine();
                psn1check.Start1();
            }


            else
            {
                all2();
            }
        }
        internal static void all3()
        {
            capture = 0;
            Console.Clear();
            Design.UI();
            Console.WriteLine();
            Console.WriteLine();
            Colorful.Console.Write("All Modules Page 3/4\n\n", Color.DarkCyan);
            Colorful.Console.Write("[", Color.DarkCyan);
            Colorful.Console.Write("1", Color.Cyan);
            Colorful.Console.Write("]", Color.DarkCyan);
            Colorful.Console.Write(" Disney+ \n", Color.Yellow);
            Colorful.Console.Write("[", Color.DarkCyan);
            Colorful.Console.Write("2", Color.Cyan);
            Colorful.Console.Write("]", Color.DarkCyan);
            Colorful.Console.Write(" Paypal Checker \n", Color.Yellow);
            Colorful.Console.Write("[", Color.DarkCyan);
            Colorful.Console.Write("3", Color.Cyan);
            Colorful.Console.Write("]", Color.DarkCyan);
            Colorful.Console.Write(" Yahoo API 1 [Inbox Searcher]\n", Color.Cyan);
            Colorful.Console.Write("[", Color.DarkCyan);
            Colorful.Console.Write("4", Color.Cyan);
            Colorful.Console.Write("]", Color.DarkCyan);
            Colorful.Console.Write(" Yahoo API 2 [Inbox Searcher]\n", Color.Cyan);
            Colorful.Console.Write("[", Color.DarkCyan);
            Colorful.Console.Write("5", Color.Cyan);
            Colorful.Console.Write("]", Color.DarkCyan);
            Colorful.Console.Write(" Yahoo API 3 [Inbox Searcher]\n", Color.Cyan);
            Colorful.Console.Write("[", Color.DarkCyan);
            Colorful.Console.Write("6", Color.Cyan);
            Colorful.Console.Write("]", Color.DarkCyan);
            Colorful.Console.Write(" Abv.BG [Inbox Searcher]\n", Color.Cyan);
            Colorful.Console.Write("[", Color.DarkCyan);
            Colorful.Console.Write("7", Color.Cyan);
            Colorful.Console.Write("]", Color.DarkCyan);
            Colorful.Console.Write(" Hotmail [Inbox Searcher]\n", Color.Cyan);
            Colorful.Console.Write("[", Color.DarkCyan);
            Colorful.Console.Write("8", Color.Cyan);
            Colorful.Console.Write("]", Color.DarkCyan);
            Colorful.Console.Write(" Paypal Checker \n", Color.Cyan);
            Colorful.Console.Write("[", Color.DarkCyan);
            Colorful.Console.Write("9", Color.Cyan);
            Colorful.Console.Write("]", Color.DarkCyan);
            Colorful.Console.Write(" All Japanesepass\n", Color.Cyan);
            Colorful.Console.Write("[", Color.DarkCyan);
            Colorful.Console.Write("10", Color.Cyan);
            Colorful.Console.Write("]", Color.DarkCyan);
            Colorful.Console.Write(" Nubiles Porn\n", Color.Cyan);
            Colorful.Console.Write("", Color.Cyan);
            Colorful.Console.Write("", Color.Cyan);
            Colorful.Console.WriteLine("                                                                                                   [B] - Previous Page", Color.Cyan);
            Colorful.Console.WriteLine("                                                                                                   [N] - Next Page", Color.Cyan);
            Colorful.Console.WriteLine("                                                                                                   [M] - Main Menu", Color.Cyan);
            Colorful.Console.WriteLine("                                                                                                   [T] - Module Menu", Color.Cyan);
            Colorful.Console.Write("\n[~] Choice: ", Color.Cyan);
            string str = Console.ReadLine();
            if (str.ToUpper() == "T")
            {
                chooose();
            }
            if (str.ToUpper() == "N")
            {
                all4();
            }
            else if (str.ToUpper() == "9")
            {
                Console.Clear();
                Design.UI();
                Thread.Sleep(300); stats.save();
                Console.WriteLine();
                japanese1check.Start1();
            }
            else if (str.ToUpper() == "10")
            {
                Console.Clear();
                Design.UI();
                Thread.Sleep(300); stats.save();
                Console.WriteLine();
                nubiles1check.Start1();
            }
            else if (str.ToUpper() == "8")
            {
                Console.Clear();
                Design.UI();
                Thread.Sleep(300); stats.save();
                Console.WriteLine();
                paypalfa1check.Start1();
            }
            else if (str.ToUpper() == "2")
            {
                Console.Clear();
                Design.UI();
                Thread.Sleep(300); stats.save();
                Console.WriteLine();
                YahooInbox3check.Start1();
            }
            else if (str.ToUpper() == "6")
            {
                Console.Clear();
                Design.UI();
                Thread.Sleep(300); stats.save();
                Console.WriteLine();
                abvinbox1check.Start1();
            }
            else if (str.ToUpper() == "7")
            {
                Console.Clear();
                Design.UI();
                Thread.Sleep(300); stats.save();
                Console.WriteLine();
                Hotmailinbox1check.Start1();
            }
            else if (str.ToUpper() == "3")
            {
                Console.Clear();
                Design.UI();
                Thread.Sleep(300); stats.save();
                Console.WriteLine();
                YahooInbox1check.Start1();
            }
            else if (str.ToUpper() == "4")
            {
                Console.Clear();
                Design.UI();
                Thread.Sleep(300); stats.save();
                Console.WriteLine();
                YahooInbox2check.Start1();
            }
            else if (str.ToUpper() == "B")
            {
                all2();
            }


            else if (str.ToUpper() == "1")
            {
                Console.Clear();
                Design.UI();
                Thread.Sleep(300); stats.save();
                Console.WriteLine();
                disney1check.Start1();
            }
            else if (str.ToUpper() == "2")
            {
                Console.Clear();
                Design.UI();
                Thread.Sleep(300); stats.save();
                Console.WriteLine();
                paypalfa1check.Start1();
            }
            else
            {
                all3();
            }
        }

        internal static void all4()
        {
            capture = 0;
            Console.Clear();
            Design.UI();
            Console.WriteLine();
            Console.WriteLine();
            Colorful.Console.Write("All Modules Page 4/4\n\n", Color.DarkCyan);
            Colorful.Console.Write("[", Color.DarkCyan);
            Colorful.Console.Write("1", Color.Cyan);
            Colorful.Console.Write("]", Color.DarkCyan);
            Colorful.Console.Write(" Pornhub \n", Color.Yellow);
            Colorful.Console.WriteLine("                                                                                                   [B] - Previous Page", Color.Cyan);
            Colorful.Console.WriteLine("                                                                                                   [N] - Next Page", Color.Cyan);
            Colorful.Console.WriteLine("                                                                                                   [M] - Main Menu", Color.Cyan);
            Colorful.Console.WriteLine("                                                                                                   [T] - Module Menu", Color.Cyan);
            Colorful.Console.Write("\n[~] Choice: ", Color.Cyan);
            string str = Console.ReadLine();
            if (str.ToUpper() == "T")
            {
                chooose();
            }
            else if (str.ToUpper() == "B")
            {
                all3();
            }
            else if (str.ToUpper() == "1")
            {
                Console.Clear();
                Design.UI();
                Thread.Sleep(300); stats.save();
                Console.WriteLine();
                pornhub1check.Start1();
            }
            else if (str.ToUpper() == "2")
            {
                Console.Clear();
                Design.UI();
                Thread.Sleep(300); stats.save();
                Console.WriteLine();
                paypalfa1check.Start1();
            }
            else
            {
                all4();
            }
        }

        internal static void mail()
        {
            capture = 0;
            Console.Clear();
            Design.UI();
            Console.WriteLine();
            Colorful.Console.Write("Mail Modules\n\n", Color.DarkCyan);
            Colorful.Console.Write("[", Color.DarkCyan);
            Colorful.Console.Write("1", Color.Cyan);
            Colorful.Console.Write("]", Color.DarkCyan);
            Colorful.Console.Write(" Yahoo API 1\n", Color.Yellow);
            Colorful.Console.Write("[", Color.DarkCyan);
            Colorful.Console.Write("2", Color.Cyan);
            Colorful.Console.Write("]", Color.DarkCyan);
            Colorful.Console.Write(" Yahoo API 2\n", Color.Yellow);
            Colorful.Console.Write("[", Color.DarkCyan);
            Colorful.Console.Write("3", Color.Cyan);
            Colorful.Console.Write("]", Color.DarkCyan);
            Colorful.Console.Write(" Yahoo API 3\n", Color.Yellow);
            Colorful.Console.Write("[", Color.DarkCyan);
            Colorful.Console.Write("4", Color.Cyan);
            Colorful.Console.Write("]", Color.DarkCyan);
            Colorful.Console.Write(" Hotmail API 1\n", Color.Green);
            Colorful.Console.Write("[", Color.DarkCyan);
            Colorful.Console.Write("5", Color.Cyan);
            Colorful.Console.Write("]", Color.DarkCyan);
            Colorful.Console.Write(" Hotmail API 2\n", Color.Green);
            Colorful.Console.Write("[", Color.DarkCyan);
            Colorful.Console.Write("6", Color.Cyan);
            Colorful.Console.Write("]", Color.DarkCyan);
            Colorful.Console.Write(" GMX API 1\n", Color.LightSkyBlue);
            Colorful.Console.Write("[", Color.DarkCyan);
            Colorful.Console.Write("7", Color.Cyan);
            Colorful.Console.Write("]", Color.DarkCyan);
            Colorful.Console.Write(" GMX API 2\n", Color.LightSkyBlue);
            Colorful.Console.Write("[", Color.DarkCyan);
            Colorful.Console.Write("8", Color.Cyan);
            Colorful.Console.Write("]", Color.DarkCyan);
            Colorful.Console.Write(" GMX API 3 [Germany]\n", Color.LightSkyBlue);
            Colorful.Console.Write("[", Color.DarkCyan);
            Colorful.Console.Write("9", Color.Cyan);
            Colorful.Console.Write("]", Color.DarkCyan);
            Colorful.Console.Write(" Abv.bg API 1\n", Color.HotPink);
            Colorful.Console.Write("[", Color.DarkCyan);
            Colorful.Console.Write("10", Color.Cyan);
            Colorful.Console.Write("]", Color.DarkCyan);
            Colorful.Console.Write(" Abv.bg API 2\n", Color.HotPink);
            Colorful.Console.Write("", Color.Cyan);
            Colorful.Console.Write("", Color.Cyan);
            Colorful.Console.WriteLine("                                                                                                   [T] - Module Menu", Color.Cyan);
            Colorful.Console.Write("\n[~] Choice: ", Color.Cyan);
            string str = Console.ReadLine();
            if (str.ToUpper() == "T")
            {
                chooose();
            }
            else if (str.ToUpper() == "1")
            {
                Console.Clear();
                Design.UI();
                Console.WriteLine("Do You Want To Capture Subscriptions?\n\n[A] - Yes \n[B] - No", Color.MediumSlateBlue);
                var option = System.Console.ReadKey();
                Console.Clear();
                if (option.Key == (ConsoleKey.A))
                {
                    capture = 1;
                    Thread.Sleep(300); stats.save();
                    Console.WriteLine();
                    Yahoo1check.Start1();
                }
                else if (option.Key == (ConsoleKey.B))
                {
                    capture = 0;
                    Thread.Sleep(300); stats.save();
                    Console.WriteLine();
                    Yahoo1check.Start1();
                }
                else
                {
                    mail();
                }
            }
            else if (str.ToUpper() == "2")
            {
                Console.Clear();
                Design.UI();
                Console.WriteLine("Do You Want To Capture Subscriptions?\n\n[A] - Yes \n[B] - No", Color.MediumSlateBlue);
                var option = System.Console.ReadKey();
                Console.Clear();
                if (option.Key == (ConsoleKey.A))
                {
                    capture = 1;
                    Thread.Sleep(300); stats.save();
                    Console.WriteLine();
                    Yahoo2check.Start1();
                }
                else if (option.Key == (ConsoleKey.B))
                {
                    capture = 0;
                    Thread.Sleep(300); stats.save();
                    Console.WriteLine();
                    Yahoo2check.Start1();
                }
                else
                {
                    mail();
                }
            }
            else if (str.ToUpper() == "3")
            {
                Console.Clear();
                Design.UI();
                Console.WriteLine("Do You Want To Capture Subscriptions?\n\n[A] - Yes \n[B] - No", Color.MediumSlateBlue);
                var option = System.Console.ReadKey();
                Console.Clear();
                if (option.Key == (ConsoleKey.A))
                {
                    capture = 1;
                    Thread.Sleep(300); stats.save();
                    Console.WriteLine();
                    Yahoo3check.Start1();
                }
                else if (option.Key == (ConsoleKey.B))
                {
                    capture = 0;
                    Thread.Sleep(300); stats.save();
                    Console.WriteLine();
                    Yahoo3check.Start1();
                }
                else
                {
                    mail();
                }
            }
            else if (str.ToUpper() == "4")
            {
                Console.Clear();
                Design.UI();
                Console.WriteLine();
                Hotmail1check.Start1();
            }
            else if (str.ToUpper() == "5")
            {
                Console.Clear();
                Design.UI();
                Console.WriteLine();
                Hotmail2check.Start1();
            }
            else if (str.ToUpper() == "6")
            {
                Console.Clear();
                Design.UI();
                Console.WriteLine();
                gmx1check.Start1();
            }

            else if (str.ToUpper() == "7")
            {
                Console.Clear();
                Design.UI();
                Console.WriteLine();
                gmx2check.Start1();
            }
            else if (str.ToUpper() == "8")
            {
                Console.Clear();
                Design.UI();
                Console.WriteLine();
                gmx3check.Start1();
            }
            else if (str.ToUpper() == "9")
            {
                Console.Clear();
                Design.UI();
                Console.WriteLine();
                abv1check.Start1();
            }
            else if (str.ToUpper() == "10")
            {
                Console.Clear();
                Design.UI();
                Console.WriteLine();
                abv2check.Start1();
            }
            else
            {
                valid();
            }
        }

    

      
         
        public static void menu()
        {
 
            Console.Clear();
            if (Checking.userpc == 1)
            {
                RPC.client.ClearPresence();
                RPC.Initialize2();
            }
            Checking.currentrun = "In Main Menu";
            string path = "Data/Config.json";
            Program.config = File.Exists(path) ? JsonConvert.DeserializeObject<Program.configObject>(File.ReadAllText(path)) : Login.renewconfig(true);
            Colorful.Console.Clear();
            Design.UI();
            Colorful.Console.Write("[", Color.DarkCyan);
            Colorful.Console.Write("1", Color.Cyan);
            Colorful.Console.Write("]", Color.DarkCyan);
            Colorful.Console.Write(" Checker\n", Color.Cyan);
            Colorful.Console.Write("[", Color.DarkCyan);
            Colorful.Console.Write("2", Color.Cyan);
            Colorful.Console.Write("]", Color.DarkCyan);
            Colorful.Console.Write(" Settings\n", Color.Cyan);
            Colorful.Console.Write("[", Color.DarkCyan);
            Colorful.Console.Write("3", Color.Cyan);
            Colorful.Console.Write("]", Color.DarkCyan);
            Colorful.Console.Write(" Exit\n", Color.Cyan);
            Console.WriteLine("\n");
            Colorful.Console.Write("[~] Choice: ", Color.Cyan);
            string str = Colorful.Console.ReadLine();
            if (str == "1")
            {
                 chooose();
            }
 
            else if (str == "3")
            {
                Console.Clear();
                Design.UI();
                Colorful.Console.WriteLine("[~] BYE", Color.Blue);
                Thread.Sleep(1000);
                Environment.Exit(0);
            }
            else if (str == "2")
            currentsettings();
            else
                menu();
        }
        public static void changelog()
        {
            Console.Clear();
            Design.UI();
            Colorful.Console.Title = "Galaxy AIO";
            Checking.currentrun = "In Main Menu";
            Colorful.Console.Write("4.3");
            Console.WriteLine("\n");
            Colorful.Console.WriteLine("\n\n[~] Press X To Go Back", Color.Cyan);
            var option = System.Console.ReadKey();
            if (option.Key == (ConsoleKey.X))
            {
                menu();
            }
            else
            {
                changelog();
            }

        }
        public static void currentsettings()
        {
            Checking.currentrun = "Viewing Current Config";
            if (Checking.userpc == 1)
            {
                RPC.client.ClearPresence();
                RPC.Initialize1();
            }
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
            Colorful.Console.Clear();
            Design.UI();
            try
            {
                Colorful.Console.WriteLine("Main Information\n", Color.LimeGreen);
                Colorful.Console.Write("\n[~] Threads: ", Color.Cyan);
                Colorful.Console.Write(Program.config.threads, Color.LawnGreen);
                Colorful.Console.Write("\n[~] Timeout: ", Color.Cyan);
                Colorful.Console.Write(Program.config.timeout, Color.LawnGreen);
                Colorful.Console.Write("\n[~] Console Refresh Rate: ", Color.Cyan);
                Colorful.Console.Write(Program.config.refreshrate, Color.LawnGreen);
                Colorful.Console.Write("\n[~] Proxy Type: ", Color.Cyan);
                Colorful.Console.Write(Program.config.proxytype, Color.LawnGreen);
                Colorful.Console.WriteLine("\n\nUI Information", Color.LimeGreen);
                Colorful.Console.Write("\n[~] Design: ", Color.Cyan);
                Colorful.Console.Write(des, Color.LawnGreen);
                    if (Program.config.showbad == "True")
                {
                    Checking.showbad1 = true;
                    Colorful.Console.Write("\n[~] Print Invalid Accounts - ", Color.Cyan);
                    Colorful.Console.Write(Checking.showbad1, Color.Green);
                }
                else if (Program.config.showbad == "False")
                {
                    Checking.showbad1 = false;
                    Colorful.Console.Write("\n[~] Print Invalid Accounts - ", Color.Cyan);
                    Colorful.Console.Write(Checking.showbad1, Color.Red);
                }
                if (Program.config.showlocked == "True" )
                {
                    Checking.showlocked1 = true;
                    Colorful.Console.Write("\n[~] Print Custom Accounts - ", Color.Cyan);
                    Colorful.Console.Write(Checking.showlocked1, Color.Green);
                }
                else if (Program.config.showlocked == "False")
                {
                    Checking.showlocked1 = false;
                    Colorful.Console.Write("\n[~] Print Custom Accounts - ", Color.Cyan);
                    Colorful.Console.Write(Checking.showlocked1, Color.Red);
                }
                if (Program.config.show2fa == "True" )
                {
                    Checking.show2fa1 = true;
                    Colorful.Console.Write("\n[~] Print Two Factor Accounts - ", Color.Cyan);
                    Colorful.Console.Write(Checking.show2fa1, Color.Green);
                }
                else if (Program.config.show2fa == "False")
                {
                    Checking.show2fa1 = false;
                    Colorful.Console.Write("\n[~] Print Two Factor Accounts - ", Color.Cyan);
                    Colorful.Console.Write(Checking.show2fa1, Color.Red);
                }
                if (Program.config.showgood == "True")
                {
                    Checking.showgood1 = true;
                    Colorful.Console.Write("\n[~] Print Valid Accounts - ", Color.Cyan);
                    Colorful.Console.Write(Checking.showgood1, Color.Green);
                }
                else if (Program.config.showgood == "False")
                {
                    Checking.showgood1 = false;
                    Colorful.Console.Write("\n[~] Print Valid Accounts - ", Color.Cyan);
                    Colorful.Console.Write(Checking.showgood1, Color.Red);
                }
                Colorful.Console.WriteLine("\n\nAPI Information", Color.LimeGreen);
                if (Program.config.usewebhook == "True")
                {
                    Checking.usewebhook = true;
                    Colorful.Console.Write("\n[~] Use Discord Webhook - ", Color.Cyan);
                    Colorful.Console.Write(Checking.usewebhook, Color.Green);
                    Colorful.Console.Write("\n[~] Webhook URL: ", Color.Cyan);
                    Colorful.Console.Write(Program.config.webhook, Color.LawnGreen);
                }
                else if (Program.config.usewebhook == "False")
                {
                    Checking.usewebhook = false;
                    Colorful.Console.Write("\n[~] Use Discord Webhook - ", Color.Cyan);
                    Colorful.Console.Write(Checking.usewebhook, Color.Red);
                }
                if (Program.config.hitstowebhook == "True")
                {
                    Checking.hitstowebhook = true;
                    Colorful.Console.Write("\n[~] Hits To Discord Webhook - ", Color.Cyan);
                    Colorful.Console.Write(Checking.hitstowebhook, Color.Green);
                }
                else if (Program.config.hitstowebhook == "False")
                {
                    Checking.hitstowebhook = false;
                    Colorful.Console.Write("\n[~] Hits To Discord Webhook - ", Color.Cyan);
                    Colorful.Console.Write(Checking.hitstowebhook, Color.Red);
                }
               //if (Program.config.useproxyapi == "True")
               //{
               //    Checking.useproxyapi = true;
               //    Colorful.Console.Write("\n[~] Use Proxy API - ", Color.Cyan);
               //    Colorful.Console.Write(Checking.useproxyapi, Color.Green);
               //}
               //else if (Program.config.useproxyapi == "False")
               //{
               //    Checking.useproxyapi = false;
               //    Colorful.Console.Write("\n[~] Use Proxy API - ", Color.Cyan);
               //    Colorful.Console.Write(Checking.useproxyapi, Color.Red);
               //}
               //if (Program.config.useproxyapi == "True")
               //{
               //    Colorful.Console.Write("\n[~] Proxy API URL: ", Color.Cyan);
               //    Colorful.Console.Write(Program.config.proxyapiurl, Color.LawnGreen);
               //}
                Checking.userpc1 = true;
                //if (Program.config.moooooood == "LOG")
                //{
                //    Checking.log = true;
                //    Colorful.Console.Write("\n[~] UI - ", Color.Cyan);
                //    Colorful.Console.Write(Program.config.moooooood, Color.Cyan);
                //}
                //else if (Program.config.moooooood == "CUI")
                //{
                //    Checking.log = false;
                //    Colorful.Console.Write("\n[~] UI - ", Color.Cyan);
                //    Colorful.Console.Write(Program.config.moooooood, Color.Cyan);
                //}
            }
            catch
            {
                Colorful.Console.WriteLine("\nERROR", Color.Red);
            }
            Colorful.Console.WriteLine("\n\n[~] Press X To Go Back | Press C To Edit Config", Color.Cyan);
            var option = System.Console.ReadKey();
            if (option.Key == (ConsoleKey.X))
            {
                menu();
            }
            if (option.Key == (ConsoleKey.C))
            {
                Checking.currentrun = "Editing Config";
                Login.renewconfig(true);
            }
            else
            {
                currentsettings();
            }
        }
        public static string color;
    }

}