using System;

namespace Prac04
{
    public class Triangle
    {
        private int _a, _b, _c;
        public Triangle(){}
        public Triangle(int a, int b, int c)
        {
            this._a = a;
            this._b = b;
            this._c = c;
        }

        public void Set_a(int a)
        {
            this._a = a;
        }

        public int Get_a()
        {
            return _a;
        }
        public void Set_b(int b)
        {
            this._b = b;
        }

        public int Get_b()
        {
            return _b;
        }
        public void Set_c(int c)
        {
            this._c = c;
        }

        public int Get_c()
        {
            return _c;
        }

        public string display_into()
        {
            return $"Длина сторон: \nПервая - {_a}\nВторая - {_b}\nТретья - {_c}";
        }

        public int Perimeter()
        {
            return _a + _b + _c;
        }
            
        public double Area(int R)
        {
            return 2 * Math.Pow(R, 2) * Math.Sign(_a) * Math.Sin(_b) * Math.Sin(_c);
        }

        public bool isTriangle()
        {
            if (_a + _b > _c && _a + _c > _b && _b + _c > _a)
            {
                return true;
            }
            throw new ArgumentOutOfRangeException();
        }
    }
}