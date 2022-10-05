using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theme_4
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.Write("Введите номер задания: ");
            int p = Convert.ToInt32(Console.ReadLine());
            switch (p)
            {
                case 1:
                {
                    int x = 1;
                    Increment(ref x);
                    Console.WriteLine(x);
                    break;
                }
                case 2:
                {
                    int i = 0;
                    Console.Write(i++ + Calculate(i));
                    Console.WriteLine(i);
                    break;
                }
                case 3:
                {
                    Display();
                    Display(1);
                    Display(1, 2);
                    Display(1, 2, 3);
                    Display(new int[]{1, 2,3 ,4, 5});
                    break;
                }
                case 4:
                {
                    Display_2(new int[]{1, 2, 3, 4, 5});
                    break;
                }
                case 5:
                {
                    int result = Sum(10, 15);
                    Console.WriteLine(result);
                    break;
                }
                case 6:
                {
                    int a = 25;
                    int b = 35;
                    int result = Sum(a, b);
                    Console.WriteLine(result); // ?
                    result = Sum(b, 45);
                    Console.WriteLine(result); // ?
                    result = Sum(a + b + 12, 18);
                    Console.WriteLine(result); // ?
                    break;
                }
                case 7:
                {
                    Console.WriteLine(OptionalParam(2, 3));
                    Console.WriteLine(OptionalParam(2, 3, 10));
                    break;
                }
                case 8:
                {
                    Console.WriteLine(OptionalParam_2(x:2, y:3)); //?
                    OptionalParam_2(y:2, x:3, s:10);//?
                    break;
                }
                default:
                {
                    Console.WriteLine("Exit...");
                    return;
                }
            }
            
        }

        static void Increment(ref int x) // 1

        {
            x++;
        }

        public static int Calculate(int i) // 2

        {
            Console.Write(i++);
            return i;
        }
        static void Display(params int[ ] numbers) // 3

        {
            int result = 0;
            for (int i = 0; i < numbers.Length; i++)

            {
                result += numbers[i];
            }
            Console.WriteLine(result);
        }
        static void Display_2(int[ ] numbers) // 4

        {
            int result = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                result += numbers[i];
            }
            Console.WriteLine(result);
        }
        static int Sum(int x, int y)

        {
            return x + y;
        }
        static int OptionalParam(int x, int y, int z=5, int s=4)
        {
            return x + y + z + s;
        }
        static int OptionalParam_2(int x, int y, int z=5, int s=4)

        {

            return x + y + z + s;

        }
    }
}
