using System;


namespace Lesson_3
{
    class SeaBattle
    {
       
        public void SeaArea()
        {
           string[,] Sea = new string[10, 10];
            for (int y = 0; y <Sea.GetLength(0); y++)
            {
                for (int x = 0; x <Sea.GetLength(1); x++)
                {
                    Sea[y, x] = " .";
                    Console.Write(Sea[y, x]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        public void Coordinates()
        {

        }
            
    }
}
