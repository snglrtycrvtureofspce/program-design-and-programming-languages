using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double bmi_mass (double height, double weight)
            {
                return Math.Round((weight / Math.Pow((height / 100), 2)), 2);
            }
            Console.Write("Введите номер задания: ");
            int p = Convert.ToInt32(Console.ReadLine());
            switch (p)
            {
                case 1:
                {
                    try
                    {
                        Console.Write("Введите первое число: ");
                        double a = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Введите второе число: ");
                        double b = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Введите третье число: ");
                        double c = Convert.ToInt32(Console.ReadLine());
                        if (a > 0)
                        {
                            a = Math.Pow(a, 2);
                        }

                        if (b > 0)
                        {
                            b = Math.Pow(b, 2);
                        }

                        if (c > 0)
                        {
                            c = Math.Pow(c, 2);
                        }

                        Console.Clear();
                        Console.WriteLine($"Ваши числа: {a};{b};{c}");
                    }
                    catch (Exception e)
                    {
                        Console.Clear();
                        Console.WriteLine("Что-то пошло не так!\n" + e.Message);
                        break;
                    }
                    break;
                }
                case 2:
                {
                    try
                    {
                        Console.Write("Введите свой рост: ");
                        double height = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Введите свой вес: ");
                        double weight = Convert.ToInt32(Console.ReadLine());
                        double bmi = bmi_mass(height, weight);
                        Console.Clear();
                        Console.WriteLine($"Ваш имт: {bmi}");
                        if (bmi < 16)
                        {
                            Console.WriteLine("У вас выраженный дефицит массы тела!");
                            Console.WriteLine("Вам потребуется питаться больше");
                        }
                        else if (bmi >= 16 && bmi <= 18.49)
                        {
                            Console.WriteLine("У вас недостаточная масса тела!");
                            Console.WriteLine("Вам потребуется питаться больше");
                        }
                        else if (bmi >= 18.5 && bmi <= 24.9)
                        {
                            Console.WriteLine("У вас нормальная масса тела, держите такую же планку!");
                        }
                        else if (bmi >= 25 && bmi <= 29.9)
                        {
                            Console.WriteLine("У вас избыточная масса тела (предожирение)!");
                            Console.WriteLine("Вам потребуется сесть на диету!");
                        }
                        else if (bmi >= 30 && bmi <= 34.99)
                        {
                            Console.WriteLine("У вас ожирение 1-ой степени!");
                            Console.WriteLine("Вам потребуется сесть на диету!");
                        }
                        else if (bmi >= 35 && bmi <= 39.99)
                        {
                            Console.WriteLine("У вас ожирение 2-ой степени!");
                            Console.WriteLine("Вам потребуется сесть на диету!");
                        }
                        else if (bmi >= 40)
                        {
                            Console.WriteLine("У вас ожирение 3-ой степени!");
                            Console.WriteLine("Вам потребуется сесть на диету!");
                        }
                    }
                    catch (Exception e)
                    {
                        Console.Clear();
                        Console.WriteLine("Что-то пошло не так!\n" + e.Message);
                        break;
                    }
                    break;
                }
                case 3:
                {
                    try
                    {
                        int[] ari = new int[4];
                        String s, s1;
                        Console.Write("Введите число: ");
                        s = Convert.ToString(Console.ReadLine());
                        for (int i = 0; i < 4; i++)
                        {
                            s1 = s.Substring(i, 1);
                            ari[i] = int.Parse(s1);
                        }

                        if (ari[0] == ari[3] && (ari[1] == ari[2]))
                        {
                            Console.WriteLine("Число является палиндромом!");
                        }
                        else
                        {
                            Console.WriteLine("Число не вляется палиндромом!");
                        }
                    }
                    catch (Exception e)
                    {
                        Console.Clear();
                        Console.WriteLine("Что-то пошло не так!\n" + e.Message);
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