using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер: ");
            int p = Convert.ToInt32(Console.ReadLine());
            switch (p)
            {
                case 1:
                {
                    Triangle a = new Triangle(3, 4, 5);
                    Console.WriteLine("Треугольник: \n" + a.display_into());
                    Console.WriteLine($"Является ли треугольником? - {a.isTriangle()}");
                    Console.WriteLine($"Периметр: {a.Perimeter()}");
                    Console.WriteLine($"Площадь: {a.Area(3)}");
                    a.Set_a(4);
                    Console.WriteLine($"Первая сторона заменена на {a.Get_a()}");
                    a.Set_b(7);
                    Console.WriteLine($"Вторая сторона заменена на {a.Get_b()}");
                    Console.WriteLine($"Треугольник изменён: \n{a.display_into()}");
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
