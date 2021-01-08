using System;

namespace MyLibrary
{
     public class UserData
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Career { get; set; }

        public UserData(string name, string career, int age)
        {
            Name = name;
            Age = age;
            Career = career;
        }

        public void PrintUser(string greeting, string name, string career, int age)
        {
            Console.WriteLine($"{greeting}\n {name}, Ваш возраст {age} и вы по профессии {career}");
            Console.ReadKey();
        }
    }
}
