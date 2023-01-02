using System;
namespace Essential.Structures
{
    //    Задание 3
    //Создайте класс MyClass и структуру MyStruct, которые содержат в себе поля public string change.
    //В классе Program создайте два метода:
    //- static void ClassTaker(MyClass myClass), который присваивает полю change экземпляра myClass значение «изменено».
    //- static void StruktTaker(MyStruct myStruct), который присваивает полю change экземпляра myStruct значение «изменено».
    //Продемонстрируйте разницу в использовании классов и структур, создав в методе Main() экземпляры структуры и класса.
    //Измените, значения полей экземпляров на «не изменено», а затем вызовите методы ClassTaker и StruktTaker.
    //Выведите на экран значения полей экземпляров. Проанализируйте полученные результаты.

    public class MyClass
    {
        public string change;
    }
    public struct MyStruct
    {
        public string change;
    }
    public static class Program1
    {
        public static void ClassTaker(MyClass myClass)
        {
            myClass.change = "change";
        }
        public static void StruktTaker(MyStruct myStruct)
        {
            myStruct.change = "change";
        }
    }
    //static void Main(string[] args)
    //{
       //MyClass myClass = new MyClass();
       //myClass.change = "not changed";
       //MyStruct myStruct;
       //myStruct.change = "not changed";
       //Program1.ClassTaker(myClass);
       //Program1.StruktTaker(myStruct);
    //}
}
