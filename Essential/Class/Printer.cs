using System;
namespace Essential.Class
{
//    Задание
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Требуется:
//Создайте класс Printer.
//В теле класса создайте метод void Print(string value), который выводит на экран значение аргумента.
//Реализуйте возможность того, чтобы в случае наследования от данного класса других классов, и вызове соответствующего метода их экземпляра, строки, переданные в качестве аргументов методов, выводились разными цветами.
//Обязательно используйте приведение типов.

    class Printer
    {
        public virtual void Print(string value)
        {
            Console.WriteLine(value);
        }
    }
    class ColorPrinter : Printer
    {
        public override void Print(string value)
        {
            PrintsColors(value);
        }
        private void PrintsColors(string value)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(value);
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(value);
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(value);
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(value);
            Console.ResetColor();
        }
    }
}
