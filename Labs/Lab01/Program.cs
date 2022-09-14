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
            Console.Write("Введите номер задания: ");
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
                    Console.Write("Введите сторону a: ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите сторону b: ");
                    int b = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите сторону c: ");
                    int c = Convert.ToInt32(Console.ReadLine());
                    int v = a * b * c; // объём прямоугольного параллелепипеда
                    int s = a * b; // площадь основания прямоугольного параллелепипеда
                    Console.WriteLine($"Объём: {v}\nПлощадь основания: {s}");
                    break;
                }
                case 3:
                {
                    int num = 0;
                    do
                    {
                        Console.Write("Введите четырёхзначное число: ");
                        num = Convert.ToInt32(Console.ReadLine());
                        if (num < 999 || num > 9999)
                        {
                            Console.Clear();
                            Console.WriteLine("Введите четырёхзначное число!");
                        }
                    } while (num < 999 || num > 9999);
                    int a = num % 10;
                    int b = num % 100 / 10;
                    int c = num % 1000 / 100;
                    int d = num % 10000 / 1000;
                    Console.WriteLine($"Число наоборот: {a}{b}{c}{d}");
                    break;
                }
                case 4:
                {
                    Console.Write("Введите массу глины: ");
                    int x = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите массу гипса: ");
                    int y = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите массу песка: ");
                    int z = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите массу смеси: ");
                    int k = Convert.ToInt32(Console.ReadLine());
                    int num = (x + y + z) / k;
                    Console.WriteLine($"Песка нужно: {num}");
                    break;
                }
                case 5:
                {
                    Console.Write("Введите сторону a: ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите сторону b: ");
                    int b = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите сторону c: ");
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
