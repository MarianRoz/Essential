using System;

//Задание 1
//Создайте собственное пространство имен MyNamespace с классом MyClass и подключите его в другом приложении.
namespace Apartment
{
    using Apartment.Toilet;
    using Apartment.Bedroom;

    namespace Toilet
    {
        class Rosette
        {
            public void On() { Console.WriteLine("The light in toilet on"); }
            public void Off() { Console.WriteLine("The light in toilet off"); }
        }
    }

    namespace Bedroom
    {
        class Rosette
        {
            public void On() { Console.WriteLine("The light in bedroom on"); }
            public void Off() { Console.WriteLine("The light in bedroom off"); }
        }
    }
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Apartment.Toilet.Rosette bulbToilet = new Apartment.Toilet.Rosette();
    //        bulbToilet.On();
    //        Apartment.Bedroom.Rosette bulbBedroom = new Apartment.Bedroom.Rosette();
    //        bulbBedroom.On();
    //    }
    //}
}


