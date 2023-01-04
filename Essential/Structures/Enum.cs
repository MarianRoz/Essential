using System;
namespace Essential.Structures
{
    //    Задание 2
    //Используя Visual Studio, создайте проект по шаблону Console Application.
    //Создайте статический класс с методом void Print (string stroka, int color), который выводит на экран строку заданным цветом.
    //Используя перечисление, создайте набор цветов, доступных пользователю.
    //Ввод строки и выбор цвета предоставьте пользователю.

    enum MyEnum
    {
        red = 1,
        blue = 2,
        yelloy = 3,
    }
    public static class MyClassEnum
    {
        public static void Print(string stroka, int color)
        {
            switch (color)
            {
                case (int)MyEnum.red:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case (int)MyEnum.blue:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case (int)MyEnum.yelloy:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                default:
                    Console.WriteLine("This color not exist. ");
                    stroka = "null";
                    break;
            }
            if (stroka!="null")
            {
                Console.WriteLine(stroka);
                Console.ResetColor();
            }
        }
    }
}
