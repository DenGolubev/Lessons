using System;

namespace Lesson_2
{
    partial class EvenNumber
    {
        public void NumberCheck()
        {
            Console.WriteLine("Введите любое число:\n");
            Number = Console.ReadLine();
            if(CheckConsoleEnter(Number) == true) EnterNumber(Number);
            else Number = Console.ReadLine();

        }

    }
}
