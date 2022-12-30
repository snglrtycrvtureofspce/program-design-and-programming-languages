using System;

namespace Lab18
{
    [Serializable]
    public class OneDimensionalArray
    {
        private int[] _intArray;
        private int _n;
        public OneDimensionalArray() => this._n = 5;
        public OneDimensionalArray(int n)
        {
            this._n = n;
            this._intArray = new int[n];
        }

        public int SizeArray => this._intArray.Length;

        public int MulArray
        {
            set
            {
                for (var i = 0; i < SizeArray; i++)
                {
                    this._intArray[i] *= value;
                }
            }
        }
        public void InputArray()
        {
            for (int i = 0, temp = 1; i < SizeArray; i++, temp++)
            {
                Console.Write($"Введите {temp}-ый элемент массива: ");
                this._intArray[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public void OutputArray()
        {
            Console.WriteLine("Вывод массива:");
            for (int i = 0, temp = 1; i < SizeArray; i++, temp++)
            {
                Console.WriteLine($"{temp}-ый элемент: {this._intArray[i]}");
            }
        }

        public void SortArray()
        {
            Array.Sort(this._intArray);
            Console.WriteLine("Массив отсортирован по возрастанию!");
        }
    }
}