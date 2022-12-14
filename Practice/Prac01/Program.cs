using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Prac01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            try
            {
                Console.Write("Введите размер массива: ");
                int n = Convert.ToInt32(Console.ReadLine());
                int[] arr = new int[n];
                int d = 0;
                for (int i = 0; i < n; i++)
                {
                    arr[i] = rnd.Next(-100, 100);
                }
                foreach (int s in arr)
                {
                    Console.Write(s + " ");
                    d++;
                    if (d % n == 0)
                    {
                        Console.WriteLine();
                        d = 0;
                    }
                }
                Console.Write("1 - максимальный элемент массива;\n2 - сумма элементов массива, " +
                              "расположенных до последнего положительного элемента;\n3 - сжать массив, " +
                              "удалив из него все элементы, модуль которых находится в интервале [a, b]. " +
                              "Освободившееся в конце массива элементы заполняются нулями." +
                              "\nВведите номер действия: ");
                int p = Convert.ToInt32(Console.ReadLine());
                switch (p)
                {
                    case 1:
                    {
                        int max = arr[0];
                        for (int i = 0; i < n; i++)
                        {
                            if (arr[i] > max)
                            {
                                max = arr[i];
                            }
                        }
                        Console.WriteLine($"Ответ: {max}");
                        break;
                    }
                    case 2:
                    {
                        int sum = 0, k = 0;
                        for (int i = 0; i < k; i++)
                        { 
                            if (arr[i] > 0)
                            {
                                k = i;
                            }
                        }

                        for (int i = 0; i < n; i++)
                        {
                            sum += arr[i];
                        }
                        Console.WriteLine($"Ответ: {sum}");
                        break;
                    }
                    case 3:
                    {
                        Console.Write("Введите A: ");
                        int A = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Введите B: ");
                        int B = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0, j = 0; i < n; i++)
                        {
                            if (A <= Math.Abs(arr[i]) && Math.Abs(arr[i]) <= B)
                            {
                                for (j = i; j < n - 1; j++)
                                {
                                    arr[j] = arr[j + 1];
                                }
                                arr[j] = 0;
                            }
                        }

                        foreach (int s in arr)
                        {
                            Console.Write(s + " ");
                            d++;
                            if (d % n == 0)
                            {
                                Console.WriteLine();
                                d = 0;
                            }
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
            catch (Exception e)
            {
                Console.WriteLine(e);
                return;
            }
        }
    }
}
