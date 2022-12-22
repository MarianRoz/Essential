using System;
namespace Essential.StaticClasses
{
//    Задание
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Требуется:
//Создать статический класс Calculator, с методами для выполнения основных арифметических операций.
//Написать программу, которая выводит на экран основные арифметические операции.

    static class Calculator
    {
        public static void Calculators(double a, double b)
        {
            Console.WriteLine("Введіть арифметичний знак (+,-,*,/) ");
            string st = Console.ReadLine();
            switch (st)
            {
                case "+":
                    Calculator.Add(a, b);
                    break;
                case "-":
                    Calculator.Subtraction(a, b);
                    break;
                case "*":
                    Calculator.Multiplication(a, b);
                    break;
                case "/":
                    Calculator.Division(a, b);
                    break;

                default:
                    Console.WriteLine("Ви ввели неправильний арифметичний знак");
                    break;
            }
        }
        static void Add(double a, double b)
        {
            Console.WriteLine($"Add {a + b}");
        }
        static void Subtraction(double a, double b)
        {
            Console.WriteLine($"Subtraction {a - b}");
        }
        static void Multiplication(double a, double b)
        {
            Console.WriteLine($"Multiplication {a * b}");
        }
        static void Division(double a, double b)
        {
            Console.WriteLine($"Division {a / b}");
        }
    }
}
