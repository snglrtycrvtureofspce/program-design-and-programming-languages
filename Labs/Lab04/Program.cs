using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
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
                    double proizv = 0.0;
                    int null_one = 0, null_two = 0;
                    int[] arr = new int[] { 23, -2, 4, 785, 89, 0, 14, 214, 64, 0, 32, 56, 87, 11, 0, 23, 55 };
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (arr[i] == 0)
                        {
                            null_one = i;
                            break;
                        }
                    }

                    for (int i = null_one + 1; i < arr.Length; i++)
                    {
                        if (arr[i] == 0)
                        {
                            null_two = i;
                            break;
                        }
                    }

                    if (null_two != 0)
                    {
                        for (int i = null_one + 1; i < null_two; i++)
                        {
                            proizv *= arr[i];
                        }
                    }

                    Console.WriteLine($"Произведение: {proizv}");
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