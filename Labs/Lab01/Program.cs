using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter job number: ");
            int p = Convert.ToInt32(Console.ReadLine());
            switch (p)
            {
                case 1:
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.Clear();
                    Console.WriteLine("Нет ничего удивительного, что из подобных дебатов родились и" +
                                      "\r\nматериалы для публикаций, попавшие в форме писем в газету 'Эркхем" +
                                      "\r\nЭдвертайзер'; некоторые из них перепечатывали газеты, издававшиеся в тех" +
                                      "\r\nрайонах Вермонта, откуда пришли загадочные истории о наводнении." +
                                      "\r\nТак, 'Ратлэнд Геральд' уделила половину страницы выдержкам из этих писем, а" +
                                      "\r\n'Брэттлборо Реформер'; полностью перепечатала один из моих обширных" +
                                      "\r\nисторических и мифологических комментариев, сопроводив их собственными" +
                                      "\r\nсуждениями в колонке ';Свободное Перо', где выразила восхищение моими" +
                                      "\r\nскептическими умозаключениями и полностью их поддержала. К весне 1928 года" +
                                      "\r\nя стал широко известной фигурой в Вермонте, хотя ни разу не бывал в этом" +
                                      "\r\nштате. И вот тут-то получил я письма от Генри Эйкели, которые произвели" +
                                      "\r\nна меня столь сильное впечатление, что раз и навсегда приковали мое внимание" +
                                      "\r\nк пленительному краю теснящихся зеленых склонов и журчащих лесных ручьев»");
                        break;
                }
                case 2:
                {
                    Console.Write("Enter a: ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter b: ");
                    int b = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter c: ");
                    int c = Convert.ToInt32(Console.ReadLine());
                    int v = a * b * c; // объём прямоугольного параллелепипеда
                    int s = a * b; // площадь основания прямоугольного параллелепипеда
                    Console.WriteLine($"Объём: {v}\nПлощадь основания: {s}");
                    break;
                }
                case 5:
                {
                    Console.Write("Enter a: ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter b: ");
                    int b = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter c: ");
                    int c = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(a * b == b * c ? "Треугольник равнобедренный" : "Треугольник не равнобедренный");
                    break;
                }
                default:
                {
                    Console.WriteLine("Exit...");
                    break;
                }
            }
            
        }
    }
}
