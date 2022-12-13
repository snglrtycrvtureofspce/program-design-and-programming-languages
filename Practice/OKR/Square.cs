using System;

namespace OKR
{
    public class Square : IComparable
    {
        private int _a;
        public Square () {}
        public Square(int a)
        {
            this._a = a;
        }
        public int A
        {
            set
            {
                try
                {
                    if (this._a <= 0)
                    {
                        throw new ArgumentException("Значение переменной!");
                    }
                    else if (this._a > Int32.MaxValue || this._a < Int32.MinValue)
                    {
                        throw new ArgumentException("Значение переменной превышает допустимое!");
                    }
                    this._a = value;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
            get => this._a;
        }
        public double Square_square()
        {
            return Math.Pow(this._a, 2);
        }
        public int Perimeter_square()
        {
            return this._a + this._a + this._a + this._a;
        }
        public override string ToString()
        {
            return "Информация об объекте:" +
                   $"\nКвадрат" +
                   $"\nСторона A: {this._a}" +
                   $"\nСвойства:" +
                   $"\nПлощадь: {Square_square()}" +
                   $"\nПериметр: {Perimeter_square()}";
        }
        public int CompareTo(object? o)
        {
            if (expr)
            {
                if(o is Square sqr) return Name.CompareTo(sqr.Name);
            }
            else throw new ArgumentException("Некорректное значение параметра");
        }
    }
}