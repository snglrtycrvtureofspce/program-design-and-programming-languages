using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab16_dll;

namespace Lab16
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("-------Объект 1-------");
            var triangle = new Triangle
            {
                A = 2.4,
                B = 3.6,
                C = 5.0
            };
            Console.WriteLine(triangle.ToString());
            Console.WriteLine("-------Объект 2-------");
            var triangle2 = new Triangle(2.9, 2.6, 3.2);
            Console.WriteLine($"Стороны: A - {triangle2.A}; B - {triangle2.B}; C - {triangle2.C}" +
                              $"\nПериметр: {triangle2.Perimeter()}" +
                              $"\nПлощадь: {triangle2.Square()}");
            Console.WriteLine("-------Объект 3-------");
            var triangle3 = new Triangle(4.2, 1, 3.1);
        }
    }
}
