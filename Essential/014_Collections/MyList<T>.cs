using System;
using System.Collections;
using System.Collections.Generic;

namespace Essential._Collections
{
    //Задание 2
    //Используя Visual Studio, создайте проект по шаблону Console Application.
    //Создайте коллекцию MyList<T>.
    //Реализуйте в простейшем приближении возможность использования ее экземпляра аналогично экземпляру класса List<T>.
    //Минимально требуемый интерфейс взаимодействия с экземпляром, должен включать метод добавления элемента,
    //индексатор для получения значения элемента по указанному индексу
    //и свойство только для чтения для получения общего количества элементов.
    //Реализуйте возможность перебора элементов коллекции в цикле foreach.
    
    class MyList1<T> : IEnumerable<T>
    {
        int positions = -1;
        T[] array = new T[0];
        T[] array1 = null;
        public void Add(T addElement)
        {
            T[] array1 = new T[array.Length + 1];
            array.CopyTo(array1, 0);
            array1[array.Length] = addElement;
            array = array1;
        }
        public T this[int index]
        {
            get { return array[index]; }
        }
        public int MyList1_
        {
            get { return array.Length; }
        }
        public int Count
        {
            get { return array.Length; }
        }
        public IEnumerator<T> GetEnumerator()
        {
            while (true)
            {
                positions++;
                if (positions < array.Length)
                {
                    yield return array[positions];
                }
                else
                {
                    positions = -1;
                    yield break;
                }
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}