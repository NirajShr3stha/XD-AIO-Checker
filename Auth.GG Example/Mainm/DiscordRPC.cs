using System; using Galaxy.Mainm;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiscordRPC;
using DiscordRPC.Logging;
using Zuttpal;
using ZuttPal;

namespace AuthGG
{
    class RPC
    {
        public static DiscordRpcClient client;
        public static void Initialize()
        {
            client = new DiscordRpcClient("843060351352569886");
            client.Logger = new ConsoleLogger() { Level = LogLevel.None };
            client.Initialize();
            client.SetPresence(new DiscordRPC.RichPresence()
            {
                State = $"Galaxy - AIO",
                Details = "https://discord.gg/2hTNXMtgj8",
                Timestamps = Timestamps.Now,
                Assets = new Assets()
                {
                    LargeImageKey = $"big",
                    LargeImageText = "Delevoped By Adamski#2935",
                }
            });
        }
        public static void Initialize1()
        {
            client = new DiscordRpcClient("843060351352569886");
            client.Logger = new ConsoleLogger() { Level = LogLevel.None };
            client.Initialize();
            client.SetPresence(new DiscordRPC.RichPresence()
            {
                State = $"Galaxy - Editing Config.Json",
                Details = "https://discord.gg/2hTNXMtgj8",
                Timestamps = Timestamps.Now,
                Assets = new Assets()
                {
                    LargeImageKey = $"big",
                    LargeImageText = "Delevoped By Adamski#2935",
                }
            });
        }
        public static void Initialize2()
        {
            client = new DiscordRpcClient("843060351352569886");
            client.Logger = new ConsoleLogger() { Level = LogLevel.None };
            client.Initialize();
            client.SetPresence(new DiscordRPC.RichPresence()
            {
                State = $"Galaxy - Choose Module",
                Details = "https://discord.gg/2hTNXMtgj8",
                Timestamps = Timestamps.Now,
                Assets = new Assets()
                {
                    LargeImageKey = $"big",
                    LargeImageText = "Delevoped By Adamski#2935",
                }
            });
        }
        public static void update(int fat, int hits, int bad, string cpm)
        {
            client = new DiscordRpcClient("843060351352569886");
            client.Logger = new ConsoleLogger() { Level = LogLevel.None };
            client.Initialize();
            client.SetPresence(new DiscordRPC.RichPresence()
            {
                State = $"Checked: {fat} Hits: {hits} Bad: {bad} CPM: {cpm}",
                Details = "https://discord.gg/2hTNXMtgj8",
                Timestamps = Timestamps.Now,
                Assets = new Assets()
                {
                    LargeImageKey = $"big",
                    LargeImageText = "Delevoped By Adamski#2935",
                }
            });
        }
        public static void Initialize5()
        {
            client = new DiscordRpcClient("843060351352569886");
            client.Logger = new ConsoleLogger() { Level = LogLevel.None };
            client.Initialize();
            client.SetPresence(new DiscordRPC.RichPresence()
            {
                State = $"Galaxy - Logging In",
                Details = "https://discord.gg/2hTNXMtgj8",
                Timestamps = Timestamps.Now,
                Assets = new Assets()
                {
                    LargeImageKey = $"big",
                    LargeImageText = "Delevoped By Adamski#2935",
                }
            });
        }
    };

}