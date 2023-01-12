using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер задания: ");
            int p = Convert.ToInt32(Console.ReadLine());
            switch (p)
            {
                case 1: // 
                {
                    string prefixExpression = "* + 2 3 4"; // Пример выражения в префиксной форме
                    Stack<int> operandStack = new Stack<int>();

                    // Переворачиваем строку, чтобы разбирать ее с конца
                    char[] chars = prefixExpression.ToCharArray();
                    Array.Reverse(chars);
                    prefixExpression = new string(chars);

                    // Разбираем строку, разбивая ее на токены
                    string[] tokens = prefixExpression.Split(' ');

                    // Обрабатываем каждый токен
                    foreach (string token in tokens)
                    {
                        // Если токен - операнд, помещаем его в стек
                        if (int.TryParse(token, out int operand))
                        {
                            operandStack.Push(operand);
                        }
                        else
                        {
                            // Берем два операнда из стека
                            int operand2 = operandStack.Pop();
                            int operand1 = operandStack.Pop();
                            Console.WriteLine(operand1 + ' ' + operand2);

                            // Выполняем операцию
                            int result = 0;
                            switch (token)
                            {
                                case "+":
                                    result = operand1 + operand2;
                                    break;
                                case "*":
                                    result = operand1 * operand2;
                                    break;
                                case "/":
                                    result = operand1 / operand2;
                                    break;
                            }

                            // Помещаем результат обратно в стек
                            operandStack.Push(result);
                        }
                    }

                    Console.WriteLine("Результат (последний элемент в стеке): " + operandStack.Pop());
                    break;
                }
                case 2:
                {
                    StreamReader reader = new StreamReader("file.txt");

                    Queue<string> upperCaseWords = new Queue<string>();
                    Queue<string> lowerCaseWords = new Queue<string>();

                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        var words = line.Split(' ');

                        foreach (string word in words)
                        {
                            if (char.IsUpper(word[0]))
                            {
                                upperCaseWords.Enqueue(word); // Добавляет объект в конец очереди
                            }
                            else
                            {
                                lowerCaseWords.Enqueue(word);
                            }
                        }
                    }

                    reader.Close();

                    Console.WriteLine("Слова, начинающиеся с прописной буквы:");
                    while (upperCaseWords.Count > 0)
                    {
                        Console.WriteLine(upperCaseWords.Dequeue());
                    }

                    Console.WriteLine("Слова, начинающиеся со строчной буквы:");
                    while (lowerCaseWords.Count > 0)
                    {
                        Console.WriteLine(lowerCaseWords.Dequeue());
                    }

                    break;
                }
                case 3:
                {
                    /*StreamReader reader = new StreamReader("input.txt");

                    ArrayList employees = new ArrayList();
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(' ');
                        string name = parts[0];
                        int hireYear = int.Parse(parts[1]);
                        string position = parts[2];
                        double salary = double.Parse(parts[3]);
                        int workExperience = int.Parse(parts[4]);

                        // Создаем объект сотрудника
                        Employee employee = new Employee(name, hireYear, position, salary, workExperience);
                        Console.WriteLine(employee);
                        // Добавляем сотрудника в список
                        employees.Add(employee);
                    }
                    reader.Close();

                    // Отфильтровываем сотрудников с зарплатой ниже определенного уровня
                    ArrayList filteredEmployees = new ArrayList();
                    foreach (Employee employee in employees)
                    {
                        if (employee.Salary < 1000)
                        {
                            filteredEmployees.Add(employee);
                             
                        }
                    }
                        // Сортируем список сотрудников по рабочему стажу
                        */
                    /*filteredEmployees.Sort((x, y) => ((Employee)x).WorkExperience.CompareTo(((Employee)y).WorkExperience));*/
                    /* //
                   
                                           StreamWriter writer = new StreamWriter("output.txt");
                   
                                       foreach (Employee employee in filteredEmployees)
                                       {
                                           writer.WriteLine(employee.Name + " " + employee.HireYear + " " + employee.Position + " " +
                                                            employee.Salary + " " + employee.WorkExperience);
                                       }
                   
                                       writer.Close();*/
                    ArrayList list = new ArrayList();
                    using (StreamReader read = new StreamReader("people.txt"))
                    {
                        while (!read.EndOfStream)
                        {
                            People person = new People(read.ReadLine());
                            if (person.Double() == true)
                            {
                                using (StreamWriter write = new StreamWriter("double.txt"))
                                {
                                    write.WriteLine(person);
                                }
                            }

                            list.Add(person);
                        }
                    }

                    foreach (var q in list)
                    {
                        Console.WriteLine(q.ToString());
                    }

                    break;
                }
                case 4:
                {
                    /*MusicCatalog catalog = new MusicCatalog();
                    CompactDisc cd = new CompactDisc
                    {
                        Title = "Greatest Hits",
                        Songs = new List<string> { "Song 1", "Song 2", "Song 3" }
                    };
                    catalog.AddCompactDisc(cd);

                    // Добавление новой песни на компакт-диск
                    catalog.AddSong("Greatest Hits", "Song 4");

                    // Удаление компакт-диска
                    catalog.RemoveCompactDisc("Greatest Hits");

                    // Удаление песни с компакт-диска
                    catalog.RemoveSong("Greatest Hits", "Song 4");

                    // Получение компакт-диска по названию
                    CompactDisc cd1 = catalog.GetCompactDisc("Greatest Hits");

                    // Получение списка всех компакт-дисков
                    List<CompactDisc> cds = catalog.GetAllCompactDiscs();

                    // Поиск всех записей заданного исполнителя
                    List<CompactDisc> cds2 = catalog.SearchByArtist("Artist Name");*/
                    int m = 0;
                    Hashtable disk = new Hashtable();
                    do
                    {
                        Console.WriteLine(
                            "0 - Добавить диск\n1 - Удалить диск\n2 - Добавить песню\n3 - Удалить песни\n4 - Посмотреть каталог\n5 - Посмотреть диск\n6 - Выход из программы");
                        m = Convert.ToInt32(Console.ReadLine());
                        switch (m)
                        {
                            case 0:
                            {
                                Console.WriteLine("Введите название диска");
                                string nameDisk = Console.ReadLine();
                                Console.WriteLine("Введите название трека");
                                string nameMusic = Console.ReadLine();
                                disk.Add(nameDisk, nameMusic);
                                break;
                            }
                            case 1:
                            {
                                Console.WriteLine("Введите диск который надо удалить");
                                disk.Remove(Console.ReadLine());
                                Console.WriteLine("Диск удален");
                                break;
                            }
                            case 2:
                            {
                                Console.WriteLine("Введите диск в котором хотите добавить трек");
                                string addDisk = Console.ReadLine();
                                Console.WriteLine("Введите трек который хотите добавить");
                                string addMusic = Console.ReadLine();
                                ICollection с = disk.Keys;
                                ICollection v = disk.Values;
                                foreach (string key in с)
                                {
                                    if (key == addDisk)
                                    {

                                    }

                                    Console.WriteLine(key);
                                }

                                break;
                            }
                            case 3:
                            {
                                Console.WriteLine("Введите диск в котором хотите удалить трек");
                                string clearDisk = Console.ReadLine();
                                Console.WriteLine("Введите трек который хотите удалить");
                                string clearMusic = Console.ReadLine();
                                ICollection с = disk.Keys;
                                foreach (string str in с)
                                    Console.WriteLine(str + ": " + disk[str]);
                                break;
                            }
                            case 4:
                            {
                                Console.WriteLine("Все диски в программе");
                                ICollection с = disk.Keys;
                                ICollection v = disk.Values;
                                Console.WriteLine("Показать все диски");
                                foreach (string str in с)
                                    Console.WriteLine(str + ": " + disk[str]);
                                break;
                            }
                            case 5:
                            {
                                Console.WriteLine("Введите название диска который хотите просмотреть");
                                string findDisk = Console.ReadLine();
                                ICollection с = disk.Keys;
                                ICollection v = disk.Values;
                                foreach (string str in с)
                                    if (str == findDisk)
                                    {
                                        Console.WriteLine(str + ": " + disk[str]);
                                        break;
                                    }

                                break;
                            }
                            default:
                            {
                                Console.WriteLine("Ошибка ввода");
                                break;
                            }
                        }

                    } while (true);
                    break;
                }
                case 5: // part 2
                {
                    CSet<int> set1 = new CSet<int>() { 5, 6, 7, 8, 9 };
                    CSet<int> set2 = new CSet<int>() { 4, 5, 6, 7, 8 };
                    CSet<int> set3 = new CSet<int>() { 2, 3, 4 };
                    CSet<int> set4 = new CSet<int>() { 7, 8, 9 };

                    Console.WriteLine("Множество set1: " + set1);
                    Console.WriteLine("Множество set2: " + set2);
                    Console.WriteLine("Множество set3: " + set3);
                    Console.WriteLine("Множество set4: " + set4);

                    // Объединение
                    CSet<int> setUnion = set1 + set2;
                    Console.WriteLine("set1 + set2: " + setUnion);

                    // Разница
                    CSet<int> setDiff = set1 - set2;
                    Console.WriteLine("set1 - set2: " + setDiff);

                    // Пересечение
                    CSet<int> setInter = set1 & set2;
                    Console.WriteLine("set1 & set2: " + setInter);

                    // Мощность множества
                    var pow = (int)set1;
                    Console.WriteLine($"Мощность множества set1(int): {pow}");

                    // Сравнение множеств
                    if (set3 <= set1)
                    {
                        Console.WriteLine("(<=)set3 является подмножеством set1");
                    }
                    else
                    {
                        Console.WriteLine("(<=)set3 не является подмножеством set1");
                    }
                    if (set4 >= set2)
                    {
                        Console.WriteLine("(>=)set4 является надмножеством set2");
                    }
                    else
                    {
                        Console.WriteLine("(>=)set4 не является надмножеством set2");
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

        class Employee : IComparable
        {
            public string Name { get; set; }
            public int HireYear { get; set; }
            public string Position { get; set; }
            public double Salary { get; set; }
            public int WorkExperience { get; set; }

            public Employee(string name, int hireYear, string position, double salary, int workExperience)
            {
                Name = name;
                HireYear = hireYear;
                Position = position;
                Salary = salary;
                WorkExperience = workExperience;
            }

            public override string ToString()
            {
                return $"Информация о сотруднике: \n" +
                       $"Имя: {Name}\n" +
                       $"Год найма: {HireYear}\n" +
                       $"Должность: {Position}\n" +
                       $"Зарплата: {Salary}\n" +
                       $"Стаж: {WorkExperience}";
            }

            public int CompareTo(object obj)
            {
                throw new NotImplementedException();
            }
        }
        public class CompactDisc
        {
            public string Title { get; set; }
            public List<string> Songs { get; set; }
        }
        public class MusicCatalog
        {
            private Hashtable _catalog;

            public MusicCatalog()
            {
                _catalog = new Hashtable();
            }

            public void AddCompactDisc(CompactDisc cd)
            {
                _catalog.Add(cd.Title, cd);
            }

            public void RemoveCompactDisc(string title)
            {
                _catalog.Remove(title);
            }

            public void AddSong(string cdTitle, string song)
            {
                CompactDisc cd = (CompactDisc)_catalog[cdTitle];
                cd.Songs.Add(song);
            }

            public void RemoveSong(string cdTitle, string song)
            {
                CompactDisc cd = (CompactDisc)_catalog[cdTitle];
                cd.Songs.Remove(song);
            }

            public CompactDisc GetCompactDisc(string title)
            {
                return (CompactDisc)_catalog[title];
            }

            public List<CompactDisc> GetAllCompactDiscs()
            {
                List<CompactDisc> cds = new List<CompactDisc>();
                foreach (DictionaryEntry entry in _catalog)
                {
                    cds.Add((CompactDisc)entry.Value);
                }
                return cds;
            }

            public List<CompactDisc> SearchByArtist(string artist)
            {
                List<CompactDisc> cds = new List<CompactDisc>();
                foreach (DictionaryEntry entry in _catalog)
                {
                    CompactDisc cd = (CompactDisc)entry.Value;
                    if (cd.Songs.Any(x => x.Contains(artist)))
                    {
                        cds.Add(cd);
                    }
                }
                return cds;
            }
        }
    }
}