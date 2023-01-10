using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab19
{
    public class CSet<T> : IEnumerable where T : IComparable
    {
        private readonly List<T> _items;

        public CSet()
        {
            _items = new List<T>();
        }

        public CSet(IEnumerable<T> items)
        {
            _items = new List<T>(items);
            _items.Sort();
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= _items.Count)
                    // Возникает, когда недопустимый индекс используется
                    // для доступа к члену массива или коллекции,
                    // а также для чтения или записи из определенного расположения в буфере
                    throw new IndexOutOfRangeException();
                return _items[index];
            }
        }

        public void Add(T item)
        {
            var index = _items.BinarySearch(item);
            if (index < 0)
            {
                // Insert - вставляет в коллецию по указанному индексу
                _items.Insert(~index, item);
            }
        }

        public void Remove(T item)
        {
            // BinarySearch - выполняет поиск элемента по всему отсортированному
            // списку и возвращает индекс, отсчитываемый с нуля
            var index = _items.BinarySearch(item);
            if (index >= 0)
            {
                // RemoveAt - удаляет элемент списка с указанным индексом
                _items.RemoveAt(index);
            }
        }

        public void Clear()
        {
            _items.Clear();
        }

        public int Count => _items.Count;

        public bool Contains(T item)
        {
            return _items.BinarySearch(item) >= 0;
        }

        public static CSet<T> operator +(CSet<T> set1, CSet<T> set2)
        {
            CSet<T> result = new CSet<T>(set1._items);
            foreach (T item in set2._items)
            {
                if (!result.Contains(item))
                    result.Add(item);
            }

            return result;
        }

        public static CSet<T> operator -(CSet<T> set1, CSet<T> set2)
        {
            CSet<T> result = new CSet<T>(set1._items);
            foreach (T item in set2._items)
            {
                if (result.Contains(item))
                    result.Remove(item);
            }

            return result;
        }

        public static bool operator <=(CSet<T> set1, CSet<T> set2)
        {
            if (set1.Count > set2.Count)
                return false;
            foreach (T item in set1._items)
            {
                if (!set2.Contains(item))
                    return false;
            }

            return true;
        }

        public static bool operator >=(CSet<T> set1, CSet<T> set2)
        {
            return (set2 <= set1);
        }

        public static CSet<T> operator &(CSet<T> set1, CSet<T> set2)
        {
            CSet<T> result = new CSet<T>();
            foreach (T item in set1._items)
            {
                if (set2.Contains(item))
                    result.Add(item);
            }

            return result;
        }

        public static explicit operator int(CSet<T> set)
        {
            return set.Count;
        }

        public override string ToString()
        {
            return string.Join(", ", _items);
        }

        ~CSet()
        {
        }

        public IEnumerator GetEnumerator()
        {
            // Указывает, что метод или свойство,
            // которые вы пытаетесь вызвать,
            // не имеет реализации и, следовательно,
            // не предоставляет функциональных возможностей
            throw new NotImplementedException();
        }
    }
}