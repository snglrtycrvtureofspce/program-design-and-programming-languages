using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер задания: ");
            var p = Convert.ToInt32(Console.ReadLine());
            switch (p)
            {
                case 1:
                {
                    /*Ats mts = new Ats("17.11.2022", 375, "Минск", 4, 0.98, "375333572524", "375291952954");
                    Console.WriteLine(mts.ToString());*/
                    Console.Write("Введите количество АТС: ");
                    var count = Convert.ToInt32(Console.ReadLine());
                    var ts = new Ats[count];
                    for (var i = 0; i < count; i++)
                    {
                        var num = i + 1;
                        Console.WriteLine($"Введите данные {num}-ой АТС: ");
                        Console.Write("Введите дату разговора: ");
                        ts[i]._talk = Console.ReadLine();
                        Console.Write("Введите код города: ");
                        ts[i]._code = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Введите название города: ");
                        ts[i]._city = Console.ReadLine();
                        Console.Write("Введите время разговора в минутах (округлено): ");
                        ts[i]._timetalk = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Введите тариф: ");
                        ts[i]._rate = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Введите номер телефона в этом городе: ");
                        ts[i]._citynum = Console.ReadLine();
                        Console.Write("Введите номер телефона абонента: ");
                        ts[i]._citysub = Console.ReadLine();
                    }
                    Console.Clear();
                    for (var i = 0; i < count; i++)
                    {
                        var num = i + 1;
                        Console.WriteLine($"Данные {num}-ой АТС: ");
                        Console.WriteLine(ts[i].ToString());
                    }
                    break;
                }
                case 2:
                {
                        Console.Write("Введите количество работников: ");
                        var count = Convert.ToInt32(Console.ReadLine());
                        var date = new DateTime[count];
                        for (var i = 0; i < count; i++)
                        {
                            var num = i + 1;
                            Console.Write($"Введите дату зачисления {num}-го работника: ");
                            date[i] = Convert.ToDateTime(Console.ReadLine()); // dd.MM.yyyy hh:mm:ss
                        }
                        for (var i = 0; i < count; i++)
                        {
                            var num = i + 1;
                            Console.Write($"Дата зачисления {num}-го работника: ");
                            Console.WriteLine(date[i]);
                            Console.Write("Работают полных дней без учёта праздничных дней и воскресенья: ");
                            Console.WriteLine(RemDayOffHol(date[i]));
                        }
                        break;
                }
                default:
                {
                    Console.WriteLine("Exit...");
                    break;
                }
            }
            int RemDayOffHol(DateTime date) // удалить выходные (воскресенья) и праздничные дни
            {
                var newDate = date;
                var countDays = newDate.Day;
                DateTime newestDate = date;
                for (var i = 0; i < countDays; i++) // проверка на праздники
                {
                    if (IsHoliday(newestDate))
                    {
                        countDays -= 1;
                    }
                    newestDate = newestDate.AddDays(-1); // отнять один день
                }
                newestDate = date;
                for (var i = 0; i < countDays; i++) // проверка на воскресенья
                {
                    if (newestDate.DayOfWeek == DayOfWeek.Sunday)
                    {
                        countDays -= 1;
                    }
                    newestDate = newestDate.AddDays(-1); // отнять один день
                }
                return countDays;
            }
            bool IsHoliday(DateTime date) // https://trudvsem.ru/information-pages/calendar-2022
            {
                var holidays =
                    new DateTime[] { 
                        new DateTime(2022,01,03),
                        new DateTime(2022,01,04),
                        new DateTime(2022,01,05),
                        new DateTime(2022,01,06),
                        new DateTime(2022,02,23),
                        new DateTime(2022,03,07),
                        new DateTime(2022,03,08),
                        new DateTime(2022,05,02),
                        new DateTime(2022,05,03),
                        new DateTime(2022,05,09),
                        new DateTime(2022,05,10),
                        new DateTime(2022,06,13),
                        new DateTime(2022,11,04)
                    };
                return holidays.Contains(date.Date);
            }
        }
    }
}
