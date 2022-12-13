using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    internal class Program
    {
        public delegate double MathFunctionHandler(double arg);

        static void ShowCalculations(MathFunctionHandler func, double from, double to, double step)
        {
            for ( ; from < to; from += step)
            {
                Console.WriteLine(func(from));
            }
        }

        private static void Main(string[] args)
        {
            Console.WriteLine("Cos(x) и Sin(x):");
            ShowCalculations(Math.Cos, -3d, -1d, 0.5);
            ShowCalculations(Math.Sin, -3d, -1d, 0.5);
        }
    }
}
