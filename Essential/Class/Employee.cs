using System;
namespace Essential.Class
{
//    Задание 3
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Требуется:
//Создать класс Employee.
//В теле класса создать пользовательский конструктор, который принимает два строковых аргумента, и инициализирует поля, соответствующие фамилии и имени сотрудника.
//Создать метод рассчитывающий оклад сотрудника (в зависимости от должности и стажа) и налоговый сбор.
//Написать программу, которая выводит на экран информацию о сотруднике(фамилия, имя, должность), оклад и налоговый сбор.

    public class Employee
    {
        public string name, surname;
        public double tax, salary;
        public Employee(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }
        public void SalaryAndTaxEmployee(string position, double experience)
        {
            if (position == "Photographer" || position == "photographer")
            {
                PhotographerSalary(position, experience);
            }
            else
            {
                Console.WriteLine("This position non exist");
            }
        }
        private void PhotographerSalary(string position, double experience)
        {
            if (experience < 12)
            {
                salary = 200;
                tax = salary / 5;
                Console.WriteLine($"{name} {surname}, {position}, salary = {salary}$, tax {tax}$");
            }
            if (experience >= 12 && experience < 24)
            {
                salary = 300;
                tax = salary / 5;
                Console.WriteLine($"{name} {surname}, {position}, salary = {salary}$, tax {tax}$");
            }
            if (experience >= 24 && experience < 60)
            {
                salary = 400;
                tax = salary / 5;
                Console.WriteLine($"{name} {surname}, {position}, salary = {salary}$, tax {tax}$");
            }
            if (experience >= 60)
            {
                salary = 600;
                tax = salary / 5;
                Console.WriteLine($"{name} {surname}, {position}, salary = {salary}$, tax {tax}$");
            }
        }
    }
}
