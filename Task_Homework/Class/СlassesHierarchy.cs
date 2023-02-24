using System;
namespace Task_Homework.Class
{
    //Треба класно створити ієрархію наступних класів
    //Кіт пес кролик ворона і літак
    //Кіт пес кролик ворона мають властивість ім’я і метод йти
    //Ворона має ще метод літати
    //А літак має властивість ім’я і метод літати
    public abstract class СlassesHierarchy
    {
        string name;
        public abstract string Name
        { get; set; }
        public virtual void Go()
        { }
        public virtual void Fly()
        { }
    }
    public class Cat : СlassesHierarchy
    {
        string name;
        public override string Name
        { get { return name; } set { name = value; } }
        public override void Go()
        {
            Console.WriteLine("Cat can walk");
        }
    }
    public class Dog : СlassesHierarchy
    {
        string name;
        public override string Name
        { get { return name; } set { name = value; } }
        public override void Go()
        {
            Console.WriteLine("Dog can walk");
        }
    }
    public class Rabbit : СlassesHierarchy
    {
        string name;
        public override string Name
        { get { return name; } set { name = value; } }
        public override void Go()
        {
            Console.WriteLine("Rabbit can walk");
        }
    }
    public class Crow : СlassesHierarchy
    {
        string name;
        public override string Name
        { get { return name; } set { name = value; } }
        public override void Go()
        { Console.WriteLine("Сrow can walk"); }
        public override void Fly()
        { Console.WriteLine("Сrow can fly"); }
    }
    public class Plane : СlassesHierarchy 
    {
        string name;
        public override string Name
        { get { return name; } set { name = value; } }
        public override void Fly()
        { Console.WriteLine("Plane can fly"); }
    }
}
