using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    internal class Program
    {
        private static readonly Random Rnd = new Random();
        private const int MinValue = 1;
        private const int MaxValue = 1000;
        private const int ArrSize = 21;

        private delegate void SortArrAsc(int[] arr);
        private delegate void SortArrDesc(int[] arr);

        private static SortArrAsc _sortAsc;
        private static SortArrDesc _sortDesc;

        private static void Main(string[] args)
        {
            var arr1 = new int[ArrSize];
            var arr2 = new int[ArrSize];
 
            FillArr(arr1, true);
            FillArr(arr2, false);
 
            _sortAsc += OrderArrAsc;
            _sortDesc += OrderArrDesc;
 
            _sortAsc(arr1);
            _sortDesc(arr2);
            Console.WriteLine("По возрастанию:");
            foreach (var t in arr1)
            {
                Console.WriteLine(t);
            }
            Console.WriteLine("По убыванию:");
            foreach (var t in arr2)
            {
                Console.WriteLine(t);
            }

        }

        private static void FillArr(int[] arr, bool evenValues)
        {
            for (var i = 0; i < arr.Length; i++)
            {
                var x = Rnd.Next(MinValue, MaxValue);
                arr[i] = (x % 2 == 0) == evenValues ?
                    x : x == MinValue ?
                        x + 1 : x == MaxValue ?
                            x - 1 : x + 1;
            }
        }
 
 
        // Сортировка пузырьком по возрастанию
        private static void OrderArrDesc(int[] arr)
        {
            for (var i = 0; i < arr.Length; i++)
            for (var j = i + 1; j < arr.Length; j++)
                if (arr[i] < arr[j])
                {
                    (arr[i], arr[j]) = (arr[j], arr[i]);
                    /*int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;*/
                }
        }
 
        //сортировка вставками по убыванию
        private static void OrderArrAsc(int[] intArray)
        {
            for (var i = 0; i < intArray.Length; i++) 
            {
                var index = i; 
                for (var j = i; j < intArray.Length; j++) 
                {
                    if (intArray[j] < intArray[index])
                    {
                        index = j; 
                    }
                }
                if (intArray[index] == intArray[i]) 
                    continue;
               
                (intArray[i], intArray[index]) = (intArray[index], intArray[i]);
                /*int temp = intArray[i]; 
                intArray[i] = intArray[index];
                intArray[index] = temp;*/
            }
        }
    }
}
