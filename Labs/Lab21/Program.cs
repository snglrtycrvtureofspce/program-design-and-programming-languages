using System;
using System.Xml;

namespace Lab21
{
    internal class Program
    {
        private static readonly Random Random = new Random();
        private static int _count = 0;
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Меню программы:" +
                              "\n0 - Выход" +
                              "\n1 - Создание через XMLDoc" +
                              "\n2 - Чтение и создание объектов" +
                              "\n3 - Добавление объектов в XML" +
                              "\n4 - Удаление объектов из XML" +
                              "\n5 - Работа с Xpath" +
                              "\nВыберите действие: ");
                var p = Console.ReadLine();
                switch (p)
                {
                    case "0": // выход
                    {
                        Console.Clear();
                        Console.WriteLine("Выход из программы...");
                        return;
                    }
                    case "1":
                    {
                        CreateXmlDoc();
                        break;
                    }
                    case "2":
                    {
                        ReadXmlDoc();
                        break;
                    }
                    case "3":
                    {
                        XmlDocument docAdd = new XmlDocument();
                        docAdd.Load("Vectors.xml");
                        AddXmlNode(docAdd);
                        break;
                    }
                    case "4":
                    {
                        XmlDocument docRemove = new XmlDocument();
                        docRemove.Load("Vectors.xml");
                        RemoveXmlNode(docRemove);
                        break;
                    }
                    case "5":
                    {
                        XmlDocument docXpath = new XmlDocument();
                        docXpath.Load("Vectors.xml");
                        XpathSearch(docXpath);
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

        public static void CreateXmlDoc() // Создание XML-документа
        {
            XmlDocument doc = new XmlDocument();

            XmlDeclaration declaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            doc.AppendChild(declaration);

            XmlElement root = doc.CreateElement("Vectors");
            doc.AppendChild(root);

            XmlElement vector1 = CreateXmlNode(doc, "Vector", $"Vector{_count}", Random.NextDouble(), Random.NextDouble(), Random.Next(0,99));
            root.AppendChild(vector1);
            _count++;

            doc.Save("vectors.xml");
            Console.WriteLine("XML-документ успешно создан!");
        }

        private static XmlElement CreateXmlNode(XmlDocument doc, string elementName, string name, double x,
            double y, double z) // Создание узла для вектора
        {
            XmlElement element = doc.CreateElement(elementName);

            XmlElement nameElement = doc.CreateElement("Name");
            nameElement.InnerText = name;
            element.AppendChild(nameElement);

            XmlElement xElement = doc.CreateElement("X");
            xElement.InnerText = x.ToString();
            element.AppendChild(xElement);

            XmlElement yElement = doc.CreateElement("Y");
            yElement.InnerText = y.ToString();
            element.AppendChild(yElement);

            XmlElement zElement = doc.CreateElement("Z");
            zElement.InnerText = z.ToString();
            element.AppendChild(zElement);

            return element;
        }

        public static void ReadXmlDoc() // Чтение объектов из XML-документа
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("vectors.xml");

            XmlNodeList nodes = doc.SelectNodes("//Vector");
            foreach (XmlNode node in nodes)
            {
                string name = node.SelectSingleNode("Name").InnerText;
                double x = double.Parse(node.SelectSingleNode("X").InnerText);
                double y = double.Parse(node.SelectSingleNode("Y").InnerText);
                double z = double.Parse(node.SelectSingleNode("Z").InnerText);

                Console.WriteLine($"Вектор: {name}" +
                                  $"\nX: {x}" +
                                  $"\nY: {y}" +
                                  $"\nZ: {z}");
            }
        }

        public static void AddXmlNode(XmlDocument doc) // Добавление узла в XML-документ
        {
            XmlElement vector = CreateXmlNode(doc, "Vector", $"Vector{_count}", Random.NextDouble(), Random.Next(0,99), Random.NextDouble());
            _count++;

            XmlNode root = doc.DocumentElement;
            root.AppendChild(vector);

            doc.Save("vectors.xml");
            Console.WriteLine("Узел добавлен в XML-документ.");
        }

        public static void RemoveXmlNode(XmlDocument doc) // Удаление узла из XML-документа
        {
            Console.Write("Введите имя вектора для удаления: ");
            string name = Console.ReadLine();

            XmlNode node = doc.SelectSingleNode($"//Vector[Name='{name}']");
            if (node != null)
            {
                node.ParentNode.RemoveChild(node);
                Console.WriteLine("Узел удален из XML-документа.");
            }
            else
            {
                Console.WriteLine("Узел не найден.");
            }
            _count--;

            doc.Save("vectors.xml");
        }

        public static void XpathSearch(XmlDocument doc) // Поиск узлов в XML-документе по Xpath-выражению
        {
            Console.Write("Введите Xpath-выражение: ");
            string xpath = Console.ReadLine();

            XmlNodeList nodes = doc.SelectNodes(xpath);
            foreach (XmlNode node in nodes)
            {
                Console.WriteLine(node.OuterXml);
            }
        }
    }
}