using System;
namespace Essential.Class
{
//    Задание 4
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Требуется:
//Создать класс Invoice.
//В теле класса создать три поля int account, string customer, string provider которые должны быть проинициализированы один раз (при создании экземпляра данного класса) без возможности их дальнейшего изменения.
//В теле класса создать два закрытых поля string article, int quantity
//Создать метод расчета стоимости заказа с НДС и без НДС.
//Написать программу, которая выводит на экран сумму оплаты заказанного товара с НДС или без НДС.

    public class Invoice
    {
        readonly int account;
        readonly string customer, provider;
        public string article;
        public int quantity;

        public Invoice(int account,string customer,string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }
        public void CalculationCost(string article, int quantity)
        {
            if (article == "123")
            {
                int amountWithTax = 200 * quantity;
                Console.WriteLine($"Amount With Tax {amountWithTax}$\nAmount without tax {amountWithTax-(amountWithTax/5)}$ ");
            }
            if (article == "321")
            {
                int amountWithTax = 200 * quantity;
                Console.WriteLine($"Amount With Tax {amountWithTax}$\nAmount without tax {amountWithTax - (amountWithTax / 5)}$ ");
            }
        }
    }
}
