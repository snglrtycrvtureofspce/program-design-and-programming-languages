using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab03
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.Write("Введите номер задания: ");
            int p = Convert.ToInt32(Console.ReadLine());
            switch (p)
            {
                case 1:
                {
                    int i = 1, sum = 0;
                    Console.Write("Введите N(максимальное число):");
                    int n = Convert.ToInt32(Console.ReadLine());
                    while (i <= n)
                    {
                        if ((i%5 != 0) && (i % 3 == 0))
                        {
                            Console.WriteLine($"Число которое не кратно пяти и кратно трём: {i}");  
                            sum += i;
                        }
                        i++;
                    }
                    Console.WriteLine($"Сумма: {sum}");
                    break;
                }
                case 2:
                {
                    int i=100;
                    do
                    {
                        Console.WriteLine(i);
                            
                        i += 200;
                    } while (i < 800);
                    break;
                }
                case 3:
                {
                    int s = 0;
                    string q = default, r = default;
                    for (int i = 1; i < 100; i++)
                        if ((q = (i * i).ToString()) == (r = new string(q.Reverse().ToArray())))
                            Console.WriteLine($"palindrome {++p} q={q} == r={r}"); ;
                    Console.WriteLine($"total: {s}");
                    break;
                }
                case 4:
                {
                    Console.Write("Введите x: ");
                    int x = Convert.ToInt32(Console.ReadLine());
                    int N = -1;
                    do
                    {
                        Console.Write("Введите N (N > 0): ");
                        N = Convert.ToInt32(Console.ReadLine());
                    } while (N < 0);
                    double t = Math.Cos(x);
                    double sum = t;
                    for (int i = 1; i < N; i++)
                    {
                        t = t * x * x / i;
                        sum += t * (2 * i + 1);
                    }
                    Console.WriteLine($"Сумма: {sum}");
                    break;
                }
                case 5:
                {
                    for (double i = 0.1; i <= 2.2; i+= .2)
                    {
                        Console.WriteLine($"x = {i}\ny = {f(i)}");
                    }
                    double f(double x)
                    {
                        return Math.Pow(x, 2) - Math.Pow(Math.Cos(x + 1), 2);
                    }
                    break;
                }
                case 6:
                {
                    for (double i = -2; i <= 3; i+= .2)
                    {
                        Console.WriteLine($"x = {i}\ny = {f(i)}");
                    }
                    double f(double x)
                    {
                        if (x > 1.5)
                        {
                            return Math.Pow(2.5, 3) + 6 * Math.Pow(x, 2) - 30;
                        }
                        else if (0 <= x && 0 <= 1.5)
                        {
                            return x + 1;
                        }
                        else if (x < 0)
                        {
                            return x;
                        }
                        return 0;
                    }
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
