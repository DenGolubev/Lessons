using System;

namespace Lesson_2
{
    partial class EvenNumber
    {


        public void EnterNumber()
        {
            Console.WriteLine("Введите любое число:\n");
            Number = Console.ReadLine();
            NumberCheck();
        }

        public void NumberCheck()
        {

            while (CheckConsoleEnter(Number) == false) 
            {
                Console.WriteLine("Введите любое число:\n");
                Number = Console.ReadLine();
            }
            EnterNumberCheck(Number);
        }

    }
}
