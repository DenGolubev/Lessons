using System;

namespace Lesson_3
{
    class TwoDimensionalArray
    {
        StartMenu startMenu = new StartMenu();
        private int[,] Matrix = new int[10,10];

        private void InputElements()
        {
            Random variableRND = new Random();
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int y = 0; y < Matrix.GetLength(1); y++)
                {
                    Matrix[i, y] = variableRND.Next(10);
                }
                
            }
        }
        public void OutputElements()
        {
            InputElements();
                       
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                Console.Write(Matrix[i, i] + "\t");
            }
            Console.ReadKey();
            Console.Clear();
            startMenu.MyStartMenu();
        }
    }
}
