using System;


namespace Lesson_2
{
    class Min_Max_Temp
    {
        private double min_Temp { get; set; }
        private double max_Temp { get; set; }
        public double aver_Temp()
        {
            return (min_Temp + max_Temp) / 2;
        }

        public void average_Temp()
        {
            Console.WriteLine("Введите минимальную суточную температуру :");
            min_Temp = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите максимальную суточную температуру:");
            max_Temp = Convert.ToDouble(Console.ReadLine());
            
        }
    }
}
