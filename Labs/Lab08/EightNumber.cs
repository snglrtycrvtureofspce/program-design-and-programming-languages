using System;

namespace Lab08
{
    public class EightNumber
    {
        private string _number;
        
        public EightNumber()
        {
        }

        public EightNumber(string number)
        {
            this._number = number;
            Console.WriteLine("Цифра: " + number);
        }

        public byte this[int index]
        {
            get
            {
                if (index >= 0 && index < this._number.Length)
                {
                    return byte.Parse(this._number[index].ToString());
                }
                return 0;
            }
        }

        public int ToInt()
        {
            var result = 0;
            var n = 1;
            for (int i = this._number.Length - 1; i >= 0; i--)
            {
                result += n * this._number[i];
                n *= 8;
            }

            return result;
        }
    }
}