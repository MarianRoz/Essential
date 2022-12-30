using System;
namespace Essential.Structures
{
//    Задание
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Создайте структуру с именем - Notebook.
//Поля структуры: модель, производитель, цена.
//В структуре должен быть реализован конструктор для инициализации полей и метод для вывода содержимого полей на экран.

    struct Notebook
    {
        int model;
        int manufacturer;
        int price;

        public Notebook(int model, int manufacturer, int price)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
        }
        public void Show()
        {
            Console.WriteLine($"{model}\n{manufacturer}\n{price}");
        }
    }
}
