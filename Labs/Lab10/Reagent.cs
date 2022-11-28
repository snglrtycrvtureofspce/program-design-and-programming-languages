using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    public class Reagent
    {
        private int _count;
        public Reagent(){}
        public Reagent(int count)
        {
            this._count = count;
        }

        public override string ToString()
        {
            return $"Информация о реагенте:\nКоличество - {this._count}";
        }
    }
}
