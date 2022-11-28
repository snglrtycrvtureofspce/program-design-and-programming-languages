using System;

namespace Lab10
{
    abstract class Organization
    {
        public abstract override string ToString(); // все организации имеют какую-либо информацию
    }

    class Insurance : Organization, IFactory
    {
        protected string _name; // имя страховой компании
        public Insurance() => this._name = "Безымянная организация";
        public Insurance(string name) => this._name = name;
        public void Service() => Console.WriteLine($"{GetType().Name} {_name} - обслуживающая организация.");
        public virtual void Stock() => Console.WriteLine($"{GetType().Name} {_name} - покупает/продаёт акции организации.");
        public void Build() => Console.WriteLine($"{GetType().Name} {_name} - строитель организации.");
        public override string ToString() // переопределение метода абстрактного класса
        {
            return $"{GetType().Name} {_name} - что-то делает/чем-то занимается.";
        }
    }

    class OilAndGas : Insurance, IFactory
    {
        private double _size;

        public OilAndGas() : base()
        {
            this._size = 99.9;
        }
        public OilAndGas(string name, double size) : base(name)
        {
            this._size = size;
        }
        public new void Service() => Console.WriteLine($"{GetType().Name} {_name} - обслуживает газовую компанию.");
        public override void Stock() => Console.WriteLine($"{GetType().Name} {_name} - покупает/продаёт акции газовой компании.");
        public new void Build() => Console.WriteLine($"{GetType().Name} {_name} - строит заводы газовой компании.");
        void IFactory.Build()
        {
            Console.WriteLine($"{GetType().Name} {_name} - уже строит завод");
        }
        public override string ToString()
        {
            return $"{GetType().Name} {_name} - что-то делает/чем-то занимается.";
        }
    }

    interface IFactory
    {
        void Build(); // строит
    }
}