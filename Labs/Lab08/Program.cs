using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08
{
    internal class Program
    {
        static void Main(string[] args)
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
                default:
                {
                    Console.WriteLine("Exit...");
                    break;
                }
            }
        }
    }
}
