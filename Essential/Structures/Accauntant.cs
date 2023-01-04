using System;
using System.Linq;
namespace Essential.Structures
{
    //    Задание 3
    //Используя Visual Studio, создайте проект по шаблону Console Application.
    //Создайте перечисление, в котором будут содержаться должности сотрудников как имена констант.
    //Присвойте каждой константе значение, задающее количество часов, которые должен отработать сотрудник за месяц.
    //Создайте класс Accauntant с методом bool AskForBonus(Post worker, int hours), отражающее давать или нет сотруднику премию.
    //Если сотрудник отработал больше положеных часов в месяц, то ему положена премия.

    public enum Post:int
    {
        cook = 100,
        waiter = 110,
        teacher = 120,
    }
    public class Accauntant
    {
        public bool AskForBonus(Post worker, int hoursWorked)
        {
            bool result;
            result = (hoursWorked > (int)worker) ? true : false;
            if (result == true)
            {
                Console.WriteLine("You will get a bonus");
            }
            if (result == false)
            {
                Console.WriteLine("You will not get a bonus");
            }
            return result;
        }
    } 
}
