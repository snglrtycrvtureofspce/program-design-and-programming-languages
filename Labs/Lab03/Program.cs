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
        static void Main(string[] args)
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
                    int a, i = 100;
                    while (i <= 700)
                    {
                        a = i / 100;
                        if (a % 2 != 0)
                        {
                            Console.WriteLine(i);
                        }
                        i++;
                    }
                    break;
                }
                case 3:
                {

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
