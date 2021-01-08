﻿using System;
using MyLibrary;

namespace Lesson_8
{
    class SetUserData
    {
        public void UserData()
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
                PrintUserData(greeting, newUser.Name, newUser.Career, newUser.Age);
               
            }
            UserData oldUser = new UserData(Properties.Settings.Default.UserName, Properties.Settings.Default.UserCareer, Properties.Settings.Default.UserAge);
            PrintUserData(greeting, oldUser.Name, oldUser.Career, oldUser.Age);
        }
        public static void PrintUserData(string greeting, string name, string career, int age)
        {
            Console.WriteLine($"{greeting}\n {name}, Ваш возраст {age} и вы по профессии {career}");
            Console.ReadKey();
        }
    }
}