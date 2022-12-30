using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Введите номер: ");
            var p = Convert.ToInt32(Console.ReadLine());
            switch (p)
            {
                case 1:
                {
                    Shar shr = new Shar(3);
                    Console.WriteLine(shr.Area());
                    Console.WriteLine(shr.Volume());
                    break;
                }
                case 2:
                {
                    EightNumber enm = new EightNumber("24252");
                    Console.WriteLine("Цифра по индексу три равна " + enm[3]);
                    Console.WriteLine("Преобразование в десятичное число: " + enm.ToInt());
                    break;
                }
                case 3:
                {
                    DemoArray Mas = new DemoArray(1, -4, 3, -5, 0); 
                    Mas.Print("Исходный массив");
                    Console.WriteLine("\nУнарный плюс");
                    DemoArray newMas=+Mas;
                    Mas.Print("Mассив Mas");
                    newMas.Print("Массив newMas");
                    Console.WriteLine("\nОперация префиксного декремента");
                    Mas.Print("Mассив Mas");
                    DemoArray newMass=--Mas;
                    newMass.Print("Mассив newMas");
                    Console.WriteLine("\nОперация бинарного минуса");
                    Mas.Print("Mассив Mas");
                    newMass = newMass - 2;
                    newMass.Print("Массив newMas");
                    Console.WriteLine();
                    Console.Write("Похожие массивы: ");
                    if (newMas & newMass)
                    {
                        Console.WriteLine("Да");
                    }
                    else
                    {
                        Console.WriteLine("Нет");
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
    }
}
