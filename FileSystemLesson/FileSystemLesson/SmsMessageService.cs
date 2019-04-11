using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystemLesson
{
    public class SmsMessageService:ISender
    {
        public void SendMessage(string number, string message)
        {
            Console.WriteLine("Отправка сообщений завершена");

        }
    }
}
