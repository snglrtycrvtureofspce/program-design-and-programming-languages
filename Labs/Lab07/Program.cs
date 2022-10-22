using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер: ");
            int p = Convert.ToInt32(Console.ReadLine());
            switch (p)
            {
                case 1:
                {
                    string s = "33-358-94-89";
                    Regex regex = new Regex(@"[0-9]{2}-[0-9]{3}-[0-9]{2}-[0-9]{2}");
                    Console.WriteLine(regex.IsMatch(s));
                    break;
                }
                case 2:
                {
                    string s = "9339AE-7";
                    Regex regex = new Regex("[0-9]{4}[A-Z]{2}-[7]{1}");
                    Console.WriteLine(regex.IsMatch(s));
                    break;
                }
                case 3:
                {
                    string s = "20.10.2022";
                    Regex regex = new Regex("[0-9]{2}.[0-9]{2}.[0-9]{4}");
                    Console.WriteLine(regex.IsMatch(s));
                    break;
                }
                case 4:
                {
                    string s = "12.24";
                    string s2 = "14:32";
                    Regex regex = new Regex(@"[0-9]{2}(.|:)[0-9]{2}");
                    Console.WriteLine(regex.IsMatch(s));
                    Console.WriteLine(regex.IsMatch(s2));
                    break;
                }
                case 5:
                {
                    string s = "12";
                    Regex regex = new Regex("^(\\d|[1-9]\\d|100)$");
                    Console.WriteLine(regex.IsMatch(s));
                    break;
                }
                case 6:
                {
                    string s = "22.2";
                    Regex regex = new Regex("^[0-9]*[.,][0-9]+$");
                    Console.WriteLine(regex.IsMatch(s));
                    break;
                }
                case 7:
                {
                    string str = "123-321-1 пук п3кп4353е3е3 32-42-23 gjkfds 23 dkfgmek 243-12-42 dfkdgjwner dd 243-124-53 dfgswd 442-462" + "\n";
                    Console.WriteLine($"Сообщение: {str}");
                    var result = Regex.Matches(str, @"(?<= )\d{2,3}-\d{2}-\d{2}|\d{3}-\d{3}(?= )");
                    Console.WriteLine("Номера телефонов:");
                    foreach(var item in result)
                    {
                        Console.WriteLine(item);
                    }
                    break;
                }
                case 8:
                {
                    var text = "Встреча состоится в 1:15.";
                    Console.WriteLine(text);
                    Console.WriteLine("Сорян. "+ReplaceTime("Встреча состоиться в 1:15", 65));
                    break;
                }
                default:
                {
                    Console.WriteLine("Exit...");
                    break;
                }
            }
        }
        private static string ReplaceTime(string sentence, int minutes)
        {
            var templ = @"\d{1,3}:\d{1,3}";
            var results = Regex.Matches(sentence, templ);
            for (var i = 0; i < results.Count; i++)
            {
                var hhss = results[i].Value.Split(':');
                var hh = Convert.ToInt32(hhss[0]);
                var mm = Convert.ToInt32(hhss[1]);
                if (hh >= 0 && hh < 24 && mm >= 0 && mm < 60)
                {
                    var time = new TimeSpan(hh, mm, 0).Add(new TimeSpan(00, 65, 0));
                    sentence = Regex.Replace(sentence, templ, time.ToString(@"hh\:mm"));
                }
            }
            return sentence;
        }
    }
}