/*Написать программу по обработке двухмерного массива. Размеры массива n, m и значения
элементов массива случайные из промежутка [-10,10].
Вариант 4. Определить произведение элементов в тех строках, которые не содержат отрицательных
элементов.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Prac03
{
    class Program
    {
        static void Main(string[] args)
        {
            //декларация и инициализация массива
            const int n = 10, m = 10;
            double proizv = 1; 
            int count = 0;
            int[,] a = new int[n,m];
            proiz pro = new proiz();
            pro.out_arr(a, n, m);
            pro.out_reshenie(a, n, m, proizv, count);
        }
    }
    public class proiz
    {
        public proiz() {}

        public void out_arr (int[,] arr, int n, int m)
        {
            Random rand = new Random();
            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i < n;  ++i)
            for (int j = 0; j < m; ++j)
            {
                arr[i,j] = rand.Next(-10, 11);
                Console.Write(arr[i,j] + "\t");
            }
            Console.WriteLine();
        }
        public void out_reshenie(int[,] arr, int n, int m, double proizvedenie, int count)
        {
            proizvedenie = 1;
            for (int i = 0; i < n; ++i)
            {
                count = 0;
                for (int j = 0; j < m; ++j)
                {
                    if (arr[i, j] == 0) count++;
                    proizvedenie *= arr[i, j];
                }
                if (count == 0) Console.WriteLine("произведение элементов в строке {0}, в которой не содержится отрицательных элементов = {1}", i, proizvedenie);
            }
        }
    }
}