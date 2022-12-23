using System;
namespace Essential.StaticClasses
{
    //Задание 2
    //Используя Visual Studio, создайте проект по шаблону Console Application.
    //Требуется:
    //Создать статический класс FindAndReplaceManager с методом void FindNext(string str) для поиска по книге из примера урока 005_Delegation.
    //При вызове этого метода, производится последовательный поиск строки в книге.

    class FindAndReplaceManager
    {
        public string FindNext(string line)
        {
            switch (line)
            {
                case "1":
                    Console.WriteLine("The first line");
                    break;
                case "2":
                    Console.WriteLine("The second line");
                    break;
                case "3":
                    Console.WriteLine("The tree line");
                    break;
                case "4":
                    Console.WriteLine("The tree line");
                    break;

                default:
                    Console.WriteLine("This line not exist");
                    break;
            }
            return line;
        }
    }
    class Book
    {
        public string FindNext(string line)
        {
            FindAndReplaceManager findAndReplaceManager = new FindAndReplaceManager();
            return findAndReplaceManager.FindNext(line);
        }
    }
}
