using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac05
{
    internal class Program
    {
        public class Car
        {
            public double MaxSpeed {get; set; }
            public string Color {get; set; }
            public string Producer {get; set; }
            public int Passengers {get; set; }
            public Car() { }
            public Car(double maxSpeed, string color, string producer, int passengers)
            {
                MaxSpeed = maxSpeed;
                Color = color;
                Producer = producer;
                Passengers = passengers;
            }
        }
        public class Product
        {
            public string Name {get; set; }
            public string Description {get; set; }
            public double CountPackages {get; set; }
            public Product() { }
            public Product(string name, string description, double countPackages)
            {
                Name = name;
                Description = description;
                CountPackages = countPackages;
            }
        }
        static void Main(string[] args)
        {
            var a = new[] { "Fallout 3","Daxter 2", "System Shok 2", "Morrowind","Pes 2013" };
            var b = new[] { 2, -7, -10, 6, 7, 9, 3};
            var c = new[] { "Light Green","Red", "Green", "Yellow","Purple", "Dark Green", "Light Red", "Dark Red", "Dark Yellow", "Light Yellow" };
            List<string> myCars = new List<string>{"Yugo", "Aztec", "BMW"};
            List<string> yourCars = new List<string>{"BMW", "Saab", "Aztec"};
            Console.Write("Введите номер задания: ");
            var p = Convert.ToInt32(Console.ReadLine());
            switch (p)
            {
                case 1:
                {
                    var query = from element in a
                        where element.Contains("2")
                        select element;

                    Console.WriteLine("Элементы содержащие двойку:");
                    foreach (var item in query)
                    {
                        Console.WriteLine(item);
                    }
                    break;
                }
                case 2:
                {
                    var query = b.Where(x => x > 0);

                    Console.WriteLine("Положительные элементы: ");
                    foreach (var item in query)
                    {
                        Console.WriteLine(item);
                    }
                    break;
                }
                case 3:
                {
                    var query = c.Where(color => color.Contains("Yellow"));

                    Console.WriteLine("Все оттенки жёлтого в массиве: ");
                    foreach (var item in query)
                    {
                        Console.WriteLine(item);
                    }
                    break;
                }
                case 4:
                {
                    var cars = new List<Car>
                    {
                        new Car(120, "Black", "Camry", 4),
                        new Car(150, "White", "Daewoo", 4),
                        new Car(100, "Purple", "Lada", 4),
                        new Car(140, "Metallic", "BMW", 6)
                    };
                    var query = cars.Where(car => car.Passengers == 4);

                    Console.WriteLine("Автомобили, количество пассажиров которых равно четырём: ");
                    foreach (var car in query)
                    {
                        Console.WriteLine($"Максимальная скорость: {car.MaxSpeed}");
                        Console.WriteLine($"Цвет: {car.Color}");
                        Console.WriteLine($"Производитель: {car.Producer}");
                        Console.WriteLine($"Количество пассажиров: {car.Passengers}");
                        Console.WriteLine("--------------------------");
                    }
                    break;
                }
                case 5:
                {
                    var products = new List<Product>
                    {
                        new Product("BH02-HF", "Multitool", 4),
                        new Product("Boeing 23-211", "Plane", 11),
                        new Product("KMS", "Adapter", 1),
                        new Product("HyperX", "Mouse", 3)
                    };
                    var query = products.Where(product => product.CountPackages < 5);

                    Console.WriteLine("Продукты, ассортимент которых меньше 5 единиц: ");
                    foreach (var product in query)
                    {
                        Console.WriteLine($"Имя: {product.Name}");
                        Console.WriteLine($"Описание:  {product.Description}");
                        Console.WriteLine($"Количество продуктов:  {product.CountPackages}");
                        Console.WriteLine("--------------------------");
                    }
                    break;
                }
                case 6:
                {
                    var result = myCars.Union(yourCars).ToList();

                    Console.WriteLine("Удаляем повторяющиеся элементы и создаём новый список: ");
                    foreach (var item in result)
                    {
                        Console.WriteLine(item);
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
