using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Lab08
{
    public class Shar
    {   
        private readonly int _r;
        private int[] arr;
        public Shar(){}
        public Shar(int r)
        {
            try
            {
                this._r = r;
                if (r < 1)
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine(e);
                throw;
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine(e);
                throw;
            }
            catch (OutOfMemoryException e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public double Area()
        {
            try
            {
                return Math.Pow(_r, 2) * Math.PI;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e);
                throw;
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e);
                throw;
            }
            catch (StackOverflowException e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public double Volume()
        {
            try
            {
                return (4.0 / 3.0) * Math.PI * Math.Pow(_r, 3);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e);
                throw;
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e);
                throw;
            }
            catch (StackOverflowException e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        ~Shar()
        {
            Console.WriteLine("Сработал деструктор");
            Console.ReadKey();
        }
    }
}
