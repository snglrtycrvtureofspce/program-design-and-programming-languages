using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Y_x, a = -2, b = 0.8, h = 0.2;
            fun(a, b, h);
        }

        static void fun(double a, double b, double h)
        {
            double Y_x;
            for (double x = a; x < b; x += h)
            {
                Y_x = (x * Math.Cos(Math.PI / 4) - Math.Pow(x, 2)) /
                    1 - 2 * x * Math.Cos(Math.PI / 4) + Math.Pow(x, 2);
                Console.WriteLine("x = " + x + "\tY(x) = " + Y_x);
            }
        }
    }
}
