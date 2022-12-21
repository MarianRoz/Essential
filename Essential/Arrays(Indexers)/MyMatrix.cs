using System;
namespace Essential.ArraysIndexers
{
//    Задание 3
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Требуется:
//Создать класс MyMatrix, обеспечивающий представление матрицы произвольного размера
//с возможностью изменения числа строк и столбцов.
//Написать программу, которая выводит на экран матрицу и производные от нее матрицы разных порядков.
    class MyMatrix
    {
        int[][] myMatrix;

        public MyMatrix(int line, int column)
        {
            myMatrix = new int[Math.Abs(line)][];
            for (int i = 0; i < Math.Abs(line); i++)
                myMatrix[i] = new int[Math.Abs(column)];
            Fill();
        }
        private void Fill()
        {
            Random random = new Random();
            for (int i = 0; i < myMatrix.Length; i++)
            {
                for (int j = 0; j < myMatrix[0].Length; j++)
                {
                    myMatrix[i][j] = random.Next(2, 10);
                }
            }
        }
        public void Show()
        {
            for (int i = 0; i < myMatrix.Length; i++)
            {
                for (int j = 0; j < myMatrix[0].Length; j++)
                {
                    Console.Write("{0} ", myMatrix[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}
