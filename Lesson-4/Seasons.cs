using System;

namespace Lesson_4
{
    class Seasons
    {
        int Number { get; set; } = 0; //String - потому что не даст ошибку при вводе 

        private enum Season
        {
            Winter = 1,
            Spring = 2,
            Summer = 3,
            Autumn = 4,
            Nothing = 5
        }
        public void InputNumber()
        {
            Console.WriteLine("Введите порядковый номер месяца:");
            Number = int.Parse(Console.ReadLine());
            while (Number < 1 || Number > 12)
            {
                Console.WriteLine("Ошибка: введите число от 1 до 12, попробуйте еще раз");
                Number = int.Parse(Console.ReadLine());
            }
            GroupeMounth(Number);
        }
       
        private void GroupeMounth(int mounthNumber)
        {
            Season season = Season.Nothing;
                      
            if (mounthNumber == 12 || mounthNumber == 1 || mounthNumber == 2)
            {
                season = Season.Winter;
            }
            else if (mounthNumber == 3 || mounthNumber == 4 || mounthNumber == 5)
            {
                season = Season.Spring;
            }
            else if (mounthNumber == 6 || mounthNumber == 7 || mounthNumber == 8)
            {
                season = Season.Summer;
            }
            else if (mounthNumber == 9 || mounthNumber == 10 || mounthNumber == 11)
            {
                season = Season.Autumn;
            }
            Console.WriteLine($"Вы выбрали {season} месяц");
            Console.ReadKey();
        }


    }
}
