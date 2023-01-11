using System;
namespace Essential._Generics
{
    //    Задание
    //Используя Visual Studio, создайте проект по шаблону Console Application.
    //Создайте класс MyClass<T>, содержащий статический фабричный метод - T FacrotyMethod(),
    //который будет порождать экземпляры типа, указанного в качестве параметра типа(указателя места заполнения типом – Т).

    public class MyClass<T> where T : new()
    {
        public static T FacrotyMethod()
        { 
            return new T();
        }
    }
}
//namespace Essential
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            MyClass<int> a = new MyClass<int>();
//            Console.WriteLine(a.GetHashCode());
//        }
//    }
//}
