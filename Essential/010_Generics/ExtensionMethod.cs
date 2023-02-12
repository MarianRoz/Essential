using System;
namespace Essential._Generics
{
    //    Задание 4
    //Используя Visual Studio, создайте проект по шаблону Console Application.
    //Создайте расширяющий метод: public static T[] GetArray<T>(this MyList<T> list)
    //Примените расширяющий метод к экземпляру типа MyList<T>, разработанному в домашнем задании 2 для данного урока.
    //Выведите на экран значения элементов массива, который вернул расширяющий метод GetArray().

    class MyListTwo<T>
    {
        private readonly int lenght;
        private readonly T[] arr;

        public int Lenght
        {
            get { return lenght; }
        }

        public MyListTwo(int n)
        {
            arr = new T[n];
            lenght = arr.Length;
        }

        public T this[int i]
        {
            get { return arr[i]; }
        }

        public void Add(int i, T k)
        {
            arr[i] = k;
        }
    }
    static class ExtensionMyList
    {
        public static T[] GetArray<T>(this MyListTwo<T> list)
        {
            var temp = new T[list.Lenght];
            for (int i = 0; i < list.Lenght; i++)
            {
                temp[i] = list[i];
            }
            return temp;
        }
    }

}
