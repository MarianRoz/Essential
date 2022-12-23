using System;
namespace Essential.StaticClasses
{
    //Задание 2
    //Используя Visual Studio, создайте проект по шаблону Console Application.
    //Требуется:
    //Создать статический класс FindAndReplaceManager с методом void FindNext(string str) для поиска по книге из примера урока 005_Delegation.
    //При вызове этого метода, производится последовательный поиск строки в книге.
    //Задание 3
    //Используя Visual Studio, создайте проект по шаблону Console Application.
    //Расширьте пример урока 005_Delegation, создав в классе Book, вложенный класс Notes, который позволит сохранять заметки читателя.

    class FindAndReplaceManager
    {
        public string FindNext(string line)
        {
            switch (line)
            {
                case "1":
                    Console.WriteLine(line = "The first line");
                    break;
                case "2":
                    Console.WriteLine(line = "The second line");
                    break;
                case "3":
                    Console.WriteLine(line = "The tree line");
                    break;
                case "4":
                    Console.WriteLine(line = "The tree line");
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
        public class Notes
        {
            string addText;
            public string Note
            {
                get
                { return addText; }
                set
                { addText += "\n"; addText += value; }
            }
            public string FindNext(string line)
            {
                FindAndReplaceManager findAndReplaceManager = new FindAndReplaceManager();
                return findAndReplaceManager.FindNext(line);
            }
        }
    }
}
