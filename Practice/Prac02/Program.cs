
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            try
            {
                int sum = 0;
                const int n = 5;
                int[,] nums = new int[n, n];
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        nums[i, j] = rnd.Next(-10, 100);
                        
                    }
                }
                for (int j = 0; j < n; j++)
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (nums[i, j] < 0)
                        {
                            sum = 0;
                            break;
                        }
                        else
                        {
                            sum += nums[i, j];
                        }
                    }
                }
                int d = 0;
                foreach (int s in nums)
                {
                    Console.Write(s + " ");
                    d++;
                    if (d % n == 0)
                    {
                        Console.WriteLine();
                        d = 0;
                    }
                }
                if (sum != 0)
                {
                    Console.WriteLine($"Сумма столбцов без отрицательных элементов: {sum}");
                }
                Console.WriteLine("________________________________________________________________________");
                double min = .0;
                double minimum = .0;
                int k = 0;
                int c = n - 2;
                int h = 1;
                for (h = 1; h < n; h++)
                {
                    while (c != -n)
                    {
                        min += Math.Abs(nums[k, c]);
                        Console.WriteLine(nums[k, c] + '\t');
                        k++;
                        c--;
                        if (k == n - 1 || c == - 1)
                        {
                            if (minimum == 0) minimum = min;
                            else if (min < minimum) minimum = min;
                            Console.WriteLine($"|{min}| \n");
                            min = 0;
                            k = 0;
                            c = n - 2 - h;
                            break;
                        }
                    }
                }

                Console.WriteLine("\n");
                k = 1;
                c = n - 1;
                h = 1;
                for (h = 1; h < n; h++)
                {
                    while (k != n)
                    {
                        min += Math.Abs(nums[k, c]);
                        Console.WriteLine(nums[k, c] + '\t');
                        k++;
                        c--;
                        if (k == n || c == n)
                        {
                            if (minimum == 0) minimum = min;
                            else if (min < minimum) minimum = min;
                            Console.WriteLine($"|{min}| \n");
                            min = 0;
                            k = h + 1;
                            c = n - 1;
                            break;
                        }
                    }
                }
                Array.Clear(nums, 0, n*n);
                Console.WriteLine($"\n\n Minimum: {minimum} \n\n");
                ////////////
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return;
            }
        }
    }
}
