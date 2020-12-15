using System;


namespace Lesson_2
{
    partial class SerialNumberMonth
    {
                

        public string NumberOfMonth()
        {
            Console.WriteLine("Введите порядковый номер месяца от 1 до 12 :");
            NumberMonth = Convert.ToInt32(Console.ReadLine());
            return SearchMonth(NumberMonth);
        }
    }
}
