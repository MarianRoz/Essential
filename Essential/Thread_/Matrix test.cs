using System;
using System.Threading;

namespace Essential.Thread_
{

    //    Используя Visual Studio, создайте проект по шаблону Console Application.
    //Создайте программу, которая будет выводить на экран цепочки падающих символов.
    //Длина каждой цепочки задается случайно.
    //Первый символ цепочки – галубой, второй символ – светло-зеленый, остальные символы темно-зеленые.
    //Во время падения цепочки, на каждом шаге, все символы меняют свое значение.
    //Дойдя до конца, цепочка исчезает и сверху формируется новая цепочка.
    //Смотрите ниже снимок экрана, представленный как образец.

    class Matrix
    {
        static readonly object locker = new object();

        const string litters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        Random rand;

        public int Colunm { get; set; }

        public Matrix(int col)
        {
            Colunm = col;
            rand = new Random((int)DateTime.Now.Ticks);
        }

        private char GetChar()
        {
            return litters.ToCharArray()[rand.Next(0, 35)];
        }
        
        public void Move()
        {
            while (true)
            {
                int count = 4;   
                int lenght = 0;
                int addCorsorTop = Console.CursorTop;
                for (int i = 0; i < 10; i++)
                {
                    lock (locker)
                    {
                        Console.CursorTop = 0+addCorsorTop;
                        for (int j = 0; j < i; j++)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.CursorLeft = Colunm;
                            if (Console.ForegroundColor != ConsoleColor.Green)
                                Console.WriteLine(GetChar());
                        }
                        if (lenght < count)
                            lenght++;
                        //else
                        //    if (lenght == count)
                        //    count = 0;

                        //if (39 - i < lenght)
                        //    lenght--;
                        //Console.CursorTop = i - lenght + 1;
                        //Console.ForegroundColor = ConsoleColor.DarkGreen;
                        //for (int j = 0; j < lenght - 2; j++)
                        //{
                        //    Console.ForegroundColor = ConsoleColor.DarkGreen;
                        //    Console.CursorLeft = Colunm;
                        //    Console.WriteLine(GetChar());
                        //}
                        if (lenght >= 2 && Console.ForegroundColor != ConsoleColor.Blue)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.CursorLeft = Colunm;
                            if (Console.ForegroundColor != ConsoleColor.Blue)
                                Console.WriteLine(GetChar());
                        }
                        if (lenght >= 1&& Console.ForegroundColor == ConsoleColor.Green)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.CursorLeft = Colunm;
                            Console.WriteLine(GetChar());
                            Console.WriteLine();
                        }
                    }
                }
            }
        }
    }
}
