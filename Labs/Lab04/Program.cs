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
            Random rnd = new Random();
            Console.Write("Введите номер задания: ");
            int p = Convert.ToInt32(Console.ReadLine());
            switch (p)
            {
                case 1:
                {
                    double proizv = 1.0;
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

                    for (int i = null_one + 1; i < null_two; i++)
                    {
                        proizv *= arr[i];
                    }

                    Console.WriteLine($"Произведение: {proizv}");
                    break;
                }
                case 2:
                {
                    int n = 5;
                    int[] arr = new int[n];
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write($"Введите {i+1} элемент массива: ");
                        arr[i] = Convert.ToInt32(Console.ReadLine());
                    }

                    for (int i = 0; i < n; i++)
                    {
                        if ((i % 2 != 0) && arr[i] > 0)
                        {
                            arr[i] = 0;
                        }
                    }

                    foreach (int i in arr)
                    {
                        Console.WriteLine(i);
                    }
                    break;
                }
                case 3:
                {
                    double srednarifm = 0.0;
                    int count = 0;
                    const int SIZE = 5;
                    int[,] arr = new int[SIZE, SIZE];

                    for (int i = 0; i < SIZE; i++)
                    {
                        for (int j = 0; j < SIZE; j++)
                        {
                            arr[i, j] = rnd.Next(0, 100);
                            Console.WriteLine(arr[i, j] + '\t');
                        }
                        Console.WriteLine();
                    }

                    for (int i = 0; i < SIZE; i++)
                    {
                        for (int j = 0; j < SIZE; j++)
                        {
                            if (i + j > SIZE - 1)
                            {
                                srednarifm += arr[i, j];
                                count++;
                            }
                        }
                    }

                    srednarifm = srednarifm / (count);
                    Console.WriteLine($"Среднее арифметическое побочное диагнонаои: {srednarifm} из {count} элементов");
                    break;
                }
                case 4:
                {
                    int count = 0;
                    const int n = 3;
                    int[,] nums = new int[n, n] { { -2, 1, 5 }, { 3, 4, -6 }, { 2, -3, 2 } };
                    int[] nums2 = new int[n*n];

                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            nums2[n * i + j] = nums[i, j];
                            if (nums2[i] > 0)
                            {
                                count++;
                            }
                        }
                    }

                    foreach (int i in nums2)
                    {
                        Console.WriteLine($"{i} \t");
                    }

                    Console.WriteLine($"Количество: {count}");
                    break;
                }
                case 5:
                {
                    int sum = 0;
                    Console.Write("Введите размер массива массивов: ");
                    int SIZE = Convert.ToInt32(Console.ReadLine());
                    int[][] nums = new int[SIZE][];
                    for (int i = 0; i < SIZE; i++)
                    {
                        Console.Write($"Введите размер {i + 1}-го массива: ");
                        int rd = Convert.ToInt32(Console.ReadLine());
                        nums[i] = new int[rd];
                        for (int j = 0; j < rd; j++)
                        {
                            Console.Write($"Введите {j + 1} элемент массива: ");
                            nums[i][j] = Convert.ToInt32(Console.ReadLine());
                            if (i % 2 == 0 && j % 2 == 0)
                            {
                                sum += nums[i][j];
                            }
                        }
                    }
                    foreach(int[] row in nums)
                    {
                        foreach(int number in row)
                        {
                            Console.Write($"{number} \t");
                        }
                        Console.WriteLine();
                    }

                    Console.WriteLine($"Сумма: {sum}");
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