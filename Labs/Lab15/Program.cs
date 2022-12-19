using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15
{
    public class Calculatator
    {
        public delegate int Operation (int x, int y);
        public static Operation Add = (x, y) => x + y;
        public static Operation Sub = (x, y) => x - y;
        public static Operation Mul = (x, y) => x * y;
        public static Operation Div = (x, y) => x / y;
    }
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Введите номер задания: ");
            var p = Convert.ToInt32(Console.ReadLine());
            switch (p)
            {
                case 1:
                {
                    var clc = new Calculatator();
                    Console.Write("Введите первое число: ");
                    var num = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите второе число: ");
                    var num2 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("1 - Сложение" +
                                      "\n2 - Вычитание" +
                                      "\n3 - Умножение" +
                                      "\n4 - Деление" +
                                      "\n0 - Выход" +
                                      "\nВыберите действие над ними: ");
                    var choice = Convert.ToInt32(Console.ReadLine());
                    if (choice == 0)
                    {
                        break;
                    }
                    else switch (choice)
                    {
                        case 1:
                            Console.WriteLine($"Результат ({num}+{num2}): {Calculatator.Add(num, num2)}");
                            break;
                        case 2:
                            Console.WriteLine($"Результат ({num}-{num2}): {Calculatator.Sub(num, num2)}");
                            break;
                        case 3:
                            Console.WriteLine($"Результат ({num}*{num2}): {Calculatator.Mul(num, num2)}");
                            break;
                        case 4:
                            Console.WriteLine($"Результат ({num}/{num2}): {Calculatator.Div(num, num2)}");
                            break;
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
