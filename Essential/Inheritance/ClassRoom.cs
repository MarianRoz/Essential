using System;
namespace Essential.Inheritance
{
//    Задание 2
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Требуется:
//Создать класс, представляющий учебный класс ClassRoom.
//Создайте класс ученик Pupil. В теле класса создайте методы void Study(), void Read(), void Write(), void Relax().
//Создайте 3 производных класса ExcelentPupil, GoodPupil, BadPupil от класса базового класса Pupil и переопределите каждый из методов, в зависимости от успеваемости ученика.
//Конструктор класса ClassRoom принимает аргументы типа Pupil, класс должен состоять из 4 учеников.Предусмотрите возможность того, что пользователь может передать 2 или 3 аргумента.
//Выведите информацию о том, как все ученики экземпляра класса ClassRoom умеют учиться, читать, писать, отдыхать.

    public class ClassRoom
    {
        Pupil[] pupils = new Pupil[4];
        public ClassRoom(Pupil pupil1, Pupil pupil2,Pupil pupil3, Pupil pupil4)
        {
            pupils[0] = pupil1;
            pupils[1] = pupil2;
            pupils[2] = pupil3;
            pupils[3] = pupil4;
        }
        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3)
        {
            pupils[0] = pupil1;
            pupils[1] = pupil2;
            pupils[2] = pupil3;
            pupils[3] = pupil1;
        }
        public ClassRoom(Pupil pupil1, Pupil pupil2)
        {
            pupils[0] = pupil1;
            pupils[1] = pupil2;
            pupils[2] = pupil1;
            pupils[3] = pupil2;
        }
        public void Study()
        {
            foreach (Pupil p in pupils)
            {
                p.Study();
            }
        }
        public void Write()
        {
            foreach (Pupil p in pupils)
            {
                p.Write();
            }
        }
        public void Read()
        {
            foreach (Pupil p in pupils)
            {
                p.Read();
            }
        }
        public void Relax()
        {
            foreach (Pupil p in pupils)
            {
                p.Relax();
            }
        }
    }
    public class Pupil
    {
        public virtual void Study()
        { }
        public virtual void Read()
        { }
        public virtual void Write()
        { }
        public virtual void Relax()
        { }
    }
    public class ExcelentPupil : Pupil
    {
        public override void Study()
        { Console.WriteLine("ExcelentPupilStudy"); }
        public override void Read()
        { Console.WriteLine("ExcelentPupilRead"); }
        public override void Write()
        { Console.WriteLine("ExcelentPupilWrite"); }
        public override void Relax()
        { Console.WriteLine("ExcelentPupilRelax"); }
    }
    public class GoodPupil : Pupil
    {
        public override void Study()
        { Console.WriteLine("GoodPupilStudy"); }
        public override void Read()
        { Console.WriteLine("GoodPupilRead"); }
        public override void Write()
        { Console.WriteLine("GoodPupilWrite"); }
        public override void Relax()
        { Console.WriteLine("GoodPupilRelax"); }
    }
    public class BadPupil : Pupil
    {
        public override void Study()
        { Console.WriteLine("BadPupilStudy"); }
        public override void Read()
        { Console.WriteLine("BadPupilRead"); }
        public override void Write()
        { Console.WriteLine("BadPupilWrite"); }
        public override void Relax()
        { Console.WriteLine("BadPupilRelax"); }
    }
}
