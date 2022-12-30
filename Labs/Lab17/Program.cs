using System;
using System.Collections;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab17
{
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
                    const string path = "Numerable.dat";
                    using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate)))
                    {
                        Console.Write("Введите количество целых чисел: ");
                        var n = Convert.ToInt32(Console.ReadLine());
                        var arr = Enumerable.Range(1, n).Select(x => x);
                        foreach (var num in arr)
                        {
                            if (num % 2 == 0)
                            {
                                writer.Write(num);
                                Console.WriteLine(num);
                            }
                        }
                        writer.Close();
                    }
                    break;
                }
                case 2:
                {
                    var minLengthLineIndex = int.MinValue;
                    foreach (var line in File.ReadLines(@"C:\Users\snglrtycrvtureofspce\Documents\snglrtycrvtureofspce\GitHub\program-design-and-programming-languages\Labs\Lab17\text.txt"))
                    {
                        const int minLength = int.MaxValue;
                        var counter = 1;
                        if (line.Length < minLength)
                        {
                            minLengthLineIndex = line.Length;
                            minLengthLineIndex = counter;
                        }
                        counter++;
                    }

                    Console.WriteLine($"Номер минимальной строки - {minLengthLineIndex}");
                    break;
                }
                case 3:
                {
                    Directory.CreateDirectory(@"C:\temp\K1");
                    Directory.CreateDirectory(@"C:\temp\K2");
                    FileInfo f = new FileInfo(@"C:\temp\K1\t1.txt");
                    StreamWriter w = new StreamWriter(f.Create());
                    w.WriteLine("Иванов Иван Иванович, 1965 года рождения, место жительства г.Саратов");
                    w.Close();
                    FileInfo f1 = new FileInfo(@"C:\temp\K1\t2.txt");
                    StreamWriter w1 = new StreamWriter(f1.Create());
                    w1.WriteLine("Петров Сергей фёдорович 1966 года рождения, место жительства г.Энгельс");
                    w1.Close();
                    f.CopyTo(@"C:\temp\K2\t3.txt");
                    FileInfo f2 = new FileInfo(@"C:\temp\K2\t3.txt");
                    break;
                }
                default:
                {
                    break;
                }
            }
        }
    }
}
