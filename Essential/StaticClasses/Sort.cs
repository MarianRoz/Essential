using System;
namespace Essential.StaticClasses
{
//    Задание 4
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Требуется: Создать расширяющий метод для целочисленного массива, который сортирует элементы массива по возрастанию.

    public static class Sort
    {
        public static void Sorted(int[] ar)
        {
            for (int i = 0; i < ar.Length; i++)
            {
                for (int j = 0; j < ar.Length-1; j++)
                {
                    if (ar[j] > ar[j + 1])
                    {
                        int z = ar[j];
                        ar[j] = ar[j + 1];
                        ar[j + 1] = z;
                    }
                }
            }
        }
    }
}
