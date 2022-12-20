using System;
namespace Essential.ArraysIndexers
{
    //    Задание 2
    //Используя Visual Studio, создайте проект по шаблону Console Application.
    //Требуется:
    //Создать массив размерностью N элементов, заполнить его произвольными целыми значениями.
    //Вывести наибольшее значение массива, наименьшее значение массива, общую сумму элементов, среднее арифметическое всех элементов, вывести все нечетные значения.
    class Array_
    {
        private double maxValue;
        private double minValue;
        private double totalValue;
        private double arithmeticMean;
        private double oddValues;
        int[] array = new int[5];
        public Array_()
        {
            array[0] = 1;
            array[1] = 2;
            array[2] = 3;
            array[3] = 4;
            array[4] = 5;
        }
        public void TotalMethod()
        {
            MaxValue();
            MinValue();
            TotalValue();
            ArithmeticMean();
            OddValues();
        }
        private void MaxValue()
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= array[i])
                {
                    maxValue = array[i];
                }
            }
            Console.WriteLine(maxValue);
        }
        private void MinValue()
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] <= minValue)
                {
                    minValue = array[i];
                }
            }
            Console.WriteLine(minValue);
        }
        private void TotalValue()
        {
            for (int i = 0; i < array.Length; i++)
            {
                totalValue += array[i];
            }
            Console.WriteLine(totalValue);
        }
        private void ArithmeticMean()
        {
            Console.WriteLine(arithmeticMean = totalValue / array.Length);
        }
        private void OddValues()
        {
            for (int i = 0; i < array.Length; i++)
            {
                if ((array[i] %2) != 0)
                {
                    Console.Write($"{array[i]} ");
                }
            }
        }
    }
}
