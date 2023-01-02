using System;
namespace Essential.Structures
{
    //    Задание 2
    //Используя Visual Studio, создайте проект по шаблону Console Application.
    //Требуется: Описать структуру с именем Train, содержащую следующие поля: название пункта назначения, номер поезда, время отправления.
    //Написать программу, выполняющую следующие действия:
    //- ввод с клавиатуры данных в массив, состоящий из восьми элементов типа Train (записи должны быть упорядочены по номерам поездов);
    //- вывод на экран информации о поезде, номер которого введен с клавиатуры(если таких поездов нет, вывести соответствующее сообщение).

    public struct Train
    {
        private string name;
        private int number;
        private DateTime time;

        public Train(string name, int number, DateTime time)
        {
            this.name = name;
            this.number = number;
            this.time = time;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Number
        {
            get { return number; }
            set { number = value; }
        }
        public DateTime Time
        {
            get { return time; }
            set { time = value; }
        }
    }
    public static class TrainClass
    {
        public static void AddTrain(Train[] train)
        {
            for (int i = 0; i < train.Length; i++)
            {
                Console.WriteLine("Where is the train going?");
                string name = Console.ReadLine();

                Console.WriteLine("Train number");
                string fff = Console.ReadLine();
                int number = Convert.ToInt32(fff);

                Console.WriteLine("Departure time (month.day.years hour:minute)");
                fff = Console.ReadLine();
                DateTime time = DateTime.Parse(fff);

                train[i] = new Train(name, number, time);
            }
        }
        public static void SortedTrain(Train[]train)
        {
            for (int i = 0; i < train.Length; i++)
            {
                for (int j = 0; j < train.Length; j++)
                {
                    if (train[i].Number <= train[j].Number)
                    {
                        Train a = train[i];
                        train[i] = train[j];
                        train[j] = a;
                    }
                }
            }
        }
        public static void SearchTrain(Train[] train,int number)
        {
            bool ok = false;
            for (int i = 0; i < train.Length; i++)
            {
                if (train[i].Number == number)
                {
                    Console.WriteLine($"\nПоїзд прямує на {train[i].Name}, номер поїзда {train[i].Number}, час відправлення {train[i].Time}");
                    ok = true;
                }
            }
            if (ok == false)
            { Console.WriteLine("Такого поїзда не існує"); }
        }
    }
}
