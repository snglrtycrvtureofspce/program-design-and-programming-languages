using System;

namespace Lab08
{
    public class DemoArray
    {
        private int [] MyArray;
  
        public DemoArray(int size)
        {
            MyArray = new int[size];
        }
        public DemoArray(params int[] arr)
        {
            MyArray = new int[arr.Length];
            for (var i = 0; i < MyArray.Length; i++)
            {
                MyArray[i] = arr[i];
            }
        }
        public int LengthArray => MyArray.Length;
        public int this[int i]
        {
            set
            {
                if (i < 0 || i >= MyArray.Length) throw new Exception("Выход за границу массива");
                else MyArray[i] = value;
            }
            get
            {
                if (i < 0 || i >= MyArray.Length) throw new Exception("Выход за границу массива");
                return MyArray[i];
            }
        }
        public static DemoArray operator +(DemoArray x) // унарный плюс
        {
            DemoArray temp = new DemoArray(x.LengthArray);
            for (int i = 0; i < x.LengthArray; ++i)
            {
                temp[i] = x[i]*-1;
            }
            return temp;
        } 

        public static DemoArray operator --(DemoArray x) // декремент
        {
            DemoArray temp = new DemoArray(x.LengthArray);
            for (int i = 0; i < x.LengthArray; ++i)
            {
                temp[i] = x[i]-1;
            }
            return temp;
        }

        public static DemoArray operator -(DemoArray x, int num) // бинарный минус
        {
            DemoArray temp = new DemoArray(x.LengthArray);
            for (int i = 0; i < x.LengthArray; ++i)
            {
                temp[i] = x[i] - num;
            }
            return temp;
        }

        public static bool operator &(DemoArray a, DemoArray b)
        {
            for (int i = 0; i < a.LengthArray; i++)
            {
                if (a.MyArray[i] != b.MyArray[i])
                {
                    return false;
                }
            }
            return true;
        }

        public void Print(string name) //метод - выводит поле-массив на экран
        {
            Console.WriteLine(name + ": ");
            for (int i = 0; i < MyArray.Length; i++)
                Console.Write(MyArray[i] + " ");
            Console.WriteLine();
        }
    }
}