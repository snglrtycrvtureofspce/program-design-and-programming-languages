using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14
{
    internal enum Category
    {
        News, Weather, Sport,
        Events, Humor
    }

    internal class NewsOperator
    {
        private delegate void MethodAddTo(string msg);
 
        private event MethodAddTo SubscribeNews;
 
        private event MethodAddTo SubscribeWeather;
 
        private event MethodAddTo SubscribeSport;
 
        private event MethodAddTo SubscribeEvents;
 
        private event MethodAddTo SubscribeHumor;
 
        public void SubscribeTo(Category id, Subscriber item)
        {
            switch (id)
            {
                case Category.News:
                    SubscribeNews += item.AddNews;
                    break;
                case Category.Weather:
                    SubscribeWeather += item.AddNews;
                    break;
                case Category.Sport:
                    SubscribeSport += item.AddNews;
                    break;
                case Category.Events:
                    SubscribeEvents += item.AddNews;
                    break;
                case Category.Humor:
                    SubscribeHumor += item.AddNews;
                    break;
                default:
                    break;
            }
        }
 
        public void SubscribeFrom(Category id, Subscriber item)
        {
            switch (id)
            {
                case Category.News:
                    SubscribeNews -= item.AddNews;
                    break;
                case Category.Weather:
                    SubscribeWeather -= item.AddNews;
                    break;
                case Category.Sport:
                    SubscribeSport -= item.AddNews;
                    break;
                case Category.Events:
                    SubscribeEvents -= item.AddNews;
                    break;
                case Category.Humor:
                    SubscribeHumor -= item.AddNews;
                    break;
                default:
                    break;
            }
        }
 
        public void AddNews(Category id, string msg)
        {
            switch (id)
            {
                case Category.News:
                    if (SubscribeNews != null)
                        SubscribeNews(msg);
                    break;
                case Category.Weather:
                    if (SubscribeWeather != null)
                        SubscribeWeather(msg);
                    break;
                case Category.Sport:
                    if (SubscribeSport != null)
                        SubscribeSport(msg);
                    break;
                case Category.Events:
                    if (SubscribeEvents != null)
                        SubscribeEvents(msg);
                    break;
                case Category.Humor:
                    if (SubscribeHumor != null)
                        SubscribeHumor(msg);
                    break;
                default:
                    break;
            }
        }
    }

    internal class Subscriber : System.Collections.IEnumerable
    {
        private System.Collections.Specialized.StringCollection Data;
 
        public Subscriber()
        {
            Data = new System.Collections.Specialized.StringCollection();
        }
 
        public System.Collections.IEnumerator GetEnumerator()
        {
            return ((System.Collections.IEnumerable)Data).GetEnumerator();
        }
 
        public void AddNews(string msg)
        {
            Data.Add(msg);
        }
    }
    public class Lesson1
    {
        public delegate string NaSuMi(string surname, string name, string middlename); // surname, name, middlename

        public delegate string NaSu(string surname, string name); // surname, name
        public Lesson1 (){}

        public string display_into_first(string surname, string name, string middlename)
        {
            return $"{surname} {name[0]}.{middlename[0]}.";
        }
        public string display_into_second(string surname, string name)
        {
            return $"{surname} {name}";
        }
    }
    internal class Program
    {
        private static void Main()
        {
            Console.Write("Введите номер задания: ");
            var p = Convert.ToInt32(Console.ReadLine());
            switch (p)
            {
                case 1:
                    Lesson1 lesson1 = new Lesson1 ();
                    Lesson1.NaSuMi naSuMi = new Lesson1.NaSuMi(lesson1.display_into_first);
                    Lesson1.NaSu naSu = new Lesson1.NaSu(lesson1.display_into_second);
                    var strNaSuMi = naSuMi ("Зеневич", "Александр", "Олегович");
                    var strNaSu = naSu("Зеневич", "Александр");
                    Console.WriteLine(strNaSuMi);;
                    Console.WriteLine(strNaSu);
                    break;
                case 2:
                    Lab14.NewsOperator newsOp = new Lab14.NewsOperator();
                    Lab14.Subscriber sub = new Lab14.Subscriber();
                    newsOp.SubscribeTo(Lab14.Category.News, sub);
                    newsOp.AddNews(Lab14.Category.News, "Первая новость #1");
                    newsOp.AddNews(Lab14.Category.News, "Вторая новость #2");
                    newsOp.AddNews(Lab14.Category.News, "Третья новость #3");
                    newsOp.SubscribeFrom(Lab14.Category.News, sub);
                    System.Console.WriteLine("Класс {0} новости:", nameof(sub));
                    foreach(string str in sub)
                        System.Console.WriteLine("=> {0}", str);
                    /*System.Console.WriteLine("******{0}*****", new string('*', nameof(sub).Length));*/
                    break;
                default:
                    Console.WriteLine("Exit...");
                    break;
            }
        }
    }
}
