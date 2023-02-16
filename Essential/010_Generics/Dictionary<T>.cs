using System;
namespace Essential._Generics
{
    //    Задание 3
    //Используя Visual Studio, создайте проект по шаблону Console Application.
    //Создайте класс MyDictionary<TKey, TValue>.
    //Реализуйте в простейшем приближении возможность использования его экземпляра аналогично экземпляру класса Dictionary (Урок 6 пример 5).
    //Минимально требуемый интерфейс взаимодействия с экземпляром, должен включать метод добавления пар элементов,
    //индексатор для получения значения элемента по указанному индексу и свойство только для чтения для получения общего количества пар элементов.
    public class MyDictionary<TKey, TValue>
    {
        private TKey[] key1;
        private TValue[] value1;
        private int length1;

        public MyDictionary(int length)
        {
            key1 = new TKey[length];
            value1 = new TValue[length];
            length1 = length;
        }

        public void Add(TKey key, TValue value, int length)
        {
            if (length1 > length)
            {
                key1[length] = key;
                value1[length] = value;
            }
        }
        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < key1.Length)
                    return key1[index] + " - " + value1[index];
                return "Non exist index";
            }
        }
        private int Property
        {
            get { return length1; }
        }

        /// IN A STATIC CLASS

        //public static class MyDictionary<TKey, TValue>
        //{
        //    private static TKey[] key1;
        //    private static TValue[] value1;
        //    private static int length1;

        //    public static void AddArray(int length)
        //    {
        //        key1 = new TKey[length];
        //        value1 = new TValue[length];
        //    }
        //    public static void Add(TKey key, TValue value, int lengthFor, int length2)
        //    {
        //        if (length2 > lengthFor)
        //        {
        //            key1[lengthFor] = key;
        //            value1[lengthFor] = value;
        //        }
        //        else Console.WriteLine("Non exist index");
        //    }
        //    public static void SearchByIndex(int index)
        //    {
        //        if (index < key1.Length && index < value1.Length)
        //            Console.WriteLine(key1[index] + " - " + value1[index]);
        //        else
        //            Console.WriteLine("Non exist index");
        //    }
        //    public static void LengthArray(int length)
        //    {
        //        Console.WriteLine($"Total number of pairs of elements - {length}");
        //    }
        //}
    }
}
