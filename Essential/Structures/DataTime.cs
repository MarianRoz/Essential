using System;
namespace Essential.Structures
{
//    Задание
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Реализуйте программу, которая будет принимать от пользователя дату его рождения и выводить количество дней до его следующего дня рождения.
    struct DataTime
    {
        public DataTime(DateTime hB)
        {
            DateTime today = DateTime.Now;
            TimeSpan left = hB - today;
            Console.WriteLine("My birthday will be in " +left.Days+ " days and " +left.Hours+ " hours");
        }
    }
}
