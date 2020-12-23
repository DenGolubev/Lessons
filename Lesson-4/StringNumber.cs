using System;

namespace Lesson_4
{
    class StringNumber
    {
        private string Number { get; set; } = null;
        private char[] arrayChar;
        private int Counter { get; set; } = 0;
        


        public void InputNumber()
        {
            Console.WriteLine("Введите числа через пробел и нажмите Enter");
            Number = Console.ReadLine();
            arrayChar = new char[] { ' ', ',', '.' }; // Данные знаки исключаем из массива
            OutputSum();
            Console.WriteLine(Counter); 
            Console.ReadKey();
        }
        private int OutputSum()
        {
            string[] arrayNumber = Number.Split(arrayChar, StringSplitOptions.RemoveEmptyEntries); //Делаем из строки - подстроки, разбиваем строку 
            for (int i = 0; i < arrayNumber.Length; i++)
            {
                Counter = Counter + int.Parse(arrayNumber[i]); // Ну и соответственно преобразуем в целое число и складываем
            }
            return Counter;
         }
    }
}
