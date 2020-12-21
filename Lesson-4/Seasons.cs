using System;

namespace Lesson_4
{
    class Seasons
    {
        string Number { get; set; } = null;
        public int InputNumber()
        {
            Console.WriteLine("Введите порядковый номер месяца:");
            Number = Console.ReadLine();
            while (int.Parse(Number) < 1 || int.Parse(Number) > 12 )
            {
                Console.WriteLine("Ошибка: введите число от 1 до 12, попробуйте еще раз");
                Number = Console.ReadLine();
            }
             return int.Parse(Number);
        }
        enum Season
        {
            Winter = 1,
            Spring = 2,
            Summer = 3,
            Autumn = 4
        }
        //public int SearchMounth()
        //{

        //}
    }
}
