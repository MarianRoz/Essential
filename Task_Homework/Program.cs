using System;
using Task_Homework.Class;

namespace Task_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            Console.WriteLine(cat.Name = "Name: Myrchik");
            cat.Go();

            Dog dog = new Dog();
            Console.WriteLine(dog.Name = "Name: Myhtar");
            dog.Go();

            Rabbit rabbit = new Rabbit();
            Console.WriteLine(rabbit.Name = "Name: Rabbitok");
            rabbit.Go();

            Crow crow = new Crow();
            Console.WriteLine(crow.Name = "Name: Black");
            crow.Go();
            crow.Fly();

            Plane plane = new Plane();
            Console.WriteLine(plane.Name = "Name: AirLine");
            plane.Fly();
        }
    }
}
