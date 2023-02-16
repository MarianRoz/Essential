using System;
using System.Collections;
using System.Collections.Generic;

namespace Essential._Collections
{
    //    Задание 3
    //Используя Visual Studio, создайте проект по шаблону Console Application.
    //Создайте коллекцию MyDictionary<TKey, TValue>.
    //Реализуйте в простейшем приближении возможность использования ее экземпляра аналогично экземпляру класса Dictionary<TKey, TValue>.
    //Минимально требуемый интерфейс взаимодействия с экземпляром, должен включать метод добавления элемента,
    //индексатор для получения значения элемента по указанному индексу
    //и свойство только для чтения для получения общего количества элементов.
    //Реализуйте возможность перебора элементов коллекции в цикле foreach.
    class MyDictionary<TKey, TValue> : IEnumerable<object>, IEnumerator<object>
    {
        private TKey[] key;
        private TValue[] value;
        private int lenght;
        private int position = -1;

        public int Lenght
        { get { return lenght; } }

        public MyDictionary(int n)
        {
            key = new TKey[n];
            value = new TValue[n];
            lenght = n;
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < key.Length)
                    return key[index] + " - " + value[index];
                return "Попитка звернення за межі масива.";
            }
        }

        public void Add(int i, TKey k, TValue l)
        {
            key[i] = k;
            value[i] = l;
        }
        public bool MoveNext()
        {
            if (position < key.Length - 1)
            {
                position++;
                return true;
            }
            return false;
        }

        public void Reset()
        { position = -1; }

        public void Dispose()
        { Reset(); }

        public object Current
        { get { return key[position] + " " + value[position]; } }

        public IEnumerator<object> GetEnumerator()
        { return this; }

        IEnumerator IEnumerable.GetEnumerator()
        { return this; }
    }
}