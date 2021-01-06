using System;

namespace MyLibrary
{
     public class UserData
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Career { get; set; }

        public void GetUserData()
        {
            Console.WriteLine("Введите ваше имя");
            Name = Console.ReadLine();
            Console.WriteLine("Введите ваш род деятельности");
            Career = Console.ReadLine();
            Console.WriteLine("Введите ваш возраст");
            Age = int.Parse(Console.ReadLine());
         }
    }
}
