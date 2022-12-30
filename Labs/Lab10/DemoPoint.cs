using System;

namespace Lab10
{
    internal interface IDemo
    {
        void Show(); //объявление метода
        int Y { get; } //объявление свойства, доступного только для чтения
    }

    internal interface ICompareble
    {
        int CompareTo(object obj);
    }

    internal class DemoPoint : IDemo, IComparable

    {
        protected int y;
        public DemoPoint(int y)
        {
            this.y = y;
        }

        public void Show() //реализация метода, объявленного в интерфейсе

        {
            Console.WriteLine("Точка на плоскости: ({0})", y);
        }

        public int Y //реализация свойства, объявленного в интерфейсе
        {
            set => this.y = value;
            get => this.y;
        }

        public double Dlina()
        {
            return Math.Sqrt(y * y);
        }
        public int CompareTo(object obj)
        {
            DemoPoint b = (DemoPoint)obj;
            if (this.Dlina() == b.Dlina()) return 0;
            else if (this.Dlina() > b.Dlina()) return 1;
            else return -1;
        }
        public static bool operator ==(DemoPoint a, DemoPoint b)
        {
            return (a.CompareTo(b) == 0);
        }
        public static bool operator !=(DemoPoint a, DemoPoint b)
        {
            return (a.CompareTo(b) == 0);
        }
        public static bool operator >(DemoPoint a, DemoPoint b)
        {
            return (a.CompareTo(b) == 1);
        }
        public static bool operator <(DemoPoint a, DemoPoint b)
        {
            return (a.CompareTo(b) == -11);
        }
        public static bool operator >=(DemoPoint a, DemoPoint b)
        {
            return (a.CompareTo(b) >= 0);
        }
        public static bool operator <=(DemoPoint a, DemoPoint b)
        {
            return (a.CompareTo(b) <= 1);
        }
    }

    internal class DemoShape : DemoPoint, IDemo

    {
        protected int z;
        public DemoShape(int y, int z) : base(y)

        {
            this.z = z;
        }

        public new void Show()
        {
            Console.WriteLine("Точка в пространстве: ({0}, {1})", y, z);
        }
    }
}