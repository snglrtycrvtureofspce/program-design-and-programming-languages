using System;

namespace Lab18
{
    [Serializable]
    public class Plitka
    {
        private string _name;
        private double _sizeFirst;
        private double _sizeSecond;
        private string _color;
        private string _surface;
        private double _price;
        private string _country;
        private string _code;

        public Plitka (string name, double sizeFirst, double sizeSecond, string color, 
            string surface, double price, string country, double available ,string code)
        {
            this._name = name;
            this._sizeFirst = sizeFirst;
            this._sizeSecond = sizeSecond;
            this._color = color;
            this._surface = surface;
            this._price = price;
            this._country = country;
            this.Available = available;
            this._code = code;
        }

        public double Available { get; }

        public override string ToString()
        {
            return "Информация об объекте:" +
                   $"\nНазвание: {this._name}" +
                   $"\nПервый размер: {this._sizeFirst}" +
                   $"\nВторой размер: {this._sizeSecond}" +
                   $"\nЦвет: {this._color}" +
                   $"\nПоверхность: {this._surface}" +
                   $"\nЦена: {this._price}" +
                   $"\nСтрана: {this._country}" +
                   $"\nНаличие: {this.Available}" +
                   $"\nКод плитки: {this._code}";
        }
    }
}