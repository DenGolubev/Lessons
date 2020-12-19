using System;


namespace Lesson_2
{
    partial class MinMaxTemp
    {
        public void EnterTemp()
        {
            Console.WriteLine("Введите минимальную суточную температуру :");
            MinTemp = CheckConsoleEnter(MinTemp);
            Console.WriteLine("Введите максимальную суточную температуру:");
            MaxTemp = CheckConsoleEnter(MaxTemp);
        }

        public void AveregeTemp()
        {
            Console.WriteLine("Среднесуточная температура = {0} градусов цельсия", AverTemp(MinTemp, MaxTemp));
        }

    }
}
