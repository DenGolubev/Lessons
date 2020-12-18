using System;

namespace Lesson_3
{
    class TwoDimensionalArray
    {
        StartMenu startMenu = new StartMenu();
        private int[,] PhoneDirectory = new int[10,10];

        private void InputElements()
        {
            Random variableRND = new Random();
           

            for (int i = 0; i < PhoneDirectory.GetLength(0); i++)
            {
                for (int y = 0; y < PhoneDirectory.GetLength(1); y++)
                {
                    PhoneDirectory[i, y] = variableRND.Next(10);
                }
                
            }
        }
        public void OutputElements()
        {
            InputElements();
            for (int i = 0; i < PhoneDirectory.GetLength(0); i++)
            {
                for (int y = 0; y < PhoneDirectory.GetLength(1); y++)
                {
                    if (i == y)
                    {
                        Console.Write(PhoneDirectory[i, y] + "\t");
                    }
                    else Console.Write(" \t");
                    
                }
                Console.WriteLine();
            }
            Console.ReadKey();
            Console.Clear();
            startMenu.MyStartMenu();
        }
    }
}
