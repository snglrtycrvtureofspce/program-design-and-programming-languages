using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lab06
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Введите номер: ");
            int p = Convert.ToInt32(Console.ReadLine());
            switch (p)
            {
                case 1:
                {
                    char[] z = { 't', 'e', 's', 't'};
                    string x = "test";
                    string a = new string(z);
                    string b = x;
                    StringBuilder Builder = new StringBuilder("test");
                    Console.WriteLine($"строка номер 1 {a}");
                    Console.WriteLine($"строка номер 2 {b}");
                    Console.WriteLine($"строка номер 3 {Builder}");
                    break;
                }
                case 2:
                {
                    char[] a = { 'm', 'a', 'X', 'i', 'M', 'u', 'S', '!', '!', '!' };
                    char[] b = "кол около колокола".ToCharArray();
                    PrintArray("Исходный массив a: ", a);
                    for (int x = 0; x < a.Length; x++)
                        if (char.IsLower(a[x])) a[x] = char.ToUpper(a[x]);
                    PrintArray("Изменный массив а:", a);
                    Counter("Кол-во знаков ", a);
                    PrintArray("Изменный массив b:", b);
                    Array.Reverse(b);
                    PrintArray("Изменный массив b:", b);
                    break;
                }
                case 3:
                {
                    string poesms = "тучки небесные вечные странники";
                    char[] div = {' '};
                    string[] parts = poesms.Split(div);
                    Console.WriteLine("Результат разбиеныя строки на части: ");
                    for (int i = parts.Length-1; i >= 0; i--)
                    {
                        Console.WriteLine(parts[i]);
                    }
                    string whole = String.Join("|", parts);
                    Console.WriteLine("Результат сборки: ");
                    Console.WriteLine(whole);
                    break;
                }
                case 4:
                {
                    string poems = "Тучки небесные, вечные странники...";
                    char[] div = {' '};
                    string[] parts = poems.Split(div);
                    Console.WriteLine("Результат разбиения строки на части:");
                    for(int i = 0; i < parts.Length; i++)
                        Console.WriteLine(parts[i]);
                    string whole = String.Join("|", parts);
                    Console.WriteLine("Результат сборки: ");
                    Console.WriteLine(whole);
                    break;
                }
                case 5:
                {
                    try
                    {
                        int[][] MyArray;
                        Console.Write("Введите количество строк: ");
                        string line = Console.ReadLine();
                        int n = int.Parse(line.Trim());
                        MyArray = new int[n][];
                        for (int i = 0; i < MyArray.Length; i++)
                        {
                            line = Console.ReadLine();
                            line = line.Trim();
                            n = line.IndexOf(' ');
                            while (n > 0)
                            {
                                line = line.Remove(n, 1);
                                n = line.IndexOf(" ");
                            }
                            string[] mas = line.Split(' ');
                            MyArray[i] = new int[mas.Length];
                            for (int j = 0; j < MyArray[i].Length; j++)
                            {
                                MyArray[i][j] = int.Parse(mas[i]);
                            }
                        }
                        PrintArray("Исходный массив", MyArray);
                        for (int i = 0; i < MyArray.Length; i++) Array.Sort(MyArray[i]);
                        PrintArray("итоговый массив", MyArray);
                    }
                    catch
                    {
                        Console.WriteLine("Exit...");
                    }
                    break;
                }
                case 6:
                {
                    try
                    {
                        StringBuilder str = new StringBuilder("Площадь");
                        PrintString(str);
                        str.Append(" треугольника равна");
                        PrintString(str);
                        str.AppendFormat(" {0:f2} см ", 123.456);
                        PrintString(str);
                        str.Insert(8, "данного ");
                        PrintString(str);
                        str.Remove(7, 21);
                        PrintString(str);
                        str.Replace("a", "o");
                        PrintString(str);
                        StringBuilder str1 = new StringBuilder(Console.ReadLine());
                        StringBuilder str2 = new StringBuilder(Console.ReadLine());
                        Console.WriteLine(str1.Equals(str2));
                    }
                    catch
                    {
                        Console.WriteLine(" Вознико исключение");
                    }
                    break;
                }
                case 7:
                {
                    Console.Write("Введите строку: ");
                    StringBuilder a = new StringBuilder(Console.ReadLine());
                    Console.WriteLine("Исходная строка: " + a);
                    for (int i = 0; i < a.Length;)
                        if (char.IsPunctuation(a[i])) a.Remove(i, 1);
                        else ++i;
                    string str = a.ToString();
                    string[] s = str.Split(' ');
                    Console.WriteLine("Искомые слова: ");
                    for (int i = 0; i < s.Length - 1; ++i)
                        if (s[i][0] == s[i][s.Length-1]) Console.WriteLine(s[i]);
                    break;
                }
                case 8:
                {
                    Console.WriteLine("Введите строку, состтящую из 15 элеметов: ");
                    string a = (Console.ReadLine());
                    Console.WriteLine("Исходная строка: " + a);
                    for (int i = 0; i < a.Length; i++)
                    {
                        a = a.ToUpper();
                    }
                    Console.WriteLine("Изменённая строка: " + a);
                    break;
                }
                case 9:
                {
                    Console.Write("Введите строку состоящую из слов разделённых пробелом: ");
                    string text = (Console.ReadLine());            
                    string[] slova = text.Split(' ');         
                    for (int i = 0; i < slova.Length; i++)
                    {
                        if (slova[i].Length < 2)
                        {
                            continue;
                        }
                        Console.WriteLine(slova[i]);
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

        private static void PrintArray(string line, Array a)
        {
            Console.WriteLine(line);
            foreach (object x in a) Console.Write(x);
            Console.WriteLine('\n');
        }

        private static void PrintArray(string a, int[][] mas)
        {
            Console.WriteLine(a);
            for (int i = 0; i < mas.Length; i++)
            {
                foreach (int x in mas[i]) Console.Write("{0}", x);
                Console.WriteLine();
            }
        }

        private static void Counter(string line,Array a)
        {
            int counter = 0;
            Console.WriteLine(line);
            foreach (object x in a) if(x.ToString() == "!")counter++;
            Console.Write(counter);
            Console.WriteLine('\n');
        }

        private static void PrintString(StringBuilder a)
        {
            Console.WriteLine(" Строка: " + a);
            Console.WriteLine(" Текущая длина строки " + a.Length);
            Console.WriteLine(" Объем буфера " + a.Capacity);
            Console.WriteLine("Максимальный объем буфера " + a.MaxCapacity);
            Console.WriteLine();
        }
    }
}
