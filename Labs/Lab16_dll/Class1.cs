using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab16_dll
{
    public class Triangle : IPrintable
    {
        public double A { set; get; }

        public double B { set; get; }

        public double C { set; get; }

        public Triangle () {}
        public Triangle (double a, double b, double c)
        {
            if ((a > 0.0 && b > 0.0 && c > 0.0) // check for positive
                && ((b + c) > a // condition check: the sum of any two sides must be greater than the third
                    || (a + c) > b
                    || (a + b) > c)
                && a != (int)a && b != (int)b && c != (int)c ) // type checking
            {
                this.A = a;
                this.B = b;
                this.C = c;
            }
            else
            {
                throw new Exception("Стороны должны соответствовать условию:" +
                                    "\nСтороны вещественные и положительные," +
                                    "\nCумма двух любых сторон должна быть больше третьей!");
            }
            this.A = a;
            this.B = b;
            this.C = c;
        }

        public double Perimeter () => this.A + this.B + this.C;

        public double Square()
        {
            var p = (this.A + this.B + this.C) / 2;
            return Math.Sqrt(p * (p - this.A) * (p - this.B) * (p - this.C));
        }

        public override string ToString()
        {
            return "Информация об объекте: " +
                   $"\nСтороны: A - {this.A}; B - {this.B}; C - {this.C}" +
                   $"\nПериметр: {Perimeter()}" +
                   $"\nПлощадь: {Square()}";
        }
    }

    internal interface IPrintable
    {
        string ToString();
    }
}
