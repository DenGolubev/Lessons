using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            //Задание к уроку 1
            //

            Console.WriteLine("Введите свое имя:");
            string name = Console.ReadLine();
            Console.WriteLine($"Добрый день, {name}. Сегодня - {DateTime.Now.ToShortDateString()}");
            Console.ReadKey();
        }
    }
}
