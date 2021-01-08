using System;
using MyLibrary;


namespace Lesson_8
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string greeting = Properties.Settings.Default.Greeting;
            Console.WriteLine(greeting);
            if (string.IsNullOrEmpty(Properties.Settings.Default.UserName) || string.IsNullOrEmpty(Properties.Settings.Default.UserCareer))
            {
                var prop = UserData();
                UserData newUser = new UserData(prop.Item1, prop.Item2, prop.Item3);
                PrintUserData(newUser.Name, newUser.Career, newUser.Age);
            }
            else
            {
                UserData oldUser = new UserData(Properties.Settings.Default.UserName, Properties.Settings.Default.UserCareer, Properties.Settings.Default.UserAge);
                PrintUserData(oldUser.Name, oldUser.Career, oldUser.Age);
            }
           

        }

        public static (string, string, int) UserData()
        {
            Console.WriteLine("Введите ваше имя");
            string name = Console.ReadLine();
            Console.WriteLine("Введите ваш род деятельности");
            string career = Console.ReadLine();
            Console.WriteLine("Введите ваш возраст");
            int age = int.Parse(Console.ReadLine());
            Properties.Settings.Default.UserName = name;
            Properties.Settings.Default.UserCareer = career;
            Properties.Settings.Default.UserAge = age;
            Properties.Settings.Default.Save();
            var RegUser = (name, career, age);
            return RegUser;
        }
        public static void PrintUserData(string name, string career, int age)
        {
            Console.WriteLine($"\n{name}, Ваш возраст {age} и вы по профессии {career}");
            Console.ReadKey();
            //Properties.Settings.Default.Reset();
        }
    }

}
