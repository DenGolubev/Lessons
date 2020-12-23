using System;

namespace Lesson_4
{
    class Fibonacci
    {
        private int Counter { get; set; } = 0;

        public void EnterNumber()
        {
            Console.WriteLine("Введите число:");
            Counter = int.Parse(Console.ReadLine());
            Result(Counter);
        }
        private int FibonachiNumber(int d)
        {
            if(d == 0) return 0;
            else if(d == 1) return 1;
            else return FibonachiNumber(d - 1) + FibonachiNumber(d - 2);
         }
        private void Result(int num)
        {
            Console.Clear();
            Console.WriteLine($"Число Фиббоначи {Counter}-й последовательности = {FibonachiNumber(num)}");
            Console.ReadKey();
        }
    }
}
