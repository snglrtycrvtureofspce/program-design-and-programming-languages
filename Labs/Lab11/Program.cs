using System;

namespace Lab11
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Введите номер задания: ");
            int p = Convert.ToInt32(Console.ReadLine());
            switch (p)
            {
                case 1:
                    {
                        try
                        {
                            int a = 3, b = 4;
                            Console.Write($"Введите угол между сторонами a ({a}) и b ({b}): ");
                            double s = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine($"Площадь треугольника: {0.5 * a * b * Math.Round(Math.Sin(s), 3)}");
                            break;
                        }
                        catch (OverflowException)
                        {
                            Console.WriteLine("Выходим за границы значения!");
                            break;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Входная строка имеет неверный формат!");
                            break;
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e);
                            throw;
                        }
                    }
                case 2:
                    {
                        try
                        {
                            Random rnd = new Random();
                            Console.Write("Введите размер массива: ");
                            int N = Convert.ToInt32(Console.ReadLine());
                            int K = 0;
                            while (K <= 1 && K <= N)
                            {
                                Console.Write("Введите целое число (1 <= K <= N): ");
                                K = Convert.ToInt32(Console.ReadLine());
                            }

                            var arr = new int[N];
                            Console.WriteLine("Заполняем массив случайнами значениями и индекс K приравниваем к нулю.");
                            for (int i = 0; i < arr.Length; i++)
                            {
                                arr[i] = rnd.Next(0, 50);
                            }

                            arr[K] = 0;
                            for (int i = 0; i < arr.Length; i++)
                            {
                                Console.WriteLine(arr[i]);
                            }
                        }
                        catch (OverflowException)
                        {
                            Console.WriteLine("Выходим за границы значения!");
                            break;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Входная строка имеет неверный формат!");
                            break;
                        }
                        catch (OutOfMemoryException)
                        {
                            Console.WriteLine("Выход из памяти!");
                            break;
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e);
                            break;
                        }
                        break;
                    }
                case 3:
                    {
                        byte n = 1; byte i;
                        try
                        {
                            checked //блок с проверкой
                            {
                                n = 1;
                                for (i = 1; i < 10; i++) n *= i;
                                Console.WriteLine("2: ", n);
                            }
                            unchecked //блок без проверки
                            {
                                for (i = 1; i < 10; i++) n *= i;
                                Console.WriteLine("1: {0}", n);
                            }
                        }
                        catch (OverflowException)
                        {
                            Console.WriteLine("возникло переполнение");
                        }
                        break;
                    }
                case 4:
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            try
                            {
                                Console.WriteLine("Введите два числа");
                                int a = int.Parse(Console.ReadLine());
                                int b = int.Parse(Console.ReadLine());
                                Console.WriteLine(a + "/" + b + "=" + a / b);
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Нужно ввести число!");
                            }
                            catch (DivideByZeroException)
                            {
                                Console.WriteLine("Делить на нуль нельзя!");
                            }
                            catch
                            {
                                Console.WriteLine("Какая-то ошибка");
                            }
                            finally
                            {
                                Console.WriteLine("после try-блока");
                            }
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
