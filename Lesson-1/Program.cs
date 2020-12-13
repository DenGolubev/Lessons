using System;


namespace Lesson_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите свое имя:");
            string name = Console.ReadLine();
            Console.WriteLine($"Добрый день, {name}. Сегодня - {DateTime.Now.ToShortDateString()}");
            Console.ReadKey();
        }
    }
}
