using System;
namespace Lesson_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите упражнение:\n\nУпражнение 1 - клавиша 1\nУпражнение 2 - клавиша 2\nУпражнение 3 - клавиша 3\nУпражнение 4 - клавиша 4\nУпражнение 5 - клавиша 5");
            AllExercises allExercises = new AllExercises();
            allExercises.MyMenu(int.Parse(Console.ReadLine()));
            
            
            
            
            
            
            
           
            
        }
    }
}
