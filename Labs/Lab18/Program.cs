using System;
using System.IO;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Soap;
using System.Runtime.Serialization.Formatters.Binary;
using System.Net.Http.Headers;

namespace Lab18
{
    internal class Program
    {
        private static void Main()
        {
            Console.Write("Введите номер задания: ");
            int p = Convert.ToInt32(Console.ReadLine());
            switch (p)
            {
                case 1:
                {
                    OneDimensionalArray da = new OneDimensionalArray();
                    // XML
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(OneDimensionalArray));
                    using (FileStream fs = new FileStream("OneDimensionalArray.xml", FileMode.OpenOrCreate))
                    {
                        xmlSerializer.Serialize(fs, da);

                        Console.WriteLine("Объект сереализован xml");
                    }

                    using (FileStream fs = new FileStream("OneDimensionalArray.xml", FileMode.OpenOrCreate))
                    {
                        OneDimensionalArray x = xmlSerializer.Deserialize(fs) as OneDimensionalArray;
                        Console.WriteLine($"дата: {x}");
                    }

                    // Soap
                    SoapFormatter formatter = new SoapFormatter();
                    using (FileStream fs = new FileStream("OneDimensionalArray.soap", FileMode.OpenOrCreate))
                    {
                        formatter.Serialize(fs, da);

                        Console.WriteLine("Объект сериализован soap");
                    }

                    // Десериализация
                    using (FileStream fs = new FileStream("OneDimensionalArray.soap", FileMode.OpenOrCreate))
                    {
                        OneDimensionalArray data = (OneDimensionalArray)formatter.Deserialize(fs);

                        Console.WriteLine("Объект десериализован");
                        Console.WriteLine($"дата: {data}");
                    }

                    break;
                }
                case 2:
                {
                    Plitka[] array = new Plitka[3];
                    array[0] = new Plitka("ОферТ2", 24, 63, "Красный", "Глянец", 214, "Беларусь", 2, "K223");
                    array[1] = new Plitka("Матуо2-к", 14, 23, "Чёрный", "Мат", 522, "Россия", 41, "C293");
                    array[2] = new Plitka("Матуо4-к", 20, 50, "Белый", "Мат", 1022, "Армения", 6, "C293-2");
                    var min = array[0].Available;
                    foreach (var t in array)
                    {
                        if (t.Available > min)
                        {
                            min = t.Available;
                        }
                    }
                    // Bin
                    BinaryFormatter formatter = new BinaryFormatter();
                    using (FileStream fs = new FileStream("Plitka.dat", FileMode.OpenOrCreate))
                    {
                        formatter.Serialize(fs, array);

                        Console.WriteLine("Объект сериализован bin");
                    }

                    using (FileStream fs = new FileStream("Plitka.dat", FileMode.OpenOrCreate))
                    {
                        Plitka[] arr = (Plitka[])formatter.Deserialize(fs);

                        Console.WriteLine("Объект десериализован");
                        for (int i = 0; i < arr.Length; i++)
                        {
                            Console.WriteLine(arr[i].ToString());
                        }
                    }

                    // Soap
                    SoapFormatter formatte = new SoapFormatter();
                    using (FileStream fs = new FileStream("Plitka.soap", FileMode.OpenOrCreate))
                    {
                        formatte.Serialize(fs, array);

                        Console.WriteLine("Объект сериализован soap");
                    }

                    // Десериализация
                    using (FileStream fs = new FileStream("Plitka.soap", FileMode.OpenOrCreate))
                    {
                        Plitka[] arr = (Plitka[])formatte.Deserialize(fs);

                        Console.WriteLine("Объект десериализован");
                        for (int i = 0; i < arr.Length; i++)
                        {
                            Console.WriteLine(arr[i].ToString());
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
