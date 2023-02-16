using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Essential._Collections
{
//    Задание 4
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Создайте расширяющий метод: public static T[] GetArray<T>(this IEnumerable<T> list) { ...}
//Примените расширяющий метод к экземпляру типа MyList<T>, разработанному в домашнем задании 2 для данного урока.
//Выведите на экран значения элементов массива, который вернул расширяющий метод GetArray().

    public static class ExtensionMethods
    {
        public static T[] GetArray<T>(this IEnumerable<T> list)
        {
            T[] array = new T[list.Count()];

            int i = 0;

            foreach (T item in list)
            {
                array[i] = item;
                i++;
            }
            return array;
        }
    }
}
