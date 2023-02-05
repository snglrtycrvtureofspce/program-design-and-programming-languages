using System;
using System.Linq;

namespace Lab20
{
    internal class Program
    {
        private static void Main()
        {
            double[] arr = {0.53, 5.5, 3, -1.99, 2.1, 0.77, -0.3};
            const double a = -2;
            const double b = 2;
            Console.WriteLine("Исходный массив:");
            foreach (var t in arr)
            {
                Console.WriteLine(t);
            }
            arr = arr.Where(x => Math.Abs(x) < a || Math.Abs(x) > b).Concat(Enumerable.Repeat(0.0, arr.Length - arr.Count(x => Math.Abs(x) < a || Math.Abs(x) > b))).ToArray();
            Console.WriteLine($"Модуль которых находился в интервале[{a}][{b}] - заполняются нулями, и добавляются в конец массива." +
                              "\nПолученный сжатый массив:");
            for (int i = 0, j = 1; i < arr.Length; i++, j++)
            {
                Console.WriteLine($"{j}-ый элемент: {arr[i]}");
            }
            /*Метод Where() фильтрует элементы в массиве на основе указанного условия, 
            а именно того, что абсолютное значение каждого элемента меньше a или больше b.
            Метод Concat() объединяет оставшиеся элементы с массивом нулей той же длины, 
            что и количество удалённых элементов. Метод Enumerable.Repeat() создает массив указанного значения, 
            повторяющегося указанное количество раз. В этом случае значение равно 0,0, 
            а количество повторений равно arr.Length - arr.Count(x => Math.Abs(x) < a || Math.Abs(x) > b), 
            что вычисляет количество элементов, удаленных из массива.*/
        }
    }
}
