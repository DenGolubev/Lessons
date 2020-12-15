using System;


namespace Lesson_2
{
    partial class MinMaxTemp
    {
        public void EnterTemp()
        {
            Console.WriteLine("Введите минимальную суточную температуру :");
            MinTemp = Console.ReadLine();
            Console.WriteLine("Введите максимальную суточную температуру:");
            MaxTemp = Console.ReadLine();
            AveregeTemp();
        }

        public double AveregeTemp()
        {
            while(CheckConsoleEnter(MinTemp, MaxTemp) == false)
            {
                Console.WriteLine("Введите минимальную суточную температуру :");
                MinTemp = Console.ReadLine();
                Console.WriteLine("Введите максимальную суточную температуру:");
                MaxTemp = Console.ReadLine();
            }
            double at = AverTemp(MinTemp, MaxTemp);
            Console.WriteLine("Среднесуточная температура = {0} градусов цельсия", at);
            return at;
        }

    }
}
