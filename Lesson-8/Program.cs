using System;
using MyLibrary;

namespace Lesson_8
{
    class Program
    {
        static void Main(string[] args)
        {
            UserData user = new UserData();
            string greeting = Properties.Settings.Default.Greeting;
            if (string.IsNullOrEmpty(Properties.Settings.Default.UserName) || string.IsNullOrEmpty(Properties.Settings.Default.UserCareer))
            {
                Console.WriteLine(greeting);
                user.GetUserData();
                Properties.Settings.Default.UserName = user.Name;
                Properties.Settings.Default.UserCareer = user.Career;
                Properties.Settings.Default.UserAge = user.Age;
                Properties.Settings.Default.Save();
            }
            string name = Properties.Settings.Default.UserName;
            string career = Properties.Settings.Default.UserCareer;
            int age = Properties.Settings.Default.UserAge;
            
            Console.WriteLine($"{greeting}\n {name}, Ваш возраст {age} и вы по профессии {career}");
            Console.ReadKey();
        }
    }
}
