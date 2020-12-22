using System;

namespace Lesson_4
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите упражнение:\n\nУпражнение 1 - клавиша 1\nУпражнение 2 - клавиша 2\nУпражнение 3 - клавиша 3\nУпражнение 4 - клавиша 4");
            AllExercises exercises = new AllExercises();
            exercises.MyMenu(int.Parse(Console.ReadLine()));
            Console.ReadKey();
        }
    }
}
