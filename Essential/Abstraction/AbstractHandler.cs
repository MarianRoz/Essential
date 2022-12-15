using System;
namespace Essential.Abstraction
{
//Задание 2
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Требуется:
//Создайте класс AbstractHandler.
//В теле класса создать методы void Open(), void Create(), void Chenge(), void Save().
//Создать производные классы XMLHandler, TXTHandler, DOCHandler от базового класса AbstractHandler.
//Написать программу, которая будет выполнять определение документа и для каждого формата должны быть методы открытия, создания, редактирования, сохранения определенного формата документа.

    public abstract class AbstractHandler
    {
        public abstract void Open();
        public abstract void Create();
        public abstract void Chenge();
        public abstract void Save();
    }
    class XMLHandler : AbstractHandler
    {
        public override void Open()
        { Console.WriteLine("Open XMLHandler"); }
        public override void Create()
        { Console.WriteLine("Create XMLHandler"); }
        public override void Chenge()
        { Console.WriteLine("Chenge XMLHandler"); }
        public override void Save()
        { Console.WriteLine("Save XMLHandler"); }
    }
    class TXTHandler : AbstractHandler
    {
        public override void Open()
        { Console.WriteLine("Open TXTHandler"); }
        public override void Create()
        { Console.WriteLine("Create TXTHandler"); }
        public override void Chenge()
        { Console.WriteLine("Chenge TXTHandler"); }
        public override void Save()
        { Console.WriteLine("Save TXTHandler"); }
    }
    class DOCHandler : AbstractHandler
    {
        public override void Open()
        { Console.WriteLine("Open DOCHandler"); }
        public override void Create()
        { Console.WriteLine("Create DOCHandler"); }
        public override void Chenge()
        { Console.WriteLine("Chenge DOCHandler"); }
        public override void Save()
        { Console.WriteLine("Save DOCHandler"); }
    }
}
