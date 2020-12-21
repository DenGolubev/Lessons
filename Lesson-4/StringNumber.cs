using System;

namespace Lesson_4
{
    class StringNumber
    {
        string Number { get; set; } = null;
        char[] arrayChar;
        int counter { get; set; } = 0;
        


        public void InputNumber()
        {
            Console.WriteLine("Введите числа через пробел и нажмите Enter");
            Number = Console.ReadLine();
            arrayChar = new char[] { ' ', ',', '.' };
            OutputSum();
            Console.ReadKey();
        }
        public void OutputSum()
        {
            string[] arrayNumber = Number.Split(arrayChar, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < arrayNumber.Length; i++)
            {
                counter = counter + int.Parse(arrayNumber[i]);
            }
            Console.WriteLine("Результат равен {0}", counter);
         }
    }
}
