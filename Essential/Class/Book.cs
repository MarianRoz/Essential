using System;
namespace Essential.Tasks
{
    //Используя Visual Studio, создайте проект по шаблону Console Application.
    //Требуется:
    //Создать класс Book.Создать классы Title, Author и Content, каждый из которых должен содержать одно строковое поле и метод void Show().
    //Реализуйте возможность добавления в книгу названия книги, имени автора и содержания.
    //Выведите на экран разными цветами при помощи метода Show() название книги, имя автора и содержание.
    //add 1
    //add 2
    //add 3
    //add 4
    //add 5
    //add 6
    //add 7
    class Program
    {
        public partial class Book
        {
            public Title Title { get; set; }
            public Author Author { get; set; }
            public Content Content { get; set; }

            public void Show()
            {
                Title.Show();
                Author.Show();
                Content.Show();
            }
        }
        public partial class Title
        {
            public string title = "My Life";
            public void Show()
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(title);
                Console.ResetColor();
            }
        }
        public partial class Author
        {
            public string author = "Marian Rozumnyi";
            public void Show()
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(author);
                Console.ResetColor();
            }
        }
        public partial class Content
        {
            public string content = "Hobby";
            public void Show()
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(content);
                Console.ResetColor();
            }
        }
    }
}