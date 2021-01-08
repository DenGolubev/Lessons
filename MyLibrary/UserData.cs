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

    }
}
