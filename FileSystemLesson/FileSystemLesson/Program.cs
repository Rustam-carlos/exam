using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace FileSystemLesson
{
    public class Program
    {        
        static void Main(string[] args)
        {
            //string fullPath = string.Empty; // " ";
            //List<DriveInfo> drives = DriveInfo.GetDrives().ToList();
            //try
            //{
            //    for (int i = 0; i < drives.Count; i++)
            //    {
            //        if (drives[i].IsReady)
            //            Console.WriteLine($"Имя: {drives[i].Name}\n" + $"Полный размер: {drives[i].TotalSize}\n" + $"Свободное место: { drives[i].TotalFreeSpace}");
            //    }
            //}
            //catch(IOException exception)
            //{
            //    Console.WriteLine(exception.Message);
            //}
            //Console.WriteLine("Введите порядковый номер диска: ");
            //int drivePosition = int.Parse(Console.ReadLine());

            //fullPath += drives[drivePosition].Name;
            //Console.Clear();

            //DirectoryInfo directoryInfo = new DirectoryInfo(fullPath);
            //FileSystemInfo[] systemFiles = directoryInfo.GetFileSystemInfos();

            //for(int i = 0; i<systemFiles.Length; i++)
            //{
            //    string extension = string.IsNullOrEmpty(systemFiles[i].Extension) ? "---" : systemFiles[i].Extension;

            //    Console.WriteLine($"{i}. Имя: {systemFiles[i].Name}" + $"Расшиоение : {extension}");
            //}
            //Console.WriteLine("Выберите порядклвый номер файла или папки: ");
            //int systemInfoPosition = int.Parse(Console.ReadLine());
            //fullPath += systemFiles[systemInfoPosition].Name;

            //if(!string.IsNullOrEmpty(systemFiles[systemInfoPosition].Extension))
            //{
            //    Process.Start(fullPath);
            //}
            //else
            //{

            //}
            File.Create(@"C:\1\data.txt").Close();
            //using (StreamWriter writer = new StreamWriter(@"C:\1\data.txt"))
            //{
            //    string data = "какой то текст";
            //    writer.WriteLine(data);
            //}
            //using (StreamReader reader = new StreamReader(@"C:\1\data.txt"))
            //{
            //    string result = reader.ReadToEnd();
            //    Console.WriteLine(result);
            //}
            //using (var stream = new FileStream(@"C:\1\data.txt", FileMode.OpenOrCreate))
            //{
            //    string data = "123abc";
            //    byte[]array = Encoding.UTF8.GetBytes(data);
            //    stream.Write(array, 0, array.Length);
            //}
            //using (var stream = new FileStream(@"C:\1\data.txt", FileMode.OpenOrCreate))
            //{
            //    byte[] array = new byte[stream.Length];
            //    stream.Read(array, 0, array.Length);
            //    string result = Encoding.UTF8.GetString(array);
            //}

            //////////////////////////////////////////////////////////////
            ISender service = new TelegramMessageService();
            service.SendMessage("+77777777777", "Смени номер полудурок");

        }
        static ISender GetSender()
        {
            return new SmsMessageService
        }
    }
}
