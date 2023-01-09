using System;
namespace Essential.Delegates
{

    //Задание 3
    //Используя Visual Studio, создайте проект по шаблону Console Application.
    //Создайте анонимный метод, который принимает в качестве аргумента массив делегатов и возвращает среднее арифметическое возвращаемых значений методов сообщенных с делегатами в массиве.
    //Методы, сообщенные с делегатами из массива, возвращают случайное значение типа int.

    class ArrayOfDelegates
    {
        delegate int MyDelegate();
        delegate double Delegate(MyDelegate[] ar);

        static int Random()
        {
            return new Random().Next(100);
        }

        public static void ArithmeticMean()
        {
            Console.WriteLine("Enter the number of array elements:");
            int n = Convert.ToInt32(Console.ReadLine());
            var myArray = new MyDelegate[n];
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = () => new MyDelegate(Random)(); 
            }

            double arithmetic = 0;
            Delegate @delegate = (MyDelegate[] ar) =>
            {
                for (int i = 0; i < ar.Length; i++)
                {
                    arithmetic += ar[i].Invoke();
                }
                return arithmetic = arithmetic / ar.Length;
            };
            Console.WriteLine(@delegate(myArray));
        }
    }
}
//namespace Essential
//{
//    partial class Program
//    {
//        static void Main(string[] args)
//        {
//            ArrayOfDelegates.ArithmeticMean();
//        }
//    }
//}
