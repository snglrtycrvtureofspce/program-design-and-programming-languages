using System;

namespace Lab10
{
    internal abstract class BaseAnimal
    {
        public abstract void DoSomeThing(); // Все животные что-то делают
    }

    internal class Animal : BaseAnimal, IVoice
    {
        protected string _name; //КЛИЧКА ЖИВОТНОГО

        public Animal() : this("Noname")
        {
        }

        public Animal(string name)
        {
            _name = name;
        }

        public override void DoSomeThing() //ПЕРЕОПРЕДЕЛЕНИЕ метода абстрактного класса
        {
            Console.WriteLine($"{GetType().Name} {_name} что-то делает");
        }

        public void Eat() //ЖИВОТНОЕ ЕСТ (обычный метод)
        {
            Console.WriteLine($"{GetType().Name} {_name} ест");
        }

        public virtual void Sleep() //ЖИВОТНОЕ СПИТ(виртуальный метод) 
        {
            Console.WriteLine($"{GetType().Name} {_name} спит");
        }

        public void Voice() //ЖИВОТНОЕ ИМЕЕТ ГОЛОС(обычный метод)
        {
            Console.WriteLine($"{GetType().Name} {_name} имеет голос");
        }
    }

    internal class Cow : Animal, IVoice
    {
        private int _milk; //СОБСТВ ДАННОЕ МОЛОКО

        public Cow() : base()
        {
            _milk = 10;
        }

        public Cow(string name, int milk) : base(name)
        {
            _milk = milk;
        }

        public new void Eat() // Обычный метод ЕСТ -НОВАЯ РЕАЛИЗАЦИЯ
        {
            Console.WriteLine($"{GetType().Name} {_name} ест траву и сено");
        }

        public override void Sleep() // Переопределение виртуального метода СПИТ
        {
            Console.WriteLine($"{GetType().Name} {_name} спит стоя");
        }

        //сокрытие базовой реализации
        public new void Voice() // Обычный метод ГОЛОС -НОВАЯ РЕАЛИЗАЦИЯ
        {
            Console.WriteLine($"{GetType().Name} {_name} мычит");
        }

        void IVoice.Voice() // ЯВНАЯ!! РЕАЛИЗАЦИЯ МЕТОДА ГОЛОС У ИНТЕРФЕЙСА!
        {
            Console.WriteLine($"{GetType().Name} {_name}: МУ-МУ");
        }
    }

    internal interface IVoice
    {
        void Voice();
    }
}