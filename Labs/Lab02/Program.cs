using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    internal class Program
    {
        private static void Main(string[] args)
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
                case 4:
                {
                    try
                    {
                        Console.Write("Введите номер месяца: ");
                        int p_1 = Convert.ToInt32(Console.ReadLine());
                        switch (p_1)
                        {
                            case 12: 
                            case 1:
                            case 2:
                            {
                                Console.WriteLine("Зима");
                                break;
                            }
                            case 3:
                            case 4:
                            case 5:
                            {
                                Console.WriteLine("Весна");
                                break;
                            }
                            case 6:
                            case 7:
                            case 8:
                            {
                                Console.WriteLine("Лето");
                                break;
                            }
                            case 9:
                            case 10:
                            case 11:
                            {
                                Console.WriteLine("Осень");
                                break;
                            }
                            default:
                            {
                                Console.WriteLine("Exit...");
                                break;
                            }
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
                case 5:
                {
                    try
                    {
                        double y = 0;
                        Console.Write("Введите x: ");
                        int x = Convert.ToInt32(Console.ReadLine());
                        Console.Write("1) a=4.2; b=0.5; z=e^ax" +
                                      "\n2) a-0.15; b=0.2; z=e^2ax" +
                                      "\n3) a=0.9; b=5; z=e^e2.5ax" +
                                      "\nВыберите функцию: ");
                        int p_2 = Convert.ToInt32(Console.ReadLine());
                        switch (p_2)
                        {
                            case 1:
                            {
                                double a = 4.2, b = 5.3, c = 1.5;
                                if (Math.Exp(a + b) > Math.Exp(x))
                                {
                                    y = Math.Sin(Math.Exp(a + b)) + Math.Pow(x, 2);
                                }
                                else if (Math.Exp(a + b) == Math.Exp(x))
                                {
                                    y = Math.Atan(a * b * c) + Math.Pow(x, 1.0 / 3);
                                }
                                else if (Math.Exp(a + b) < Math.Exp(x))
                                {
                                    y = Math.Cos(Math.Sqrt(Math.Abs(x + (a * b * c))));
                                }
                                y = Math.Round(y, 3);
                                Console.WriteLine($"Ответ: {y}");
                                break;
                            }
                            case 2:
                            {
                                double a = -0.35, b = 1.8, c = -1.8;
                                if (Math.Exp(a + b) > Math.Exp(x))
                                {
                                    y = Math.Sin(Math.Exp(a + b)) + Math.Pow(x, 2);
                                }
                                else if (Math.Exp(a + b) == Math.Exp(x))
                                {
                                    y = Math.Atan(a * b * c) + Math.Pow(x, 1.0 / 3);
                                }
                                else if (Math.Exp(a + b) < Math.Exp(x))
                                {
                                    y = Math.Cos(Math.Sqrt(Math.Abs(x + (a * b * c))));
                                }
                                y = Math.Round(y, 3);
                                Console.WriteLine($"Ответ: {y}");
                                break;
                            }
                            case 3:
                            {
                                double a = 2.8, b = -0.6, c = 2.0;
                                if (Math.Exp(a + b) > Math.Exp(x))
                                {
                                    y = Math.Sin(Math.Exp(a + b)) + Math.Pow(x, 2);
                                }
                                else if (Math.Exp(a + b) == Math.Exp(x))
                                {
                                    y = Math.Atan(a * b * c) + Math.Pow(x, 1.0 / 3);
                                }
                                else if (Math.Exp(a + b) < Math.Exp(x))
                                {
                                    y = Math.Cos(Math.Sqrt(Math.Abs(x + (a * b * c))));
                                }
                                y = Math.Round(y, 3);
                                Console.WriteLine($"Ответ: {y}");
                                break;
                            }
                            default:
                            {
                                Console.WriteLine("Exit...");
                                break;
                            }
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
                case 6:
                {
                    try
                    {
                        Console.Write("1 - Новогодние" +
                                      "\n2 - С Днём рождения" +
                                      "\n3 - С Днём Защитника Отечества" +
                                      "\nВведите номер темы: ");
                        int p_2 = Convert.ToInt32(Console.ReadLine());
                        switch (p_2)
                        {
                            case 1:
                            {
                                Console.Write("Выберите вариант (a, b, c): ");
                                string num = Console.ReadLine();
                                if (num == "a")
                                {
                                    Console.WriteLine("Новогодние, вариант a");
                                }
                                else if (num == "b")
                                {
                                    Console.WriteLine("Новогодние, вариант b");
                                }
                                else if (num == "c")
                                {
                                    Console.WriteLine("Новогодние, вариант c");
                                }
                                else
                                {
                                    Console.WriteLine("Неверный вариант");
                                    break;
                                }
                                Console.Write("Введите купюру оплаты (5, 10, 20): ");
                                int money = Convert.ToInt32(Console.ReadLine());
                                if (money == 5)
                                {
                                    Console.WriteLine("Ваша сдача: 5гр");
                                }
                                else if (money == 10)
                                {
                                    Console.WriteLine("Ваша сдача: 5гр+5гр");
                                }
                                else if (money == 20)
                                {
                                    Console.WriteLine("Ваша сдача: 10гр+10гр");
                                }
                                else
                                {
                                    Console.WriteLine("Неверная купюра!");
                                }
                                break;
                            }
                            case 2:
                            {
                                Console.Write("Выберите вариант (a, b, c):");
                                string num = Console.ReadLine();
                                if (num == "a")
                                {
                                    Console.WriteLine("С Днём Рождения, вариант a");
                                }
                                else if (num == "b")
                                {
                                    Console.WriteLine("С Днём Рождения, вариант b");
                                }
                                else if (num == "c")
                                {
                                    Console.WriteLine("С Днём Рождения, вариант c");
                                }
                                else
                                {
                                    Console.WriteLine("Неверный вариант");
                                    break;
                                }
                                Console.Write("Введите купюру оплаты (5, 10, 20): ");
                                int money = Convert.ToInt32(Console.ReadLine());
                                if (money == 5)
                                {
                                    Console.WriteLine("Ваша сдача: 5гр");
                                }
                                else if (money == 10)
                                {
                                    Console.WriteLine("Ваша сдача: 5гр+5гр");
                                }
                                else if (money == 20)
                                {
                                    Console.WriteLine("Ваша сдача: 10гр+10гр");
                                }
                                else
                                {
                                    Console.WriteLine("Неверная купюра!");
                                }
                                break;
                            }
                            case 3:
                            {
                                Console.Write("Выберите вариант (a, b, c):");
                                string num = Console.ReadLine();
                                if (num == "a")
                                {
                                    Console.WriteLine("С Днём Защитника Отечества, вариант a");
                                }
                                else if (num == "b")
                                {
                                    Console.WriteLine("С Днём Защитника Отечества, вариант b");
                                }
                                else if (num == "c")
                                {
                                    Console.WriteLine("С Днём Защитника Отечества, вариант c");
                                }
                                else
                                {
                                    Console.WriteLine("Неверный вариант");
                                    break;
                                }
                                Console.Write("Введите купюру оплаты (5, 10, 20): ");
                                int money = Convert.ToInt32(Console.ReadLine());
                                if (money == 5)
                                {
                                    Console.WriteLine("Ваша сдача: 5гр");
                                }
                                else if (money == 10)
                                {
                                    Console.WriteLine("Ваша сдача: 5гр+5гр");
                                }
                                else if (money == 20)
                                {
                                    Console.WriteLine("Ваша сдача: 10гр+10гр");
                                }
                                else
                                {
                                    Console.WriteLine("Неверная купюра!");
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