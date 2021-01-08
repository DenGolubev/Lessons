using System;
using MyLibrary;

namespace Lesson_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string greeting = Properties.Settings.Default.Greeting;
            if (string.IsNullOrEmpty(Properties.Settings.Default.UserName) || string.IsNullOrEmpty(Properties.Settings.Default.UserCareer))
            {
                Console.WriteLine(greeting);
                Console.WriteLine("Введите ваше имя");
                string name = Console.ReadLine();
                Console.WriteLine("Введите ваш род деятельности");
                string career = Console.ReadLine();
                Console.WriteLine("Введите ваш возраст");
                int age = int.Parse(Console.ReadLine());
                UserData newUser = new UserData(name, career, age);
                newUser.PrintUser(greeting, newUser.Name, newUser.Career, newUser.Age);
            }
            UserData oldUser = new UserData(Properties.Settings.Default.UserName, Properties.Settings.Default.UserCareer, Properties.Settings.Default.UserAge);
            oldUser.PrintUser(greeting, oldUser.Name, oldUser.Career, oldUser.Age);


        }
       
    }

}
