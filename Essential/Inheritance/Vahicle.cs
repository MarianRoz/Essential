using System;
namespace Essential.Inheritance
{
    //    Задание 3
    //Используя Visual Studio, создайте проект по шаблону Console Application.
    //Требуется:
    //Создать класс Vehicle.
    //В теле класса создайте поля: координаты и параметры средств передвижения (цена, скорость, год выпуска).
    //Создайте 3 производных класса Plane, Саг и Ship.
    //Для класса Plane должна быть определена высота и количество пассажиров.
    //Для класса Ship — количество пассажиров и порт приписки.
    //Написать программу, которая выводит на экран информацию о каждом средстве передвижения.

    public class Vehicle
    {
        public int prise;
        public int speed;
        public int year;
    }
    class Plane : Vehicle
    {
        public Plane(int prise, int speed, int year)
        {
            this.prise = prise;
            this.speed = speed;
            this.year = year;
        }
        public void Method(int height, int passengersPlane)
        {
            Console.WriteLine($"Plane: prise-{prise} $, speed-{speed} km/h, year-{year}, height-{height} meters, passengers plane-{passengersPlane} people");
        }
    }
    class Car : Vehicle
    {
        public Car(int prise, int speed, int year)
        {
            this.prise = prise;
            this.speed = speed;
            this.year = year;
        }
        public void Method()
        {
            Console.WriteLine($"Car: prise-{prise} $, speed-{speed} km/h, year-{year}");
        }
    }
    class Ship : Vehicle
    {
        public Ship(int prise, int speed, int year)
        {
            this.prise = prise;
            this.speed = speed;
            this.year = year;
        }
        public void Method(int homePort, int passengersPlane)
        {
            Console.WriteLine($"Ship: prise-{prise} $, speed-{speed} km/h, year-{year}, home port-{homePort}, passengers plane-{passengersPlane} people");
        }
    }
}
