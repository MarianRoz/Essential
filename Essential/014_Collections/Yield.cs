using System;
using System.Collections;

namespace Essential._Collections
{
//    Задание
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Создайте метод, который в качестве аргумента принимает массив целых чисел и возвращает коллекцию всех четных чисел массива.
//Для формирования коллекции используйте оператор yield.
    class Yield : IEnumerable
    {
        int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 ,10 };
        
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]%2==0)
                {
                    yield return array[i];
                    Console.WriteLine(array[i]);
                }
            }
        }
    }
}
