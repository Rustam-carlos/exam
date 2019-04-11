using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystemLesson
{
    public class TelegramMessageService:ISender
    {
        public void SendMessage(string to, string text)
        {
            Console.WriteLine($"Telegram. Кому:{to}, Сщщбшение:{text}");

        }
    }
}
