using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Button smallButton = new Button
            {
                Width = 20,
                Heigt = 20,
                Text = "Жмакни"
            };

            //smallButton.ClickEvent += Hz;
            ////то же что и
            ////smallButton.ClickEvent += new ClickButtonDelegate(Hz);

            //smallButton.ClickEvent += delegate (OurButtonEventArgs arguments)
            //{

            //};

            // (параметры без типа через запятую) => {тело; return если надо;};

            smallButton.ClickEvent += (arguments) => Console.WriteLine("Меня нажали");

            Button mediumButton = new Button
            {
                Width = 40,
                Heigt = 40,
                Text = "Жмакни сильнее"
            };
            Button bigButton = new Button
            {
                Width = 100,
                Heigt = 100,
                Text = "Всеки"
            };
            List<string> names = new List<string>
            {
                "Бахыт",
                "Анвар",
                "Фриц"
            };
            var result = names.Single(name =>name.Contains("Ф"));
        }

        public static void Hz(OurButtonEventArgs args)
        {
            Console.WriteLine(" AAAAAAAAAA!!! Push mi")
        }
    }
}
