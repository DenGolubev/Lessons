using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4
{
    class AllExercises
    {
        string exercise { get; set; }
        GetFullName fullName = new GetFullName();
        public enum Menu
        {
            Exercises1 = 1,
            Exercises2 = 2,
            Exercises3 = 3,
            Exercises4 = 4
        }
        public string Exercises(Menu menu)
        {
            if (menu == Menu.Exercises1)  exercise = "Упражнение №1";
            fullName.PrintUser();
            return exercise;
        }

        


    }
}
