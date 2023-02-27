using System;
using System.Threading.Tasks;

namespace Lab22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m = 100, n = 50, k = 200;
            int[,] A = new int[m, n];
            int[,] B = new int[n, k];
            int[,] C = new int[m, k];

            var rndRandom = new Random();
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    A[i, j] = rndRandom.Next(10);
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    B[i, j] = rndRandom.Next(10);
                }
            }

            Parallel.For(0, m, i =>
            {
                for (int j = 0; j < k; j++)
                {
                    int sum = 0;
                    for (int l = 0; l < n; l++)
                    {
                        sum += A[i, l] * B[l, j];
                    }
                    C[i, j] = sum;
                }
            });

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    Console.Write(C[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
