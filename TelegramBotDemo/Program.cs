using System;
using Telegram.Bot;

namespace TelegramBotDemo
{
    class Program
    {
        private static TelegramBotClient client = null;
        static void Main(string[] args)
        {
            Console.WriteLine("Dastur ishga tushdi!");
            client = new TelegramBotClient("948048497:AAH5wdne2AWc-XTC7j-A6-1-CNawUljU8DM");
            client.OnMessage += Client_OnMessage;
            client.StartReceiving();
            Console.WriteLine("Dasturdan chiqish uchun Enterni bosing.");
            Console.ReadLine();
        }

        private static void Client_OnMessage(object sender, Telegram.Bot.Args.MessageEventArgs e)
        {
            Console.WriteLine($"Botdan kelgan xabar:{e.Message.Text}");
            if (e.Message.Text.ToLower().Contains("salom"))
                client.SendTextMessageAsync(e.Message.Chat.Id, "vaaleykum assalom!");
        }
    }
}
