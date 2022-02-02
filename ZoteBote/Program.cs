using System;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using Newtonsoft.Json;
using Discord;
using Discord.WebSocket;
using Discord.Commands;

namespace ZoteBote
{
    class Program
    {
        static string curpath { get => Environment.CurrentDirectory; }

        private DiscordSocketClient _client;
        private ZoteboteConfig _config;

        static Task Main(string[] args)
            => new Program().MainAsync(args);

        public async Task MainAsync(string[] args)
        {
            _config = new ZoteboteConfig();

            Console.WriteLine("Hello, cur. I'm the Zote Bot. Some call me ZoteBote. Sounds like a ridiculous name, I know.");
            string token = Environment.GetEnvironmentVariable("ZOTEBOTETOKEN");
            if (token == null)
            {
                if (!GetUserSecrets(out token))
                {
                    Console.WriteLine("Looks like you don't have a Discord token key, you clumsy little oaf!");
                    Console.Write("Give me your Discord bot's token key!: ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    string tokenkey = Console.ReadLine();
                    _config.Set("zotebotetoken", tokenkey);
                    Console.ResetColor();
                }
            }
            else
            {
                ConsoleColor.Magenta.WriteLine("Hmm? I found an environment variable that has the Discord bot's token.");
                _config.Set("zotebotetoken", token);
            }
            Console.WriteLine("Looks like we're ready to boot. Hold on, cur. I need to connect to Discord first.");

            _client = new DiscordSocketClient();
            _client.Log += Log;

            GetUserSecrets(out token);

            LogTask(ConsoleColor.Blue, "Logging into ZoteBote...", _client.LoginAsync(TokenType.Bot, token));
            LogTask(ConsoleColor.Blue, "Starting up...", _client.StartAsync());

            LogTask(ConsoleColor.Green, "Setting status...", _client.SetGameAsync(name: "the 57 precepts of Zote", type: ActivityType.Listening));

            var commandhandler = new CommandHandler(_client, new CommandService());
            LogTask(ConsoleColor.Blue, "Setting up commands...", commandhandler.InstallCommandsAsync());

            await Task.Delay(-1);
        }

        private void LogTask(ConsoleColor c, string text, Task task)
        {
            c.WriteLine(text);
            task.Wait();
        }

        private Task Log(LogMessage log)
        {
            Console.WriteLine(log.ToString());
            return Task.CompletedTask;
        }

        public bool GetUserSecrets(out string otoken)
        {
            string token = _config.Get("zotebotetoken");

            if (token == null)
            {
                otoken = null;
                return false;
            }

            otoken = token;
            return true;
        }
    }

    class UserSecrets
    {
        public string tokenkey = null;
    }
}
