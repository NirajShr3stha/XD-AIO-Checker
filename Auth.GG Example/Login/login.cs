using System; using Galaxy.Mainm;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ZuttPal;
using Colorful;
using System.Drawing;
using Console = Colorful.Console;
using System.Threading;
using System.IO;
using Zuttpal;
using Newtonsoft.Json;

namespace AuthGG
{
    class Login
    {
        public static string date = DateTime.Now.ToString("MM-dd-yyyy H.mm");
        public static string username = "";

        [STAThread]

        static void Main1()
        {
            Console.Clear();
            RPC.Initialize();
            Design.UI();
            if (File.Exists("Data/Config.json"))
            {
                niggers.menu();
            }
            else if (!File.Exists("Data/Config.json"))
            {
                renewconfig(true);
            }
        }
        public static string printType;

        public static void printLogo()
        {
            Console.Clear();
            Design.UI();
            Console.WriteLine("");
        }
        public static void printLogo1()
        {
            Console.Clear();
            Design.defff();
            Console.WriteLine("");
        }
        public static Program.configObject renewconfig(bool AskToSave)
        {
            Console.Clear();
            Design.UI();
            if (Checking.userpc == 1)
            {
                RPC.client.ClearPresence();
                RPC.Initialize();
            }
            printLogo1();
            Colorful.Console.WriteLine("[?] Design\n\n", Color.Cyan);
            Colorful.Console.WriteLine("[1] CUI", Color.Cyan);
            Colorful.Console.WriteLine("[2] LOG\n", Color.Cyan);
            Colorful.Console.Write("[~] Choice: ", Color.Cyan);
            Program.config.ui = int.Parse(Console.ReadLine());
            printLogo();
            Colorful.Console.Write("[~] Threads [Defualt 200]: ", Color.Cyan);
            Program.config.threads = int.Parse(Console.ReadLine());
            printLogo();
            Colorful.Console.Write("[~] Timeout [Defualt 7000]: ", Color.Cyan);
            Program.config.timeout = int.Parse(Console.ReadLine());
            printLogo();
            Colorful.Console.Write("[~] Console Refresh Rate [Default 1000]: ", Color.Cyan);
            Program.config.refreshrate = int.Parse(Console.ReadLine());
            printLogo();
            Colorful.Console.Write("[~] Proxy Type [HTTP, SOCKS4, SOCKS5, PROXYLESS]: ", Color.Cyan);
            Program.config.proxytype = (Console.ReadLine());
            printLogo();
        IL13:
            Console.Clear();
            Design.UI();
            if (Checking.showbad1 == true)
            {
                Colorful.Console.Write("\n[1] Print Invalid Accounts - ", Color.Cyan);
                Colorful.Console.Write(Checking.showbad1, Color.Green);
            }
            else if (Checking.showbad1 == false)
            {
                Colorful.Console.Write("\n[1] Print Invalid Accounts - ", Color.Cyan);
                Colorful.Console.Write(Checking.showbad1, Color.Red);
            }
            if (Checking.showgood1 == true)
            {
                Colorful.Console.Write("\n[2] Print Valid Accounts - ", Color.Cyan);
                Colorful.Console.Write(Checking.showgood1, Color.Green);
            }
            else if (Checking.showgood1 == false)
            {
                Colorful.Console.Write("\n[2] Print Valid Accounts - ", Color.Cyan);
                Colorful.Console.Write(Checking.showgood1, Color.Red);
            }
            if (Checking.show2fa1 == true)
            {
                Colorful.Console.Write("\n[3] Print Two Factor Accounts - ", Color.Cyan);
                Colorful.Console.Write(Checking.show2fa1, Color.Green);
            }
            else if (Checking.show2fa1 == false)
            {
                Colorful.Console.Write("\n[3] Print Two Factor Accounts - ", Color.Cyan);
                Colorful.Console.Write(Checking.show2fa1, Color.Red);
            }
            if (Checking.showlocked1 == true)
            {
                Colorful.Console.Write("\n[4] Print Custom Accounts - ", Color.Cyan);
                Colorful.Console.Write(Checking.showlocked1, Color.Green);
            }
            else if (Checking.showlocked1 == false)
            {
                Colorful.Console.Write("\n[4] Print Custom Accounts - ", Color.Cyan);
                Colorful.Console.Write(Checking.showlocked1, Color.Red);
            }
            if (Checking.usewebhook == true)
            {
                Colorful.Console.Write("\n[5] Use Discord Webhook - ", Color.Cyan);
                Colorful.Console.Write(Checking.usewebhook, Color.Green);
                
            }
            else if (Checking.usewebhook == false)
            {
                Colorful.Console.Write("\n[5] Use Discord Webhook - ", Color.Cyan);
                Colorful.Console.Write(Checking.usewebhook, Color.Red);
            }
            if (Checking.hitstowebhook == true)
            {
                Colorful.Console.Write("\n[6] Send Hits To Webhook - ", Color.Cyan);
                Colorful.Console.Write(Checking.hitstowebhook, Color.Green);
            }
            else if (Checking.hitstowebhook == false)
            {
                Colorful.Console.Write("\n[6] Send Hits To Webhook - ", Color.Cyan);
                Colorful.Console.Write(Checking.hitstowebhook, Color.Red);
            }
           //if (Checking.useproxyapi == true)
           //{
           //    Colorful.Console.Write("\n[7] Use Proxy API - ", Color.Cyan);
           //    Colorful.Console.Write(Checking.useproxyapi, Color.Green);
           //
           //}
           //
           //else if (Checking.useproxyapi == false)
           //{
           //    Colorful.Console.Write("\n[7] Use Proxy API - ", Color.Cyan);
           //    Colorful.Console.Write(Checking.useproxyapi, Color.Red);
           //}

            Checking.userpc1 = true;
            //if (Checking.log == true)
            //{
            //    Program.config.moooooood = "LOG";
            //    Colorful.Console.Write("\n[6] UI - ", Color.Cyan);
            //    Colorful.Console.Write(Program.config.moooooood, Color.Cyan);
            //}
            //else if (Checking.log == false)
            //{
            //    Program.config.moooooood = "CUI";
            //    Colorful.Console.Write("\n[6] UI - ", Color.Cyan);
            //    Colorful.Console.Write(Program.config.moooooood, Color.Cyan);
            //}
            Colorful.Console.WriteLine("\n\n\n[~] Press X To Go Finish", Color.Cyan);
            var option1 = System.Console.ReadKey();
            if (option1.Key == (ConsoleKey.X))
            {
                Console.Clear();
                Design.UI();
                if (Checking.showbad1 == true)
                {
                    Program.config.showbad = "True";
                }
                if (Checking.showbad1 == false)
                {
                    Program.config.showbad = "False";
                }
                if (Checking.showgood1 == true)
                {
                    Program.config.showgood = "True";
                }
                if (Checking.showgood1 == false)
                {
                    Program.config.showgood = "False";
                }
                if (Checking.showlocked1 == true)
                {
                    Program.config.showlocked = "True";
                }
                if (Checking.showlocked1 == false)
                {
                    Program.config.showlocked = "False";
                }
                if (Checking.show2fa1 == true)
                {
                    Program.config.show2fa = "True";
                }
                if (Checking.show2fa1 == false)
                {
                    Program.config.show2fa = "False";
                }
                if (Checking.usewebhook == true)
                {
                    Colorful.Console.Write("[~] Webhook URL: ", Color.Cyan);
                    Program.config.webhook = (Console.ReadLine());
                    Program.config.usewebhook = "True";
                }
                if (Checking.usewebhook == false)
                {
                    Program.config.usewebhook = "False";
                }
                if (Checking.hitstowebhook == true)
                {
                    Program.config.hitstowebhook = "True";
                }
                if (Checking.hitstowebhook == false)
                {
                    Program.config.hitstowebhook = "False";
                }
               //if (Checking.useproxyapi == true)
               //{
               //    Colorful.Console.Write("[~] API URL: ", Color.Cyan);
               //    Program.config.proxyapiurl = (Console.ReadLine());
               //    Program.config.useproxyapi = "True";
               //}
               //if (Checking.useproxyapi == false)
               //{
               //    Program.config.useproxyapi = "False";
               //}
                //if (Checking.log == true)
                //{
                //    Program.config.moooooood = "LOG";
                //}
                //if (Checking.log == false)
                //{
                //    Program.config.moooooood = "CUI";
                //}
                File.WriteAllText("Data/Config.json", JsonConvert.SerializeObject((object)Program.config));
                Colorful.Console.WriteLine("[~] Config saved To Config.json!", Color.LawnGreen);
                Thread.Sleep(5000);
                Console.Clear();
                Thread.Sleep(1000);
                loginpart();
            }
            if (option1.Key == (ConsoleKey.D1))
            {
                if (Checking.showbad1 == false)
                {
                    Checking.showbad1 = true;
                }
                else if (Checking.showbad1 == true)
                {
                    Checking.showbad1 = false;
                }
                goto IL13;
            }
            if (option1.Key == (ConsoleKey.D2))
            {
                if (Checking.showgood1 == false)
                {
                    Checking.showgood1 = true;
                }
                else if (Checking.showgood1 == true)
                {
                    Checking.showgood1 = false;
                }
                goto IL13;
            }
            if (option1.Key == (ConsoleKey.D3))
            {
                if (Checking.show2fa1 == false)
                {
                    Checking.show2fa1 = true;
                }
                else if (Checking.show2fa1 == true)
                {
                    Checking.show2fa1 = false;
                }
                goto IL13;
            }
            if (option1.Key == (ConsoleKey.D4))
            {
                if (Checking.showlocked1 == false)
                {
                    Checking.showlocked1 = true;
                }
                else if (Checking.showlocked1 == true)
                {
                    Checking.showlocked1 = false;
                }
                goto IL13;
            }

            if (option1.Key == (ConsoleKey.D5))
            {
                if (Checking.usewebhook == false)
                {
                    Checking.usewebhook = true;

                }
                else if (Checking.usewebhook == true)
                {
                    Checking.usewebhook = false;
                }
                goto IL13;
            }
            if (option1.Key == (ConsoleKey.D6))
            {
                if (Checking.hitstowebhook == false)
                {
                    Checking.hitstowebhook = true;
                }
                else if (Checking.hitstowebhook == true)
                {
                    Checking.hitstowebhook = false;
                }
                goto IL13;
            }
            if (option1.Key == (ConsoleKey.D7))
            {
                if (Checking.useproxyapi == false)
                {
                    Checking.useproxyapi = true;

                }
                else if (Checking.useproxyapi == true)
                {
                    Checking.useproxyapi = false;
                }
                goto IL13;
            }
            else
            {
                Console.Clear();
                Design.UI();
                goto IL13;
            }
            File.WriteAllText("Data/Config.json", JsonConvert.SerializeObject((object)Program.config));
            Colorful.Console.WriteLine("[~] Config saved To Config.json!", Color.Cyan);
            Thread.Sleep(5000);
            Login.Main1();
            return Program.config;
        }
        public enum PrintType
        {
            Input,
            Output,
            Warning,
            Error,
            Custom
        }
        public static void GetColors()
        {
            foreach (var colorValue in Enum.GetValues(typeof(KnownColor)))
            {
                Color coloor = Color.FromKnownColor((KnownColor)colorValue);
                colorss.Add(coloor);
            }
        }
        public static List<Color> colorss = new List<Color>();

        public static void loginpart()
        {

            RPC.Initialize5();
            OnProgramStart.Initialize("Hora", "844777", "AVWcMzP5b99x475PIe9rI10CS1aPfJqvTdo", "1.0");
            if (File.Exists("Data//login.galaxy"))
            {
                check();
            }
            Console.Clear();
            Design.UI();
            Console.WriteLine("[1] - Login", Color.Cyan);
            Console.WriteLine("[2] - Register", Color.Cyan);
            Console.WriteLine("[3] - Free Tools", Color.Cyan);
            Console.Write("\nChoice: ", Color.Cyan);
            string ans = Console.ReadLine();
            if (ans == "1")
            {
                check();
            }
            else if (ans == "2")
            {
                reg();
            }
            else if (ans == "3")
            {
                niggers.free();
            }
            else
            {
                loginpart();
            }
        }
        public static void check()
        {
            Console.Clear();
            Checking.currentrun = "Logging In";
            if (Checking.userpc == 1)
            {
                RPC.client.ClearPresence();
                RPC.Initialize5();
            }
            Design.UI();
            Colorful.Console.Title = "Galaxy AIO";
            Colorful.Console.WriteLine("");
            Console.WriteLine();
            if (File.Exists("Data//login.galaxy"))
            {
                Console.WriteLine();
                string readText = File.ReadAllText("Data//login.galaxy");
                string readText11 = Functions.Base64Decode(readText);
                string username = readText11.Split(':')[0];
                string password = readText11.Split(':')[1];
                if (API.Login(username, password))
                {
                    

                    Main1(); 
                }
            }
            else
            {
                Console.WriteLine();
                string password = "";
                Colorful.Console.Write("Username: ", Color.Cyan);
                string username = Console.ReadLine();
                Colorful.Console.Write("Password: ", Color.Cyan);
                ConsoleKeyInfo info = Colorful.Console.ReadKey(true);
                while (info.Key != ConsoleKey.Enter)
                {
                    if (info.Key != ConsoleKey.Backspace)
                    {
                        Colorful.Console.Write("*");
                        password += info.KeyChar.ToString();
                    }
                    else if (info.Key == ConsoleKey.Backspace && !string.IsNullOrEmpty(password))
                    {
                        password = password.Substring(0, password.Length - 1);
                        int cursorLeft = Colorful.Console.CursorLeft;
                        Colorful.Console.SetCursorPosition(cursorLeft - 1, Colorful.Console.CursorTop);
                        Colorful.Console.Write(" ");
                        Colorful.Console.SetCursorPosition(cursorLeft - 1, Colorful.Console.CursorTop);
                    }
                    info = Colorful.Console.ReadKey(true);
                }
                if (API.Login(username, password))
                {
                    string lol = (username + ":" + password);
                    string nacas = Functions.Base64Encode(lol);
                    using (StreamWriter streamWriter = new StreamWriter("Data//login.galaxy"))
                    {
                        streamWriter.Write(nacas);
                    }

                    Main1();
                }
            }
        }
        public static void reg()
        {

            Console.Clear();
            Checking.currentrun = "Logging In";
            if (Checking.userpc == 1)
            {
                RPC.client.ClearPresence();
                RPC.Initialize5();
            }
            Design.UI();
            Colorful.Console.Title = "Galaxy AIO";
            Colorful.Console.WriteLine("");
            Console.WriteLine();
            Console.Write("Username: ");
            string username = Console.ReadLine();
            string password = "";
            Console.Write("Password: ");
            ConsoleKeyInfo info = Colorful.Console.ReadKey(true);
            while (info.Key != ConsoleKey.Enter)
            {
                if (info.Key != ConsoleKey.Backspace)
                {
                    Colorful.Console.Write("*");
                    password += info.KeyChar.ToString();
                }
                else if (info.Key == ConsoleKey.Backspace && !string.IsNullOrEmpty(password))
                {
                    password = password.Substring(0, password.Length - 1);
                    int cursorLeft = Colorful.Console.CursorLeft;
                    Colorful.Console.SetCursorPosition(cursorLeft - 1, Colorful.Console.CursorTop);
                    Colorful.Console.Write(" ");
                    Colorful.Console.SetCursorPosition(cursorLeft - 1, Colorful.Console.CursorTop);
                }
                info = Colorful.Console.ReadKey(true);
            }
            Console.Write("\nEmail: ");
            string email = Console.ReadLine();
            Console.Write("License: ");
            string license = Console.ReadLine();
            if (API.Register(username, password, email, license))
            {
                string lol = (username + ":" + password);
                string nacas = Functions.Base64Encode(lol);
                using (StreamWriter streamWriter = new StreamWriter("Data//login.galaxy"))
                {
                    streamWriter.Write(nacas);
                }
                Main1();
            }
            else
            {
                Console.Clear();
                Design.UI();
                Console.WriteLine("Wrong License Or Something Else");
            }
        }
    }
}
