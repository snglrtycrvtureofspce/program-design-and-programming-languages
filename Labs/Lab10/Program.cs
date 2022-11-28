using System;
using System.Collections.Generic;

namespace Lab10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер: ");
            var p = Convert.ToInt32(Console.ReadLine());
            switch (p)
            {
                case 1:
                    {
                        Reagent a = new Reagent(15);
                        Console.WriteLine(a.ToString());
                        Carbon b = new Carbon("Карбон");
                        Console.WriteLine(b.ToString());
                        Iron c = new Iron(11.2);
                        Console.WriteLine(c.ToString());
                        break;
                    }
                case 2:
                    {
                        Console.OutputEncoding = System.Text.Encoding.Default;
                        Animal cowA = new Cow("CowA", 12); // создаем животное как корову
                        Cow cow = new Cow("Cow", 5); // создаем корову как корову
                        Console.WriteLine("--------EAT----------");
                        // невиртуальный метод – смотрим на тип ссылки
                        cow.Eat(); // КОРОВА КАК КОРОВА
                        cowA.Eat(); // КОРОВА КАК ЖИВОТНОЕ

                        (cowA as Cow).Eat(); // животное к корове и , следовательно ,будет жевать сено //null
                        ((Cow)cowA).Eat(); // аналогично //exception неправильное приведение типов
                                           // виртуальный метод – смотрим на тип, котырым проинициализирована ссылка
                        Console.WriteLine("--------SLEEP--------");
                        cow.Sleep(); // вызов виртуального метода КОРОВА  корова спит стоя
                        cowA.Sleep(); // вызов виртуального метода ЖИВОТНОЕ  корова спит стоя

                        Console.WriteLine("--------VOICE--------");
                        cow.Voice(); /// вызов метода  корова мычит ( как невиртуальный)

                        (cow as Animal).Voice(); // приводим корову к животному и тогда корова имеет голос 
                        ((IVoice)cow).Voice(); // приведение к интерфейсу IVoice, вызов явной реализации интерфейса

                        // что здесь происходит         
                        cowA.Voice();
                        (cowA as Cow).Voice();
                        ((IVoice)cowA).Voice();

                        List<BaseAnimal> bs = new List<BaseAnimal>();
                        bs.Add(cow);
                        bs.Add(cowA);
                        bs.Add(new Animal());

                        foreach (var item in bs)
                        {
                            item.DoSomeThing(); // для всех
                            if (item is Animal) (item as Animal).Eat(); // только для тех  у кого реализован метод Eat
                            if (item is Cow) (item as Cow).Eat();
                        }
                        break;
                    }
                case 3:
                    {
                        Insurance OilA = new OilAndGas("OilA", 255); // создаем организацию как газовую компанию
                        OilAndGas Oil = new OilAndGas("Oil", 5); // создаем газовую компанию как газовую компанию
                        Console.WriteLine("--------Service----------");
                        Oil.Service(); // газовая компания как газовая компания
                        OilA.Service(); // газовая компания КАК организация

                        (OilA as OilAndGas).Service(); // организация к газовой компании и , следовательно , будет обслуживать //null
                        ((OilAndGas)OilA).Service(); // аналогично //exception неправильное приведение типов
                                                     // виртуальный метод – смотрим на тип, котырым проинициализирована ссылка
                        Console.WriteLine("--------Stock--------");
                        Oil.Stock(); // вызов виртуального метода газовая компания покупает/продаёт акции организации
                        OilA.Stock(); // вызов виртуального метода организация газовая компания покупает/продаёт акции организации

                        Console.WriteLine("--------Build--------");
                        Oil.Build(); // вызов метода строить газовую компанию ( как невиртуальный)

                        (Oil as OilAndGas).Build(); // приводим газовую компанию к организации и тогда газовая компания имеет метод строить 
                        ((IFactory)Oil).Build(); // приведение к интерфейсу IFactory, вызов явной реализации интерфейса

                        OilA.Build();
                        (OilA as OilAndGas).Build();
                        ((IFactory)OilA).Build();

                        var bs = new List<Organization>
                        {
                            Oil,
                            OilA,
                            new OilAndGas()
                        };

                        foreach (var item in bs)
                        {
                            Console.WriteLine(item.ToString()); // для всех
                            if (item is Insurance) (item as Insurance).Service(); // только для тех  у кого реализован метод Service
                            if (item is OilAndGas) (item as OilAndGas).Service();
                        }
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Exit...");
                        break;
                    }
            }
        }
    }
}
