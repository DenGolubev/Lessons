using System;

namespace Lesson_4
{
    class Program
    {
        
        static void Main(string[] args)
        {
            AllExercises allExercises = new AllExercises();
            GetFullName fullName = new GetFullName();
            fullName.PrintUser();
            StringNumber stringNumber = new StringNumber();
            stringNumber.InputNumber();
        }
    }
}
