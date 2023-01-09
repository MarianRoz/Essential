using System;
namespace Essential.Delegates
{
    //    Задание 2
    //Используя Visual Studio, создайте проект по шаблону Console Application.
    //Создайте четыре лямбда оператора для выполнения арифметических действий: (Add – сложение, Sub – вычитание, Mul – умножение, Div – деление).
    //Каждый лямбда оператор должен принимать два аргумента и возвращать результат вычисления.
    //Лямбда оператор деления должен делать проверку деления на ноль.
    //Написать программу, которая будет выполнять арифметические действия указанные пользователем.

    class AddOperatorLambda
    {
        delegate int MyDelegate(int a, int b);

        public static void Add()
        {
            Console.WriteLine("Enter first number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            MyDelegate myDelegate = null;
            myDelegate = (a, b) => { return a + b; };
            Console.WriteLine(myDelegate(a, b));
        }
        public static void Sub()
        {
            Console.WriteLine("Enter first number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            MyDelegate myDelegate = null;
            myDelegate = (a, b) => { return a - b; };
            Console.WriteLine(myDelegate(a, b));
        }
        public static void Mul()
        {
            Console.WriteLine("Enter first number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            MyDelegate myDelegate = null;
            myDelegate = (a, b) => { return a * b; };
            Console.WriteLine(myDelegate(a, b));
        }
        public static void Div()
        {
            Console.WriteLine("Enter first number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int c = 0;
            MyDelegate myDelegate = null;
            myDelegate = (a, b) =>
            {
                if (b != 0)
                    c = a / b;
                else
                    Console.WriteLine("You cannot divide by zero");
                return c;
            };
            Console.WriteLine(myDelegate(a, b));
        }
    }
}
//namespace Essential
//{
//    partial class Program
//    {
//        static void Main(string[] args)
//        {
//            AddOperatorLambda.Add();
//            AddOperatorLambda.Sub();
//            AddOperatorLambda.Mul();
//            AddOperatorLambda.Div();
//        }
//    }
//}
