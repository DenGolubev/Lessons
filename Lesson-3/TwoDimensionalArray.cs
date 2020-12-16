using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3
{
    class TwoDimensionalArray
    {
        private int[,] PhoneDirectory = new int[5,5];

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
                        Console.Write("{0}\t",PhoneDirectory[i, y]);
                    }
                    
                }

            }
            Console.ReadKey();
        }
    }
}
