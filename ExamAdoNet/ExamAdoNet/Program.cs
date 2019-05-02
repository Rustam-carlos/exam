using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamAdoNet
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1, x = 0; i > x; i++)
            {
                int choise = 0;
                Console.WriteLine("Добро пожаловать!!!");
                Menu();
                choise = int.Parse(Console.ReadLine());
                if ((choise != 1) & (choise != 2) & (choise != 3) & (choise != 4) & (choise != 5) & (choise != 6) & (choise != 7) & (choise != 8) & (choise != 9) & (choise != 10) & (choise != 11) & (choise != 12) & (choise != 13))
                    Console.WriteLine("ОШИБКА ВВОДА!!! СОБЕРИСЬ ТРЯПКА!!!");
                else
                {
                    Console.Clear();
                    using (CountryContext context = new CountryContext())
                    {
                        Street NewStreet = new Street { Name = "Аль Фараби" };
                        context.Streets.Add(NewStreet);
                        context.SaveChanges();
                        int idStreet = 1;
                        var _city = (from Street in context.Streets
                                    where Street.ID.Equals(idStreet)
                                    select Street).FirstOrDefault();

                        City NewCity = new City { Name = "Астана", street = _city };
                        context.Cityes.Add(NewCity);
                        context.SaveChanges();
                        int idCity = 1;
                        var _country = (from City in context.Cityes
                                     where City.ID.Equals(idCity)
                                     select City).FirstOrDefault();
                        Country NewCountry = new Country { Name = "Казахстан", city = _country };
                        context.Countryes.Add(NewCountry);
                        context.SaveChanges();


                        switch (choise)
                        {
                            case 1:
                                Console.WriteLine("Введите пожалуйста название страны");
                                string name = Console.ReadLine();
                                Country newCountry = new Country { Name = name };
                                context.Countryes.Add(NewCountry);
                                context.SaveChanges();

                                Console.ReadKey();
                                Console.Clear();
                                continue;
                            case 2:
                                Console.WriteLine("Введите пожалуйста название страны которую хотели изменить");
                                int idCountry = int.Parse(Console.ReadLine());
                                var _country_ = (from Country in context.Countryes
                                                where Country.ID.Equals(idCountry)
                                                select Country).FirstOrDefault();
                                Console.WriteLine("Введите пожалуйста новое название страны ");
                                string NewNameCountry = Console.ReadLine();
                                _country_.Name = NewNameCountry;
                                context.Countryes.Add(_country_);
                                context.SaveChanges();
                                Console.ReadKey();
                                Console.Clear();
                                continue;
                            case 3:
                                Console.WriteLine("Введите пожалуйста название страны которую хотели удалить");
                                int IDCountry = int.Parse(Console.ReadLine());
                                var Delcountry = (from Country in context.Countryes
                                                 where Country.ID.Equals(IDCountry)
                                                 select Country).FirstOrDefault();
                                context.Countryes.Remove(Delcountry);
                                context.SaveChanges();
                                Console.ReadKey();
                                Console.Clear();
                                continue;
                            case 4:
                                var CountryShow = context.Countryes;
                                Console.WriteLine("Содержимое таблицы страны");
                                foreach (Country n in CountryShow)
                                {
                                    Console.WriteLine("{0}.{1}.{2}", n.ID, n.Name, n.city.Name);
                                }                                

                                Console.ReadKey();
                                Console.Clear();
                                continue;
                            case 5:
                                Console.WriteLine("Введите пожалуйста название города");
                                string nameCity = Console.ReadLine();
                                City newcity = new City { Name = nameCity };
                                context.Cityes.Add(newcity);
                                context.SaveChanges();

                                Console.ReadKey();
                                Console.Clear();
                                continue;
                            case 6:
                                Console.WriteLine("Введите пожалуйста название города которую хотели изменить");
                                int idcity = int.Parse(Console.ReadLine());
                                var ReNameCity = (from City in context.Cityes
                                                 where City.ID.Equals(idcity)
                                                 select City).FirstOrDefault();
                                Console.WriteLine("Введите пожалуйста новое название страны ");
                                string NewNameCity = Console.ReadLine();
                                ReNameCity.Name = NewNameCity;
                                context.Cityes.Add(ReNameCity);
                                context.SaveChanges();
                                Console.ReadKey();
                                Console.Clear();
                                continue;
                            case 7:
                                Console.WriteLine("Введите пожалуйста название города которую хотели удалить");
                                int IdCity = int.Parse(Console.ReadLine());
                                var Delcity = (from City in context.Cityes
                                                  where City.ID.Equals(IdCity)
                                                  select City).FirstOrDefault();
                                context.Cityes.Remove(Delcity);
                                context.SaveChanges();

                                Console.ReadKey();
                                Console.Clear();
                                continue;
                            case 8:
                                var CityShow = context.Cityes;
                                Console.WriteLine("Содержимое таблицы города");
                                foreach (City n in CityShow)
                                {
                                    Console.WriteLine("{0}.{1}.{2}", n.ID, n.Name, n.street.Name);
                                }
                                Console.ReadKey();
                                Console.Clear();
                                continue;
                            case 9:
                                Console.WriteLine("Введите пожалуйста название улицы");
                                string nameStreet = Console.ReadLine();
                                Street newstreet = new Street { Name = nameStreet };
                                context.Streets.Add(newstreet);
                                context.SaveChanges();

                                Console.ReadKey();
                                Console.Clear();
                                continue;
                            case 10:
                                Console.WriteLine("Введите пожалуйста название улицы которую хотели изменить");
                                int idstreet = int.Parse(Console.ReadLine());
                                var ReNameStreet = (from Street in context.Streets
                                                  where Street.ID.Equals(idstreet)
                                                  select Street).FirstOrDefault();
                                Console.WriteLine("Введите пожалуйста новое название улицы ");
                                string NewNameStreet = Console.ReadLine();
                                ReNameStreet.Name = NewNameStreet;
                                context.Streets.Add(ReNameStreet);
                                context.SaveChanges();

                                Console.ReadKey();
                                Console.Clear();
                                continue;
                            case 11:
                                Console.WriteLine("Введите пожалуйста название улицы которую хотели удалить");
                                int IdStreet = int.Parse(Console.ReadLine());
                                var Delstreet = (from Street in context.Streets
                                               where Street.ID.Equals(IdStreet)
                                               select Street).FirstOrDefault();
                                context.Streets.Remove(Delstreet);
                                context.SaveChanges();

                                Console.ReadKey();
                                Console.Clear();
                                continue;
                            case 12:
                                var StreetShow = context.Streets;
                                Console.WriteLine("Содержимое таблицы улицы");
                                foreach (Street n in StreetShow)
                                {
                                    Console.WriteLine("{0}.{1}", n.ID, n.Name);
                                }

                                Console.ReadKey();
                                Console.Clear();
                                continue;
                            case 13:
                                i = 0;
                                break;
                        }
                    }
                }
            }
                
        }

        private static void Menu()
        {
            Console.WriteLine("Меню");
            //Console.WriteLine("Сделайте свой выбор пожалуйста");
            Console.WriteLine("1 - Добавить страну");
            Console.WriteLine("2 - Изменить название страны");
            Console.WriteLine("3 - Удалить страну");
            Console.WriteLine("4 - Посмотреть список стран");
            Console.WriteLine("5 - Добавить город");
            Console.WriteLine("6 - Изменить название города");
            Console.WriteLine("7 - Удалить город");
            Console.WriteLine("8 - Посмотреть список городов");
            Console.WriteLine("9 - Добавить улицу");
            Console.WriteLine("10 - Изменить название улицы");
            Console.WriteLine("11 - Удалить улицу");
            Console.WriteLine("12 - Посмотреть список улиц");
            Console.WriteLine("13 - Выход");
        }
    }
}
