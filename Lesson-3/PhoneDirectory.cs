using System;
using System.Collections;

namespace Lesson_3
{
    class PhoneDirectory
    {
        string[,] PhoneBook = new string[5, 2];
        ArrayList User = new ArrayList();
        public void AddUser()
        {
            Console.WriteLine("Введите имя контакта:");
            string name = Console.ReadLine();
            Console.WriteLine("Введите номер телефона:");
            string phone = Console.ReadLine();
            User.AddRange(new string[] { name, phone });
            
        }

        public void OutUser()
        {

        }
    }
}
