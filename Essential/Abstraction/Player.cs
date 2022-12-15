using System;
namespace Essential.Abstraction
{
//    Задание 3
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Требуется:
//Создайте 2 интерфейса IPlayable и IRecodable. В каждом из интерфейсов создайте по 3 метода void Play() / void Pause() / void Stop() и void Record() / void Pause() / void Stop() соответственно.
//Создайте производный класс Player от базовых интерфейсов IPlayable и IRecodable.
//Написать программу, которая выполняет проигрывание и запись.

    interface IPlayable
    {
        void Play();
        void Pause();
        void Stop();
    }
    interface IRecodable
    {
        void Record();
        void Pause();
        void Stop();
    }
    class Player: IPlayable , IRecodable
    {
        public void Play()
        { Console.WriteLine(" Play IPlayable "); }
        void IPlayable.Pause()
        { Console.WriteLine(" Pause IPlayable "); }
        void IPlayable.Stop()
        { Console.WriteLine(" Stop IPlayable "); }

        public void Record()
        { Console.WriteLine(" Play IRecodable "); }
        void IRecodable.Pause()
        { Console.WriteLine(" Pause IRecodable "); }
        void IRecodable.Stop()
        { Console.WriteLine(" Stop IRecodable "); }
    }
}
